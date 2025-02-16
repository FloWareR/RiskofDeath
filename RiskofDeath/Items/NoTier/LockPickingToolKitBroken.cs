using R2API;
using RoR2;
using UnityEngine;

namespace RiskofDeath.Items.NoTier
{
    public class LockpickingToolKitBroken : ItemBase
    {
        // Item Definition
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("lockpickingtoolkitbroken");
        public override string ItemIdentifier => "LockpickingToolKitBroken";
        public override string ItemName => "Lockpicking Tool Kit (Broken)";
        public override string ItemPick => "...Better luck next time.";
        public override string ItemDesc => "...";
        public override string ItemLore => "...";
        public override float logbookCameraMinDistance => 0f;
        public override float logbookCameraMaxDistance => 0f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => Vector3.zero;

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return null;
        }

        public override void Hook()
        {
        }
        public override void Unhook()
        {
        }
        
    }
}
