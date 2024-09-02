using CarRent.Domain.Cars;

namespace CarRent.Feature.Cars.API
{
    public class CarResponse
    {
        public Guid Id { get; set; }
        public CarModel Model { get; set; }
    }
}
