using CarRent.Domain.Common;
using CarRent.Feature.Cars.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Persistence
{
    public class CarRentDbContext : DbContext, IUnitOfWork
    {
        public CarRentDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }
    }
}