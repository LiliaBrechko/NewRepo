using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Domain.Services.DomainEvents;

public static class DependencyResolver
{
    public static IServiceCollection AddDomainEventDispatcher(this IServiceCollection services)
    {
        services.AddSingleton<DomainEventDispatcher>();

        return services;
    }
}
