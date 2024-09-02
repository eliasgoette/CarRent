using CarRent.Domain.Cars;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Feature.Cars.Infrastructure
{
    public class CarBrandConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData([
            ]);
        }
    }
}
