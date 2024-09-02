using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class GetCarByIdEndpoint : EndpointWithoutRequest
    {
        private ICarRepository _repository;

        public GetCarByIdEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Get("/cars/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var id = Route<Guid>("id");
            var car = _repository.FindById(id);
            var carResponse = new CarResponse
            {
                Id = car.Id,
                Model = car.Model,
            };

            await SendAsync(carResponse, 200, ct);
        }
    }
}
