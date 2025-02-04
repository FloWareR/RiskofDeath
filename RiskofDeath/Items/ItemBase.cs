using RoR2;
using R2API;
using UnityEngine.AddressableAssets;
using RoR2.ExpansionManagement;
namespace RiskofDeath.Items

{
    public abstract class ItemBase
    {
        public abstract ItemDef ItemData { get; }
        public abstract string ItemIdentifier { get; }
        public abstract string ItemName { get; }
        public abstract string ItemPick { get; }
        public abstract string ItemDesc { get; }
        public abstract string ItemLore { get; }
        public abstract ItemDef ItemToCorrupt { get; }

        public virtual void Init()
        {
            SetLangToken();
            Hook();
        }

        protected void SetLangToken()
        {
            ItemData.name = ItemIdentifier;
            ItemData.nameToken = "ROD_ITEM_" + ItemIdentifier + "_" + "NAME";
            ItemData.pickupToken = "ROD_ITEM_" + ItemIdentifier + "_" + "PICK";
            ItemData.descriptionToken = "ROD_ITEM_" + ItemIdentifier + "_" + "DESC";
            ItemData.loreToken = "ROD_ITEM_" + ItemIdentifier + "_" + "LORE";

            LanguageAPI.Add(ItemData.nameToken, ItemName);
            LanguageAPI.Add(ItemData.pickupToken, ItemPick);
            LanguageAPI.Add(ItemData.descriptionToken, ItemDesc);
            LanguageAPI.Add(ItemData.loreToken, ItemLore);

            ItemAPI.Add(new CustomItem(ItemData, new ItemDisplayRuleDict(null)));
        }

        public int GetItemCount(CharacterMaster characterMaster)
        {
            if (!characterMaster || !characterMaster.inventory) return 0;
            return characterMaster.inventory.GetItemCount(ItemData);
        }

        public abstract void Hook();

        public abstract void Unhook();
    }
}
