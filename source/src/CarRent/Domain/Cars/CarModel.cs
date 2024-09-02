using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class CarModel : Entity, IAggregateRoot
    {
        private CarModel() { }

        public CarModel(CarBrand brand, string modelName, VehicleCategory category)
        {
            Brand = brand;
            ModelName = modelName;
            Category = category;
        }

        public CarBrand Brand { get; private set; }
        public string ModelName { get; private set; }
        public VehicleCategory Category { get; private set; }

        public IReadOnlyList<IDomainEvent> Events { get; } = [];
    }
}
