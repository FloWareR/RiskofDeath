using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections;

namespace RiskofDeath.Items.Tier3
{
    public class XiuhtecuhtliIdol : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("xiuhtecuhtliidol");
        public override string ItemIdentifier => "XiuhtecuhtliIdol";
        public override string ItemName => "Xiuhtecuhtli Idol";
        public override string ItemPick => "Dealt a powerful blasts of fire and cripple to enemies when stacking ignition. Recharges over time.";
        public override string ItemDesc => "After staking(5 or more) ignition to an enemy dealt a blast within 12m(+2 meters per ignition stack) for 2000%(+2000% per stack) base damage. Additionally, enemies burn for 10% blast base damage. Recharges every 20 seconds.";
        public override string ItemLore => "The idol of an ancient fire deity, radiating an intense heat.";
        public override float logbookCameraMinDistance => 3.5f;
        public override float logbookCameraMaxDistance => 5.5f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => new(0f, 0f, 1f);

        private const float idolRadius = 12f;
        private const int cooldownDuration = 20;
        private static bool isOnCooldown;
        private static DotController.DotIndex fireIndex;

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetXiuhtecuhtliIdol(gameObject);
        }

        public override void Hook()
        {
            On.RoR2.DotController.AddDot += DotController_AddDot;
            On.RoR2.CharacterMaster.OnInventoryChanged += OnInventoryChanged;
            On.RoR2.Stage.Start += OnStageStart;
        }

        public override void Unhook()
        {
            On.RoR2.DotController.AddDot -= DotController_AddDot;
            On.RoR2.CharacterMaster.OnInventoryChanged -= OnInventoryChanged;
            On.RoR2.Stage.Start -= OnStageStart;
        }

        private IEnumerator OnStageStart(On.RoR2.Stage.orig_Start orig, Stage self)
        {
            yield return orig(self);

            ResetCooldown();
            ReapplyIdolBuff();
        }

        private void ResetCooldown()
        {
            isOnCooldown = false;

            foreach (var player in PlayerCharacterMasterController.instances)
            {
                var body = player.master.GetBody();
                if (body)
                {
                    body.RemoveBuff(RiskofDeath.BuffLoader.IdolCooldown.BuffData);
                }
            }
        }

        private void ReapplyIdolBuff()
        {
            foreach (var player in PlayerCharacterMasterController.instances)
            {
                var body = player.master.GetBody();
                if (body && player.master.inventory.GetItemCount(ItemData) > 0)
                {
                    body.AddBuff(RiskofDeath.BuffLoader.Idol.BuffData);
                }
            }
        }

        private void OnInventoryChanged(On.RoR2.CharacterMaster.orig_OnInventoryChanged orig, CharacterMaster self)
        {
            if (!self.inventory) return;

            CharacterBody body = self.GetBody();
            if (!body) return;

            if (self.inventory.GetItemCount(ItemData) > 0)
            {
                if (!isOnCooldown && !body.HasBuff(RiskofDeath.BuffLoader.Idol.BuffData))
                {
                    body.AddBuff(RiskofDeath.BuffLoader.Idol.BuffData);
                }
            }
            else
            {
                if (body.HasBuff(RiskofDeath.BuffLoader.Idol.BuffData))
                {
                    body.RemoveBuff(RiskofDeath.BuffLoader.Idol.BuffData);
                }
            }

            orig(self);
        }

        private void DotController_AddDot(On.RoR2.DotController.orig_AddDot orig, DotController self, GameObject attackerObject, float duration, DotController.DotIndex dotIndex, float damageMultiplier, uint? maxStacksFromAttacker, float? totalDamage, DotController.DotIndex? preUpgradeDotIndex)
        {
            orig(self, attackerObject, duration, dotIndex, damageMultiplier, maxStacksFromAttacker, totalDamage, preUpgradeDotIndex);

            if (dotIndex == DotController.DotIndex.Burn || dotIndex == DotController.DotIndex.StrongerBurn)
            {
                var attackerBody = attackerObject?.GetComponent<CharacterBody>();
                if (attackerBody)
                {
                    var itemCount = GetItemCount(attackerBody.master);
                    if (itemCount > 0 && !isOnCooldown)
                    {
                        int fireStacks;
                        var victimBody = self.victimObject?.GetComponent<CharacterBody>();

                        string burnBuffName = "bdOnFire";
                        string strongerBurnBuffName = "bdStrongerBurn";

                        if (dotIndex == DotController.DotIndex.Burn)
                        {
                            BuffIndex burnBuffIndex = BuffCatalog.FindBuffIndex(burnBuffName);
                            fireStacks = victimBody.GetBuffCount(burnBuffIndex);
                            Debug.LogError(victimBody.GetBuffCount(burnBuffIndex));
                            fireIndex = DotController.DotIndex.Burn;
                        }
                        else
                        {
                            BuffIndex strongerBurnBuffIndex = BuffCatalog.FindBuffIndex(strongerBurnBuffName);
                            fireStacks = victimBody.GetBuffCount(strongerBurnBuffIndex);
                            Debug.LogError(victimBody.GetBuffCount(strongerBurnBuffIndex));
                            fireIndex = DotController.DotIndex.StrongerBurn;
                        }

                        Debug.LogError(fireStacks);

                        if (fireStacks >= 5)
                        {
                            StartCooldown(attackerBody);
                            TriggerIdolEffect(self.transform.position, attackerBody, fireStacks, duration, itemCount);
                        }
                    }
                }
            }
        }

        private void TriggerIdolEffect(Vector3 position, CharacterBody attackerBody, int fireStacks, float duration, int itemCount)
        {
            float totalDuration = duration + itemCount;
            BlastAttack blastAttack = new BlastAttack
            {
                attacker = attackerBody.gameObject,
                inflictor = attackerBody.gameObject,
                teamIndex = attackerBody.teamComponent.teamIndex,
                position = position,
                radius = idolRadius + (2 * fireStacks),
                baseDamage = attackerBody.damage * (itemCount * (2000 / 100)),
                baseForce = 0f,
                crit = attackerBody.RollCrit(),
                damageType = DamageType.DoT,
                attackerFiltering = AttackerFiltering.NeverHitSelf,
                falloffModel = BlastAttack.FalloffModel.None
            };

            blastAttack.Fire();

            foreach (var hit in blastAttack.CollectHits())
            {
                if (hit.hurtBox && hit.hurtBox.healthComponent)
                {
                    var body = hit.hurtBox.healthComponent.body;
                    if (body)
                    {
                        body.AddTimedBuff(RoR2Content.Buffs.Cripple, totalDuration);
                        DotController.InflictDot(body.gameObject, attackerBody.gameObject, fireIndex, totalDuration, blastAttack.baseDamage * 0.1f);
                    }
                }
            }

            GameObject ignitePrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/ExplodeOnDeath/WilloWispExplosion.prefab").WaitForCompletion();
            EffectManager.SpawnEffect(ignitePrefab, new EffectData
            {
                origin = position,
                scale = idolRadius + (2 * fireStacks)
            }, true);
        }

        private void StartCooldown(CharacterBody body)
        {
            if (!isOnCooldown)
            {
                isOnCooldown = true;

                if (body.HasBuff(RiskofDeath.BuffLoader.Idol.BuffData))
                {
                    body.RemoveBuff(RiskofDeath.BuffLoader.Idol.BuffData);
                }

                body.SetBuffCount(RiskofDeath.BuffLoader.IdolCooldown.BuffData.buffIndex, cooldownDuration);

                body.StartCoroutine(CooldownCoroutine(body));
            }
        }

        private IEnumerator CooldownCoroutine(CharacterBody body)
        {
            int timer = cooldownDuration;

            while (true)
            {
                if (timer <= 0) break;

                body.SetBuffCount(RiskofDeath.BuffLoader.IdolCooldown.BuffData.buffIndex, timer);
                timer -= 1;

                yield return new WaitForSeconds(1);
            }

            isOnCooldown = false;

            body.RemoveBuff(RiskofDeath.BuffLoader.IdolCooldown.BuffData);

            if (body.master.inventory.GetItemCount(ItemData) > 0 && !body.HasBuff(RiskofDeath.BuffLoader.Idol.BuffData))
            {
                body.AddBuff(RiskofDeath.BuffLoader.Idol.BuffData);
            }

            yield return null;
        }
    }
}