using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using CapacityPlanning.Domain.Entities;
using CapacityPlanning.Domain.Interfaces;

namespace CapacityPlanning.Application.Services;

public class PersonService : IPersonService
{
    private readonly IRepository<Person> _repository;

    public PersonService(IRepository<Person> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PersonDto>> GetByTeamAsync(Guid teamId)
    {
        var all = await _repository.GetAllAsync();
        return all.Where(p => p.TeamId == teamId)
                  .Select(p => new PersonDto(p.Id, p.Name, p.Role, p.AvailabilityPercentage, p.TeamId));
    }

    public async Task<PersonDto> CreateAsync(CreatePersonDto dto)
    {
        var person = new Person
        {
            Name = dto.Name,
            Role = dto.Role,
            TeamId = dto.TeamId,
            AvailabilityPercentage = dto.AvailabilityPercentage
        };
        _repository.Add(person);
        await _repository.SaveChangesAsync();
        return new PersonDto(person.Id, person.Name, person.Role, person.AvailabilityPercentage, person.TeamId);
    }

    public async Task DeleteAsync(Guid id)
    {
        var person = await _repository.GetByIdAsync(id);
        if (person is not null)
        {
            _repository.Delete(person);
            await _repository.SaveChangesAsync();
        }
    }
}
