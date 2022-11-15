using Microsoft.AspNetCore.Mvc;
using WebApiControllerAttribute.Models;

namespace WebApiControllerAttribute.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(ClientViewModel model)
    {
        // create a new client

        return Ok($"Created new user {model.Name}");
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetClient(int id)
    {
        // oops, that client isn't found!
        return NotFound();
    }
}