using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityFrameworkSandbox;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(options =>
{
    //options.AddUserSecrets<Program>();
    //options.AddJsonFile("settings.json");
});

builder.ConfigureServices((context, services) =>
{
    services.AddDbContext<FoodContext>(options => options.UseSqlite("Data Source=food.db"));
});

var app = builder.Build();

var context = app.Services.GetService<FoodContext>();

var foods = context.Foods.ToList();

foreach (var food in foods)
{
    Console.WriteLine($"{food.Name} is from {food.Origin}");
}