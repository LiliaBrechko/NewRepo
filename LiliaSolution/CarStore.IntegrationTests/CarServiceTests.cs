using CarStore.Application.Services.ServicesForTest;
using CarStore.Domain.Services;
using CarStore.Domain.Services.Cars;
using CarStore.Infrastructure.DB;
using Microsoft.Extensions.DependencyInjection;
using CarStore.Application.Services;
using CarStore.Presentation;
using Xunit;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;
using FluentAssertions;

namespace CarStore.IntegrationTests;

public class CarServiceTests
{
    private readonly ICarRepository _carRepository;
    private readonly ICarService _carService;
    private readonly IServiceProvider serviceProvider;

    public CarServiceTests()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddDomainServices()
            .AddApplicationServices()
            .AddPersistenceDependencies()
            .AddPresentation();

        // Build service provider
        serviceProvider = serviceCollection.BuildServiceProvider();

        _carService = serviceProvider.GetRequiredService<ICarService>();
        _carRepository = serviceProvider.GetRequiredService<ICarRepository>();
    }

    [Fact]
    public async Task AddCarAsync_StoresCarInRepository()
    {
        // Arrange
        var createCarDto = new CreateCarDto(new Money(12, Currency.EUR), CarMark.Audi);

        // Act
        var carId = await _carService.AddCarAsync(createCarDto, CancellationToken.None);

        // Assert
        var actualCar = await _carRepository.GetByIdAsync(carId, CancellationToken.None);
        actualCar.InitialPrice.Amount.Should().Be(12);
        actualCar.InitialPrice.Currency.Should().Be(Currency.EUR);
        actualCar.Mark.Should().Be(CarMark.Audi);
    }

    [Fact]
    public async Task UpdateCarAsync_StoresCarChangesInRepository()
    {
        // Arrange
        var createCarDto = new CreateCarDto(new Money(12, Currency.EUR), CarMark.Audi);
        var carId = await _carService.AddCarAsync(createCarDto, CancellationToken.None);

        // Act
        await _carService.UpdateCarAsync(carId.Value, new UpdateCarDto(new Money(15, Currency.EUR)), CancellationToken.None);

        // Assert
        var actualCar = await _carRepository.GetByIdAsync(carId, CancellationToken.None);
        actualCar.InitialPrice.Amount.Should().Be(15);
        actualCar.InitialPrice.Currency.Should().Be(Currency.EUR);
        actualCar.Mark.Should().Be(CarMark.Audi);
    }
}
