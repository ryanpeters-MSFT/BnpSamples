namespace WebApiEntityFramework.Entities;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public bool HasAllShots { get; set; }
}