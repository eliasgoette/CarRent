using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class Car : Entity, IAggregateRoot
    {
        private Car() { }

        public Car(CarModel model)
        {
            Model = model;
        }

        public CarModel Model { get; set; }
        public IReadOnlyList<IDomainEvent> Events { get; } = [];
    }
}
