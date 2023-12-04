using ExampleItemGenerator.Models;
using ExampleItemGenerator.Services.Generators;

IItemGenerator itemGenerator = new ItemGenerator();
var count = 0;

while (true)
{
    var item = await itemGenerator.Generate();

    Console.WriteLine($"Item: {item.Name} ({item.Rarity})");

    foreach (var itemStat in Enum.GetValues<ItemStat>())
        Console.WriteLine($"{itemStat} = {item.Statistics[itemStat]}");
    
    Console.WriteLine("\n-------------\n");
    count++;

    if (count >= 10)
        break;
}