using CapacityPlanning.Application.DTOs;

namespace CapacityPlanning.Application.Interfaces;

public interface IPersonService
{
    Task<IEnumerable<PersonDto>> GetByTeamAsync(Guid teamId);
    Task<PersonDto> CreateAsync(CreatePersonDto dto);
    Task DeleteAsync(Guid id);
}
