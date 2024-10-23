using CarStore.Domain.Services.Cars;
using CarStore.Domain.Services.DomainEvents;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Domain.Services;

public static class DependencyResolver
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddCarDomainServices();
        services.AddDomainEventDispatcher();

        return services;
    }
}
