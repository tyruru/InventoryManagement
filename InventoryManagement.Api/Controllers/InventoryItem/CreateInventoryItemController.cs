using InventoryManagement.Api.RestModels;
using InventoryManagement.Db.Commands.InventoryItem.Create;
using InventoryManagement.Db.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.InventoryItem;

[ApiController]
[Route("InventoryItem")]
[ApiExplorerSettings(GroupName = "InventoryItems")]

public sealed class CreateInventoryItemController : ControllerBase
{
    private readonly ICreateInventoryItemCommand _createInventoryItem;

    public CreateInventoryItemController(ICreateInventoryItemCommand createInventoryItem)
    {
        _createInventoryItem = createInventoryItem;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateInventoryItemRequest request)
    {
        
        CreateInventoryItemDto dto = new CreateInventoryItemDto(
            request.InventoryItemId,
            request.ProductId,
            request.LocationId,
            request.Quantity);
        
        await _createInventoryItem.Execute(dto);

        return Ok();
    }
}