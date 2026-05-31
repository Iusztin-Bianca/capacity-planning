using CapacityPlanning.Application.DTOs;

namespace CapacityPlanning.Application.Interfaces;

public interface ITeamService 
{
    Task<IEnumerable<TeamDto>> GetAllAsync();
    Task<TeamDto?> GetByIdAsync(Guid id);
    Task<TeamDto> CreateAsync(CreateTeamDto dto);
    Task DeleteAsync(Guid id);
}