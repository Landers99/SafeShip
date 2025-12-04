using Microsoft.AspNetCore.Mvc;
using SafeShip.API.Repositories;

namespace SafeShip.API.Controllers;

[ApiController]
[Route("telemetry")]
public class TelemetryController : ControllerBase
{
    private readonly ITelemetryRepository _telemetry;

    public TelemetryController(ITelemetryRepository telemetry)
    {
        _telemetry = telemetry;
    }

    [HttpPost]
    public IActionResult Ingest()
    {
        // TODO
        return Ok("Telemetry endpoint placeholder");
    }
}

