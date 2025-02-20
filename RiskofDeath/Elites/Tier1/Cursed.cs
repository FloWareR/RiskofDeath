using R2API;
using RiskofDeath.Items;
using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace RiskofDeath.Elites.Tier1
{
    public class Cursed : EliteBase
    {
        public override Color32 EliteColor => new Color32(63, 170, 150, 255);
        public override CombatDirector.EliteTierDef[] EliteTiers => EliteAPI.GetCombatDirectorEliteTiers().Where(x => x.eliteTypes.Contains(Addressables.LoadAssetAsync<EliteDef>("RoR2/Base/EliteFire/edFire.asset").WaitForCompletion())).ToArray();
        public override float HealthMultiplier => 4f;
        public override float DamageMultiplier => 2f;

        public override string EliteLangTokenName => "ELiteCursed";

        public override string EliteEquipmentName => "Demiurge's touch";

        public override string EliteEquipmentPickupDesc => "Become an aspect of curse";

        public override string EliteEquipmentFullDescription => "Become an aspect of curse";

        public override string EliteEquipmentRampTexturePath => "default";

        public override string EliteEquipmentIconPath => "cursedicon";

        public override string EliteEquipmentBuffIconPath => "cursedeliteicon";

        public override bool HasAdjustedHonourTier => true;

        public override string EliteName => "Cursed";

        public override string EliteEquipmentCrownModelPath => "cursedhorn";



        //Elite specifics
        BuffDef permanentCurseBuff = RoR2Content.Buffs.PermanentCurse;
        private static Dictionary<CharacterBody, Dictionary<CharacterBody, int>> cursedEnemiesAndVictims = new Dictionary<CharacterBody, Dictionary<CharacterBody, int>>();


        public override ItemDisplayRuleDict CreateEliteEquipmentDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetCursedElite(gameObject);
        }

        public override void Hook()
        {
            GlobalEventManager.onServerDamageDealt += GlobalEventManager_onServerDamageDealt;
            GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeath;

        }

        private void GlobalEventManager_onServerDamageDealt(DamageReport report)
        {
            var victim = report.victim;
            var attacker = report.attackerBody;

            if (!attacker || !victim) return;

            if (attacker.equipmentSlot?.equipmentIndex == equipmentDef.equipmentIndex || attacker.HasBuff(eliteBuffDef))
            {
                var victimBody = victim.body;
                var damageTaken = report.damageDealt;
                var maxHP = victimBody.maxHealth;

                if (maxHP <= 0) return;

                var hpLostPercentage = (damageTaken / maxHP);
                var maxHPLossPercentage = hpLostPercentage * 1f;
                var stacksToAdd = Mathf.FloorToInt(maxHPLossPercentage * 100f); 

                if (stacksToAdd > 0)
                {
                    for (int i = 0; i < stacksToAdd; i++)
                    {
                        victimBody.AddBuff(RoR2Content.Buffs.PermanentCurse);
                    }

                    Debug.Log($"[Cursed] {victimBody.name} now has {victimBody.GetBuffCount(RoR2Content.Buffs.PermanentCurse)} Permanent Curse stacks.");

                    if (!cursedEnemiesAndVictims.ContainsKey(attacker))
                    {
                        cursedEnemiesAndVictims[attacker] = new Dictionary<CharacterBody, int>();
                    }

                    if (!cursedEnemiesAndVictims[attacker].ContainsKey(victimBody))
                    {
                        cursedEnemiesAndVictims[attacker][victimBody] = 0;
                    }

                    cursedEnemiesAndVictims[attacker][victimBody] += stacksToAdd;
                }
            }
        }

        private void GlobalEventManager_onCharacterDeath(DamageReport report)
        {
            var victim = report.victim;

            if (!victim) return;

            if (cursedEnemiesAndVictims.ContainsKey(victim.body))
            {
                foreach (var affectedVictim in cursedEnemiesAndVictims[victim.body])
                {
                    var victimBody = affectedVictim.Key;
                    int stacksToRemove = affectedVictim.Value;

                    for (int i = 0; i < stacksToRemove; i++)
                    {
                        if (victimBody.HasBuff(RoR2Content.Buffs.PermanentCurse))
                        {
                            victimBody.RemoveBuff(RoR2Content.Buffs.PermanentCurse);
                        }
                    }

                    Debug.Log($"[Cursed] Removed {stacksToRemove} Permanent Curse stacks from {victimBody.name} because {victim.body.name} died.");
                }

                cursedEnemiesAndVictims.Remove(victim.body);
            }
        }

    }
}
