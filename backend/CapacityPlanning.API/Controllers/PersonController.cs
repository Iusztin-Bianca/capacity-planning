using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CapacityPlanning.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonsController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonsController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("by-team/{teamId}")]
    public async Task<IActionResult> GetByTeam(Guid teamId) =>
        Ok(await _personService.GetByTeamAsync(teamId));

    [HttpPost]
    public async Task<IActionResult> Create(CreatePersonDto dto)
    {
        var created = await _personService.CreateAsync(dto);
        return Created(string.Empty, created);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _personService.DeleteAsync(id);
        return NoContent();
    }
}
