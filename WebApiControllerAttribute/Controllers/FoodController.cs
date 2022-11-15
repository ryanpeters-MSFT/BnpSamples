using Microsoft.AspNetCore.Mvc;
using WebApiControllerAttribute.Models;

namespace WebApiControllerAttribute.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{
    [HttpPost]
    [Consumes("application/json")]
    public IActionResult CreateJson(FoodViewModel model)
    {
        // create a new client

        return Ok($"Added a new food {model.Name} using JSON");
    }

    [HttpPost]
    [Consumes("application/xml")]
    public IActionResult CreateXml(FoodViewModel model)
    {
        // create a new client

        return Ok($"Added a new food {model.Name} using XML");
    }
}