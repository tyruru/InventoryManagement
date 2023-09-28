using InventoryManagement.Db.Commands.Core;

namespace InventoryManagement.Db.Commands.Product.Delete;

public interface IDeleteProductCommand : INoResponseAsyncCommand<DeleteProductDto>
{
    
}