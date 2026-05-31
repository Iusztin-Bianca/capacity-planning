using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CapacityPlanning.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InitiativesController : ControllerBase
{
    private readonly IInitiativeService _initiativeService;

    public InitiativesController(IInitiativeService initiativeService)
    {
        _initiativeService = initiativeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _initiativeService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var initiative = await _initiativeService.GetByIdAsync(id);
        return initiative is null ? NotFound() : Ok(initiative);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateInitiativeDto dto)
    {
        var created = await _initiativeService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _initiativeService.DeleteAsync(id);
        return NoContent();
    }
}
