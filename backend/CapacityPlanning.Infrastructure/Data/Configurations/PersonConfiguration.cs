using CapacityPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapacityPlanning.Infrastructure.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
            new Person { Id = Guid.NewGuid(), Name = "Alice", Role = "Tech Lead", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000001"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Bob", Role = "Senior Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000001"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Carol", Role = "Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000001"), AvailabilityPercentage = 50, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Dan", Role = "Tech Lead", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000002"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Eva", Role = "Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000002"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Frank", Role = "Tech Lead", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000003"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Grace", Role = "Senior Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000003"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Henry", Role = "Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000003"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Iris", Role = "Tech Lead", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000004"), AvailabilityPercentage = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Person { Id = Guid.NewGuid(), Name = "Jack", Role = "Engineer", TeamId = Guid.Parse("11111111-0000-0000-0000-000000000004"), AvailabilityPercentage = 50, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        );
    }
}
