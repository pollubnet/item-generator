using System;

namespace ExampleItemGenerator.Services.Generators
{
    public class TemporaryNameGenerator : INameGenerator
    {
        public string GenerateName()
        {
            return "Cool Item";
        }
    }
}
