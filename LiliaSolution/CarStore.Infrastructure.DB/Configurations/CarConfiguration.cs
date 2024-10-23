using CarStore.Domain.Models.Cars;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Infrastructure.DB.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        // Set CarId as the primary key.
        builder.HasKey(c => c.Id);

        // Configure the CarId to be stored as a Guid in the database.
        builder.Property(c => c.Id)
               .HasConversion(
                    id => id.Value, // Convert from CarId to Guid.
                    value => new CarId(value) // Convert from Guid to CarId.
                );

        // Other configurations...
        builder.Property(c => c.Mark).IsRequired();
        builder.OwnsOne(c => c.InitialPrice, ip =>
        {
            ip.Property(m => m.Amount);

            ip.Property(m => m.Currency);
        });
    }
}
