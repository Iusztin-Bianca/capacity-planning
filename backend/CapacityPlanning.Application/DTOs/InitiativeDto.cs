using CapacityPlanning.Domain.Common;

namespace CapacityPlanning.Application.DTOs;

public record InitiativeDto(Guid Id, string Name, string? Description, Priority Priority, DateTime TargetDate);

public record CreateInitiativeDto(string Name, string? Description, Priority Priority, DateTime TargetDate);
