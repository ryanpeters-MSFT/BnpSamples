using Microsoft.EntityFrameworkCore;
using WebApiEntityFramework.Entities;

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
                Description = "Daisy is a cute dog with short black hair and loves people.",
                Breed = "Beagle",
                Age = 7,
                HasAllShots = true
            }, new Dog
            {
                Id = 2,
                Name = "Sadie",
                Description = "Large dog with big feet. Loves to chew shoes.",
                Breed = "Boxer",
                Age = 4,
                HasAllShots = true
            }, new Dog
            {
                Id = 3,
                Name = "Belle",
                Description = "Great at playing fetch!",
                Breed = "Basset Hound",
                Age = 2,
                HasAllShots = false
            }, new Dog
            {
                Id = 4,
                Name = "Ellie",
                Description = "Big girl who loves the couch. Needs lots of space to play. Loves eating socks and tennis balls.",
                Breed = "Mastiff",
                Age = 3,
                HasAllShots = false
            }
        );
    }
}
