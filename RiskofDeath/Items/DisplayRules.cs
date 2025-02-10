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

        #region Tier2
        public static ItemDisplayRuleDict GetRustyCleaver(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.02869F, 0.45339F, -0.05617F),
                localAngles = new Vector3(345.9638F, 89.09334F, 359.4414F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.06188F, 0.35699F, -0.04915F),
                localAngles = new Vector3(336.1166F, 99.3255F, 358.0585F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.04797F, 0.26488F, -0.00119F),
                localAngles = new Vector3(341.7979F, 87.68604F, 348.5745F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(0.00164F, 4.05014F, 1.74238F),
                localAngles = new Vector3(33.91186F, 359.974F, 0.06662F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HeadCenter",
                localPos = new Vector3(-0.00021F, 0.22392F, 0.03135F),
                localAngles = new Vector3(348.6994F, 90F, 359.4972F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.02801F, 0.21596F, 0.00206F),
                localAngles = new Vector3(343.333F, 89.71896F, 15.18069F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.01347F, 0.3018F, 0.06613F),
                localAngles = new Vector3(338.8049F, 91.01917F, 11.6614F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PlatformBase",
                localPos = new Vector3(0.54051F, 0.53434F, 0.49352F),
                localAngles = new Vector3(0.00015F, 134.2849F, 90F),
                localScale = new Vector3(0.4F, 0.4F, 0.4F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.0015F, 0.28487F, -0.00071F),
                localAngles = new Vector3(334.318F, 90.18276F, 359.666F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(0.00134F, 1.69847F, 1.97656F),
                localAngles = new Vector3(55.41888F, 0.32299F, 0.77654F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.00398F, 0.2678F, -0.01936F),
                localAngles = new Vector3(335.9519F, 92.31834F, 357.4459F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.00079F, 0.28442F, -0.06959F),
                localAngles = new Vector3(356.2583F, 93.7F, 3.2681F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.0354F, 0.10203F, -0.15594F),
                localAngles = new Vector3(46.88807F, 228.9811F, 61.57678F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.03532F, 0.28191F, 0.03178F),
                localAngles = new Vector3(335.4603F, 97.77063F, 359.4907F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(0.02972F, 0.39662F, -0.23865F),
                localAngles = new Vector3(289.3741F, 11.62114F, 351.8151F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.37805F, 0.08382F, 0.18078F),
                localAngles = new Vector3(44.74932F, 16.17601F, 24.43461F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(0F, 5.01826F, -2.57556F),
                localAngles = new Vector3(10.35941F, 170.7444F, 359.9207F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            return itemRules;
        }
        #endregion

        #region VoidTier
        public static ItemDisplayRuleDict GetDisperseObsidian(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0.015F, 0.089F, 0.094F),
                localAngles = new Vector3(354.006F, 25.52922F, 12.64355F),
                localScale = new Vector3(0.05F, 0.05F, 0.05F)
            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(-0.005F, 0.079F, 0.065F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MainWeapon",
                localPos = new Vector3(-0.0571F, 0.2465F, -0.0411F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.03F, 0.03F, 0.03F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "LowerArmL",
                localPos = new Vector3(0F, 3.16F, 1.33F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.6F, 0.6F, 0.6F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0F, 0.11F, 0.0961F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.06F, 0.06F, 0.06F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(-0.018F, -0.063F, 0.14F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.06F, 0.06F, 0.06F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(-0.002F, 0.124F, 0.097F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PlatformBase",
                localPos = new Vector3(0F, -0.087F, 0.559F),
                localAngles = new Vector3(30F, 0F, 0F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MechHandL",
                localPos = new Vector3(-0.071F, 0.167F, 0.18F),
                localAngles = new Vector3(1.98064F, 335.2029F, 0.86459F),
                localScale = new Vector3(0.06F, 0.06F, 0.06F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0F, 0F, 0F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.6F, 0.6F, 0.6F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(-0.002F, 0.124F, -0.062F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "TopRail",
                localPos = new Vector3(-0.0018F, 0.6546F, 0.0682F),
                localAngles = new Vector3(333.5999F, 228.3362F, 242.2269F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ElbowR",
                localPos = new Vector3(0.01412F, -0.0128F, 0.00314F),
                localAngles = new Vector3(350.8115F, 267.9935F, 170.0059F),
                localScale = new Vector3(0.06F, 0.06F, 0.06F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0.0023F, -0.0184F, 0.0428F),
                localAngles = new Vector3(5.39894F, 338.2419F, 351.8678F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0F, 0.173F, -0.052F),
                localAngles = new Vector3(5.40387F, 4.77987F, 2.0632F),
                localScale = new Vector3(0.07F, 0.07F, 0.077F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandL",
                localPos = new Vector3(0.0031F, 0.0011F, -0.0616F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(0.07F, 0.07F, 0.07F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Weapon",
                localPos = new Vector3(0F, 18.58F, 0F),
                localAngles = new Vector3(0F, 0F, 0F),
                localScale = new Vector3(1.3F, 1.3F, 1.3F)
            });

            return itemRules;
        }

        public static ItemDisplayRuleDict GetOblivionRod(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.03887F, 0.19313F, -0.35922F),
                localAngles = new Vector3(342.1374F, 90F, 359.4743F),
                localScale = new Vector3(0.03F, 0.03F, 0.03F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.19274F, 0.15706F, -0.11192F),
                localAngles = new Vector3(359.3159F, 90F, 359.6954F),
                localScale = new Vector3(0.025F, 0.025F, 0.025F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.16469F, 0.0046F, -0.14465F),
                localAngles = new Vector3(341.7979F, 87.68604F, 348.5745F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.83001F, 0.7502F, -2.31366F),
                localAngles = new Vector3(0F, 90F, 0F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.16523F, 0.23189F, -0.40223F),
                localAngles = new Vector3(348.6994F, 90F, 359.4972F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.06557F, -0.0568F, -0.36536F),
                localAngles = new Vector3(13.23862F, 90.00001F, 15.10512F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.00818F, -0.0112F, -0.22463F),
                localAngles = new Vector3(4.00708F, 90F, 11.84948F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "CalfBackL",
                localPos = new Vector3(0.09101F, 0.44698F, -0.15614F),
                localAngles = new Vector3(0F, 90F, 0F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.13729F, 0.0872F, -0.38956F),
                localAngles = new Vector3(4.00708F, 90F, 359.713F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(-0.67749F, -1.06753F, 3.14891F),
                localAngles = new Vector3(7.16477F, 76.65801F, 17.82576F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.12563F, -0.0426F, -0.23743F),
                localAngles = new Vector3(4.00708F, 90F, 358.0416F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Backpack",
                localPos = new Vector3(0.15717F, -0.1137F, -0.1316F),
                localAngles = new Vector3(11.38076F, 90F, 3.61178F),
                localScale = new Vector3(0.03F, 0.03F, 0.03F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "CalfR",
                localPos = new Vector3(-0.01221F, 0.23852F, -0.0729F),
                localAngles = new Vector3(358.3372F, 267.2607F, 171.668F),
                localScale = new Vector3(0.03F, 0.03F, 0.03F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.12983F, -0.17392F, -0.54172F),
                localAngles = new Vector3(27.46382F, 90F, 347.1331F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.06847F, 0.009F, -0.36224F),
                localAngles = new Vector3(0F, 71.66755F, 0F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.02691F, -0.29368F, -0.16817F),
                localAngles = new Vector3(356.4931F, 21.20902F, 90F),
                localScale = new Vector3(0.04F, 0.04F, 0.04F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Weapon",
                localPos = new Vector3(1.51914F, 14.93707F, 3.67804F),
                localAngles = new Vector3(4.59619F, 195F, 180F),
                localScale = new Vector3(0.8F, 0.8F, 0.8F)

            });

            return itemRules;
        }
        #endregion

        #region Elites
        public static ItemDisplayRuleDict GetCursedElite(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.13155F, 0.25568F, 0.05598F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.13155F, 0.25568F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.07893F, 0.2023F, -0.08553F),
                    localAngles = new Vector3(0F, 0F, 354.3904F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.07893F, 0.2023F, -0.08553F),
                    localAngles = new Vector3(0.09448F, 182.007F, 354.3904F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.06115F, 0.11574F, 0.02232F),
                    localAngles = new Vector3(359.9698F, 359.9662F, 353.8948F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.0561F, 0.10652F, 0.02204F),
                    localAngles = new Vector3(359.6158F, 168.3848F, 345.0797F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.14142F, 1.17352F, -0.0319F),
                    localAngles = new Vector3(52.18505F, 0.73549F, 357.8897F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.28221F, 1.30215F, -0.23344F),
                    localAngles = new Vector3(304.4953F, 179.5544F, 347.3702F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                }
            });

            itemRules.Add("mdlEngi", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "HeadCenter",
                    localPos = new Vector3(0.10674F, 0.03389F, -0.0008F),
                    localAngles = new Vector3(0F, 0.00172F, 359.6529F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "HeadCenter",
                    localPos = new Vector3(-0.09771F, 0.03389F, -0.00108F),
                    localAngles = new Vector3(0F, 180F, 359.4972F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlMage", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.04747F, 0.07822F, -0.05586F),
                    localAngles = new Vector3(0.01224F, 0.11757F, 347.5523F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.04747F, 0.07822F, -0.05586F),
                    localAngles = new Vector3(359.9848F, 179.9051F, 347.5523F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlMerc", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.09567F, 0.15831F, 0.05772F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.09567F, 0.15831F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "FlowerBase",
                    localPos = new Vector3(0.56665F, -0.16998F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "FlowerBase",
                    localPos = new Vector3(-0.56665F, -0.16998F, 0F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                }
            });

            itemRules.Add("mdlLoader", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.08736F, 0.14587F, 0.02489F),
                    localAngles = new Vector3(-0.00005F, 359.9876F, 354.6518F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.08736F, 0.14575F, 0.02489F),
                    localAngles = new Vector3(0.00143F, 180.0169F, 354.8311F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlCroco", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.28366F, 0.21945F, 0.03642F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.28366F, 0.21945F, 0.03642F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.09244F, 0.11623F, 0.0677F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.09244F, 0.11623F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.08787F, 0.07967F, -0.02034F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.08787F, 0.07967F, -0.02034F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.12116F, 0.05902F, 0.01179F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.12116F, 0.05902F, 0.01179F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.08189F, 0.13718F, -0.04639F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.08189F, 0.13718F, -0.04639F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.16633F, 0.25096F, -0.02699F),
                    localAngles = new Vector3(359.4137F, 357.0717F, 353.5334F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.16633F, 0.27405F, -0.04165F),
                    localAngles = new Vector3(0.02306F, 180.8884F, 357.5222F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                }
            });

            itemRules.Add("mdlChef", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.2146F, 0.01313F, 0.11352F),
                    localAngles = new Vector3(85.68816F, 39.85076F, 119.3247F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.2005F, -0.00555F, -0.13256F),
                    localAngles = new Vector3(274.4655F, 121.0445F, 321.8722F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                }
            });

            itemRules.Add("AcidLarva", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.07742F, -0.59815F, -0.3173F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.07742F, -0.59815F, -0.3173F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlBeetle", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.28697F, 0.19561F, 0.31185F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.28697F, 0.19561F, 0.31185F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                }
            });

            itemRules.Add("mdlBeetleGuard", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.72109F, -0.00455F, 0.06069F),
                    localAngles = new Vector3(88.11903F, 89.74161F, 83.16888F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.72109F, -0.00455F, 0.06069F),
                    localAngles = new Vector3(271.185F, 84.38835F, 91.47202F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlBeetleQueen", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.17763F, 2.34727F, 0.10603F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.17763F, 2.34727F, 0.10603F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlBell", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Chain",
                    localPos = new Vector3(-0.52882F, 0.63962F, 0.8703F),
                    localAngles = new Vector3(-0.00008F, 73.87173F, 180.0003F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Chain",
                    localPos = new Vector3(0.54123F, 0.63969F, -1.07891F),
                    localAngles = new Vector3(-0.00043F, 236.8977F, 180.0002F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlBison", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.39246F, 0.27381F, 0.05688F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.39246F, 0.25568F, 0.06122F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                }
            });

            itemRules.Add("mdlBrother", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.16196F, 0.12841F, 0.02863F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.13155F, 0.12841F, 0.02863F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlChild", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.19878F, 0.25568F, 0.05598F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.19878F, 0.25574F, 0.06239F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                }
            });

            itemRules.Add("mdlClayBoss", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Center",
                    localPos = new Vector3(1.31197F, 0.5264F, 0.18599F),
                    localAngles = new Vector3(0.05204F, 359.0919F, 9.68002F),
                    localScale = new Vector3(0.7F, 0.7F, 0.7F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Center",
                    localPos = new Vector3(-1.31197F, 0.5264F, 0.06122F),
                    localAngles = new Vector3(0.00401F, 181.209F, 8.74318F),
                    localScale = new Vector3(0.7F, 0.7F, 0.7F)

                }
            });

            itemRules.Add("mdlClayBruiser", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.22905F, 0.14376F, 0.05632F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.22905F, 0.14376F, 0.05632F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                }
            });

            itemRules.Add("mdlClayGrenadier", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Torso",
                    localPos = new Vector3(0.1263F, 0.31799F, 0.03421F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Torso",
                    localPos = new Vector3(-0.13155F, 0.31799F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                }
            });

            itemRules.Add("mdlLemurian", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.66405F, 0.87239F, 0.07219F),
                    localAngles = new Vector3(270.4261F, 18.54297F, 333.575F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.69243F, 0.89705F, 0.07219F),
                    localAngles = new Vector3(89.34389F, 10.48191F, 183.8669F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlLemurianBruiser", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.28069F, 0.00004F, -0.00008F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.28069F, 0.25568F, 0.06122F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlMagmaWorm", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.51143F, 0.25646F, -0.03008F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.51143F, 0.25646F, -0.03008F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlFlyingVermin", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Body",
                    localPos = new Vector3(0.53916F, 0.46258F, 0.06941F),
                    localAngles = new Vector3(0.00032F, 359.9505F, 0.7624F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Body",
                    localPos = new Vector3(-0.53916F, 0.46258F, 0.06941F),
                    localAngles = new Vector3(-0.00553F, 179.7973F, 356.8754F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlGolem", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.64639F, 0.75184F, -0.0371F),
                    localAngles = new Vector3(0F, 0F, 5.19797F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.64639F, 0.75184F, -0.0371F),
                    localAngles = new Vector3(-0.00001F, 180F, 2.90551F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                }
            });

            itemRules.Add("mdlGrandparent", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(1.71721F, -1.14759F, -1.46644F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.71738F, -1.14759F, -1.57788F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                }
            });

            itemRules.Add("mdlGravekeeper", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Mask",
                    localPos = new Vector3(1.04961F, -0.48584F, 1.21916F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Mask",
                    localPos = new Vector3(-1.04961F, -0.48584F, 1.21916F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlGreaterWisp", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MaskBase",
                    localPos = new Vector3(0.61522F, 0.25223F, 0.05598F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MaskBase",
                    localPos = new Vector3(-0.61522F, 0.25223F, 0.05598F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlGup", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MainBody2",
                    localPos = new Vector3(0.53182F, 0.48258F, 0.50286F),
                    localAngles = new Vector3(359.8611F, 1.18013F, 13.31096F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MainBody2",
                    localPos = new Vector3(-0.53182F, 0.48258F, 0.50286F),
                    localAngles = new Vector3(0.14711F, 178.8059F, 13.42579F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                }
            });

            itemRules.Add("mdlHalcyonite", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.36164F, 0.48226F, -0.01434F),
                    localAngles = new Vector3(0.01981F, 0.6479F, 356.4983F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.36164F, 0.48226F, -0.01434F),
                    localAngles = new Vector3(359.9735F, 179.251F, 355.9511F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlHermitCrab", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Base",
                    localPos = new Vector3(0.51935F, 0.2574F, 0.17202F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Base",
                    localPos = new Vector3(-0.51935F, 0.2574F, 0.17202F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlImp", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Neck",
                    localPos = new Vector3(0.13155F, -0.05262F, -0.06125F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.15F, 0.15F, 0.15F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Neck",
                    localPos = new Vector3(-0.13155F, -0.05262F, -0.06125F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.15F, 0.15F, 0.15F)

                }
            });

            itemRules.Add("mdlImpBoss", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Neck",
                    localPos = new Vector3(0.79384F, -0.35674F, -0.49547F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.55F, 0.55F, 0.55F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Neck",
                    localPos = new Vector3(-0.79384F, -0.35674F, -0.49547F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.55F, 0.55F, 0.55F)

                }
            });

            itemRules.Add("mdlJellyfish", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Hull2",
                    localPos = new Vector3(0.68472F, 0.11371F, 0.01025F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Hull2",
                    localPos = new Vector3(-0.68472F, 0.25568F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlMiniMushroom", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.13155F, 0.25568F, 0.88483F),
                    localAngles = new Vector3(90F, 261F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.15439F, 0.25568F, -0.88483F),
                    localAngles = new Vector3(270.4266F, 197.6121F, 260.1848F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlMinorConstruct", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "CapTop",
                    localPos = new Vector3(0.23261F, 0.16436F, 0.06964F),
                    localAngles = new Vector3(359.3379F, 359.8035F, 348.0065F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "CapTop",
                    localPos = new Vector3(-0.23261F, 0.16436F, 0.06964F),
                    localAngles = new Vector3(359.4379F, 180.2997F, 348.9383F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlNullifier", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Muzzle",
                    localPos = new Vector3(1.5305F, 0.25275F, 0.06527F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Muzzle",
                    localPos = new Vector3(-1.5305F, 0.25568F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlParent", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.18052F, 54.1965F, -23.47074F),
                    localAngles = new Vector3(299.9759F, 92.853F, 347.4128F),
                    localScale = new Vector3(50F, 50F, 50F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.18052F, 54.1965F, 23.47074F),
                    localAngles = new Vector3(58.12616F, 287.4763F, 4.45937F),
                    localScale = new Vector3(50F, 50F, 50F)

                }
            });

            itemRules.Add("mdlRoboBallBoss", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MainEyeMuzzle",
                    localPos = new Vector3(0.55159F, 0.64669F, -0.76966F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "MainEyeMuzzle",
                    localPos = new Vector3(-0.55159F, 0.64669F, -0.76966F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                }
            });

            itemRules.Add("mdlRoboBallMini", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Muzzle",
                    localPos = new Vector3(0.65644F, 0.30671F, -1.00922F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Muzzle",
                    localPos = new Vector3(-0.65644F, 0.30671F, -1.00922F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlScav", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Chest",
                    localPos = new Vector3(6.89633F, 1.24636F, 0.50014F),
                    localAngles = new Vector3(0.47671F, 354.6756F, 10.19843F),
                    localScale = new Vector3(3F, 3F, 3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Chest",
                    localPos = new Vector3(-6.89633F, 1.24636F, 0.50014F),
                    localAngles = new Vector3(359.3986F, 186.0365F, 11.36971F),
                    localScale = new Vector3(3F, 3F, 3F)

                }
            });

            itemRules.Add("mdlScorchling", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.69697F, -0.27725F, -0.48212F),
                    localAngles = new Vector3(0.94113F, 89.21177F, 356.6841F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.69697F, -0.27725F, 0.48212F),
                    localAngles = new Vector3(2.20908F, 271.5287F, 352.7828F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlTitan", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.99577F, 3.13986F, 0.12376F),
                    localAngles = new Vector3(0.03385F, 0.89221F, 352.2552F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.99577F, 3.13986F, 0.12376F),
                    localAngles = new Vector3(-0.00276F, 180.0745F, 351.5695F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                }
            });

            itemRules.Add("mdlVagrant", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Hull",
                    localPos = new Vector3(1.02435F, 0.5948F, 0.06473F),
                    localAngles = new Vector3(359.7614F, 0.06962F, 18.46623F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Hull",
                    localPos = new Vector3(-1.02435F, 0.5948F, 0.06473F),
                    localAngles = new Vector3(359.8113F, 179.873F, 16.89439F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlVermin", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.48555F, 0.25365F, 0.0569F),
                    localAngles = new Vector3(321.1211F, 178.9934F, 181.0524F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.48555F, 0.25365F, 0.0569F),
                    localAngles = new Vector3(38.87891F, 359.8678F, 180.0237F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            itemRules.Add("mdlVoidBarnacle", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.04813F, 0.45889F, 0.07169F),
                    localAngles = new Vector3(9.08382F, 12.9179F, 101.1444F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.04813F, -0.45889F, 0.07169F),
                    localAngles = new Vector3(354.8286F, 185.6496F, 282.8542F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)

                }
            });

            itemRules.Add("mdlVoidJailer", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.28138F, 0.33108F, -0.21593F),
                    localAngles = new Vector3(326.6686F, 328.2053F, 87.1455F),
                    localScale = new Vector3(0.35F, 0.35F, 0.35F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.28138F, -0.33108F, -0.21593F),
                    localAngles = new Vector3(33.35485F, 145.801F, 268.4816F),
                    localScale = new Vector3(0.35F, 0.35F, 0.35F)

                }
            });

            itemRules.Add("mdlVoidMegaCrab", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "BodyBase",
                    localPos = new Vector3(5.50533F, 5.63122F, 0.66957F),
                    localAngles = new Vector3(0.11118F, 0.50728F, 14.58453F),
                    localScale = new Vector3(3F, 3F, 3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "BodyBase",
                    localPos = new Vector3(-5.50533F, 5.63122F, 0.66957F),
                    localAngles = new Vector3(0.0908F, 180.5785F, 14.81367F),
                    localScale = new Vector3(3F, 3F, 3F)

                }
            });

            itemRules.Add("mdlVulture", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.95161F, 0.25492F, 0.05937F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.95161F, 0.25492F, 0.06122F),
                    localAngles = new Vector3(90F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                }
            });

            itemRules.Add("mdlWisp1Mouth", new ItemDisplayRule[]
            {
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(0.50598F, 0.07985F, 0.06869F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.50598F, 0.07985F, 0.06869F),
                    localAngles = new Vector3(270F, 180F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                }
            });

            return itemRules;
        }
        #endregion
    }
}
