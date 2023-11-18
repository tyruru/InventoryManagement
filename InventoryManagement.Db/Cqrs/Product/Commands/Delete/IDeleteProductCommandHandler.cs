using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Delete;

public interface IDeleteProductCommandHandler : ICommandHandler<DeleteProductCommand>
{
    
}