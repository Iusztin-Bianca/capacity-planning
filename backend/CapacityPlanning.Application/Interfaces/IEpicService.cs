using CapacityPlanning.Application.DTOs;
namespace CapacityPlanning.Application.Interfaces;

public interface IEpicService
{
    Task<IEnumerable<EpicDto>> GetAllAsync();
    Task<IEnumerable<EpicDto>> GetByInitiativeAsync(Guid initiativeId);
    Task<EpicDto> CreateAsync(CreateEpicDto dto);
    Task DeleteAsync(Guid id);
}
