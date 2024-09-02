using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class CarBrand : Entity, IAggregateRoot
    {
        public string BrandName { get; set; }
        public IReadOnlyList<IDomainEvent> Events { get; }
    }
}
