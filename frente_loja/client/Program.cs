using System.Security.Claims;
using System.Net.WebSockets;
using System.Net.Http;
using client.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//inicio conexao
// ler a tag conexaoMySQL no arquivo appsettings.json
string  connString = builder.Configuration.GetConnectionString("conexaoMySQL");
builder.Services.AddDbContext<DataContext>(option => option.UseMySql(connString,ServerVersion.AutoDetect(connString)));
//fim conexao

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
