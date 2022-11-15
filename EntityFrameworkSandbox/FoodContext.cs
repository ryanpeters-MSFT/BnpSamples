using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSandbox
{
    public class FoodContext : DbContext
    {
        public FoodContext() { }
        public FoodContext(DbContextOptions<FoodContext> context) : base(context) { }

        public DbSet<Food> Foods { get;set; }
    }

    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
    }

}
