using RiskofDeath.Items.Tier1;
using RiskofDeath.Items.Void;

namespace RiskofDeath.Core
{
    public class ItemLoader
    {
        public BoxOMatches BoxOMatches;
        public DisperseObsidian DisperseObsidian;
        public OblivionRod OblivionRod;

        public void Init()
        {
            BoxOMatches = new BoxOMatches();
            BoxOMatches.Init();

            DisperseObsidian = new DisperseObsidian();
            DisperseObsidian.Init();

            OblivionRod = new OblivionRod();
            OblivionRod.Init();
        }
    }
}
