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
                    childName = "Pelvis",
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    localPos = new Vector3(0.1F, 0.5F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F),
                },
                new ItemDisplayRule
                {
                    childName = "Pelvis",
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    localPos = new Vector3(-0.1F, 0.5F, 0F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F),
                }
            });

            return itemRules;
        }
        #endregion
    }
}
