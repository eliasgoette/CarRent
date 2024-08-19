using CarRent.Domain.Cars;

namespace CarRent.Feature.Cars.Domain
{
    public interface ICarRepository
    {
        void Add(Car entity);
        IEnumerable<Car> GetAll();
        void Remove(Car entity);
    }
}
