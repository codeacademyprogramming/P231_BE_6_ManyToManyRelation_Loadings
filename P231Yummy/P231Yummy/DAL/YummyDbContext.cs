using Microsoft.EntityFrameworkCore;
using P231Yummy.Models;

namespace P231Yummy.DAL
{
    public class YummyDbContext:DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> options):base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MealIngredient> MealIngredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealIngredient>().HasKey(x => new { x.MealId,x.IngredientId});
        }
    }
}
