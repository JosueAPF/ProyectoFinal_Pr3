using Microsoft.OpenApi.Models;
using TarjetasCredito_API_Rest.Data;
using TarjetasCredito_API_Rest.Models;
using TarjetasCredito_API_Rest.Services;

//using web_Api_persona.Servicios; //importa los servicios

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios
builder.Services.AddControllers();


// ⬇️  registras el servicio 
//builder.Services.AddSingleton<PilaServicio>();

builder.Services.AddSingleton<LecturaDatos<Clientes>>();
builder.Services.AddSingleton<LecturaDatos<TarjetasCredito>>();
builder.Services.AddSingleton<CargaInicialServicio>();

// Configurar Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Mi API",
        Version = "v1",
        Description = "API REST para gestión de productos"
    });
});

var app = builder.Build();

// Configurar middleware
if (app.Environment.IsDevelopment())
{
    // Habilitar Swagger
    app.UseSwagger();

    // Habilitar Swagger UI
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");
        c.RoutePrefix = "swagger"; // Acceder desde /swagger
    });
}

// Redirigir la raíz "/" hacia "/swagger"
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/swagger");
        return;
    }
    await next();
});



app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();