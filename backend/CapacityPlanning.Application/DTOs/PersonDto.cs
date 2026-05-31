namespace CapacityPlanning.Application.DTOs;

public record PersonDto(Guid Id, string Name, string? Role, int AvailabilityPercentage, Guid TeamId);

public record CreatePersonDto(string Name, string? Role, int AvailabilityPercentage, Guid TeamId);