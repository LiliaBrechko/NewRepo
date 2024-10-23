using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;

namespace CarStore.Domain.Services.Cars;

//It is not static helper. This is a service.
//It can have dependencies on other domain level services. For example CountryTaxService - some service that will return taxes
//Depending or country where you want to buy a car.
public class CarStoreService
{
    public Money GetPrice(Car car)
    {
        //Here we can have domain logic that will count car price depending on the YEAR it was made, depending on taxes in each country returned from some CountryTaxService
        //No call to repositories or some other external systems. Pure domain logic.
        //If this logic doesn't require any info from other entities like countries and taxes, and contains only logic dependent on car info
        //then this method can be placed directly to the Car entity where it naturally belongs in this case

        return car.IsNew ? car.InitialPrice : new Money(car.InitialPrice.Amount * 0.8, car.InitialPrice.Currency);
    }
}
