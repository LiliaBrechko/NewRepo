using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Services;
using CarStore.Domain.Services.Cars;

namespace CarStore.Application.Services.Cars.Commands.CreateCar;

public class CreateCarCommandHandler : ICommandHandler<CreateCarCommand, Guid>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly ICarRepository carRepository;

    public CreateCarCommandHandler(IUnitOfWork unitOfWork, ICarRepository carRepository)
    {
        this.unitOfWork = unitOfWork;
        this.carRepository = carRepository;
    }

    public async Task<Guid> Handle(CreateCarCommand command, CancellationToken cancellationToken)
    {
        var car = Car.Create(new CarId(Guid.NewGuid()), command.InitialPrice, command.Mark, DateTime.UtcNow);

        carRepository.Add(car);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return car.Id.Value;
    }
}
