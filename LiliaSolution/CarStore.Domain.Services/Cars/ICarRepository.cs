using CarStore.Domain.Models.Cars;

namespace CarStore.Domain.Services.Cars;

public interface ICarRepository
{
    //Get operations are useless without Specification pattern
    Task<Car?> GetByIdAsync(CarId id, CancellationToken cancellationToken);
    //Get operations are useless without Specification pattern
    Task<IEnumerable<Car>> GetAllAsync(CancellationToken cancellationToken);
    void Add(Car car);
    void Remove(Car car);
}
