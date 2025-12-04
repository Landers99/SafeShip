using SafeShip.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IClientRepository, InMemoryClientRepository>();
builder.Services.AddSingleton<IFeatureFlagRepository, InMemoryFeatureFlagRepository>();
builder.Services.AddSingleton<ITelemetryRepository, InMemoryTelemetryRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();