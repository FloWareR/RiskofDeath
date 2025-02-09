using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace RiskofDeath.Elites.Tier1
{
    public class Cursed : EliteBase
    {

        public override Color32 EliteColor => new Color32(53, 5, 5, 255);
        public override CombatDirector.EliteTierDef[] EliteTiers => EliteAPI.GetCombatDirectorEliteTiers().Where(x => x.eliteTypes.Contains(Addressables.LoadAssetAsync<EliteDef>("RoR2/Base/EliteFire/edFire.asset").WaitForCompletion())).ToArray();
        public override float HealthMultiplier => 4f;
        public override float DamageMultiplier => 2f;

        public override string EliteLangTokenName => "ELiteCursed";

        public override string EliteEquipmentName => "Demiurge's touch";

        public override string EliteEquipmentPickupDesc => "Become an aspect of curse";

        public override string EliteEquipmentFullDescription => "Become an aspect of curse";

        public override string EliteEquipmentRampTexturePath => "texRampNuclearElite";

        public override string EliteEquipmentIconPath => "cursedicon";

        public override string EliteEquipmentBuffIconPath => "cursedeliteicon";

        public override bool HasAdjustedHonourTier => true;

        public override string EliteName => "Curse";

        public override ItemDisplayRuleDict CreateEliteEquipmentDisplayRules(GameObject gameObject)
        {
            return null;
        }

        public override void Hooks()
        {

        }
    }
}
