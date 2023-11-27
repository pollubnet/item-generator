using ExampleItemGenerator.Services.Generators;

IItemGenerator itemGenerator = new ItemGenerator();
var count = 0;

while (true)
{
    var item = itemGenerator.Generate();
    if (item.Rarity != ExampleItemGenerator.Models.ItemRarity.Legendary)
        continue;

    Console.WriteLine($"Item: {item.Name} ({item.Rarity})");
    Console.WriteLine($"Agility: {item.Agility}");
    Console.WriteLine($"Defense: {item.Defense}");
    Console.WriteLine($"Intelligence: {item.Intelligence}");
    Console.WriteLine($"Strength: {item.Strength}");
    Console.WriteLine($"Health: {item.Health}");

    Console.WriteLine("\n-------------\n");
    count++;

    if (count >= 10)
        break;
}

Console.ReadLine();
