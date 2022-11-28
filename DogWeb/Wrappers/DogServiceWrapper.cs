namespace DogWeb.Wrappers
{
    public class DogServiceWrapper : IDogServiceWrapper
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IConfiguration configuration;

        public DogServiceWrapper(IHttpClientFactory httpClientFactory, IConfiguration configuration) 
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
        }

        public Task<ICollection<Dog>> GetAllDogsAsync()
        {
            var httpClient = httpClientFactory.CreateClient();

            var dogApiServiceBase = configuration["DogApiServiceUrl"];
            var dogApiServiceGetAll = $"{dogApiServiceBase}/dogs";

            return httpClient.GetFromJsonAsync<ICollection<Dog>>(dogApiServiceGetAll);
        }
    }
}
