using Microsoft.EntityFrameworkCore;
using CaloriesCalculator.Models;
using Microsoft.Extensions.Configuration;

namespace CaloriesCalculator.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null !;
        public DbSet<Portion> Portions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("AppSettings.json").Build();
            optionsBuilder.UseSqlite(builder.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>().HasOne(x => x.User).WithMany(x => x.Meals).HasForeignKey(x => x.UserID);
            modelBuilder.Entity<Meal>().HasMany(x => x.Portions).WithOne(x => x.Meal).HasForeignKey(x => x.MealId);
            modelBuilder.Entity<Portion>().HasKey(x=> new {x.ProductId, x.MealId});
        }

    }
}

