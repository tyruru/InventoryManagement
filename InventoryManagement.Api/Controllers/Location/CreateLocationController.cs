using InventoryManagement.Api.RestModels.Location;
using InventoryManagement.Db.Commands.Location.Create;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Location;

[ApiController]
[Route("Location")]
[ApiExplorerSettings(GroupName = "Locations")]

public sealed class CreateLocationController : ControllerBase
{
    private readonly ICreateLocationCommand _createLocationCommand;

    public CreateLocationController(ICreateLocationCommand createLocationCommand)
    {
        _createLocationCommand = createLocationCommand;
    }

    [HttpPost("Create")]

    public async Task<IActionResult> Create([FromBody] CreateLocationRequest request)
    {

        CreateLocationDto dto = new(
            request.LocationId,
            request.LocationName,
            request.LocationAddress);

        await _createLocationCommand.Execute(dto);

        return Ok();
        
    }

}