using CarStore.Domain.Models.Cars;

namespace CarStore.Domain.Models.Exceptions;

//To be thrown on application layer when we attempt to fetch a Car from DB
public sealed class CarNotFoundException: Exception
{
    public CarId CarId { get; private set; }

    public CarNotFoundException(CarId carId)
        : base($"Car with id '{carId.Value}' not found.")
    {
        CarId = carId;
    }
}
