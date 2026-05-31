using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;

namespace CapacityPlanning.Application.Services;

public class InitiativeService : IInitiativeService
{
    private readonly IInitiativeRepository _initiativeRepository;

    public InitiativeService(IInitiativeRepository initiativeRepository)
    {
        _initiativeRepository = initiativeRepository;
    }

    public async Task<IEnumerable<InitiativeDto>> GetAllAsync()
    {
        var initiatives = await _initiativeRepository.GetAllAsync();
        return initiatives.Select(i => new InitiativeDto(i.Id, i.Name, i.Description, i.Priority, i.TargetDate));
    }

    public async Task<InitiativeDto?> GetByIdAsync(Guid id)
    {
        var i = await _initiativeRepository.GetByIdAsync(id);
        return i is null ? null : new InitiativeDto(i.Id, i.Name, i.Description, i.Priority, i.TargetDate);
    }

    public async Task<InitiativeDto> CreateAsync(CreateInitiativeDto dto)
    {
        var initiative = new Initiative
        {
            Name = dto.Name,
            Description = dto.Description,
            Priority = dto.Priority,
            TargetDate = dto.TargetDate
        };
        _initiativeRepository.Add(initiative);
        await _initiativeRepository.SaveChangesAsync();
        return new InitiativeDto(initiative.Id, initiative.Name, initiative.Description, initiative.Priority, initiative.TargetDate);
    }

    public async Task DeleteAsync(Guid id)
    {
        var initiative = await _initiativeRepository.GetByIdAsync(id);
        if (initiative is not null)
        {
            _initiativeRepository.Delete(initiative);
            await _initiativeRepository.SaveChangesAsync();
        }
    }
}
