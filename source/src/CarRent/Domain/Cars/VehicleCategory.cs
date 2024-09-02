using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class VehicleCategory : Entity, IAggregateRoot
    {
        private VehicleCategory() { }

        public VehicleCategory(string name, string description, decimal pricePerDay)
        {
            Name = name;
            Description = description;
            PricePerDay = pricePerDay;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }

        public IReadOnlyList<IDomainEvent> Events { get; } = [];
    }
}
