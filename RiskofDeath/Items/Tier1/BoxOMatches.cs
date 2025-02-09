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

        public static List<Dictionary<string, object>> itemRules;

        static BoxOMatches()
        {
            itemRules = new List<Dictionary<string, object>>();

            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.10403F, -0.08257F, -0.11774F) },
                { "localAngles", new Vector3(0F, 320F, 180F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.10403F, -0.08257F, -0.11774F) },
                { "localAngles", new Vector3(0F, 320F, 180F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.14089F, -0.02668F, -0.14147F) },
                { "localAngles", new Vector3(21.17312F, 317.0703F, 181.7356F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.92374F, 0.26504F, 0.60976F) },
                { "localAngles", new Vector3(284.0886F, 158.2516F, 180.0001F) },
                { "localScale", new Vector3(1F, 1F, 1F) }

            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.11682F, 0.02026F, -0.1634F) },
                { "localAngles", new Vector3(0.00008F, 336.4403F, 180F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.07731F, -0.03175F, -0.15196F) },
                { "localAngles", new Vector3(25.54552F, 348.3605F, 168.2716F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.13974F, 0.0217F, -0.14504F) },
                { "localAngles", new Vector3(0.86981F, 309.7755F, 180.8664F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(-0.00706F, -0.14998F, 0.67067F) },
                { "localAngles", new Vector3(0F, 173.516F, -0.00003F) },
                { "localScale", new Vector3(0.3F, 0.3F, 0.3F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.16066F, 0.07236F, -0.1276F) },
                { "localAngles", new Vector3(349.6508F, 320F, 180F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "SpineChest1" },
                { "localPos", new Vector3(1.18544F, 0.99035F, -0.53707F) },
                { "localAngles", new Vector3(78.44698F, 174.1575F, -0.00001F) },
                { "localScale", new Vector3(1F, 1F, 1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.1802F, -0.11795F, -0.13532F) },
                { "localAngles", new Vector3(11.27298F, 318.7819F, 188.1838F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.07506F, 0.03893F, -0.09566F) },
                { "localAngles", new Vector3(0F, 320F, 180F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.06729F, 0.04692F, -0.13212F) },
                { "localAngles", new Vector3(1.82844F, 342.9527F, 177.2779F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.13277F, 0.05855F, 0.06943F) },
                { "localAngles", new Vector3(8.45829F, 219.3854F, 0.00001F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.14764F, 0.14829F, 0.0498F) },
                { "localAngles", new Vector3(55.21856F, 154.4252F, 7.76815F) },
                { "localScale", new Vector3(0.3F, 0.3F, 0.3F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Pelvis" },
                { "localPos", new Vector3(0.11163F, 0.02529F, -0.14101F) },
                { "localAngles", new Vector3(0F, 340F, 90F) },
                { "localScale", new Vector3(0.1F, 0.1F, 0.1F) }
            });
            itemRules.Add(new Dictionary<string, object>
            {
                { "childName", "Head" },
                { "localPos", new Vector3(0.00001F, -7.07703F, -8.73324F) },
                { "localAngles", new Vector3(323.1961F, 0.00002F, -0.00006F) },
                { "localScale", new Vector3(1F, 1F, 1F) }
            });
        }

        //Item specifics
        private ItemDef _ignitionTank;
        private const float BaseBurnDuration = 1.5f;
        private const float BaseBurnStackIncrease = 0.5f;
        private const float BaseDamageMultiplier = 0.1f;


        public override void Init()
        {
            base.Init();
        }


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

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            if (itemRules.Count == 0) return null;

            ItemDisplayRuleDict itemDisplayRuleDict = new ItemDisplayRuleDict();

            for (int i = 0; i < itemRules.Count; i++)
            {
                AddModelRule(itemDisplayRuleDict, gameObject, modelList[i], itemRules[i]);
            }

            return itemDisplayRuleDict;
        }
    }
}
