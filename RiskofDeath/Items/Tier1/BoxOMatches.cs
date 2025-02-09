using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;

namespace RiskofDeath.Items.Tier1
{
    public class BoxOMatches : ItemBase
    {

        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("boxomatches");
        public override string ItemIdentifier => "BoxOMatches";
        public override string ItemName => "Box O' Matches";
        public override string ItemPick => "Light em' up, break em' down.";
        public override string ItemDesc => "5% chance (+5% per stack) to set enemies on fire for 2 seconds (+0.5s per stack), dealing 10% base damage.";
        public override string ItemLore => "An old, half-empty box of matches. Each one a spark waiting to ignite chaos.";
        public override float logbookCameraMinDistance => 0.5f;
        public override float logbookCameraMaxDistance => 1.5f;
        public override Vector3 logbookFocusPointOffset => Vector3.zero;
        public override Vector3 logbookCameraPositionOffset => Vector3.zero;

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetBoxOMatches(gameObject);
        }

        //Item specifics
        private ItemDef _ignitionTank;
        private const float BaseBurnDuration = 1.5f;
        private const float BaseBurnStackIncrease = 0.5f;
        private const float BaseDamageMultiplier = 0.1f;

        public override void Hook()
        {
            GlobalEventManager.onServerDamageDealt += GlobalEventManager_onServerDamageDealt;
        }

        public override void Unhook()
        {
            GlobalEventManager.onServerDamageDealt -= GlobalEventManager_onServerDamageDealt;
        }

        private void GlobalEventManager_onServerDamageDealt(DamageReport report)
        {
            if (!_ignitionTank) _ignitionTank = ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("StrengthenBurn"));

            if (!report.attackerBody || !report.victimBody) return;
            if ((report.damageInfo.damageType & DamageType.DoT) != 0) return;
            var attacker = report.attackerBody;
            var itemCount = GetItemCount(attacker.master);
            if (itemCount <= 0) return;
            if (!Util.CheckRoll(5f * itemCount, attacker.master)) return;

            var burnDuration = BaseBurnDuration + (itemCount * BaseBurnStackIncrease);
            var burnDamage = (attacker.baseDamage * BaseDamageMultiplier);
            var ignitionTankCount = attacker.inventory.GetItemCount(_ignitionTank);
            var debuff = ignitionTankCount > 0 ? DotController.DotIndex.StrongerBurn : DotController.DotIndex.Burn;

            if (debuff == DotController.DotIndex.StrongerBurn)
            {
                burnDamage *= (4 * ignitionTankCount);
            }

            DotController.InflictDot(
                report.victimBody.gameObject,
                report.attackerBody.gameObject,
                debuff,
                burnDuration,
                burnDamage
            );

        }
    }
}
