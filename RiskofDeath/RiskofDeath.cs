using BepInEx;
using R2API;
using R2API.Utils;
using RiskofDeath.Core;
using RoR2.ExpansionManagement;
using System.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace RiskofDeath
{
    [BepInDependency(ItemAPI.PluginGUID)]
    [BepInDependency(LanguageAPI.PluginGUID)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]

    public class RiskofDeath : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "Floware&Alphainvicta";
        public const string PluginName = "RiskofDeath";
        public const string PluginVersion = "0.1.0";

        public static AssetBundle Assets;
        public static ExpansionDef riskofdeathExpansion;
        private static ExpansionDef survivorsofthevoidDlc = Addressables.LoadAssetAsync<ExpansionDef>("RoR2/DLC1/Common/DLC1.asset").WaitForCompletion();

        public static ItemLoader ItemLoader;
        public static BuffLoader BuffLoader;
        public static EliteLoader EliteLoader;

        public void Awake()
        {
            Log.Init(Logger);
            LoadResources();
            LoadExpansion();
            LoadItems();
            LoadElites();
            LoadBuffs();
        }

        private void LoadResources()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RiskofDeath.import"))
            {
                Assets = AssetBundle.LoadFromStream(stream);
            }
        }

        private void LoadExpansion()
        {
            riskofdeathExpansion = Assets.LoadAsset<ExpansionDef>("rodexpansiondef");

            riskofdeathExpansion.disabledIconSprite = survivorsofthevoidDlc.disabledIconSprite;
            ContentAddition.AddExpansionDef(riskofdeathExpansion);
        }
        private void LoadItems()
        {
            ItemLoader = new();
            ItemLoader.Init();
        }

        private void LoadElites()
        {
            EliteLoader = new();
            EliteLoader.Init();
        }

        private void LoadBuffs()
        {
            BuffLoader = new();
            BuffLoader.Init();
        }

        private void OnDestroy()
        {

        }
    }
}