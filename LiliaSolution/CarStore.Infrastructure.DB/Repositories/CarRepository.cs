using CarStore.Domain.Models.Cars;
using CarStore.Domain.Services.Cars;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Infrastructure.DB.Repositories;

public class CarRepository : ICarRepository
{
    private readonly CarStoreDbContext _context;

    public CarRepository(CarStoreDbContext context)
    {
        _context = context;
    }

    //Get operations are useless without Specification pattern
    public async Task<Car?> GetByIdAsync(CarId id, CancellationToken cancellationToken)
    {
        return await _context.Cars
            .FirstOrDefaultAsync(car => car.Id == id, cancellationToken);
    }

    //Get operations are useless without Specification pattern
    public async Task<IEnumerable<Car>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.Cars.ToListAsync(cancellationToken);
    }

    public void Add(Car car)
    {
        _context.Cars.Add(car);
    }

    public void Remove(Car car)
    {
        _context.Cars.Remove(car);
    }
}
