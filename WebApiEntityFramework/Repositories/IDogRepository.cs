public interface IDogRepository
{
    Task<List<Dog>> GetAllDogsAsync();
    Task<Dog> GetDogAsync(int id);
    //int CreateDog(Dog dog);
}
