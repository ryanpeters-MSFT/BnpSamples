using Microsoft.AspNetCore.Mvc;
using WebApiControllerAttribute.Models;

namespace WebApiControllerAttribute.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{
    [HttpPost]
    [Consumes("application/json")]
    [Produces("application/xml")]
    public object CreateJson(FoodViewModel model)
    {
        // create a new client

        //return Ok($"Added a new food {model.Name} using JSON");
        return model;
    }

    [HttpPost]
    [Consumes("application/xml")]
    public IActionResult CreateXml(FoodViewModel model)
    {
        // create a new client

        return Ok($"Added a new food {model.Name} using XML");
    }
}