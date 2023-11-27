using System;

namespace ExampleItemGenerator.Models
{
    public class RarityModifier
    {
        public float ValueBelow { get; init; } = 0f;
        public ItemRarity Rarity { get; init; } = ItemRarity.Common;

        public StatRange AgilityRange { get; init; }
        public StatRange StrengthRange { get; init; }
        public StatRange IntelligenceRange { get; init; }
        public StatRange DefenseRange { get; init; }
        public StatRange HealthRange { get; init; }

        public RarityModifier(
            float valueBelow,
            ItemRarity rarity,
            StatRange agilityRange,
            StatRange strengthRange,
            StatRange intelligenceRange,
            StatRange defenseRange,
            StatRange healthRange
        )
        {
            ValueBelow = valueBelow;
            Rarity = rarity;
            AgilityRange = agilityRange;
            StrengthRange = strengthRange;
            IntelligenceRange = intelligenceRange;
            DefenseRange = defenseRange;
            HealthRange = healthRange;
        }
    }
}
