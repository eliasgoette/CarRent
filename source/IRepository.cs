using System;

public interface IRepository<IAggregate> where IAggregate : IAggregateRoot
{
	TAggregate? FindById(Guid id);

	void Add(IAggregate item);
}
