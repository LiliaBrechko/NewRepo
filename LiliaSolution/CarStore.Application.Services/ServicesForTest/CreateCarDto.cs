using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;

namespace CarStore.Application.Services.ServicesForTest;

public record CreateCarDto(Money InitialPrice, CarMark Mark);
