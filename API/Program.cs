using API.API;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices();
var app = builder.Build();
Configure();

app.MapGet("/", () => "Hello World!");

app.Run();


void ConfigureServices()
{
    builder.Services.ConfigureSwaggerServices();
    builder.Services.ConfigureDependencyInjection();
}

void Configure()
{
    app.ConfigureSwagger();
}