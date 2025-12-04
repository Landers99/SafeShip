using SafeShip.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IClientRepository, InMemoryClientRepository>();
builder.Services.AddSingleton<IFeatureFlagRepository, InMemoryFeatureFlagRepository>();
builder.Services.AddSingleton<ITelemetryRepository, InMemoryTelemetryRepository>();