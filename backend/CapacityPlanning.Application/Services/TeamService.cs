using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;

namespace CapacityPlanning.Application.Services;

public class TeamService : ITeamService 
{
    private readonly ITeamRepository _teamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<IEnumerable<TeamDto>> GetAllAsync()
    {
        var teams = await _teamRepository.GetAllWithMembersAsync();
        return teams.Select(t => new TeamDto(t.Id, t.Name, t.OverheadPercentage, t.Members.Count));
    }

    public async Task<TeamDto?> GetByIdAsync(Guid id)
    {
        var team = await _teamRepository.GetWithMembersAsync(id);
        return team is null ? null : new TeamDto(team.Id, team.Name, team.OverheadPercentage, team.Members.Count);
    }
    
    public async Task<TeamDto> CreateAsync(CreateTeamDto dto)
    {
        var team = new Team { Name = dto.Name, OverheadPercentage = dto.OverheadPercentage };
        _teamRepository.Add(team);
        await _teamRepository.SaveChangesAsync();
        return new TeamDto(team.Id, team.Name, team.OverheadPercentage, 0);
    }

    public async Task DeleteAsync(Guid id)
    {
        var team = await _teamRepository.GetByIdAsync(id);
        if (team is not null)
        {
            _teamRepository.Delete(team);
            await _teamRepository.SaveChangesAsync();
        }
    }
}