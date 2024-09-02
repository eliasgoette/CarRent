using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CarRent.Domain.Common
{
    public abstract class Entity
    {
        private Guid id;
        private List<IDomainEvent> domainEvents;

        protected Entity()
        {
            id = Guid.NewGuid();
        }

        public Guid Id { get { return id; } }

        public List<IDomainEvent> DomainEvents { get { return domainEvents; } }

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            domainEvents.Add(domainEvent);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Entity other)
        {
            return other is not null && id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
