using Microsoft.EntityFrameworkCore;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Services;
using NiceToDev.Schedules.Database;
using NiceToDev.Schedules.Domain.Interfaces;
using NiceToDev.Schedules.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console() // Logowanie do konsoli
    .WriteTo.File("bin/Logs/log-.txt", rollingInterval: RollingInterval.Day) // Logowanie do plików
    .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ScheduleContext>(
        options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("NiceToDev.Schedules")));

builder.Services.AddScoped<IScheduleRepository, ScheduleRepository>();
builder.Services.AddScoped<IScheduleService, ScheduleService>();

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
