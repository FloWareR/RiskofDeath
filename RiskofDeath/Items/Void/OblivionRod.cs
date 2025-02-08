using RoR2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static RoR2.CombatDirector;

namespace RiskofDeath.Items.Void
{
    public class OblivionRod : ItemBase
    {
        public override ItemDef ItemToCorrupt => RoR2Content.Items.Crowbar;
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("oblivionrod");
        public override string ItemIdentifier => "OblivionRod";
        public override string ItemName => "Oblivion Rod";
        public override string ItemPick => "Bonus damage to enemies above 90% health, Freezes the enemy health for 1.5s then applies all the damage in a single burst <color=#ed7fcd>Corrupts all crowbars </color>";
        public override string ItemDesc => "Deals bonus damage to enemies above 90% health, Enemies will take 1 damage and the rest will be accumulated and applied 1.5s after the initial hit <color=#ed7fcd>Corrupts all crowbars </color>";
        public override string ItemLore => "A twisted and rusty crowbar, infused with the power of the void";
        public override float logbookCameraMinDistance => 15f;
        public override float logbookCameraMaxDistance => 21f;
        public override Vector3 logbookFocusPointOffset => new(0f, 5.6f, 0f);
        public override Vector3 logbookCameraPositionOffset => new(-1f, 5.6f, 0.4f);


        private const DamageType OblivionRodDamageFlag = (DamageType)0x4000000u;

        private static readonly float maxAllowedTime = 1.5f;
        private static readonly Dictionary<HealthComponent, EnemyState> enemyStates = new Dictionary<HealthComponent, EnemyState>();

        private class EnemyState
        {
            public float accumulatedDamage;
            public Coroutine damageCoroutine;
            public GameObject attacker;
            public GameObject inflictor;
        }

        public override void Init()
        {
            SetLangToken();
            SetupItem();
            SetupCorruption();
            Hook();
        }

        public override void Hook()
        {
            On.RoR2.HealthComponent.TakeDamage += OnDamageDealt;
        }

        public override void Unhook()
        {
            On.RoR2.HealthComponent.TakeDamage -= OnDamageDealt;
        }

        private void OnDamageDealt(On.RoR2.HealthComponent.orig_TakeDamage orig, HealthComponent self, DamageInfo damageInfo)
        {
            if ((damageInfo.damageType & OblivionRodDamageFlag) != 0)
            {
                orig(self, damageInfo);
                return;
            }

            if (damageInfo.attacker == null || !damageInfo.attacker.TryGetComponent<CharacterBody>(out var attackerBody))
            {
                orig(self, damageInfo);
                return;
            }

            var inventory = attackerBody.inventory;
            if (inventory == null || inventory.GetItemCount(ItemData) <= 0)
            {
                orig(self, damageInfo);
                return;
            }

            if (self.health >= self.fullHealth * 0.9f)
            {
                if (!enemyStates.TryGetValue(self, out var state))
                {
                    state = new EnemyState
                    {
                        accumulatedDamage = 0,
                        attacker = damageInfo.attacker,
                        inflictor = damageInfo.inflictor
                    };
                    enemyStates[self] = state;
                }

                state.accumulatedDamage += damageInfo.damage * (1 + (inventory.GetItemCount(ItemData) * 0.35f));
                damageInfo.damageColorIndex = DamageColorIndex.Item;
                damageInfo.damage = 1;

                if (state.damageCoroutine == null)
                {
                    GameObject coroutineObject = new GameObject("OblivionRodCoroutine");
                    MonoBehaviour mb = coroutineObject.AddComponent<CoroutineHelper>();
                    state.damageCoroutine = mb.StartCoroutine(ApplyAccumulatedDamageAfterDelay(self));
                    self.body.AddTimedBuff(RiskofDeath.BuffLoader.Oblivious.BuffData, 1.5f);
                }
            }
            else
            {
                if (enemyStates.TryGetValue(self, out var state) && state.accumulatedDamage > 0)
                {
                    ApplyAccumulatedDamageNow(self, state.accumulatedDamage, state.attacker, state.inflictor);
                }

                enemyStates.Remove(self);
            }

            orig(self, damageInfo);
        }

        private void ApplyAccumulatedDamageNow(HealthComponent enemy, float damage, GameObject attacker, GameObject inflictor)
        {
            if (enemy != null && damage > 0)
            {
                DamageInfo damageInfo = new DamageInfo
                {
                    attacker = attacker,
                    damage = damage,
                    damageType = OblivionRodDamageFlag,
                    damageColorIndex = DamageColorIndex.Item,
                    procCoefficient = 1f,
                    position = enemy.transform.position,
                    force = Vector3.zero,
                    crit = false,
                    procChainMask = default,
                };

                enemy.TakeDamage(damageInfo);
            }
        }

        private IEnumerator ApplyAccumulatedDamageAfterDelay(HealthComponent target)
        {
            yield return new WaitForSeconds(maxAllowedTime);

            if (target != null && target.health > 0)
            {
                if (enemyStates.TryGetValue(target, out var state))
                {
                    var damageInfo = new DamageInfo
                    {
                        attacker = state.attacker,
                        damage = state.accumulatedDamage,
                        procCoefficient = 1f,
                        position = target.transform.position,
                        damageColorIndex = DamageColorIndex.Void,
                        damageType = OblivionRodDamageFlag,
                        force = Vector3.zero,
                        crit = false,
                        procChainMask = default,
                    };

                    target.TakeDamage(damageInfo);

                    state.damageCoroutine = null;
                    enemyStates.Remove(target);
                }
            }
            else
            {
                if (target != null && enemyStates.ContainsKey(target))
                {
                    enemyStates[target].damageCoroutine = null;
                    enemyStates.Remove(target);
                }
            }
        }

        private class CoroutineHelper : MonoBehaviour
        {
        }
    }
}