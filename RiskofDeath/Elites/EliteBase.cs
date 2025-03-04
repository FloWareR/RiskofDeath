﻿using R2API;
using RoR2;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static RoR2.CombatDirector;

namespace RiskofDeath.Elites
{
    public abstract class EliteBase
    {
        public abstract string EliteName { get; }
        public abstract string EliteLangTokenName { get; }
        public abstract string EliteEquipmentName { get; }
        public abstract string EliteEquipmentPickupDesc { get; }
        public abstract string EliteEquipmentFullDescription { get; }
        public abstract Color32 EliteColor { get; }

        public abstract string EliteEquipmentIconPath { get; } 
        public abstract string EliteEquipmentCrownModelPath { get; }
        public abstract string EliteEquipmentBuffIconPath { get; }
        public abstract string EliteEquipmentRampTexturePath { get; }
        public abstract EliteTierDef[] EliteTiers { get; }

        public abstract float HealthMultiplier { get; }
        public abstract float DamageMultiplier { get; }

        public abstract bool HasAdjustedHonourTier { get; }

        public virtual void Init()
        {
            CreateLang();
            CreateEliteBuff();
            CreateEliteEquipment();
            CreateElite();
            Hook();
        }

        public BuffDef eliteBuffDef = ScriptableObject.CreateInstance<BuffDef>();
        public EquipmentDef equipmentDef = ScriptableObject.CreateInstance<EquipmentDef>();
        public EliteDef eliteDef = ScriptableObject.CreateInstance<EliteDef>();

        protected void CreateLang()
        {
            LanguageAPI.Add("ELITE_" + EliteLangTokenName + "_MODIFIER", EliteName + " {0}");
            LanguageAPI.Add("ELITE_" + EliteLangTokenName, EliteName);

            LanguageAPI.Add("ELITE_EQUIPMENT_" + EliteLangTokenName + "_NAME", EliteEquipmentName);
            LanguageAPI.Add("ELITE_EQUIPMENT_" + EliteLangTokenName + "_PICKUP", EliteEquipmentPickupDesc);
            LanguageAPI.Add("ELITE_EQUIPMENT_" + EliteLangTokenName + "_DESCRIPTION", EliteEquipmentFullDescription);
            LanguageAPI.Add("ELITE_EQUIPMENT_" + EliteLangTokenName + "_LORE", "");
        }

        public abstract ItemDisplayRuleDict CreateEliteEquipmentDisplayRules(GameObject gameObject);

        protected void CreateEliteBuff()
        {
            eliteBuffDef.name = EliteLangTokenName;
            eliteBuffDef.canStack = false;
           

            Sprite sprite = RiskofDeath.Assets.LoadAsset<Sprite>(EliteEquipmentBuffIconPath);
            eliteBuffDef.iconSprite = sprite;
        }

        protected void CreateEliteEquipment()
        {
            equipmentDef.name = "ELITE_EQUIPMENT_" + EliteLangTokenName;
            equipmentDef.nameToken = "ELITE_EQUIPMENT_" + EliteLangTokenName + "_NAME";
            equipmentDef.pickupToken = "ELITE_EQUIPMENT_" + EliteLangTokenName + "_PICKUP";
            equipmentDef.descriptionToken = "ELITE_EQUIPMENT_" + EliteLangTokenName + "_DESCRIPTION";
            equipmentDef.loreToken = "ELITE_EQUIPMENT_" + EliteLangTokenName + "_LORE";
            equipmentDef.pickupModelPrefab = CreateEliteEquipmentModel(EliteColor);

            if (!EliteEquipmentIconPath.StartsWith("RoR2"))
            {
                equipmentDef.pickupIconSprite = RiskofDeath.Assets.LoadAsset<Sprite>(EliteEquipmentIconPath);
            }
            else
            {
                equipmentDef.pickupIconSprite = Addressables.LoadAssetAsync<Sprite>(EliteEquipmentIconPath).WaitForCompletion();
            }

            equipmentDef.appearsInSinglePlayer = true;
            equipmentDef.appearsInMultiPlayer = true;
            equipmentDef.canDrop = false;
            equipmentDef.passiveBuffDef = eliteBuffDef;
            equipmentDef.requiredExpansion = RiskofDeath.riskofdeathExpansion;

            var crownModelAsset = RiskofDeath.Assets.LoadAsset<GameObject>(EliteEquipmentCrownModelPath);
            var itemDisplayRuleDict = CreateEliteEquipmentDisplayRules(crownModelAsset);
            ItemAPI.Add(new CustomEquipment(equipmentDef, itemDisplayRuleDict));
        }

        public virtual GameObject CreateEliteEquipmentModel(Color32 color)
        {
            GameObject gameObject = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/EliteFire/PickupEliteFire.prefab").WaitForCompletion().InstantiateClone("PickupAffix" + EliteName, false);
            Material material = Object.Instantiate(gameObject.GetComponentInChildren<MeshRenderer>().material);
            material.color = color;

            foreach (Renderer renderer in gameObject.GetComponentsInChildren<Renderer>())
            {
                renderer.material = material;
            }

            return gameObject;
        }

        protected void CreateElite()
        {
            eliteDef.name = "ELITE_" + EliteLangTokenName;
            eliteDef.modifierToken = "ELITE_" + EliteLangTokenName + "_MODIFIER";
            eliteDef.eliteEquipmentDef = equipmentDef;
            eliteDef.healthBoostCoefficient = HealthMultiplier;
            eliteDef.damageBoostCoefficient = DamageMultiplier;
            eliteDef.shaderEliteRampIndex = 0;

            Texture2D rampTexture = RiskofDeath.Assets.LoadAsset<Texture2D>(EliteEquipmentRampTexturePath);
            //Texture2D defaultRampTexture = Addressables.LoadAssetAsync<Texture2D>("RoR2/Base/Common/ColorRamps/texRampFireElite.png").WaitForCompletion();
            EliteAPI.Add(new CustomElite(eliteDef, EliteTiers, rampTexture));

            eliteBuffDef.eliteDef = eliteDef;
            ContentAddition.AddBuffDef(eliteBuffDef);

            if (HasAdjustedHonourTier)
            {
                EliteDef honourEliteDef = ScriptableObject.CreateInstance<EliteDef>();
                honourEliteDef.name = eliteDef.name;
                honourEliteDef.modifierToken = eliteDef.modifierToken;
                honourEliteDef.eliteEquipmentDef = eliteDef.eliteEquipmentDef;
                honourEliteDef.healthBoostCoefficient = 2.5f;
                honourEliteDef.damageBoostCoefficient = 1.5f;
                honourEliteDef.shaderEliteRampIndex = eliteDef.shaderEliteRampIndex;

                EliteTierDef[] honourTiers = EliteAPI.GetCombatDirectorEliteTiers().Where(x => x.eliteTypes.Contains(Addressables.LoadAssetAsync<EliteDef>("RoR2/Base/EliteFire/edFireHonor.asset").WaitForCompletion())).ToArray();
                EliteAPI.Add(new CustomElite(honourEliteDef, honourTiers, rampTexture));
            }
        }

        public abstract void Hook();
    }
}
