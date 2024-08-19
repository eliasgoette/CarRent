using System;

namespace CarRent.Domain.Common
{
    public interface IRepository<TAggregate> where TAggregate : IAggregateRoot
    {
        TAggregate? FindById(Guid id);

        void Add(TAggregate item);
    }
}
