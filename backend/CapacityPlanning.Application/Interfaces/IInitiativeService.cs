using CapacityPlanning.Application.DTOs;
namespace CapacityPlanning.Application.Interfaces;

public interface IInitiativeService
{
    Task<IEnumerable<InitiativeDto>> GetAllAsync();
    Task<InitiativeDto?> GetByIdAsync(Guid id);
    Task<InitiativeDto> CreateAsync(CreateInitiativeDto dto);
    Task DeleteAsync(Guid id);
}
