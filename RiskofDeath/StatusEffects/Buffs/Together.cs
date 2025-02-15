using System;
using System.Collections.Generic;
using System.Text;
using RiskofDeath.StatusEffects.Debuffs;
using RoR2;
using UnityEngine;

namespace RiskofDeath.StatusEffects.Buffs
{
    public class Together : BaseStatusEffect
    {
        public override string BuffName => "Together";
        public override bool CanStack => true;
        public override bool IsDebuff => false;
        public override bool IsHidden => false;
        public override EliteDef EliteDef => null;
        public override bool IsCooldown => false;
        public override bool IsDOT => false;
        public override Sprite Sprite => RiskofDeath.Assets.LoadAsset<Sprite>("togetherBuff");
        public override Color BuffColor => new (255, 255, 255);
        public override bool DotResetTimerOnAdd => false;
        public override float DotInterval => 1.0f;
        public override DamageColorIndex DotDamageColorIndex => DamageColorIndex.Count;
        public override float DotDamageCoefficient => 0.75f;

        public override void Hook()
        {

        }

        public override void UnHook()
        {

        }
    }
}
