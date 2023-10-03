using SmartScoolApi.Domain.DomaiModel.Interfaces;
using SmartScoolApi.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ConfigurarInjecaoDeDependencia(builder);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static WebApplicationBuilder ConfigurarInjecaoDeDependencia(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();    
    return builder;
}