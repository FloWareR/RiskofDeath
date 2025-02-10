using RiskofDeath.Elites;
using RiskofDeath.Elites.Tier1;


namespace RiskofDeath.Core
{
    public class EliteLoader
    {
        public static Cursed Cursed;

        public void Init()
        {
            Cursed = new();
            Cursed.Init();
        }
    }
}
