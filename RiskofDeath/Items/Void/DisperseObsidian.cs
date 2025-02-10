using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;

namespace RiskofDeath.Items.Void
{
    public class DisperseObsidian : ItemBase
    {
        public override ItemDef ItemToCorrupt => RoR2Content.Items.NearbyDamageBonus;
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("disperseobsidian");
        public override string ItemIdentifier => "DisperseObsidian";
        public override string ItemName => "Disperse Obsidian";
        public override string ItemPick => "Deal bonus damage to enemies at long distance. <color=#ed7fcd>Corrupts all Focus Crystals </color>";
        public override string ItemDesc => "Grants a damage boost against enemies at long range (29.99999999m). Displays a pulsating effect around the player. <color=#ed7fcd>Corrupts all Focus Crystals </color>";
        public override string ItemLore => "A shard that resonates with the distant echoes of battle.";
        public override float logbookCameraMinDistance => 4.5f;
        public override float logbookCameraMaxDistance => 5.5f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => Vector3.zero;

        public override void Init()
        {
            SetLangToken();
            SetupItem();
            SetupCorruption();
            Hook();
        }

        //Item specifics
        private static GameObject ringPrefab;
        private const float ringScaleMultiplier = 2.3f;
        private static bool isRingActive;

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

            ringPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/NearbyDamageBonus/NearbyDamageBonusIndicator.prefab").WaitForCompletion().InstantiateClone("Disperse Obsidian Indicator", true);
            var indicatorMaterial = Object.Instantiate(Addressables.LoadAssetAsync<Material>("RoR2/Base/NearbyDamageBonus/matNearbyDamageBonusRangeIndicator.mat").WaitForCompletion());
            indicatorMaterial.SetColor("_TintColor", new Color32(128, 0, 128, 255));
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

            var distance = Vector3.Distance(attackerBody.transform.position, self.transform.position);
            if (distance > 29.9f)
            {
                damageInfo.damage *= 1 + (0.2f * itemCount);
                damageInfo.damageColorIndex = DamageColorIndex.Void;
            }

            orig(self, damageInfo);
        }

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetDisperseObsidian(gameObject);
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
                
                ringIndicator = Instantiate(DisperseObsidian.ringPrefab);
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
                else if(isRingActive  && NetworkServer.active)
                {
                    ringIndicator.SetActive(true);
                }
            }
        }
    }
}
