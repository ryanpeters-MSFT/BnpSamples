using System.Text.Json;

internal class JsonConstellationRepository : IConstellationRepository
{
    private readonly ICollection<Constellation> constellations;

    public JsonConstellationRepository()
    {
        var file = "constellations.json";

        var contents = File.ReadAllText(file);

        constellations = JsonSerializer.Deserialize<ICollection<Constellation>>(contents);
    }

    public ICollection<Constellation> GetAllConstellations()
    {
        return constellations;
    }

    public Constellation GetConstellation(int id)
    {
        return constellations.FirstOrDefault(c => c.Id == id);
    }

    public Constellation GetRandomConstellation()
    {
        var random = new Random(DateTime.Now.Second);

        return constellations
            .OrderBy(c => random.Next())
            .FirstOrDefault();
    }
}
