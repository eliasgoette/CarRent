using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class CarBrand : Entity, IAggregateRoot
    {
        private CarBrand() { }

        public CarBrand(string brandName)
        {
            BrandName = brandName;
        }

        public string BrandName { get; set; }
        public IReadOnlyList<IDomainEvent> Events { get; } = [];
    }
}
