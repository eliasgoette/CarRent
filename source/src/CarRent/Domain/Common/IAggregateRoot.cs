namespace CarRent.Domain.Common
{
    public interface IAggregateRoot
    {
        IReadOnlyList<IDomainEvent> Events { get; }
    }
}
