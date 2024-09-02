using CarRent.Domain.Cars;
using CarRent.Feature.Cars.Domain;
using CarRent.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Feature.Cars.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentDbContext _context;

        public CarRepository(CarRentDbContext context)
        {
            _context = context;
        }

        public void Add(Car entity)
        {
            _context.Set<Car>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Set<Car>()
                .Include(x => x.Model)
                .Include(x => x.Model.Brand)
                .Include(x => x.Model.Category);
        }

        public Car? FindById(Guid id)
        {
            return GetAll()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public void Remove(Car entity)
        {
            _context.Set<Car>().Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveById(Guid id)
        {
            var entity = FindById(id);

            if (entity != null)
            {
                Remove(entity);
            }
        }
    }
}