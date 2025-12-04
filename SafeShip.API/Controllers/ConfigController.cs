using Microsoft.AspNetCore.Mvc;
using SafeShip.API.Repositories;

namespace SafeShip.API.Controllers;

[ApiController]
[Route("config")]
public class ConfigController : ControllerBase
{
    private readonly IFeatureFlagRepository _flags;

    public ConfigController(IFeatureFlagRepository flags)
    {
        _flags = flags;
    }

    [HttpGet]
    public IActionResult GetConfig()
    {
        // TODO
        var allFlags = _flags.GetAll();
        return Ok(new { features = allFlags });
    }
}
