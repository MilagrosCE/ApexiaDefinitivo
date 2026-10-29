using Apexia.API.AutoMapper;
using Apexia.API.DTOs;
using Apexia.API.Validators;
using Apexia.Core.Interfaces;
using Apexia.Core.Services;
using Apexia.Infrastructure.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Inyección de dependencias de AutoMapper
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappeoObjeto>());

// Servicios
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// El puente a Infrastructure (MySQL)
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();

// Validadores

// Inyectar el servicio de autenticación


// Configurar JWT
var jwtKey = builder.Configuration["Jwt:llave_secreta"];
var jwtIssuer = builder.Configuration["Jwt:emisor"];
var jwtAudience = builder.Configuration["Jwt:audiencia"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtAudience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey!))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();