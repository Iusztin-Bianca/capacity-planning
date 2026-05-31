using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Application.Strategies;
using CapacityPlanning.Domain.Interfaces;

namespace CapacityPlanning.Application.Services;

public class CapacityService : ICapacityService
{
    private readonly ITeamRepository _teamRepository;
    private readonly IEpicRepository _epicRepository;
    private readonly ICapacityCalculationStrategy _strategy;

    public CapacityService(ITeamRepository teamRepository, IEpicRepository epicRepository, ICapacityCalculationStrategy strategy)
    {
        _teamRepository = teamRepository;
        _epicRepository = epicRepository;
        _strategy = strategy;
    }

    public async Task<CapacityReportDto> GetCapacityReportAsync(DateTime startDate, DateTime endDate)
    {
        var teams = await _teamRepository.GetAllWithMembersAsync();
        var epics = await _epicRepository.GetInDateRangeAsync(startDate, endDate);

        var teamCapacities = teams.Select(team =>
            _strategy.Calculate(team, epics.Where(e => e.TeamId == team.Id), startDate, endDate));

        return new CapacityReportDto(startDate, endDate, teamCapacities);
    }
}
