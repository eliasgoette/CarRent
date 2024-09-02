using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class GetCarsEndpoint : EndpointWithoutRequest<List<CarResponse>>
    {
        private ICarRepository _repository;

        public GetCarsEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Get("/cars");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var cars = _repository.GetAll();

            var carResponses = cars.Select(car => new CarResponse
            {
                Id = car.Id,
                Model = car.Model
            }).ToList();

            await SendAsync(carResponses, cancellation: ct);
        }
    }
}
