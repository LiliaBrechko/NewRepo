using CarStore.Domain.Models.Cars;
using CarStore.Infrastructure.DB.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Infrastructure.DB;

public class CarStoreDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = \"E:\\CommonRepository\\LiliaSolution\\CarStore.Infrastructure.DB\\CarStoreDatabase.db\"");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CarConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
