using System;
using System.Collections.Generic;
using System.Text;
using RiskofDeath.StatusEffects.Debuffs;
using RoR2;
using UnityEngine;

namespace RiskofDeath.StatusEffects.Buffs
{
    public class Idol : BaseStatusEffect
    {
        public override string BuffName => "Idol";
        public override bool CanStack => false;
        public override bool IsDebuff => false;
        public override bool IsHidden => false;
        public override EliteDef EliteDef => null;
        public override bool IsCooldown => false;
        public override bool IsDOT => false;
        public override Sprite Sprite => RiskofDeath.Assets.LoadAsset<Sprite>("idolBuff");
        public override Color BuffColor => new Color(0, 124, 96);
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
