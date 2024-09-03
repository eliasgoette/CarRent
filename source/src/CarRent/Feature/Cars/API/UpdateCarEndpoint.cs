using CarRent.Domain.Common;
using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class UpdateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private IUnitOfWork _unitOfWork;
        private ICarRepository _repository;

        public UpdateCarEndpoint(IUnitOfWork unitOfWork, ICarRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public override void Configure()
        {
            Post("/cars/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CarRequest req, CancellationToken ct)
        {
            var id = Route<Guid>("id");

            var car = _repository.FindById(id);

            if (car != null)
            {
                _repository.Remove(car);
                _unitOfWork.Commit();

                car.Model = req.Model;

                _repository.Add(car);
                _unitOfWork.Commit();

                var res = new CarResponse
                {
                    Id = car.Id,
                    Model = car.Model
                };

                await SendAsync(res, 200, ct);
            }
            else
            {
                await SendNotFoundAsync(ct);
            }
        }
    }
}
