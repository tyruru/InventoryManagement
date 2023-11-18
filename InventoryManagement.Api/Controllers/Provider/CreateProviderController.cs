using FluentValidation;
using FluentValidation.Results;
using InventoryManagement.Api.RestModels.Provider;
using InventoryManagement.Db.Cqrs.Provider.Commands;
using InventoryManagement.Db.Cqrs.Provider.Queries.Find;
using InventoryManagement.Db.Dtos.Provider;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Provider;

[ApiController]
[Route("Provider")]
[ApiExplorerSettings(GroupName = "Providers")]

public sealed class CreateProviderController : ControllerBase
{
    private readonly IValidator<CreateProviderRequest> _validator;
    private readonly ICreateProviderCommandHandler _createProviderCommandHandler;
    private readonly IFindProviderQueryHandler _findProviderQueryHandler;
    private readonly ILogger<CreateProviderController> _logger;
 
    public CreateProviderController(
        IValidator<CreateProviderRequest> validator,
        ICreateProviderCommandHandler createProviderCommandHandler,
        IFindProviderQueryHandler findProviderQueryHandler,
        ILogger<CreateProviderController> logger)
    {
        _validator = validator;
        _createProviderCommandHandler = createProviderCommandHandler;
        _findProviderQueryHandler = findProviderQueryHandler;
        _logger = logger;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<CreateProviderResponce>> Create([FromBody] CreateProviderRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage }));
        }

        try
        {
            CreateProviderCommand createProviderCommand = new(
                request.SupplierId,
                request.SupplierName,
                request.SupplierPhone);

            await _createProviderCommandHandler.Handle(createProviderCommand);

            ProviderInfoDto? providerInfo =
                await _findProviderQueryHandler.Handle(new FindProviderQuery(request.SupplierId));

            if (providerInfo != null)
            {
                CreateProviderResponce providerResponse = new(
                    request.SupplierId,
                    request.SupplierName,
                    request.SupplierPhone);

                return Ok(providerResponse);
            }
            else
            {
                _logger.LogError("Couldn't find Provider after creations");

                return BadRequest();
            }

        }
        catch (Exception ex)
        {
           _logger.LogError(ex, "Error occured during the Provider creation process");

           return Problem("Something went wrong");
        }
    }
}