using Carpinteria.Data;
using Carpinteria.ImplementacionCU;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.InterfacesCU;
using Carpinteria.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CarpinteriaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.

//CU
builder.Services.AddScoped<IAltaInsumo, AltaInsumo>();
builder.Services.AddScoped<IRegistrarMovimiento, RegistrarMovimiento>();
builder.Services.AddScoped<IBajaInsumo, BajaInsumo>();
builder.Services.AddScoped<IModificarInsumo, ModificarInsumo>();

//REPOS
builder.Services.AddScoped<IRepositorioInsumo, RepositorioInsumo>();
builder.Services.AddScoped<IRepositorioStock, RepositorioStock>();
builder.Services.AddScoped<IRepositorioMovimientoStock, RepositorioMovimientoStock>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

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
