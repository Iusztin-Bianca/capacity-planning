using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Application.Services;
using CapacityPlanning.Application.Strategies;
using CapacityPlanning.Domain.Interfaces;
using CapacityPlanning.Infrastructure.Data;
using CapacityPlanning.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
    options.AddPolicy("AllowFrontend", policy =>
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IEpicRepository, EpicRepository>();
builder.Services.AddScoped<IInitiativeRepository, InitiativeRepository>();
builder.Services.AddScoped<IRepository<Person>, Repository<Person>>();

// Services
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IEpicService, EpicService>();
builder.Services.AddScoped<IInitiativeService, InitiativeService>();
builder.Services.AddScoped<ICapacityService, CapacityService>();
builder.Services.AddScoped<IPersonService, PersonService>();

// Strategy Pattern
builder.Services.AddScoped<ICapacityCalculationStrategy, WorkingDaysStrategy>();

var app = builder.Build();

// Auto-create DB and apply migrations on startup
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");
app.UseAuthorization();
app.MapControllers();
app.Run();
