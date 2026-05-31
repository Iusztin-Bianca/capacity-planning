using CapacityPlanning.Domain.Common;

namespace CapacityPlanning.Domain.Entities;

public class Team : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    // Percentage of capacity consumed by overhead (meetings, support, on-call).
    // EX: 20 means 20% overhead → 80% available for project work.
   
    public int OverheadPercentage { get; set; } = 20;

    public ICollection<Person> Members { get; set; } = new List<Person>();
    public ICollection<Epic> Epics { get; set; } = new List<Epic>();
}
