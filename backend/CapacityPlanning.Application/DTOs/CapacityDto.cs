namespace CapacityPlanning.Application.DTOs;

public record TeamCapacityDto(
    Guid TeamId,
    string TeamName,
    double RawCapacityDays,
    double NetCapacityDays,
    double AllocatedDays,
    double UtilizationPercentage
);

public record CapacityReportDto(
    DateTime StartDate,
    DateTime EndDate,
    IEnumerable<TeamCapacityDto> Teams
);