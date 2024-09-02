﻿using CarRent.Domain.Common;

namespace CarRent.Domain.Cars
{
    public class Car : Entity, IAggregateRoot
    {
        public CarModel Model { get; set; }
        public IReadOnlyList<IDomainEvent> Events { get; }
    }
}
