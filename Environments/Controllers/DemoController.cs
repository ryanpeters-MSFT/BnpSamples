using Microsoft.AspNetCore.Mvc;

namespace Environments.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly IConfiguration configuration;

    public DemoController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public string GetData()
    {
        return configuration.GetConnectionString("Default");
    }
}
