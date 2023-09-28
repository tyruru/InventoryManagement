using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Db.Commands.Product.Delete;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Product;
 
public class DeleteProductController : ControllerBase
{
    private readonly IDeleteProductCommand _deleteProductCommand;

    public DeleteProductController(IDeleteProductCommand deleteProductCommand)
    {
        _deleteProductCommand = deleteProductCommand;
    }

    [HttpDelete("Delete")]

    public async Task<IActionResult> Delete([FromBody] DeleteProductRequest request)
    {
        DeleteProductDto dto = new(
            request.ProductId);

        
        await _deleteProductCommand.Execute(dto);
        return Ok();
    }
}