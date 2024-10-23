using CarStore.Application.Services.Cars.Queries.GetCarById;
using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Infrastructure.DB.Handlers;

public class GetCarListItemsQueryHandler : IQueryHandler<GetCarListItemsQuery, IEnumerable<CarListItem>>
{

    private readonly CarStoreDbContext _context;

    public GetCarListItemsQueryHandler(CarStoreDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CarListItem>> Handle(GetCarListItemsQuery query, CancellationToken cancellationToken)
    {
        //I don't need all the info from Car table. Only fields for CarCard. That's why it is useless without Specification pattern.
        var cars = await Task.FromResult(_context.Cars.Select(x => new CarListItem(x.Id.Value, x.Mark.ToString())));

        return cars;
    }
}
