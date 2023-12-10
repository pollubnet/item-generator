using ExampleItemGenerator.Api;
using ExampleItemGenerator.Services.Generators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IItemGenerator>(new BogusItemGenerator());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapGet("/item", async (IItemGenerator generator) =>
{
	return await generator.Generate();
})
.WithName("GetRandomItem")
.WithOpenApi();

app.Run();
