namespace CapacityPlanning.Application.DTOs;

public record TeamDto(Guid Id, string Name, int OverheadPercentage, int MemberCount );

public record CreateTeamDto(string Name, int OverheadPercentage);

