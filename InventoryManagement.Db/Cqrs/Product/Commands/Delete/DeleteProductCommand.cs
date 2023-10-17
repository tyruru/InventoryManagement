using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Delete;

public class DeleteProductCommand : ICommand
{
    public int ProductId { get; }

    public DeleteProductCommand(int productId)
    {
        ProductId = productId;
    }
}