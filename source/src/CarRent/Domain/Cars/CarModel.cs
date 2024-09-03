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

        public CarBrand Brand { get; set; }
        public string ModelName { get; set; }
        public VehicleCategory Category { get; set; }

        public IReadOnlyList<IDomainEvent> Events { get; } = [];
    }
}
