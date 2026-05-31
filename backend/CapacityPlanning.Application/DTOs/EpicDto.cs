namespace CapacityPlanning.Application.DTOs;

public record EpicDto(Guid Id, string Name, string? Description, Guid InitiativeId, Guid TeamId, int EstimatedDays, DateTime StartDate, DateTime DueDate);

public record CreateEpicDto(string Name, string? Description, Guid InitiativeId, Guid TeamId, int EstimatedDays, DateTime StartDate, DateTime DueDate);
