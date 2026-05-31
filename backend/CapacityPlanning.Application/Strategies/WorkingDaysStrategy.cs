using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Domain.Entities;
namespace CapacityPlanning.Application.Strategies;

public class WorkingDaysStrategy : ICapacityCalculationStrategy 
{
    public TeamCapacityDto Calculate(Team team, IEnumerable<Epic> teamEpics, DateTime startDate, DateTime endDate)
    {
        var workingDays = CountWorkingDays(startDate, endDate);
        var rawCapacity = team.Members.Sum(m => m.AvailabilityPercentage / 100.0 * workingDays);
        var netCapacity = rawCapacity * (1 - team.OverheadPercentage / 100.0);
        var allocated = teamEpics.Sum(e => e.EstimatedDays);
        var utilization = netCapacity > 0 ? Math.Round(allocated / netCapacity *100) : 0;

        return new TeamCapacityDto(team.Id, team.Name, rawCapacity, netCapacity, allocated, utilization);
    }

    private static int CountWorkingDays(DateTime start, DateTime end)
    {
        int count = 0;
        for(var day = start.Date; day <= end.Date; day = day.AddDays(1))
            if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                count++;
        return count;
    }
}

