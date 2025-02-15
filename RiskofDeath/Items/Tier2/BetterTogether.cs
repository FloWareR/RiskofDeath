using R2API;
using RoR2;
using UnityEngine;

namespace RiskofDeath.Items.Tier2
{
    public class BetterTogether : ItemBase
    {
        public override ItemDef ItemData => RiskofDeath.Assets.LoadAsset<ItemDef>("bettertogether");
        public override string ItemIdentifier => "BetterTogether";
        public override string ItemName => "Better Together";
        public override string ItemPick => "Increase health regeneration for each ally nearby.";
        public override string ItemDesc => "Gain 10% (+10% per stack) health regeneration for up to 4 (+2 per stack) allies within a 10-meter radius.";
        public override string ItemLore => "Together, we are stronger.";
        public override float logbookCameraMinDistance => 1f;
        public override float logbookCameraMaxDistance => 2f;
        public override Vector3 logbookFocusPointOffset => new(0f, .1f, 0f);
        public override Vector3 logbookCameraPositionOffset => new(-1f, .1f, 0f);

        public override ItemDisplayRuleDict CreateItemDisplayRules(GameObject gameObject)
        {
            return DisplayRules.GetBetterTogether(gameObject);
        }

        public override void Hook()
        {
            On.RoR2.CharacterMaster.OnInventoryChanged += OnInventoryChanged;
        }

        public override void Unhook()
        {
            On.RoR2.CharacterMaster.OnInventoryChanged -= OnInventoryChanged;
        }

        private void OnInventoryChanged(On.RoR2.CharacterMaster.orig_OnInventoryChanged orig, CharacterMaster self)
        {
            orig(self);

            CharacterBody body = self.GetBody();
            if (body)
            {
                if (self.inventory && self.inventory.GetItemCount(ItemData) > 0)
                {
                    if (!body.gameObject.GetComponent<BetterTogetherBehavior>())
                    {
                        body.gameObject.AddComponent<BetterTogetherBehavior>();
                    }
                }
                else
                {
                    var behavior = body.gameObject.GetComponent<BetterTogetherBehavior>();
                    if (behavior)
                    {
                        Object.Destroy(behavior);
                    }
                }
            }
        }
    }

    public class BetterTogetherBehavior : MonoBehaviour
    {
        private CharacterBody body;
        private float baseRegen;

        private void Start()
        {
            body = GetComponent<CharacterBody>();
            if (body)
            {
                baseRegen = body.baseRegen;
            }
        }

        private void FixedUpdate()
        {
            if (body)
            {
                int itemCount = body.inventory.GetItemCount(RiskofDeath.ItemLoader.BetterTogether.ItemData);

                int maxAllies = 2 + (2 * itemCount);

                float regenPerAlly = 0.10f * (itemCount);

                float radius = 10f;

                int allyCount = 0;
                foreach (var allyBody in CharacterBody.readOnlyInstancesList)
                {
                    if (allyBody.teamComponent.teamIndex == body.teamComponent.teamIndex && allyBody != body)
                    {
                        float distance = Vector3.Distance(body.corePosition, allyBody.corePosition);
                        if (distance <= radius)
                        {
                            allyCount++;
                            if (allyCount >= maxAllies)
                            {
                                break;
                            }
                        }
                    }
                }

                float healthRegenBonus = regenPerAlly * Mathf.Min(allyCount, maxAllies);

                body.regen = baseRegen * (1 + healthRegenBonus);
            }
        }

        private void OnDestroy()
        {
            if (body)
            {
                body.regen = baseRegen;
            }
        }
    }
}