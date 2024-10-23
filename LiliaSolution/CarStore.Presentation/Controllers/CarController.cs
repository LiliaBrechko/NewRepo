using CarStore.Application.Services.Cars.Commands.CreateCar;
using CarStore.Application.Services.Cars.Queries.GetCarById;
using CarStore.Application.Services.Primitives;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarStore.Presentation.Controllers;

[ApiController]
[Route("api/cars")]
public class CarController : ControllerBase
{
    private readonly ILogger<CarController> logger;
    private readonly ICommandHandler<CreateCarCommand, Guid> commandHandler;
    private readonly IQueryHandler<GetCarByIdQuery, CarCard> carByIdQueryHandler;
    private readonly IQueryHandler<GetCarListItemsQuery, IEnumerable<CarListItem>> carListItemsQueryHandler;

    public CarController(ILogger<CarController> logger, ICommandHandler<CreateCarCommand, Guid> commandHandler, IQueryHandler<GetCarByIdQuery, CarCard> carByIdQueryHandler, IQueryHandler<GetCarListItemsQuery, IEnumerable<CarListItem>> carListItemsQueryHandler)
    {
        this.logger = logger;
        this.commandHandler = commandHandler;
        this.carByIdQueryHandler = carByIdQueryHandler;
        this.carListItemsQueryHandler = carListItemsQueryHandler;
    }

    [HttpGet, Route("{id}")]
    [ProducesResponseType(typeof(CarCard), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCar(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetCarByIdQuery(new CarId(id));

        var carCard = await carByIdQueryHandler.Handle(query, cancellationToken);

        return Ok(carCard);
    }

    [HttpGet, Route("")]
    [ProducesResponseType(typeof(IEnumerable<CarListItem>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCars(CancellationToken cancellationToken)
    {
        var query = new GetCarListItemsQuery();

        var carListItems = await carListItemsQueryHandler.Handle(query, cancellationToken);

        return Ok(carListItems);
    }

    [HttpPost, Route("")]
    [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCar([FromBody] CreateCarRequest request, CancellationToken cancellationToken)
    {
        var command = new CreateCarCommand(new Money(request.Amount, request.Currency), request.Mark);

        var carId = await commandHandler.Handle(command, cancellationToken);

        return Ok(carId);
    }
}
