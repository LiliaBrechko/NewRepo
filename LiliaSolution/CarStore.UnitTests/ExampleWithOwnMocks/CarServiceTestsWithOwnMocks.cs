using CarStore.Application.Services.ServicesForTest;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;
using CarStore.Domain.Services.Cars;
using CarStore.Domain.Services;
using FluentAssertions;
using Moq;
using Xunit;

namespace CarStore.UnitTests.ExampleWithOwnMocks;

public class CarServiceTestsWithOwnMocks
{
    private readonly ICarRepository _mockCarRepository;
    private readonly ICarService _carService;

    public CarServiceTestsWithOwnMocks()
    {
        _mockCarRepository = new MockedCarRepository();

        _carService = new CarService(_mockCarRepository, null);
    }

    [Fact]
    public async Task UpdateCar_WrongCurrency_ThrowsExactError()
    {
        //ARRANGE

        //ACT
        var act = async () => await _carService.UpdateCarAsync(Guid.NewGuid(), new UpdateCarDto(new Money(12, Currency.GBP)), CancellationToken.None);

        //ASSERT
        await act.Should().ThrowAsync<Exception>().WithMessage("Wrong Currency");
    }
}
