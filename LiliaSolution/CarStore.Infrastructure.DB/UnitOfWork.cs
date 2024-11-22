using CarStore.Domain.Models.Primitives;
using CarStore.Domain.Services;
using CarStore.Domain.Services.DomainEvents;

namespace CarStore.Infrastructure.DB;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly CarStoreDbContext _context;
    private readonly DomainEventDispatcher _domainEventDispatcher;

    public UnitOfWork(CarStoreDbContext context, DomainEventDispatcher domainEventDispatcher)
    {
        _context = context;
        _domainEventDispatcher = domainEventDispatcher;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Get all entities that have domain events.
        var domainEntities = _context.ChangeTracker
            .Entries<Entity>()
            .Where(x => x.Entity.Events.Any())
            .ToList();

        // Dispatch the domain events before saving the changes.
        var domainEvents = domainEntities
            .SelectMany(x => x.Entity.Events)
            .ToList();

        // After saving changes, clear the domain events.
        await _domainEventDispatcher.Dispatch(domainEvents, cancellationToken);

        var result = await _context.SaveChangesAsync(cancellationToken);

        foreach (var entity in domainEntities)
        {
            entity.Entity.ClearDomainEvents();
        }

        return result;
    }
}
