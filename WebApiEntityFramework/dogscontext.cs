using Microsoft.EntityFrameworkCore;

public class DogsContext : DbContext
{
    public DbSet<Dog> Dogs { get; set; }

    public DogsContext(DbContextOptions<DogsContext> context) : base(context) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Dog>().HasData(
            new Dog
            {
                Id = 1,
                Name = "Daisy",
                Breed = "Beagle",
                Age = 7,
                HasAllShots = true
            }, new Dog
            {
                Id = 2,
                Name = "Sadie",
                Breed = "Boxer",
                Age = 4,
                HasAllShots = true
            }, new Dog
            {
                Id = 3,
                Name = "Belle",
                Breed = "Basset Hound",
                Age = 2,
                HasAllShots = false
            }, new Dog
            {
                Id = 4,
                Name = "Ellie",
                Breed = "Mastiff",
                Age = 3,
                HasAllShots = false
            }
        );
    }
}
