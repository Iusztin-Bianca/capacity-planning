using CapacityPlanning.Domain.Entities;
namespace CapacityPlanning.Domain.Interfaces;

public interface IInitiativeRepository : IRepository<Initiative>
{
    Task<IEnumerable<Initiative>> GetAllWithEpicsAsync();
}
