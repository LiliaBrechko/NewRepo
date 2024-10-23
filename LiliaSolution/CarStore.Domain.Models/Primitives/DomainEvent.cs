namespace CarStore.Domain.Models.Primitives;

public record DomainEvent(Guid Id, DateTime OccurredOn);
