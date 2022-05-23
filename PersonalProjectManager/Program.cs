using Microsoft.EntityFrameworkCore;
using PersonalProjectManager.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PPMDbContext>(x => {
    x.UseSqlServer(builder.Configuration.GetConnectionString("PPMDbContext"));
});

builder.Services.AddCors();
var app = builder.Build();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
