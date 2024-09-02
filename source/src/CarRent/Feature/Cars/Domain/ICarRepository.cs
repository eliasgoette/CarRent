using CarRent.Domain.Cars;

namespace CarRent.Feature.Cars.Domain
{
    public interface ICarRepository
    {
        void Add(Car entity);
        IEnumerable<Car> GetAll();
        Car FindById(Guid id);
        void Remove(Car entity);
        void RemoveById(Guid id);
    }
}
