using CarStore.Application.Services.Cars.Queries.GetCarById;
using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Infrastructure.DB.Handlers;

public class GetCarByIdQueryHandler : IQueryHandler<GetCarByIdQuery, CarCard>
{

    private readonly CarStoreDbContext _context;

    public GetCarByIdQueryHandler(CarStoreDbContext context)
    {
        _context = context;
    }

    public async Task<CarCard> Handle(GetCarByIdQuery query, CancellationToken cancellationToken)
    {
        //I don't need all the info from Car table. Only fields for CarCard. That's why it is useless without Specification pattern.
        var car = await _context.Cars.FirstOrDefaultAsync(x => x.Id == query.Id, cancellationToken);

        if (car == null)
        {
            throw new CarNotFoundException(query.Id);
        }

        return new CarCard(car.Id.Value, new CarPrice(car.InitialPrice.Amount, car.InitialPrice.Currency.ToString()), car.Mark.ToString(), car.IsNew);
    }
}
