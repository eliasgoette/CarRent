using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class Car : IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
