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
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.10403F, -0.06406F, -0.11774F),
                localAngles = new Vector3(0F, 320F, 180F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.10157F, -0.04906F, -0.0992F),
                localAngles = new Vector3(21.17312F, 317.0703F, 181.7356F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.12821F, -0.00556F, -0.15787F),
                localAngles = new Vector3(15.0063F, 323.3486F, 180F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Hip",
                localPos = new Vector3(0.86887F, 0.31993F, 0.63673F),
                localAngles = new Vector3(282.8052F, 147.9402F, 179.9999F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.15689F, 0.03205F, -0.14952F),
                localAngles = new Vector3(0.00013F, 342.9873F, 178.9941F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.1234F, -0.03102F, -0.132F),
                localAngles = new Vector3(17.71575F, 316.2902F, 163.7028F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.13914F, 0.02648F, -0.16529F),
                localAngles = new Vector3(348.1204F, 316.7823F, 185.5043F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PlatformBase",
                localPos = new Vector3(0F, 0.04381F, 0.67484F),
                localAngles = new Vector3(0.00007F, 182.3645F, -0.00001F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F)
            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.12766F, 0.01956F, -0.12229F),
                localAngles = new Vector3(358.7666F, 323.4932F, 180.094F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "SpineChest1",
                localPos = new Vector3(1.13145F, 0.60751F, -0.64428F),
                localAngles = new Vector3(81.25551F, 339.0484F, 154.3532F),
                localScale = new Vector3(1.5F, 1.5F, 1.5F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.07295F, -0.10108F, -0.2124F),
                localAngles = new Vector3(17.46597F, 7.65265F, 189.5712F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.11913F, 0.09532F, -0.08649F),
                localAngles = new Vector3(1.4034F, 336.4563F, 176.1281F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.11465F, 0.08315F, 0.10491F),
                localAngles = new Vector3(4.57092F, 234.9868F, 178.7012F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.13277F, 0.05855F, 0.06943F),
                localAngles = new Vector3(350.8522F, 220.6062F, 0.75774F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.14764F, 0.14829F, 0.0498F),
                localAngles = new Vector3(55.21856F, 154.4252F, 7.76815F),
                localScale = new Vector3(0.3F, 0.3F, 0.3F),
            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.0866F, 0.02533F, -0.14143F),
                localAngles = new Vector3(0F, 340F, 90F),
                localScale = new Vector3(0.2F, 0.2F, 0.2F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Chest",
                localPos = new Vector3(0.00002F, 5.92999F, 0.97976F),
                localAngles = new Vector3(80.3193F, 180.0001F, 180F),
                localScale = new Vector3(5F, 5F, 5F)

            });


            return itemRules;
        }

        public static ItemDisplayRuleDict LockpickingToolKit(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.07399F, -0.05219F, 0.15919F),
                localAngles = new Vector3(6.67591F, 260.7462F, 215.5085F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.08377F, -0.08228F, 0.1387F),
                localAngles = new Vector3(3.19505F, 269.2154F, 171.1969F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.13197F, -0.05026F, 0.1392F),
                localAngles = new Vector3(353.9337F, 243.7929F, 193.6587F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Hip",
                localPos = new Vector3(-1.26671F, 0.83212F, -0.6388F),
                localAngles = new Vector3(2.13743F, 185.3209F, 204.6726F),
                localScale = new Vector3(0.5F, 0.5F, 0.5F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.16067F, 0.11567F, 0.19629F),
                localAngles = new Vector3(0.09582F, 241.2295F, 213.6097F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.06585F, -0.15338F, 0.11309F),
                localAngles = new Vector3(2.96221F, 258.2677F, 159.0531F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.15942F, 0.06207F, 0.13115F),
                localAngles = new Vector3(357.1039F, 234.5331F, 186.4007F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PlatformBase",
                localPos = new Vector3(-0.62287F, 0.13993F, -0.34941F),
                localAngles = new Vector3(0.00004F, 337.3127F, 0F),
                localScale = new Vector3(0.15F, 0.15F, 0.15F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.18527F, 0.12484F, 0.22282F),
                localAngles = new Vector3(345.7701F, 231.9325F, 178.3216F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "SpineChest1",
                localPos = new Vector3(-0.89214F, 0.27705F, -0.86228F),
                localAngles = new Vector3(328.3521F, 69.95983F, 274.624F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.23504F, -0.07089F, -0.10489F),
                localAngles = new Vector3(356.7931F, 138.4856F, 209.6767F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.12857F, 0.14182F, -0.13167F),
                localAngles = new Vector3(341.5357F, 103.6193F, 212.3664F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.16242F, 0.0373F, -0.10076F),
                localAngles = new Vector3(355.3246F, 23.20775F, 188.393F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.13466F, 0.02007F, 0.13658F),
                localAngles = new Vector3(8.78433F, 69.01947F, 20.90045F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.16965F, 0.22908F, 0.01755F),
                localAngles = new Vector3(10.85545F, 55.77841F, 306.6025F),
                localScale = new Vector3(0.15F, 0.15F, 0.15F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(0.0818F, 0.14766F, 0.15683F),
                localAngles = new Vector3(314.2477F, 169.4796F, 292.4969F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Backpack",
                localPos = new Vector3(-8.88703F, 5.84192F, -0.82595F),
                localAngles = new Vector3(355.3763F, 345.6576F, 23.90281F),
                localScale = new Vector3(3F, 3F, 3F)

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

        public static ItemDisplayRuleDict GetBetterTogether(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.00504F, -0.00113F, 0.0393F),
                localAngles = new Vector3(357.1039F, 90.00005F, 113.2839F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.00762F, 0.01948F, -0.05606F),
                localAngles = new Vector3(37.08055F, 327.0893F, 148.7007F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.10741F, 0.00757F, -0.01697F),
                localAngles = new Vector3(6.20546F, 356.777F, 98.97968F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(0.00042F, -0.59128F, 0.17499F),
                localAngles = new Vector3(355.4553F, 285.7084F, 195.8592F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.05691F, -0.15557F, -0.09398F),
                localAngles = new Vector3(29.17347F, 89.62615F, 180.7519F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.017F, -0.08517F, -0.01787F),
                localAngles = new Vector3(34.96421F, 65.9851F, 176.217F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.02641F, -0.13139F, -0.0336F),
                localAngles = new Vector3(18.71482F, 79.24775F, 185.5329F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PlatformBase",
                localPos = new Vector3(-0.51196F, 0.74576F, 0.25076F),
                localAngles = new Vector3(1.53066F, 287.2355F, 2.99494F),
                localScale = new Vector3(0.4F, 0.4F, 0.4F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.25233F, 0.05145F, -0.12722F),
                localAngles = new Vector3(4.61651F, 96.99581F, 264.6218F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(1.7981F, 0.13032F, 0.27792F),
                localAngles = new Vector3(81.44908F, 231.9664F, 156.1082F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.05997F, -0.25481F, 0.0363F),
                localAngles = new Vector3(18.15229F, 76.4865F, 169.1699F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(0.00415F, -0.02866F, 0.063F),
                localAngles = new Vector3(13.90251F, 71.95468F, 127.7304F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmL",
                localPos = new Vector3(0.09192F, 0.03761F, 0.0409F),
                localAngles = new Vector3(313.8992F, 71.14402F, 168.998F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(-0.06315F, -0.11031F, 0.05198F),
                localAngles = new Vector3(14.77455F, 185.2004F, 211.432F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(0.14707F, -0.32368F, 0.08208F),
                localAngles = new Vector3(29.85394F, 170.4902F, 167.6455F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(0.25306F, -0.03056F, 0.1209F),
                localAngles = new Vector3(1.46687F, 107.2422F, 110.9657F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "UpperArmR",
                localPos = new Vector3(2.13264F, -0.86206F, 0.02071F),
                localAngles = new Vector3(11.55699F, 180.6615F, 107.6257F),
                localScale = new Vector3(2.5F, 2.5F, 2.5F)

            });

            return itemRules;
        }
        #endregion

        #region Tier3
        public static ItemDisplayRuleDict GetSniperScope(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "GunR",
                localPos = new Vector3(-0.16513F, 0.08088F, 0.04533F),
                localAngles = new Vector3(79.41177F, 119.1713F, 78.19859F),
                localScale = new Vector3(0.05F, 0.05F, 0.05F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "BowBase",
                localPos = new Vector3(0F, 0F, 0F),
                localAngles = new Vector3(13.26896F, 24.39033F, 232.6967F),
                localScale = new Vector3(0.05F, 0.05F, 0.05F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MainWeapon",
                localPos = new Vector3(-0.15207F, 0.55329F, 0.05772F),
                localAngles = new Vector3(359.7786F, 34.84789F, 47.49165F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-2.04255F, 2.01534F, 0.33166F),
                localAngles = new Vector3(331.5265F, 356.3476F, 53.69168F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "CannonHeadR",
                localPos = new Vector3(0.00001F, 0.42969F, 0.24632F),
                localAngles = new Vector3(359.7713F, 90F, 51.01556F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandR",
                localPos = new Vector3(-0.0554F, -0.05365F, -0.10326F),
                localAngles = new Vector3(10.07773F, 98.89804F, 240.0187F),
                localScale = new Vector3(0.06899F, 0.06899F, 0.06899F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(-0.13251F, 0.15366F, 0.1156F),
                localAngles = new Vector3(277.7001F, 88.65024F, 326.635F),
                localScale = new Vector3(0.05647F, 0.05647F, 0.05647F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "WeaponPlatformEnd",
                localPos = new Vector3(-0.00088F, -0.40016F, 0.12186F),
                localAngles = new Vector3(0.22344F, 97.36004F, 230.6543F),
                localScale = new Vector3(0.2009F, 0.2009F, 0.2009F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MechBase",
                localPos = new Vector3(-0.1954F, 0.51878F, 0.16892F),
                localAngles = new Vector3(357.0736F, 89.88731F, 318.3874F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandR",
                localPos = new Vector3(0.20771F, -1.23475F, 0.11182F),
                localAngles = new Vector3(359.0685F, 206.8047F, 102.5846F),
                localScale = new Vector3(0.57451F, 0.57451F, 0.57451F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MuzzleGun",
                localPos = new Vector3(0.00447F, 0.06365F, -0.1104F),
                localAngles = new Vector3(4.0338F, 90F, 319.2416F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "MuzzlePistol",
                localPos = new Vector3(-0.00014F, 0F, -0.21891F),
                localAngles = new Vector3(86.33975F, 89.99968F, 330.1947F),
                localScale = new Vector3(0.08397F, 0.08397F, 0.08397F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Hand",
                localPos = new Vector3(-0.00001F, 0.00003F, -0.0794F),
                localAngles = new Vector3(0F, 270F, 49.49315F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "HandR",
                localPos = new Vector3(-0.07448F, -0.1223F, 0.00454F),
                localAngles = new Vector3(1.07539F, 349.0049F, 46.70107F),
                localScale = new Vector3(0.06277F, 0.06277F, 0.06277F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Head",
                localPos = new Vector3(0.1822F, 0.13927F, -0.04667F),
                localAngles = new Vector3(90F, 131.6205F, 0F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "PizzaCutter",
                localPos = new Vector3(-0.01874F, 0.33175F, -0.04426F),
                localAngles = new Vector3(2.06722F, 270.8728F, 52.2393F),
                localScale = new Vector3(0.07298F, 0.07298F, 0.07298F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Weapon",
                localPos = new Vector3(-3.77129F, 3.14459F, 2.18127F),
                localAngles = new Vector3(358.1877F, 206.944F, 227.0175F),
                localScale = new Vector3(3F, 3F, 3F)

            });

            return itemRules;
        }

        public static ItemDisplayRuleDict GetXiuhtecuhtliIdol(GameObject prefab)
        {
            var itemDisplay = prefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(prefab);
            ItemDisplayRuleDict itemRules = new ItemDisplayRuleDict();

            itemRules.Add("mdlCommandoDualies", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.12094F, 0.01868F, 0.05822F),
                localAngles = new Vector3(354.1613F, 294.962F, 182.9239F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlHuntress", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.125F, 0.02373F, 0.06333F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlBandit2", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.10728F, 0.20682F, 0.02258F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlToolbot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(0.00061F, 0.70899F, 1.45844F),
                localAngles = new Vector3(0F, 0F, 180F),
                localScale = new Vector3(1F, 1F, 1F)

            });

            itemRules.Add("mdlEngi", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.20399F, 0.06735F, 0.01911F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlMage", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.07567F, 0.04959F, 0.11729F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.06899F, 0.06899F, 0.06899F)

            });

            itemRules.Add("mdlMerc", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.10555F, 0.02573F, 0.05697F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlTreebot", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighFrontR",
                localPos = new Vector3(0.38728F, -0.04823F, -0.42829F),
                localAngles = new Vector3(41.79556F, 310.974F, 181.1771F),
                localScale = new Vector3(0.2009F, 0.2009F, 0.2009F)

            });

            itemRules.Add("mdlLoader", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.07155F, 0.09083F, 0.14979F),
                localAngles = new Vector3(346.774F, 305.5094F, 187.3312F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlCroco", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-1.45597F, 1.08628F, -0.02163F),
                localAngles = new Vector3(350.1276F, 279.7472F, 176.1922F),
                localScale = new Vector3(0.57451F, 0.57451F, 0.57451F)

            });

            itemRules.Add("mdlCaptain", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.13331F, 0.15325F, -0.00001F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlRailGunner", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.12034F, 0.00001F, 0F),
                localAngles = new Vector3(0F, 270F, 180F),
                localScale = new Vector3(0.08397F, 0.08397F, 0.08397F)

            });

            itemRules.Add("mdlVoidSurvivor", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-0.03355F, 0.13888F, -0.12306F),
                localAngles = new Vector3(0F, 180F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlSeeker", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(0.03798F, 0.08039F, 0.11973F),
                localAngles = new Vector3(0F, 0F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlFalseSon", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(0.12051F, 0.3814F, 0.19015F),
                localAngles = new Vector3(0F, 30.13542F, 180F),
                localScale = new Vector3(0.1F, 0.1F, 0.1F)

            });

            itemRules.Add("mdlChef", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "Pelvis",
                localPos = new Vector3(-0.06085F, 0.04867F, -0.23117F),
                localAngles = new Vector3(-0.00001F, 180F, 270F),
                localScale = new Vector3(0.07298F, 0.07298F, 0.07298F)

            });

            itemRules.Add("mdlScav", new ItemDisplayRule
            {
                followerPrefab = prefab,
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = "ThighR",
                localPos = new Vector3(-2.37817F, 1.6272F, 0.86134F),
                localAngles = new Vector3(345.4606F, 270F, 180F),
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
                    localPos = new Vector3(0.09567F, 0.20247F, -0.08563F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.11246F, 0.20219F, -0.08548F),
                    localAngles = new Vector3(0.09448F, 182.007F, 0F),
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
                    localPos = new Vector3(1.14075F, 1.54549F, 0.52143F),
                    localAngles = new Vector3(50.00001F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.14075F, 1.54549F, 0.52143F),
                    localAngles = new Vector3(308.9973F, 179.7816F, 358.6743F),
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
                    localPos = new Vector3(-0.58114F, -0.12739F, 0.11436F),
                    localAngles = new Vector3(84.82082F, 307.0061F, 26.68633F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.58114F, -0.12739F, -0.11436F),
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
                    localAngles = new Vector3(61.02067F, 171.2456F, 165.1444F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.72109F, -0.00455F, 0.06069F),
                    localAngles = new Vector3(300.0179F, 357.5317F, 178.7104F),
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
                    childName = "ShieldL",
                    localPos = new Vector3(0.1449F, -0.15316F, -0.03757F),
                    localAngles = new Vector3(0F, 180F, 180F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "ShieldR",
                    localPos = new Vector3(-0.09923F, -0.13911F, 0.03757F),
                    localAngles = new Vector3(0F, 0F, 180F),
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
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.7F, 0.7F, 0.7F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Center",
                    localPos = new Vector3(-1.31197F, 0.5264F, 0.06122F),
                    localAngles = new Vector3(0F, 180F, 0F),
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
                    localAngles = new Vector3(3.85251F, 179.888F, 359.3211F),
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
                    localAngles = new Vector3(87.74883F, 0.00006F, 0.00006F),
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
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-0.64639F, 0.75184F, -0.0371F),
                    localAngles = new Vector3(0F, 180F, 0F),
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
                    childName = "Head",
                    localPos = new Vector3(1.07711F, 1.311F, 0.47994F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Head",
                    localPos = new Vector3(-1.07711F, 1.311F, 0.47994F),
                    localAngles = new Vector3(0F, 180F, 0F),
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
                    localPos = new Vector3(-0.04507F, 0.1195F, 0.64868F),
                    localAngles = new Vector3(0F, 270F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Hull2",
                    localPos = new Vector3(-0.04507F, 0.1195F, -0.64868F),
                    localAngles = new Vector3(0F, 90F, 0F),
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
                    localAngles = new Vector3(35F, 0F, 0F),
                    localScale = new Vector3(3F, 3F, 3F)

                },
                new ItemDisplayRule
                {
                    followerPrefab = prefab,
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    childName = "Chest",
                    localPos = new Vector3(-6.89633F, 1.24636F, 0.50014F),
                    localAngles = new Vector3(325F, 180F, 0F),
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
