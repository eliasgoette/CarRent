using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class RemoveCarEndpoint : EndpointWithoutRequest
    {
        private ICarRepository _repository;

        public RemoveCarEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Delete("/cars/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var id = Route<Guid>("id");
            _repository.RemoveById(id);

            await SendAsync(200);
        }
    }
}
