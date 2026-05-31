using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;

namespace CapacityPlanning.Application.Services;

public class EpicService : IEpicService
{
    private readonly IEpicRepository _epicRepository;

    public EpicService(IEpicRepository epicRepository)
    {
        _epicRepository = epicRepository;
    }

    public async Task<IEnumerable<EpicDto>> GetAllAsync()
    {
        var epics = await _epicRepository.GetAllAsync();
        return epics.Select(ToDto);
    }

    public async Task<IEnumerable<EpicDto>> GetByInitiativeAsync(Guid initiativeId)
    {
        var epics = await _epicRepository.GetByInitiativeAsync(initiativeId);
        return epics.Select(ToDto);
    }

    public async Task<EpicDto> CreateAsync(CreateEpicDto dto)
    {
        var epic = new Epic
        {
            Name = dto.Name,
            Description = dto.Description,
            InitiativeId = dto.InitiativeId,
            TeamId = dto.TeamId,
            EstimatedDays = dto.EstimatedDays,
            StartDate = dto.StartDate,
            DueDate = dto.DueDate
        };
        _epicRepository.Add(epic);
        await _epicRepository.SaveChangesAsync();
        return ToDto(epic);
    }

    public async Task DeleteAsync(Guid id)
    {
        var epic = await _epicRepository.GetByIdAsync(id);
        if (epic is not null)
        {
            _epicRepository.Delete(epic);
            await _epicRepository.SaveChangesAsync();
        }
    }

    private static EpicDto ToDto(Epic e) =>
        new(e.Id, e.Name, e.Description, e.InitiativeId, e.TeamId, e.EstimatedDays, e.StartDate, e.DueDate);
}
