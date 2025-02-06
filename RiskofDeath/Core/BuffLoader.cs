using RiskofDeath.StatusEffects.Debuffs;


namespace RiskofDeath.Core
{
    public class BuffLoader
    {
        public Oblivious Oblivious;

        public void Init()
        {
            Oblivious= new Oblivious();
            Oblivious.Init();
        }
    }
}
