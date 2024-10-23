using CarStore.Domain.Models.Cars;
using CarStore.Domain.Services.DomainEvents;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Domain.Services.Cars;

public static class DependencyResolver
{
    public static IServiceCollection AddCarDomainServices(this IServiceCollection services)
    {
        services.AddSingleton<CarStoreService>();
        services.AddTransient<IDomainEventHandler<CarCreatedEvent>, CarCreatedEventHandler>();

        return services;
    }
}
