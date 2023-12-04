using System;
using ExampleItemGenerator.Models;

namespace ExampleItemGenerator.Services.Generators
{
    public interface IItemGenerator
    {
        Task<Item> Generate();
    }
}
