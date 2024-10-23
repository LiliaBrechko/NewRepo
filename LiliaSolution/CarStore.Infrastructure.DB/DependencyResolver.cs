using CarStore.Domain.Services;
using CarStore.Infrastructure.DB.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Infrastructure.DB;

public static class DependencyResolver
{
    public static IServiceCollection AddPersistenceDependencies(this IServiceCollection services)
    {
        services.AddScoped<CarStoreDbContext>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddRepositories();

        return services;
    }
}
