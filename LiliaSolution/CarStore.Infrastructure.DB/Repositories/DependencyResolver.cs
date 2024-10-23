using CarStore.Application.Services.Cars.Queries.GetCarById;
using CarStore.Application.Services.Primitives;
using CarStore.Domain.Services.Cars;
using CarStore.Infrastructure.DB.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Infrastructure.DB.Repositories;

public static class DependencyResolver
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ICarRepository, CarRepository>();
        services.AddTransient<IQueryHandler<GetCarByIdQuery, CarCard>, GetCarByIdQueryHandler>();
        services.AddTransient<IQueryHandler<GetCarListItemsQuery, IEnumerable<CarListItem>>, GetCarListItemsQueryHandler>();

        return services;
    }
}
