using CapacityPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CapacityPlanning.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CapacityController : ControllerBase
{
    private readonly ICapacityService _capacityService;

    public CapacityController(ICapacityService capacityService)
    {
        _capacityService = capacityService;
    }

    [HttpGet]
    public async Task<IActionResult> GetReport([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
    {
        if (startDate >= endDate)
            return BadRequest("startDate must be before endDate");

        var report = await _capacityService.GetCapacityReportAsync(startDate, endDate);
        return Ok(report);
    }
}
