using System;
using System.Collections.Generic;
using System.Text;
using RiskofDeath.StatusEffects.Debuffs;
using RoR2;
using UnityEngine;

namespace RiskofDeath.StatusEffects.Buffs
{
    public class IdolCooldown : BaseStatusEffect
    {
        public override string BuffName => "IdolCooldown";
        public override bool CanStack => true;
        public override bool IsDebuff => false;
        public override bool IsHidden => false;
        public override EliteDef EliteDef => null;
        public override bool IsCooldown => true;
        public override bool IsDOT => false;
        public override Sprite Sprite => RiskofDeath.Assets.LoadAsset<Sprite>("idolBuffCooldown");
        public override Color BuffColor => new Color(255, 255, 255);
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
