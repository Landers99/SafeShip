using Microsoft.AspNetCore.Mvc;
using SafeShip.API.Repositories;

namespace SafeShip.API.Controllers;

[ApiController]
[Route("clients")]
public class ClientsController : ControllerBase
{
    private readonly IClientRepository _clients;

    public ClientsController(IClientRepository clients)
    {
        _clients = clients;
    }

    [HttpPost("register")]
    public IActionResult Register()
    {
        // TODO
        return Ok("Register endpoint placeholder");
    }
}
