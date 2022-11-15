using Microsoft.EntityFrameworkCore;
using WebApiEntityFramework.Entities;

public class EfDogRepository : IDogRepository
{
    private readonly DogsContext dogContext;

    public EfDogRepository(DogsContext dogContext)
    {
        this.dogContext = dogContext;
    }

    public Task<List<Dog>> GetAllDogsAsync()
    {
        return dogContext.Dogs.ToListAsync();
    }

    public Task<Dog> GetDogAsync(int id)
    {
        return dogContext.Dogs.FirstOrDefaultAsync(d => d.Id == id);
    }

    public async Task<int> CreateDogAsync(Dog dog)
    {
        dogContext.Attach(dog);

        await dogContext.SaveChangesAsync();

        return dog.Id;
    }

    public async Task DeleteDogAsync(int id)
    {
        var entity = new Dog { Id = id };

        dogContext.Remove(entity);

        await dogContext.SaveChangesAsync();
    }
}