using CapacityPlanning.Domain.Common;

namespace CapacityPlanning.Domain.Entities;

public class Epic : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid InitiativeId { get; set; }
    public Guid TeamId { get; set; }
    public int EstimatedDays { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DueDate { get; set; }

    public Initiative Initiative { get; set; } = null!;
    public Team Team { get; set; } = null!;
}
