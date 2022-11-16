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
                Name = "Cheese Cake",
                Origin = "Greece"
            }, new Food
            {
                Id = Guid.Parse("b30085f2-522e-4200-885d-b662af6151c6"),
                Name = "Sushi",
                Origin = "Asia"
            }, new Food
            {
                Id = Guid.Parse("64d22bfd-0e55-487b-87fb-f96ce0cb7c1b"),
                Name = "French Fries",
                Origin = "Belgium"
            });
        }
    }
}
