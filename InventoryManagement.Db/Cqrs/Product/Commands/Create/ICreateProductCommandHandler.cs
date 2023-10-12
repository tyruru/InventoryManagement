using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Create;

public interface ICreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    
}