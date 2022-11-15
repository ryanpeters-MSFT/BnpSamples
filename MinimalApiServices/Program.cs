var builder = WebApplication.CreateBuilder(args);

// define services
builder.Services.AddSingleton<IConstellationRepository, JsonConstellationRepository>();

var app = builder.Build();

var clientRepository = app.Services.GetService<IConstellationRepository>();

app.MapGet("/stars", clientRepository.GetAllConstellations);
app.MapGet("/stars/{id:int}", (int id) => clientRepository.GetConstellation(id));
app.MapGet("/stars/random", clientRepository.GetRandomConstellation);

app.Run();
