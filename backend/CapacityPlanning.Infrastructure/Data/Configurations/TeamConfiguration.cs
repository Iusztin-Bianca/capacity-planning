using CapacityPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapacityPlanning.Infrastructure.Data.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(t => t.Members).WithOne(p => p.Team).HasForeignKey(p => p.TeamId);
        builder.HasMany(t => t.Epics).WithOne(e => e.Team).HasForeignKey(e => e.TeamId);

        builder.HasData(
            new Team { Id = Guid.Parse("11111111-0000-0000-0000-000000000001"), Name = "Platform", OverheadPercentage = 25, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Team { Id = Guid.Parse("11111111-0000-0000-0000-000000000002"), Name = "Frontend", OverheadPercentage = 20, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Team { Id = Guid.Parse("11111111-0000-0000-0000-000000000003"), Name = "Backend", OverheadPercentage = 20, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Team { Id = Guid.Parse("11111111-0000-0000-0000-000000000004"), Name = "Mobile", OverheadPercentage = 15, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        );
    }
}
