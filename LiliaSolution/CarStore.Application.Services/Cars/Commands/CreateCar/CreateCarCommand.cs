using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;

namespace CarStore.Application.Services.Cars.Commands.CreateCar;

public record CreateCarCommand(Money InitialPrice, CarMark Mark) : ICommand<Guid>;
