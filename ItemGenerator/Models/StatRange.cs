using System;
namespace ExampleItemGenerator.Models
{
	public class StatRange
	{
		public int MinValue { get; init; } = 0;
		public int MaxValue { get; init; } = 0;

		public StatRange(int min, int max)
		{
			MinValue = min;
			MaxValue = max;
		}

		public int GenerateStat(Random rnd)
		{
			return rnd.Next(MinValue, MaxValue + 1);
		}
	}
}

