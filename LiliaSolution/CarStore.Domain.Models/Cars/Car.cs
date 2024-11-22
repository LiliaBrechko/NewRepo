using CarStore.Domain.Models.Primitives;
using CarStore.Domain.Models.ValueObjects;

namespace CarStore.Domain.Models.Cars;

public class Car : Entity
{
    public CarId Id { get; private set; }
    public Money InitialPrice { get; set; }
    public CarMark Mark { get; private set; }
    public DateTime Created { get; private set; }
    public bool IsNew
    {
        get
        {
            //add some more logic dependent on month and day
            return Created.Year == DateTime.UtcNow.Year;
        }
    }

    // Private constructor for EF Core.
    private Car() { }

    public static Car Create(CarId id, Money initialPrice, CarMark mark, DateTime created)
    {
        //Add validation for example for price and created date

        var car = new Car
        {
            Id = id,
            InitialPrice = initialPrice,
            Mark = mark,
            Created = created
        };

        car.Raise(new CarCreatedEvent(Guid.NewGuid(), car));

        return car;
    }
}
