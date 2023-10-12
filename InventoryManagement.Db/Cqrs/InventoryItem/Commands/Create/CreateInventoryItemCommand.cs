using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;

public sealed class CreateInventoryItemCommand : ICommand
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }

    public CreateInventoryItemCommand(int inventoryItemId, int productId, int locationId, int quantity)
    {
        InventoryItemId = inventoryItemId;
        ProductId = productId;
        LocationId = locationId;
        Quantity = quantity;
    }
}