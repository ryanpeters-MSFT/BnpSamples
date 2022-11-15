using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSandbox
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public FoodContext() { }
        public FoodContext(DbContextOptions<FoodContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(new Food 
            {
                Id = Guid.Parse("b559d96b-cd55-4bde-8814-225e815828bc"),
                Name = "Spaghetti",
                Origin = "Italy"
            });
        }
    }
}
