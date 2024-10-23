using CarStore.Domain.Models.Cars;
using CarStore.Domain.Services.DomainEvents;

namespace CarStore.Domain.Services.Cars;

public class CarCreatedEventHandler : IDomainEventHandler<CarCreatedEvent>
{
    public Task Handle(CarCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        // Logic to handle the car created event.
        // Notice that this is a domain event. We don't use any external systems to Send Email, SMS, etc here (This is the responsibility of integration events via service bus). 
        // This handler should work only with domain layer logic 

        Console.WriteLine($"Car '{domainEvent.Car.Mark}' with price: '{domainEvent.Car.InitialPrice.Amount} {domainEvent.Car.InitialPrice.Currency}' created.");

        return Task.CompletedTask;
    }
}
