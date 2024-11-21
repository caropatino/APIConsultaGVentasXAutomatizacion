using Microsoft.EntityFrameworkCore;
using APIConsultaGVentasXAutomatizacion.Models;
using APIConsultaGVentasXAutomatizacion.Context;
using APIConsultaGVentasXAutomatizacion.Services;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientesAppService, ClientesAppService>();
builder.Services.AddScoped<IOportunidadDeVentaAppService, OportunidadDeVentaAppService>();
builder.Services.AddScoped<ITicketsAppService, TicketsAppService>();

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

app.UseRouting();

app.MapGet("/", () => {
    return Results.Extensions.HtmlResponse(@"
<html>
<head></head>
<Body>   
<center>  
<H1>API Automatizacion<br> </h1>
<p> Estado:
<b> Running </b> desde " + System.DateTime.Now.ToString("dd/MM/yy hh:mm:ss") +
                @"</p>                     
</center>  
</Body>  
</html>");
});

app.Run();


