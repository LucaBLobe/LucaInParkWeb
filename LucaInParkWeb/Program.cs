using LucaInParkWeb.Models.Application.Services;
using LucaInParkWeb.Models.Domain.Entities;
using LucaInParkWeb.Models.Infrastructure.Contexts;
using LucaInParkWeb.Models.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ControleEstacionamentoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());


});


builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAllOrigins");

if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
app.UseDeveloperExceptionPage();
}
//app.UseHttpsRedirection();

app.UseRouting();

//app.UseAuthorization();

app.MapControllers();

app.Run();
