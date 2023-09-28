using InventoryManagement.Db.Commands.Core;

namespace InventoryManagement.Db.Commands.Product.Create;

public interface ICreateProductCommand : INoResponseAsyncCommand<CreateProductDto>
{
    
}