using CarStore.Domain.Models.Primitives;

namespace CarStore.Domain.Models.Cars;

public record CarCreatedEvent(Guid Id, Car Car) : DomainEvent(Id, DateTime.UtcNow);
