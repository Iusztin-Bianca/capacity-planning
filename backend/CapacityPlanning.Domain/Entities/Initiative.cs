using CapacityPlanning.Domain.Common;

namespace CapacityPlanning.Domain.Entities;

public class Initiative : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; } = Priority.Medium;
    public DateTime TargetDate { get; set; }

    public ICollection<Epic> Epics { get; set; } = new List<Epic>();
}
