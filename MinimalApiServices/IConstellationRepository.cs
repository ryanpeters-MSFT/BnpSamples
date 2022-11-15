internal interface IConstellationRepository
{
    Constellation GetRandomConstellation();
    ICollection<Constellation> GetAllConstellations();
    Constellation GetConstellation(int id);
}
