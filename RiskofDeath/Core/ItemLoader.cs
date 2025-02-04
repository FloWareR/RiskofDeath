using RiskofDeath.Items.Tier1;

namespace RiskofDeath.Core
{
    public class ItemLoader
    {
        public BoxOMatches BoxOMatches;
        public void Init()
        {
            BoxOMatches = new BoxOMatches();
            BoxOMatches.Init(); 
        }
    }
}
