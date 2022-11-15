using WebApiEntityFramework.Entities;

public interface IDogRepository
{
    Task<List<Dog>> GetAllDogsAsync();
    Task<Dog> GetDogAsync(int id);
    Task<int> CreateDogAsync(Dog dog);
    Task DeleteDogAsync(int id);
}
