using CarStore.Domain.Models.Primitives;

namespace CarStore.Domain.Services.DomainEvents;

public interface IDomainEventHandler<T> where T : DomainEvent
{
    Task Handle(T domainEvent, CancellationToken cancellationToken);
}
