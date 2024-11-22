using CarStore.Domain.Models.Cars;

namespace CarStore.Application.Services.ServicesForTest;

public interface ICarService
{
    Task<Car?> GetCarByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<Car>> GetAllCarsAsync(CancellationToken cancellationToken);
    Task<CarId> AddCarAsync(CreateCarDto car, CancellationToken cancellationToken);
    Task RemoveCarAsync(Guid id, CancellationToken cancellationToken);
    Task UpdateCarAsync(Guid id, UpdateCarDto updatedCar, CancellationToken cancellationToken);
}
