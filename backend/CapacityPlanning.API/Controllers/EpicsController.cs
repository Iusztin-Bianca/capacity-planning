using CapacityPlanning.Application.DTOs;
using CapacityPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CapacityPlanning.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EpicsController : ControllerBase
{
    private readonly IEpicService _epicService;

    public EpicsController(IEpicService epicService)
    {
        _epicService = epicService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _epicService.GetAllAsync());

    [HttpGet("by-initiative/{initiativeId}")]
    public async Task<IActionResult> GetByInitiative(Guid initiativeId) =>
        Ok(await _epicService.GetByInitiativeAsync(initiativeId));

    [HttpPost]
    public async Task<IActionResult> Create(CreateEpicDto dto)
    {
        var created = await _epicService.CreateAsync(dto);
        return Created(string.Empty, created);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _epicService.DeleteAsync(id);
        return NoContent();
    }
}
