using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;

namespace RiskofDeath.Items.Tier3
{
    public class SniperScope : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("sniperscope");
        public override string ItemIdentifier => "SniperScope";
        public override string ItemName => "Sniper scope";
        public override string ItemPick => "Sniper in the building!";
        public override string ItemDesc => "Increase the damage dealt the further you are with a minimum distance of 30 meters";
        public override string ItemLore => "One man can change the world with a bullet in the right place.";
        public override float logbookCameraMinDistance => 5.5f;
        public override float logbookCameraMaxDistance => 9f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => Vector3.zero;

        private const float DistanceThreshold = 29.9f;
        private static GameObject ringPrefab;
        private static bool isRingActive;
        private const float ringScaleMultiplier = 2.3f;

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetSniperScope(gameObject);
        }

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

            ringPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/NearbyDamageBonus/NearbyDamageBonusIndicator.prefab").WaitForCompletion().InstantiateClone("Sniper Scope Indicator", true);
            var indicatorMaterial = Object.Instantiate(Addressables.LoadAssetAsync<Material>("RoR2/Base/NearbyDamageBonus/matNearbyDamageBonusRangeIndicator.mat").WaitForCompletion());
            indicatorMaterial.SetColor("_TintColor", new Color32(16, 63, 145, 255));
            var blastRadius = ringPrefab.transform.Find("Radius, Spherical");
            blastRadius.GetComponent<MeshRenderer>().material = indicatorMaterial;

            PrefabAPI.RegisterNetworkPrefab(ringPrefab);
        }

        private void OnInventoryChanged(On.RoR2.CharacterMaster.orig_OnInventoryChanged orig, CharacterMaster self)
        {
            if (!self.inventory) return;
            if (self.inventory.GetItemCount(ItemData) > 0)
            {
                isRingActive = true;
                if (!self.TryGetComponent<IndicatorRingController>(out var controller))
                {
                    controller = self.gameObject.AddComponent<IndicatorRingController>();
                }

            }
            else
            {
                isRingActive = false;
            }
            orig(self);
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

            float distance = Vector3.Distance(attackerBody.corePosition, self.body.corePosition);
            if (distance > DistanceThreshold)
            {
                float distanceBeyondThreshold = distance - DistanceThreshold;
                float additionalDamage = damageInfo.damage * (itemCount * (distanceBeyondThreshold / 100f));

                damageInfo.damage += additionalDamage;
            }

            orig(self, damageInfo);
        }

        public class IndicatorRingController : MonoBehaviour
        {
            public CharacterBody body;
            public CharacterMaster characterComponent;
            private GameObject ringIndicator;

            public void Start()
            {
                characterComponent = GetComponent<CharacterMaster>();
                body = characterComponent.GetBody();

                ringIndicator = Instantiate(SniperScope.ringPrefab);
                var indicatorRadius = ringIndicator.transform.Find("Radius, Spherical");
                indicatorRadius.localScale *= ringScaleMultiplier;
                ringIndicator.GetComponent<NetworkedBodyAttachment>().AttachToGameObjectAndSpawn(body.gameObject);
            }

            public void FixedUpdate()
            {
                if (!isRingActive && NetworkServer.active)
                {
                    ringIndicator.SetActive(false);
                }
                else if (isRingActive && NetworkServer.active)
                {
                    ringIndicator.SetActive(true);
                }
            }
        }
    }
}