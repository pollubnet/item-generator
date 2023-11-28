using System;
using ExampleItemGenerator.Services;

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
            RarityProperties props
        )
        {
            ValueBelow = valueBelow;
            Rarity = rarity;
            AgilityRange = props.AgilityRange;
            StrengthRange = props.StrengthRange;
            IntelligenceRange = props.IntelligenceRange;
            DefenseRange = props.DefenseRange;
            HealthRange = props.HealthRange;
        }
    }
}
