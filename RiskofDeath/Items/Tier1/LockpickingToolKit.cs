using R2API;
using RoR2;
using UnityEngine;

namespace RiskofDeath.Items.Tier1
{
    public class LockpickingToolKit : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("lockpickingtoolkit");
        public override string ItemIdentifier => "LockpickingToolKit";
        public override string ItemName => "Lockpicking Tool Kit";
        public override string ItemPick => "You feel nimble...";
        public override string ItemDesc => "Allows you to open chests for free. Regenerate after stage.";
        public override string ItemLore => "A set of tools passed down from generations of thieves. Use it wisely.";
        public override float logbookCameraMinDistance => 2f;
        public override float logbookCameraMaxDistance => 3f;
        public override Vector3 logbookFocusPointOffset => new(-0.3f, 0f, -0.3f);
        public override Vector3 logbookCameraPositionOffset => new(-0.33f, 0.03f, -0.3f);

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.LockpickingToolKit(gameObject);
        }

        public override void Hook()
        {
            On.RoR2.PurchaseInteraction.CanBeAffordedByInteractor += OverrideCanBeAfforded;
            On.RoR2.PurchaseInteraction.OnInteractionBegin += OnChestOpened;
        }

        public override void Unhook()
        {
            On.RoR2.PurchaseInteraction.CanBeAffordedByInteractor -= OverrideCanBeAfforded;
            On.RoR2.PurchaseInteraction.OnInteractionBegin -= OnChestOpened;
        }

        private bool OverrideCanBeAfforded(On.RoR2.PurchaseInteraction.orig_CanBeAffordedByInteractor orig, PurchaseInteraction self, Interactor activator)
        {
            if (IsChest(self))
            {
                CharacterBody body = activator.GetComponent<CharacterBody>();
                if (body && body.inventory)
                {
                    int itemCount = body.inventory.GetItemCount(ItemData.itemIndex);
                    if (itemCount > 0)
                    {
                        return true;
                    }
                }
            }

            return orig(self, activator);
        }

        private void OnChestOpened(On.RoR2.PurchaseInteraction.orig_OnInteractionBegin orig, PurchaseInteraction self, Interactor activator)
        {
            if (IsChest(self))
            {
                CharacterBody body = activator.GetComponent<CharacterBody>();
                if (body && body.inventory)
                {
                    int itemCount = body.inventory.GetItemCount(ItemData.itemIndex);
                    if (itemCount > 0)
                    {
                        body.inventory.RemoveItem(ItemData.itemIndex, itemCount);
                        body.inventory.GiveItem(RiskofDeath.ItemLoader.LockpickingToolKitBroken.ItemData, itemCount);

                        CharacterMasterNotificationQueue.SendTransformNotification(
                            body.master,
                            ItemData.itemIndex,
                            RiskofDeath.ItemLoader.LockpickingToolKitBroken.ItemData.itemIndex,
                            CharacterMasterNotificationQueue.TransformationType.Default
                        );

                        if (!Util.CheckRoll(10f * (itemCount), body.master))
                        {
                            return;
                        }
                        self.cost = 0;
                    }
                }
            }

            orig(self, activator);
        }

        private bool IsChest(PurchaseInteraction purchaseInteraction)
        {
            if (!purchaseInteraction.name.Contains("Lunar"))
            return purchaseInteraction.name.Contains("Chest")
                || purchaseInteraction.name.Contains("Equipment")
                || purchaseInteraction.name.Contains("Shop");

            return false;
        }
    }
}