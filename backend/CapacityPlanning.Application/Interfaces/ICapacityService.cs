using CapacityPlanning.Application.DTOs;
namespace CapacityPlanning.Application.Interfaces;

public interface ICapacityService
{
    Task<CapacityReportDto> GetCapacityReportAsync(DateTime startDate, DateTime endDate);
}