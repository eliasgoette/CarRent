using CarRent.Domain.Cars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRent.Feature.Cars.Infrastructure
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(256);

            builder.HasData([
                new Car {
                    Id = Guid.NewGuid(),
                    Name = "Benz"
                },
                new Car {
                    Id = Guid.NewGuid(),
                    Name = "GMC"
                }
            ]);
        }
    }
}