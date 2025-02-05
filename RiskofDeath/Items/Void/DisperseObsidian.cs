using RoR2;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.Networking;
using static UnityEngine.UI.Image;

namespace RiskofDeath.Items.Void
{
    public class DisperseObsidian : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("disperseobsidian");
        public override string ItemIdentifier => "DisperseObsidian";
        public override string ItemName => "Disperse Obsidian";
        public override string ItemPick => "Deal bonus damage to enemies at long distance. <color=#ed7fcd>Corrupts all Focus Crystals </color>";
        public override string ItemDesc => "Grants a damage boost against enemies at long range. Displays a pulsating effect around the player. <color=#ed7fcd>Corrupts all Focus Crystals </color>";
        public override string ItemLore => "A shard that resonates with the distant echoes of battle.";
        public override ItemDef ItemToCorrupt => RoR2Content.Items.NearbyDamageBonus;
        public override float logbookCameraMinDistance => 5f;
        public override float logbookCameraMaxDistance => 20f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => Vector3.zero;



        //Item specifics
        private GameObject ringEffect;
        private GameObject ringPrefab;
        private const float ringScaleMultiplier = 2.3f;

        public override void Hook()
        {
            On.RoR2.CharacterMaster.OnInventoryChanged += OnInventoryChanged;
            On.RoR2.HealthComponent.TakeDamage += OnDamageDealt;
            LoadPrefab();
        }

        public override void Unhook()
        {
            On.RoR2.CharacterMaster.OnInventoryChanged -= OnInventoryChanged;
            On.RoR2.HealthComponent.TakeDamage -= OnDamageDealt;
        }

        private void LoadPrefab()
        {
            if (ringPrefab) return;
            ringEffect = LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/NearbyDamageBonusIndicator");
            if(!ringPrefab) return;
            Debug.Log("Loaded ringEffect");
        }

        private void OnInventoryChanged(On.RoR2.CharacterMaster.orig_OnInventoryChanged orig, CharacterMaster self)
        {
            orig(self);
            if (!self.inventory) return;
            var itemCount = self.inventory.GetItemCount(ItemData);
            if (itemCount <= 0)
            {
                DestroyRing();
            } else 
            {
                CreateRing(self);
            }

        }

        private void CreateRing(CharacterMaster self)
        {
            if (ringEffect || !ringPrefab) return;
            ringEffect = GameObject.Instantiate(ringPrefab, self.GetBody().corePosition, Quaternion.identity);
            if (!ringEffect) return;
            if(!ringEffect.TryGetComponent(out NetworkIdentity netId))
            {
                netId = ringEffect.AddComponent<NetworkIdentity>();
            }
            var attachment = ringEffect.GetComponent<NetworkedBodyAttachment>();

            ringEffect.transform.localScale *= ringScaleMultiplier;
            ringEffect.transform.SetParent(self.transform, true);
            attachment.AttachToGameObjectAndSpawn(self.gameObject, null);
        }

        private void DestroyRing()
        {
            if (ringEffect != null)
            {
                GameObject.Destroy(ringEffect);
                ringEffect = null;
            }
        }

        private void OnDamageDealt(On.RoR2.HealthComponent.orig_TakeDamage orig, HealthComponent self, DamageInfo damageInfo)
        {
            if (!NetworkServer.active)
            {
                orig(self, damageInfo);
                return;
            }

            if (damageInfo.attacker == null)
            {
                orig(self, damageInfo);
                return;
            }

            var attackerBody = damageInfo.attacker.GetComponent<CharacterBody>();
            if (attackerBody == null)
            {
                orig(self, damageInfo);
                return;
            }

            var inventory = attackerBody.inventory;
            if (inventory == null)
            {
                orig(self, damageInfo);
                return;
            }

            var itemCount = inventory.GetItemCount(ItemData);
            if (itemCount <= 0)
            {
                orig(self, damageInfo);
                return;
            }

            var distance = Vector3.Distance(attackerBody.transform.position, self.transform.position);
            if (distance > 29.9f)
            {
                damageInfo.damage *= 1 + (0.2f * itemCount);
                damageInfo.damageColorIndex = DamageColorIndex.Item;
            }

            orig(self, damageInfo);
        }
    }
}
