using CapacityPlanning.Domain.Common;

namespace CapacityPlanning.Domain.Entities;

public class Person : BaseEntity
{
    public Guid TeamId {get; set; }
    public string Name {get; set; } = string.Empty;
    public string? Role {get; set; }
    public int AvailabilityPercentage {get; set;} = 100;

    public Team Team {get; set;} = null!;
}