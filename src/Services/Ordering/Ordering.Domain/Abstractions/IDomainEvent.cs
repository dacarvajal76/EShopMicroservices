﻿using MediatR;

namespace Ordering.Domain.Abstractions
{
    public interface IDomainEvent : INotification
    {
        // Marker interface for domain events
        Guid EventId => Guid.NewGuid();

        public DateTime OccurredOn => DateTime.Now;

        public string EventType => GetType().AssemblyQualifiedName!;
    }
    
}
