using FluentValidation;
using FluentValidation.Results;
using InventoryManagement.Api.RestModels.Location;
using InventoryManagement.Db.Cqrs.Location.Commands.Create;
using InventoryManagement.Db.Cqrs.Location.Queries.FindLocation;
using InventoryManagement.Db.Dtos.Location;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Location;

[ApiController]
[Route("Location")]
[ApiExplorerSettings(GroupName = "Locations")]

public sealed class CreateLocationController : ControllerBase
{
    private readonly IValidator<CreateLocationRequest> _validator;
    private readonly ICreateLocationCommandHandler _createLocationCommandHandler;
    private readonly IFindLocationQueryHandler _findLocationQueryHandler;
    private readonly ILogger<CreateLocationController> _logger;
 
    public CreateLocationController(
        IValidator<CreateLocationRequest> validator,
        ICreateLocationCommandHandler createLocationCommandHandler,
        IFindLocationQueryHandler findLocationQueryHandler,
        ILogger<CreateLocationController> logger)
    {
        _validator = validator;
        _createLocationCommandHandler = createLocationCommandHandler;
        _findLocationQueryHandler = findLocationQueryHandler;
        _logger = logger;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<CreateLocationResponse>> Create([FromBody] CreateLocationRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage }));
        }

        try
        {
            CreateLocationCommand createLocationCommand = new(
                request.LocationId,
                request.LocationName,
                request.LocationAddress);

            await _createLocationCommandHandler.Handle(createLocationCommand);

            LocationInfoDto? locationInfo =
                await _findLocationQueryHandler.Handle(new FindLocationQuery(request.LocationId));

            if (locationInfo != null)
            {
                CreateLocationResponse locationResponse = new(
                    request.LocationId,
                    request.LocationName,
                    request.LocationAddress);

                return Ok(locationResponse);
            }
            else
            {
                _logger.LogError("Couldn't find Location after creations");

                return BadRequest();
            }

        }
        catch (Exception ex)
        {
           _logger.LogError(ex, "Error occured during the Location creation process");

           return Problem("Something went wrong");
        }
    }
}