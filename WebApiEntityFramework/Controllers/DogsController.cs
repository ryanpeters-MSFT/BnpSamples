using Microsoft.AspNetCore.Mvc;

namespace WebApiEntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class DogsController : ControllerBase
{
    private readonly IDogRepository dogRepository;

    public DogsController(IDogRepository dogRepository)
    {
        this.dogRepository = dogRepository;
    }

    public Task<List<Dog>> GetAsync()
    {
        return dogRepository.GetAllDogsAsync();
    }

    [Route("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var dog = await dogRepository.GetDogAsync(id);

        if (dog == null)
        {
            return NotFound("We could not find your dog :-)");
        }

        return Ok(dog);
    }
}
