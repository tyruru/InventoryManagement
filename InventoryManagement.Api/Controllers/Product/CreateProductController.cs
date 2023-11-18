using FluentValidation;
using FluentValidation.Results;
using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Db.Cqrs.Product.Commands.Create;
using InventoryManagement.Db.Cqrs.Product.Queries.Find;
using InventoryManagement.Db.Dtos.Product;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Product;

[ApiController]
[Route("Product")]
[ApiExplorerSettings(GroupName = "Products")]

public sealed class CreateProductController : ControllerBase
{
    private readonly IValidator<CreateProductRequest> _validator;
    private readonly ICreateProductCommandHandler _createProductCommandHandler;
    private readonly IFindProductQueryHandler _findProductQueryHandler;
    private readonly ILogger<CreateProductController> _logger;
 
    public CreateProductController(
        IValidator<CreateProductRequest> validator,
        ICreateProductCommandHandler createProductCommandHandler,
        IFindProductQueryHandler findProductQueryHandler,
        ILogger<CreateProductController> logger)
    {
        _validator = validator;
        _createProductCommandHandler = createProductCommandHandler;
        _findProductQueryHandler = findProductQueryHandler;
        _logger = logger;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<CreateProductResponse>> Create([FromBody] CreateProductRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage }));
        }

        try
        {
            CreateProductCommand createProductCommand = new(
                request.ProductId,
                request.Price,
                request.Quantity,
                request.Name);

            await _createProductCommandHandler.Handle(createProductCommand);

            ProductInfoDto? productInfo =
                await _findProductQueryHandler.Handle(new FindProductQuery(request.ProductId));

            if (productInfo != null)
            {
                CreateProductResponse productResponse = new(
                    request.ProductId,
                    request.Price,
                    request.Quantity,
                    request.Name);

                return Ok(productResponse);
            }
            else
            {
                _logger.LogError("Couldn't find Product after creations");

                return BadRequest();
            }

        }
        catch (Exception ex)
        {
           _logger.LogError(ex, "Error occured during the Product creation process");

           return Problem("Something went wrong");
        }
    }
}