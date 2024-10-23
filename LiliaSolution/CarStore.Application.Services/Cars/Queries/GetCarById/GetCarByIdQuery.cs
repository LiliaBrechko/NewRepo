using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Cars;

namespace CarStore.Application.Services.Cars.Queries.GetCarById;

public record GetCarByIdQuery(CarId Id) : IQuery<CarCard>;
