using RiskofDeath.StatusEffects.Buffs;
using RiskofDeath.StatusEffects.Debuffs;


namespace RiskofDeath.Core
{
    public class BuffLoader
    {
        public Oblivious Oblivious;
        public Idol Idol;
        public IdolCooldown IdolCooldown;

        public void Init()
        {
            Oblivious= new Oblivious();
            Oblivious.Init();

            Idol = new Idol();
            Idol.Init();

            IdolCooldown = new IdolCooldown();
            IdolCooldown.Init();
        }
    }
}
