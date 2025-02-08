using R2API;
using RiskofDeath.Items;
using RoR2;
using UnityEngine;

namespace RiskofDeath.Elites
{
    public abstract class EliteBase
    {
        public EliteDef EliteData = ScriptableObject.CreateInstance<EliteDef>();
        public EquipmentDef EquipmentData = ScriptableObject.CreateInstance<EquipmentDef>();
        public BuffDef BuffData = ScriptableObject.CreateInstance<BuffDef>();

        public abstract string EliteIdentifier { get; }
        public abstract string EliteName { get; }
        public abstract string EquipmentName { get; }
        public abstract string EquipmentPick { get; }
        public abstract string EquipmentDesc { get; }
        public abstract string EquipmentLore { get; }
        public abstract Color32 EliteColor { get; }
        public abstract float HealthMultiplier { get; }
        public abstract float DamageMultiplier { get; }

        public abstract string EquipmentIconPath { get; }


        public virtual void Init()
        {
            SetLangToken();
        }

        public void SetLangToken()
        {
            EliteData.name = EliteIdentifier;
            EliteData.modifierToken = EliteIdentifier;
            LanguageAPI.Add(EliteData.name, EliteName);
            LanguageAPI.Add(EliteData.modifierToken, EliteName);


            EquipmentData.name = EliteIdentifier +"_equipment";
            EquipmentData.nameToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_" + "NAME";
            EquipmentData.pickupToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_" + "PICK";
            EquipmentData.descriptionToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_" + "DESC";
            EquipmentData.loreToken = "ROD_EQUIPMENT_" + EliteIdentifier + "_" + "LORE";

            LanguageAPI.Add(EquipmentData.nameToken, EquipmentName);
            LanguageAPI.Add(EquipmentData.pickupToken, EquipmentPick);
            LanguageAPI.Add(EquipmentData.descriptionToken, EquipmentDesc);
            LanguageAPI.Add(EquipmentData.loreToken, EquipmentLore);
        }

        protected void CreateEliteBuff()
        {
            BuffData.name = EliteIdentifier;
            BuffData.canStack = false;

            var sprite = RiskofDeath.Assets.LoadAsset<Sprite>(EquipmentIconPath);
            BuffData.iconSprite = sprite;
        }
    }
}
