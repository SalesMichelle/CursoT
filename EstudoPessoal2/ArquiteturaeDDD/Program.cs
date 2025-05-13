using ArquiteturaeDDD.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Injeção de dependência
builder.Services.AddScoped<IHelloService, HelloService>();

// Adiciona controladores
builder.Services.AddControllers();

var app = builder.Build();

// Mapeia os controllers
app.MapControllers();

app.Run();