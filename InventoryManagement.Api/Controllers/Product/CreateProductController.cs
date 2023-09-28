using System.Security.AccessControl;
using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Db.Commands.Product.Create;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Product;

[ApiController]
[Route("Product")]
[ApiExplorerSettings(GroupName = "Products")]

public class CreateProductController : ControllerBase
{
    private readonly ICreateProductCommand _createProductCommand;

    public CreateProductController(ICreateProductCommand createProductCommand)
    {
        _createProductCommand = createProductCommand;
    }

    [HttpPost("Create")]

    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        CreateProductDto dto = new(
            request.ProductId,
            request.Price,
            request.Quantity,
            request.Name);

        await _createProductCommand.Execute(dto);

        return Ok();
    }
}