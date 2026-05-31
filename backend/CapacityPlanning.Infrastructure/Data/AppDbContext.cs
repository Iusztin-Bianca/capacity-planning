using CapacityPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace CapacityPlanning.Infrastructure.Data;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Initiative> Initiatives => Set<Initiative>();
    public DbSet<Epic> Epics => Set<Epic>();
    public DbSet<Team> Teams => Set<Team>();
    public DbSet<Person> Persons => Set<Person>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}