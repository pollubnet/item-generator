using System;
namespace ExampleItemGenerator.Models
{
	public class Item
	{
		public string Name { get; set; } = null!;
		public string History { get; set; } = null!;

		public ItemRarity Rarity { get; set; } = ItemRarity.Common;

		public int Agility { get; set; } = 0;
		public int Strength { get; set; } = 0;
		public int Intelligence { get; set; } = 0;
		public int Defense { get; set; } = 0;
		public int Health { get; set; } = 0;
	}
}