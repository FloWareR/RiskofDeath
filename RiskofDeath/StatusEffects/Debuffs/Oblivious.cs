using R2API;
using RoR2;
using UnityEngine;


namespace RiskofDeath.StatusEffects.Debuffs
{
    public class Oblivious : BaseStatusEffect
    {
        public override string BuffName => "Oblivious";
        public override bool CanStack => false;
        public override bool IsDebuff => true;
        public override bool IsHidden => false;
        public override EliteDef EliteDef => null;
        public override bool IsCooldown => false;
        public override bool IsDOT => false;
        public override Sprite Sprite => RiskofDeath.Assets.LoadAsset<Sprite>("rodicon");
        public override Color BuffColor => new Color(237, 127, 205);
        public override bool DotResetTimerOnAdd => false;
        public override float DotInterval => 1.0f;
        public override DamageColorIndex DotDamageColorIndex => DamageColorIndex.Void;
        public override float DotDamageCoefficient => 0.75f;

        public override void Hook()
        {

        }

        public override void UnHook()
        {

        }
    }
}
