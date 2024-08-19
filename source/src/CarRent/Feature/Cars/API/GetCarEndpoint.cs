using FastEndpoints;

namespace CarRent.Feature.Cars.API
{
    public class GetCarEndpoint : EndpointWithoutRequest<CarResponse>
    {
        public override void Configure()
        {
            Get("/cars");
        }

        public override Task HandleAsync(CancellationToken ct)
        {
            return base.HandleAsync(ct);
        }
    }
}
