using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(config => 
{
    // order matters!
    config.AddJsonFile("settings.json");
    config.AddIniFile("settings.ini", optional: true);
    config.AddXmlFile("settings.xml", optional: true);
    //config.AddCommandLine(args);
});

var app = builder.Build();

var configuration = app.Services.GetService<IConfiguration>();

Console.WriteLine(configuration["PaymentProcessor"]); // from settings.json
Console.WriteLine(configuration["MaxAge"]); // from settings.ini
Console.WriteLine(configuration["emailSettings:server"]); // from settings.xml