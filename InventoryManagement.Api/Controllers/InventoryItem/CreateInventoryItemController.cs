using System.Linq.Expressions;
using FluentValidation;
using FluentValidation.Results;
using InventoryManagement.Api.RestModels;
using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;
using InventoryManagement.Db.Cqrs.Core.InventoryItem.Queries.FindInventoryItem;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Dtos.InventoryItem;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.InventoryItem;

[ApiController]
[Route("InventoryItem")]
[ApiExplorerSettings(GroupName = "InventoryItems")]

public sealed class CreateInventoryItemController : ControllerBase
{
    private readonly IValidator<CreateInventoryItemRequest> _validator;
    private readonly ICreateInventoryItemCommandHandler _createInventoryItemCommandHandler;
    private readonly IFindInventoryItemQueryHandler _findInventoryItemQueryHandler;
    private readonly ILogger<CreateInventoryItemController> _logger;
 
    public CreateInventoryItemController(
        IValidator<CreateInventoryItemRequest> validator,
        ICreateInventoryItemCommandHandler createInventoryItemCommandHandler,
        IFindInventoryItemQueryHandler findInventoryItemQueryHandler,
        ILogger<CreateInventoryItemController> logger)
    {
        _validator = validator;
        _createInventoryItemCommandHandler = createInventoryItemCommandHandler;
        _findInventoryItemQueryHandler = findInventoryItemQueryHandler;
        _logger = logger;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<CreateInventoryItemResponse>> Create([FromBody] CreateInventoryItemRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage }));
        }

        try
        {
            CreateInventoryItemCommand createInventoryItemCommand = new(
                request.InventoryItemId,
                request.ProductId,
                request.LocationId,
                request.Quantity);

            await _createInventoryItemCommandHandler.Handle(createInventoryItemCommand);

            InventoryItemInfoDto? inventoryItemInfo =
                await _findInventoryItemQueryHandler.Handle(new FindInventoryItemQuery(request.InventoryItemId));

            if (inventoryItemInfo != null)
            {
                CreateInventoryItemResponse inventoryItemResponse = new(
                    inventoryItemInfo.InventoryItemId,
                    inventoryItemInfo.ProductId,
                    inventoryItemInfo.LocationId,
                    inventoryItemInfo.Quantity);

                return Ok(inventoryItemResponse);
            }
            else
            {
                _logger.LogError("Couldn't find InventoryItem after creations");

                return BadRequest();
            }

        }
        catch (Exception ex)
        {
           _logger.LogError(ex, "Error occured during the InventoryItem creation process");
           
           return Problem("Something went wrong");

        }
    }
}