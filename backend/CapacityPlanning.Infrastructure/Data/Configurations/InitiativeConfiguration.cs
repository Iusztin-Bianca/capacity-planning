using CapacityPlanning.Domain.Common;
using CapacityPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapacityPlanning.Infrastructure.Data.Configurations;

public class InitiativeConfiguration : IEntityTypeConfiguration<Initiative>
{
    public void Configure(EntityTypeBuilder<Initiative> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Name).IsRequired().HasMaxLength(200);
        builder.HasMany(i => i.Epics).WithOne(e => e.Initiative).HasForeignKey(e => e.InitiativeId);

        builder.HasData(
            new Initiative { Id = Guid.Parse("22222222-0000-0000-0000-000000000001"), Name = "New Customer Portal", Description = "Rebuild customer-facing portal", Priority = Priority.High, TargetDate = new DateTime(2025, 12, 31), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Initiative { Id = Guid.Parse("22222222-0000-0000-0000-000000000002"), Name = "Performance Rework", Description = "Reduce p99 latency by 50%", Priority = Priority.Critical, TargetDate = new DateTime(2025, 9, 30), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Initiative { Id = Guid.Parse("22222222-0000-0000-0000-000000000003"), Name = "Mobile App Launch", Description = "First native mobile app", Priority = Priority.Medium, TargetDate = new DateTime(2026, 3, 31), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        );
    }
}
