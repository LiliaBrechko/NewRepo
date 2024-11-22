using CarStore.Domain.Models.Cars;
using CarStore.Domain.Services;
using CarStore.Domain.Services.Cars;

namespace CarStore.Application.Services.ServicesForTest
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IUnitOfWork unitOfWork;

        public CarService(ICarRepository carRepository, IUnitOfWork unitOfWork)
        {
            _carRepository = carRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Car?> GetCarByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _carRepository.GetByIdAsync(new CarId(id), cancellationToken);
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync(CancellationToken cancellationToken)
        {
            return await _carRepository.GetAllAsync(cancellationToken);
        }

        public async Task<CarId> AddCarAsync(CreateCarDto carDto, CancellationToken cancellationToken)
        {
            var car = Car.Create(new CarId(Guid.NewGuid()), carDto.InitialPrice, carDto.Mark, DateTime.UtcNow);

            _carRepository.Add(car);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return car.Id;
        }

        public async Task RemoveCarAsync(Guid id, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetByIdAsync(new CarId(id), cancellationToken);

            if (car != null)
            {
                _carRepository.Remove(car);
            }
            else
            {
                throw new KeyNotFoundException($"Car with ID {id} not found.");
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateCarAsync(Guid id, UpdateCarDto updatedCar, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetByIdAsync(new CarId(id), cancellationToken);

            if (car != null)
            {
                if (car.InitialPrice.Currency != updatedCar.newPrice.Currency)
                {
                    throw new Exception("Wrong Currency");
                }

                car.InitialPrice = updatedCar.newPrice;

            }
            else
            {
                throw new KeyNotFoundException($"Car with ID {id} not found.");
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
