using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;
using CarStore.Domain.Services.Cars;

namespace CarStore.UnitTests.ExampleWithOwnMocks
{
    public class MockedCarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Car?> GetByIdAsync(CarId id, CancellationToken cancellationToken)
        {
            var car = Car.Create(id, new Money(12, Currency.USD), CarMark.Audi, DateTime.Now);

            return await Task.FromResult(car);
        }

        public void Remove(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
