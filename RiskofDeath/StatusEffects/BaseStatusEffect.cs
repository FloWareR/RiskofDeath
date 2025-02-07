using R2API;
using RoR2;
using UnityEngine;

namespace RiskofDeath.StatusEffects.Debuffs
{
    public abstract class BaseStatusEffect
    {
        private BuffDef _buffData;
        public BuffDef BuffData => _buffData;
        public DotController.DotDef DotData { get; set; }
        public DotController.DotIndex DotIndex { set; get; }

        public abstract string BuffName { get; }
        public abstract bool CanStack { get; }
        public abstract bool IsDebuff { get; }
        public abstract bool IsHidden { get; }
        public abstract EliteDef EliteDef { get; }
        public abstract bool IsCooldown { get; }
        public abstract bool IsDOT { get; }
        public abstract Sprite Sprite { get; }
        public abstract Color BuffColor { get; }
        public abstract bool DotResetTimerOnAdd { get; }
        public abstract float DotInterval { get; }
        public abstract DamageColorIndex DotDamageColorIndex { get; }
        public abstract float DotDamageCoefficient { get; }

        public void Init()
        {
            _buffData = ScriptableObject.CreateInstance<BuffDef>();
            SetupBuff();
            if (IsDOT) SetupDot();
            Hook();
            UnHook();
        }

        private void SetupBuff()
        {
            _buffData.name = BuffName;
            _buffData.canStack = CanStack;
            _buffData.isDebuff = IsDebuff;
            _buffData.eliteDef = EliteDef;
            _buffData.isCooldown = IsCooldown;
            _buffData.isHidden = IsHidden;
            _buffData.buffColor = BuffColor;
            _buffData.isDOT = IsDOT;
            _buffData.iconSprite = Sprite;

            ContentAddition.AddBuffDef(_buffData);
        }

        private void SetupDot()
        {
            DotData = new()
            {
                associatedBuff = BuffData,
                resetTimerOnAdd = DotResetTimerOnAdd,
                interval = DotInterval,
                damageColorIndex = DotDamageColorIndex,
                damageCoefficient = DotDamageCoefficient
            };
            DotIndex = DotAPI.RegisterDotDef(DotData);
        }

        public abstract void Hook();
        public abstract void UnHook();
    }
}
