using System.Collections;
using R2API;
using RiskofDeath.Items.Tier2;
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
            On.RoR2.Stage.Start += OnStageStart;
        }
        public override void Unhook()
        {
            On.RoR2.Stage.Start -= OnStageStart;
        }

        private IEnumerator OnStageStart(On.RoR2.Stage.orig_Start orig, Stage self)
        {
            yield return orig(self);

            foreach (var player in PlayerCharacterMasterController.instances)
            {
                CharacterBody body = player.master.GetBody();
                if (body && body.inventory && body.inventory.GetItemCount(ItemData) > 0)
                {
                    body.inventory.GiveItem(RiskofDeath.ItemLoader.LockpickingToolKit.ItemData, body.inventory.GetItemCount(ItemData));
                    body.inventory.RemoveItem(ItemData.itemIndex, body.inventory.GetItemCount(ItemData));
                }
            }
        }
    }
}
