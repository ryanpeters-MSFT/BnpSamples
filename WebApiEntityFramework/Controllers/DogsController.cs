using Microsoft.AspNetCore.Mvc;
using WebApiEntityFramework.Entities;
using WebApiEntityFramework.Models;

namespace WebApiEntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class DogsController : ControllerBase
{
    private readonly IDogRepository dogRepository;

    public DogsController(IDogRepository dogRepository) => this.dogRepository = dogRepository;

    public Task<List<Dog>> GetAsync() => dogRepository.GetAllDogsAsync();

    [Route("{id:int}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var dog = await dogRepository.GetDogAsync(id);

        if (dog == null)
        {
            return NotFound("We could not find your dog :-(");
        }

        return Ok(dog);
    }

    [HttpPost]
    public async Task<int> Create(DogViewModel dog)
    {
        // in production, consider a mapping utility, such as AutoMapper
        var entity = new Dog
        {
            Name = dog.Name,
            Age = dog.Age.Value,
            Breed = dog.Breed,
            HasAllShots = dog.HasAllShots
        };

        return await dogRepository.CreateDogAsync(entity);
    }

    [HttpDelete]
    [Route("{id:int}")]
    public Task Delete(int id) => dogRepository.DeleteDogAsync(id);
}
