using CarStore.Domain.Models.Primitives;

namespace CarStore.Domain.Services.DomainEvents;

public class DomainEventDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public DomainEventDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task Dispatch(IEnumerable<DomainEvent> domainEvents, CancellationToken cancellationToken)
    {
        foreach (var domainEvent in domainEvents)
        {
            // Find the appropriate handler for each domain event.
            var handlerType = typeof(IDomainEventHandler<>).MakeGenericType(domainEvent.GetType());
            var handlers = (IEnumerable<object>)_serviceProvider.GetService(typeof(IEnumerable<>).MakeGenericType(handlerType));

            foreach (var handler in handlers)
            {
                // Cast the handler to the correct type based on the event type
                var method = handlerType.GetMethod("Handle");
                if (method != null)
                {
                    // Call the method dynamically
                    await (Task)method.Invoke(handler, new object[] { domainEvent, cancellationToken });
                }
            }
        }
    }
}
