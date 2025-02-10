using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace RiskofDeath.Items.Tier2
{
    public class RustyCleaver : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("rustycleaver");
        public override string ItemIdentifier => "RustyCleaver";
        public override string ItemName => "Rusty Cleaver";
        public override string ItemPick => "Your bleeding effects deal quadruple damage.";
        public override string ItemDesc => "Bleeding effects deal +300% (+300% per stack) more damage over time.";
        public override string ItemLore => "Everybody is a book of blood; wherever we're opened, we're red.";
        public override float logbookCameraMinDistance => 3.5f;
        public override float logbookCameraMaxDistance => 5.5f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => new(-1f, 0f, 0f);

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetRustyCleaver(gameObject);
        }

        public override void Hook()
        {
            On.RoR2.DotController.AddDot += DotController_AddDot;
        }

        public override void Unhook()
        {
            On.RoR2.DotController.AddDot -= DotController_AddDot;
        }

        private void DotController_AddDot(On.RoR2.DotController.orig_AddDot orig, DotController self, GameObject attackerObject, float duration, DotController.DotIndex dotIndex, float damageMultiplier, uint? maxStacksFromAttacker, float? totalDamage, DotController.DotIndex? preUpgradeDotIndex)
        {
            if (dotIndex == DotController.DotIndex.Bleed || dotIndex == DotController.DotIndex.SuperBleed)
            {
                var attackerBody = attackerObject?.GetComponent<CharacterBody>();
                if (attackerBody)
                {
                    var itemCount = GetItemCount(attackerBody.master);
                    if (itemCount > 0)
                    {
                        if (dotIndex == DotController.DotIndex.Bleed)
                        {
                            dotIndex = DotController.DotIndex.SuperBleed;
                        }

                        damageMultiplier = 4f * itemCount;
                    }
                }
            }

            orig(self, attackerObject, duration, dotIndex, damageMultiplier, maxStacksFromAttacker, totalDamage, DotController.DotIndex.Bleed);
        }
    }
}