using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;

namespace CarStore.Application.Services.Cars.Commands.CreateCar;

public record CreateCarRequest(Currency Currency, double Amount, CarMark Mark) : ICommand<Guid>;
