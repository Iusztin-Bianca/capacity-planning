using CapacityPlanning.Domain.Entities;
namespace CapacityPlanning.Domain.Interfaces;

public interface IEpicRepository : IRepository<Epic>
{
    Task<IEnumerable<Epic>> GetByInitiativeAsync(Guid initiativeId);
    Task<IEnumerable<Epic>> GetInDateRangeAsync(DateTime startDate, DateTime endDate);
}
