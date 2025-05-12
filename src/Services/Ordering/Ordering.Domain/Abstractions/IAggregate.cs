
namespace Ordering.Domain.Abstractions
{

    public interface IAggregate<T> : IAggregate, IEntity<T>
    {
        // Marker interface for aggregates
        // This interface inherits from IAggregate and IEntity<T>
        // to enforce the implementation of both interfaces in aggregate classes.
    }
    public interface IAggregate : IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }

        IDomainEvent[] ClearDomainEvents();
    }
}
