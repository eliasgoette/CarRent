using CarRent.Domain.Common;
using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class RemoveCarEndpoint : EndpointWithoutRequest
    {
        private ICarRepository _repository;
        private IUnitOfWork _unitOfWork;

        public RemoveCarEndpoint(ICarRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();

            await SendAsync(200);
        }
    }
}
