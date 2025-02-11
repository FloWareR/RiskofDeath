using RiskofDeath.Items;
using RiskofDeath.Items.Tier1;
using RiskofDeath.Items.Tier2;
using RiskofDeath.Items.Void;
using System.Collections.Generic;
using System.Data;

namespace RiskofDeath.Core
{
    public class ItemLoader
    {
        public static List<ItemBase> rodItems;

        public BoxOMatches BoxOMatches;
        public DisperseObsidian DisperseObsidian;
        public OblivionRod OblivionRod;
        public RustyCleaver RustyCleaver;
        public PestilentPool PestilentPool;

        public void Init()
        {
            rodItems = new();

            BoxOMatches = new BoxOMatches();
            rodItems.Add(BoxOMatches);

            DisperseObsidian = new DisperseObsidian();
            rodItems.Add(DisperseObsidian);

            OblivionRod = new OblivionRod();
            rodItems.Add(OblivionRod);

            RustyCleaver = new RustyCleaver();
            rodItems.Add(RustyCleaver);

            PestilentPool = new();
            rodItems.Add(PestilentPool);

            foreach (var item in rodItems)
            {
                item.Init();
            }
        }
    }
}
