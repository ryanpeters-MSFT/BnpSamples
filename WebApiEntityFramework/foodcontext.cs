using Microsoft.EntityFrameworkCore;

public class DogsContext : DbContext
{
    public DbSet<Dog> Dogs { get; set; }

    public DogsContext(DbContextOptions<DogsContext> context) : base(context) { }
}

public class Dog
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public bool HasAllShots { get; set; }
}