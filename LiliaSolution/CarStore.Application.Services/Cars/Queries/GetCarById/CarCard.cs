namespace CarStore.Application.Services.Cars.Queries.GetCarById;

public record CarCard(Guid Id, CarPrice price, string Mark, bool IsNew);
