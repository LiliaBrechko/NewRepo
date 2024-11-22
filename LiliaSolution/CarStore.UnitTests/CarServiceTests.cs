using CarStore.Application.Services.ServicesForTest;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;
using CarStore.Domain.Services;
using CarStore.Domain.Services.Cars;
using FluentAssertions;
using Moq;
using Xunit;

namespace CarStore.UnitTests;

public class CarServiceTests
{
    private readonly Mock<ICarRepository> _mockCarRepository;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly ICarService _carService;

    public CarServiceTests()
    {
        _mockCarRepository = new Mock<ICarRepository>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();

        _carService = new CarService(_mockCarRepository.Object, _mockUnitOfWork.Object);
    }

    [Fact]
    public async Task UpdateCar_WrongCurrency_ThrowsExactError()
    {
        //ARRANGE
        var carId = new CarId(Guid.NewGuid());
        var car = Car.Create(carId, new Money(12, Currency.USD), CarMark.Audi, DateTime.Now);

        _mockCarRepository.Setup(repo => repo.GetByIdAsync(carId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(car);

        //ACT
        var act = async () => await _carService.UpdateCarAsync(carId.Value, new UpdateCarDto(new Money(12, Currency.GBP)), CancellationToken.None);

        //ASSERT
        await act.Should().ThrowAsync<Exception>().WithMessage("Wrong Currency");
    }
}
