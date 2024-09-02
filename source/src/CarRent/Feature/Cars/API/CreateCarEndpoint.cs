using CarRent.Domain.Cars;
using CarRent.Domain.Common;
using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class CreateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private IUnitOfWork _unitOfWork;
        private ICarRepository _repository;

        public CreateCarEndpoint(IUnitOfWork unitOfWork, ICarRepository repository)
        {
            _unitOfWork = unitOfWork;
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
                Model = req.Model
            };

            _repository.Add(newCar);
            _unitOfWork.Commit();

            var res = new CarResponse
            {
                Id = newCar.Id,
                Model = newCar.Model
            };

            await SendAsync(res, 200, ct);
        }
    }
}
