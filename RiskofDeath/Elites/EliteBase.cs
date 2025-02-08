using R2API;
using RoR2;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static RoR2.CombatDirector;

namespace RiskofDeath.Elites
{
    public abstract class EliteBase
    {
        public BuffDef BuffData = ScriptableObject.CreateInstance<BuffDef>();

        public abstract EliteDef EliteData { get; }
        public abstract EquipmentDef EquipmentData { get; }
        public abstract string EliteIdentifier { get; }
        public abstract string EliteName { get; }
        public abstract string EquipmentName { get; }
        public abstract string EquipmentPick { get; }
        public abstract string EquipmentDesc { get; }
        public abstract string EquipmentLore { get; }
        public abstract string EliteEquipmentRampTexturePath { get; }
        public abstract Color32 EliteColor { get; }
        public abstract EliteTierDef[] EliteTiers { get; }
        public abstract float HealthMultiplier { get; }
        public abstract float DamageMultiplier { get; }
        public abstract string EquipmentIconPath { get; }
        public abstract bool HonorArtifactAdjustment { get; }


        public virtual void Init()
        {
            SetLangToken();
            SetEliteBuff();
            SetEquipment();

        }

        public void SetLangToken()
        {
            EliteData.name = "ROD_ELITE_" + EliteIdentifier + "_NAME";
            EliteData.modifierToken = "ROD_ELITE" + EliteIdentifier + "_MOD";

            LanguageAPI.Add(EliteData.name, EliteName);
            LanguageAPI.Add(EliteData.modifierToken, EliteName);


            EquipmentData.name = EliteIdentifier +"_equipment";
            EquipmentData.nameToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_NAME";
            EquipmentData.pickupToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_PICK";
            EquipmentData.descriptionToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_DESC";
            EquipmentData.loreToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_LORE";

            LanguageAPI.Add(EquipmentData.nameToken, EquipmentName);
            LanguageAPI.Add(EquipmentData.pickupToken, EquipmentPick);
            LanguageAPI.Add(EquipmentData.descriptionToken, EquipmentDesc);
            LanguageAPI.Add(EquipmentData.loreToken, EquipmentLore);
        }

        protected void SetEliteBuff()
        {
            BuffData.name = EliteIdentifier;
            BuffData.canStack = false;

            var sprite = RiskofDeath.Assets.LoadAsset<Sprite>(EquipmentIconPath);
            BuffData.iconSprite = sprite;
        }

        protected void SetEquipment()
        {
            EquipmentData.pickupModelPrefab = CreateEliteEquipmentModel(EliteColor);
            EquipmentData.passiveBuffDef = BuffData;
            ItemAPI.Add(new CustomEquipment(EquipmentData, new ItemDisplayRuleDict(null)));
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

        protected void SetElite()
        {
            EliteData.color = EliteColor;
            BuffData.eliteDef = EliteData;
            EliteData.healthBoostCoefficient = HealthMultiplier;
            EliteData.damageBoostCoefficient = DamageMultiplier;

            Texture2D rampTexture = RiskofDeath.Assets.LoadAsset<Texture2D>(EliteEquipmentRampTexturePath);
            EliteAPI.Add(new CustomElite(EliteData, EliteTiers, rampTexture));
            ContentAddition.AddBuffDef(BuffData);
            if (!HonorArtifactAdjustment) return;

            EliteDef HonorEliteData = ScriptableObject.CreateInstance<EliteDef>();
            HonorEliteData.name = EliteData.name;
            HonorEliteData.modifierToken = EliteData.modifierToken;
            HonorEliteData.eliteEquipmentDef = EliteData.eliteEquipmentDef;
            HonorEliteData.healthBoostCoefficient = 2.5f;
            HonorEliteData.damageBoostCoefficient = 1.5f;
            HonorEliteData.shaderEliteRampIndex = EliteData.shaderEliteRampIndex;

            EliteTierDef[] honourTiers = EliteAPI.GetCombatDirectorEliteTiers().Where(x => x.eliteTypes.Contains(Addressables.LoadAssetAsync<EliteDef>("RoR2/Base/EliteFire/edFireHonor.asset").WaitForCompletion())).ToArray();
            EliteAPI.Add(new CustomElite(HonorEliteData, honourTiers, rampTexture));
        }
    }
}
