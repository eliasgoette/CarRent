using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class VehicleCategory : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerDay { get; set; }

        public IReadOnlyList<IDomainEvent> Events { get; }
    }
}
