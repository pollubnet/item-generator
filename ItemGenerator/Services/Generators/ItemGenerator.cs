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
			_nameGenerator = new TemporaryNameGenerator();

			_rnd = new Random();
			_modifiers = new List<RarityModifier>()
			{
				new(0.01f, ItemRarity.Legendary, new(-100, 100), new(-20, 60), new(-7, 10), new(-15, 30), new(-30, 40)),
                new(0.2f, ItemRarity.Epic, new(-9, 70), new(-10, 30), new(-8, 10), new(-7, 30), new(-10, 20)),
                new(0.4f, ItemRarity.Insane, new(10, 100), new(5, 60), new(1, 10), new(7, 30), new(10, 20)),
                new(0.5f, ItemRarity.Rare, new(2, 10), new(5, 60), new(1, 10), new(7, 30), new(10, 20)),
                new(0.6f, ItemRarity.Uncommon, new(-2, 10), new(-5, 10), new(-10, 10), new(7, 20), new(10, 20)),
                new(1f, ItemRarity.Common, new(-2, 2), new(-5, 5), new(-5, 5), new(-3, 3), new(-8, 8))
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

