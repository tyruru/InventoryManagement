using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Db.Cqrs.Product.Commands.Delete;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Product;
 
[ApiController]
[Route("Product")]
[ApiExplorerSettings(GroupName = "Products")]
public sealed class DeleteProductController : ControllerBase
{
    private readonly IDeleteProductCommandHandler _deleteProductCommandHandler;

    public DeleteProductController(IDeleteProductCommandHandler deleteProductCommandHandler)
    {
        _deleteProductCommandHandler = deleteProductCommandHandler;
    }

    [HttpDelete("Delete")]

    public async Task<ActionResult<DeleteProductResponse>> Delete([FromBody] DeleteProductRequest request)
    {
        try
        {
            DeleteProductCommand deleteProductCommand = new(request.ProductId);

            await _deleteProductCommandHandler.Handle(deleteProductCommand);
            return Ok("Account was deleted");
        }
        catch (Exception ex)
        {
            return BadRequest($"Account was not deleted: {ex.Message}");
        }
    }
}