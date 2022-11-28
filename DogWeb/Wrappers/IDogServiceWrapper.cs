namespace DogWeb.Wrappers
{
    public interface IDogServiceWrapper
    {
        Task<ICollection<Dog>> GetAllDogsAsync();
    }
}
