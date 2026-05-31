using CapacityPlanning.Domain.Entities;

namespace CapacityPlanning.Domain.Interfaces;

public interface ITeamRepository : IRepository<Team>
{
    Task<IEnumerable<Team>> GetAllWithMembersAsync();
    Task<Team?> GetWithMembersAsync(Guid id);
}
