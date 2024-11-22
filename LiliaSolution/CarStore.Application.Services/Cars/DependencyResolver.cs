using CarStore.Application.Services.Cars.Commands.CreateCar;
using CarStore.Application.Services.Cars.Queries.GetCarById;
using CarStore.Application.Services.Primitives;
using CarStore.Application.Services.ServicesForTest;
using Microsoft.Extensions.DependencyInjection;

namespace CarStore.Application.Services.Cars;

public static class DependencyResolver
{
    public static IServiceCollection AddCarApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<ICommandHandler<CreateCarCommand, Guid>, CreateCarCommandHandler>();
        services.AddTransient<ICarService, CarService>();

        return services;
    }
}
