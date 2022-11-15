using Microsoft.EntityFrameworkCore;

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
}