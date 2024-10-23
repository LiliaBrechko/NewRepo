using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Presentation;

public static class DependencyResolver
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}
