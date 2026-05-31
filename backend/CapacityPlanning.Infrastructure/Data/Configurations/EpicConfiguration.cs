using CapacityPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapacityPlanning.Infrastructure.Data.Configurations;

public class EpicConfiguration : IEntityTypeConfiguration<Epic>
{
    public void Configure(EntityTypeBuilder<Epic> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).IsRequired().HasMaxLength(200);

        builder.HasData(
            new Epic { Id = Guid.NewGuid(), Name = "Auth Service Rewrite", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000001"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000003"), EstimatedDays = 30, StartDate = new DateTime(2025, 1, 1), DueDate = new DateTime(2025, 3, 31), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Epic { Id = Guid.NewGuid(), Name = "Portal UI Redesign", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000001"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000002"), EstimatedDays = 40, StartDate = new DateTime(2025, 2, 1), DueDate = new DateTime(2025, 5, 31), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Epic { Id = Guid.NewGuid(), Name = "API Gateway Setup", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000002"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000001"), EstimatedDays = 20, StartDate = new DateTime(2025, 1, 1), DueDate = new DateTime(2025, 2, 28), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Epic { Id = Guid.NewGuid(), Name = "DB Query Optimization", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000002"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000003"), EstimatedDays = 25, StartDate = new DateTime(2025, 3, 1), DueDate = new DateTime(2025, 4, 30), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Epic { Id = Guid.NewGuid(), Name = "iOS App MVP", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000003"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000004"), EstimatedDays = 60, StartDate = new DateTime(2025, 6, 1), DueDate = new DateTime(2025, 12, 31), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Epic { Id = Guid.NewGuid(), Name = "Push Notifications", InitiativeId = Guid.Parse("22222222-0000-0000-0000-000000000003"), TeamId = Guid.Parse("11111111-0000-0000-0000-000000000001"), EstimatedDays = 15, StartDate = new DateTime(2025, 9, 1), DueDate = new DateTime(2025, 11, 30), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        );
    }
}
