using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace RiskofDeath.Items.Tier1
{
    public class PestilentPool : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("pestilentpool");

        public override string ItemIdentifier => "VenomPool";

        public override string ItemName => "Pestilent Pool";

        public override string ItemPick => "Killing an enemy spawns an acid pool at their location.";

        public override string ItemDesc => "Killing an enemy spawns an acid pool at their location, dealing damage over time to enemies in the area.";

        public override string ItemLore => "A pool of venomous acid, left behind by the fallen.";

        public override float logbookCameraMinDistance => 1f;

        public override float logbookCameraMaxDistance => 5f;

        public override Vector3 logbookFocusPointOffset => Vector3.zero;

        public override Vector3 logbookCameraPositionOffset => Vector3.zero;

        // Acid pool effect prefab
        private static GameObject acidPoolEffectPrefab;

        public override void Init()
        {
            SetLangToken();
            SetupItem();
            Hook();
            LoadPrefab();
        }

        public override void Hook()
        {
            GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeathGlobal;
        }

        public override void Unhook()
        {
            GlobalEventManager.onCharacterDeathGlobal -= GlobalEventManager_onCharacterDeathGlobal;
        }

        private void LoadPrefab()
        {

        }

        private void GlobalEventManager_onCharacterDeathGlobal(DamageReport report)
        {

        }

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return null;
        }
    }
}