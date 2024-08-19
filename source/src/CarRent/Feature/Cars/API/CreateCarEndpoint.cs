using CarRent.Domain.Cars;
using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class CreateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private ICarRepository _repository;

        public CreateCarEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Post("/cars");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CarRequest req, CancellationToken ct)
        {
            var newCar = new Car
            {
                Id = Guid.NewGuid(),
                Name = req.Name
            };

            _repository.Add(newCar);

            var res = new CarResponse
            {
                Id = newCar.Id,
                Name = newCar.Name
            };

            await SendAsync(res, 200, ct);
        }
    }
}
