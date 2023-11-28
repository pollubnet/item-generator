using System;
using ExampleItemGenerator.Models;

namespace ExampleItemGenerator.Services.Generators
{
    public class ItemGenerator : IItemGenerator
    {
        private readonly Random _rnd;
        private readonly List<RarityModifier> _modifiers;
        private readonly INameGenerator _nameGenerator;

        public ItemGenerator()
        {
            _nameGenerator = new ChristmasNameGenerator();

            _rnd = new Random();
            _modifiers = new List<RarityModifier>()
            {
                new(
                    0.01f,
                    ItemRarity.Legendary,
                    new RarityProperties {
                        AgilityRange = new(-100, 100),
                        StrengthRange = new(-20, 60),
                        IntelligenceRange = new(-7, 10),
                        DefenseRange = new(-15, 30),
                        HealthRange = new(-30, 40)
                    }
                ),
                new(
                    0.2f,
                    ItemRarity.Epic,
                    new RarityProperties {
                        AgilityRange = new(-9, 70),
                        StrengthRange = new(-10, 30),
                        IntelligenceRange = new(-8, 10),
                        DefenseRange = new(-7, 30),
                        HealthRange = new(-10, 20)
                    }
                ),
                new(
                    0.4f,
                    ItemRarity.Insane,
                    new RarityProperties {
                        AgilityRange = new(10, 100),
                        StrengthRange = new(5, 60),
                        IntelligenceRange = new(1, 10),
                        DefenseRange = new(7, 30),
                        HealthRange = new(10, 20)
                    }
                ),
                new(
                    0.5f,
                    ItemRarity.Rare,
                    new RarityProperties {
                        AgilityRange = new(2, 10),
                        StrengthRange = new(5, 60),
                        IntelligenceRange = new(1, 10),
                        DefenseRange = new(7, 30),
                        HealthRange = new(10, 20)
                    }
                ),
                new(
                    0.6f,
                    ItemRarity.Uncommon,
                    new RarityProperties {
                        AgilityRange = new(-2, 10),
                        StrengthRange = new(-5, 10),
                        IntelligenceRange = new(-10, 10),
                        DefenseRange = new(7, 20),
                        HealthRange = new(10, 20)
                    }
                ),
                new(
                    1f,
                    ItemRarity.Common,
                    new RarityProperties {
                        AgilityRange = new(-2, 2),
                        StrengthRange = new(-5, 5),
                        IntelligenceRange = new(-5, 5),
                        DefenseRange = new(-3, 3),
                        HealthRange = new(-8, 8)
                    }
                )
            };
        }

        public Item Generate()
        {
            var value = _rnd.NextSingle();
            var modifier = _modifiers.First(m => m.ValueBelow > value);

            var item = new Item
            {
                Name = _nameGenerator.GenerateName(),
                Rarity = modifier.Rarity,
                Agility = modifier.AgilityRange.GenerateStat(_rnd),
                Defense = modifier.DefenseRange.GenerateStat(_rnd),
                Intelligence = modifier.IntelligenceRange.GenerateStat(_rnd),
                Strength = modifier.StrengthRange.GenerateStat(_rnd),
                Health = modifier.HealthRange.GenerateStat(_rnd)
            };

            return item;
        }
    }
}
