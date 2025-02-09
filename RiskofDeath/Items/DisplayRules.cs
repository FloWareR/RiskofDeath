using R2API;
using RoR2;
using UnityEngine;


namespace RiskofDeath.Items
{
    public static class DisplayRules
    {
        public static CharacterModel.RendererInfo[] ItemDisplaySetup(GameObject obj)
        {
            MeshRenderer[] meshes = obj.GetComponentsInChildren<MeshRenderer>();
            CharacterModel.RendererInfo[] renderInfos = new CharacterModel.RendererInfo[meshes.Length];

            for (int i = 0; i < meshes.Length; i++)
            {
                renderInfos[i] = new CharacterModel.RendererInfo
                {
                    defaultMaterial = meshes[i].material,
                    renderer = meshes[i],
                    defaultShadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On,
                    ignoreOverlays = false
                };
            }

            return renderInfos;
        }

        #region Tier1
        public static ItemDisplayRuleDict GetBoxOMatches(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.10403F, -0.08257F, -0.11774F),
                localAngles = new Vector3(0F, 320F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.14089F, -0.02668F, -0.14147F),
                localAngles = new Vector3(21.17312F, 317.0703F, 181.7356F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.92374F, 0.26504F, 0.60976F),
                localAngles = new Vector3(284.0886F, 158.2516F, 180.0001F),
                localScale = new Vector3(1F, 1F, 1F),
            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.11682F, 0.02026F, -0.1634F),
                localAngles = new Vector3(0.00008F, 336.4403F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.07731F, -0.03175F, -0.15196F),
                localAngles = new Vector3(25.54552F, 348.3605F, 168.2716F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.13974F, 0.0217F, -0.14504F),
                localAngles = new Vector3(0.86981F, 309.7755F, 180.8664F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(-0.00706F, -0.14998F, 0.67067F),
                localAngles = new Vector3(0F, 173.516F, -0.00003F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F),
            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.16066F, 0.07236F, -0.1276F),
                localAngles = new Vector3(349.6508F, 320F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(1.18544F, 0.99035F, -0.53707F),
                localAngles = new Vector3(78.44698F, 174.1575F, -0.00001F),
                localScale = new Vector3(1F, 1F, 1F),
            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                childName = "SpineChest1",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.1802F, -0.11795F, -0.13532F),
                localAngles = new Vector3(11.27298F, 318.7819F, 188.1838F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.07506F, 0.03893F, -0.09566F),
                localAngles = new Vector3(0F, 320F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.06729F, 0.04692F, -0.13212F),
                localAngles = new Vector3(1.82844F, 342.9527F, 177.2779F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.13277F, 0.05855F, 0.06943F),
                localAngles = new Vector3(8.45829F, 219.3854F, 0.00001F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.13277F, 0.05855F, 0.06943F),
                localAngles = new Vector3(8.45829F, 219.3854F, 0.00001F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.14764F, 0.14829F, 0.0498F),
                localAngles = new Vector3(55.21856F, 154.4252F, 7.76815F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F),
            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                childName = "Pelvis",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.11163F, 0.02529F, -0.14101F),
                localAngles = new Vector3(0F, 340F, 90F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F),
            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                childName = "Head",
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                localPos = new Vector3(0.00001F, -7.07703F, -8.73324F),
                localAngles = new Vector3(323.1961F, 0.00002F, -0.00006F),
                localScale = new Vector3(1F, 1F, 1F),
            });


            return itemRules;
        }
        #endregion

    }
}
