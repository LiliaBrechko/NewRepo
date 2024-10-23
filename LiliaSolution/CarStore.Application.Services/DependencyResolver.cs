using CarStore.Application.Services.Cars;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Application.Services;

public static class DependencyResolver
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddCarApplicationServices();

        return services;
    }
}
