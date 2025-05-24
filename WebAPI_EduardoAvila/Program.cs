using Microsoft.EntityFrameworkCore;
using WebAPI_EduardoAvila.Models;

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios necesarios
builder.Services.AddControllers(); // ✅ Activar controladores
builder.Services.AddEndpointsApiExplorer(); // ✅ Swagger: metadatos
builder.Services.AddSwaggerGen(); // ✅ Swagger: generación UI

// Agrega el contexto de base de datos con SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();        // ✅ Habilita Swagger
    app.UseSwaggerUI();      // ✅ Interfaz Swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // ✅ Activa rutas de controladores

app.Run();
