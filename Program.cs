
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef.Models;


var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB")); //internal memory for data
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));   ///conection to SQL Server 

var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Test to API in postman

app.MapGet("/dbconexion", async ([FromServices] TareasContext DbContext) =>
{
    DbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + DbContext.Database.IsInMemory());
});

app.Run();
