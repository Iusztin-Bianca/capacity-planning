using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Domain.Entities;
namespace CapacityPlanning.Application.Strategies;

public interface ICapacityCalculationStrategy 
{
    TeamCapacityDto Calculate(Team team, IEnumerable<Epic> teamEpics, DateTime startDate, DateTime endDate);
}