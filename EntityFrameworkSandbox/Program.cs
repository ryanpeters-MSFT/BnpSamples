﻿using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityFrameworkSandbox;
using Microsoft.Extensions.Configuration;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(options =>
{
    options.AddUserSecrets<Program>();
});

builder.ConfigureServices((context, services) =>
{
    var connectionString = context.Configuration.GetConnectionString("Default");

    services.AddDbContext<FoodContext>(options => options.UseSqlServer(connectionString));
});

var app = builder.Build();

var context = app.Services.GetService<FoodContext>();

var foods = context.Foods.ToList();

foreach (var food in foods)
{
    Console.WriteLine($"{food.Name} is from {food.Origin}");
}