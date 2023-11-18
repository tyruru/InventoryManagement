using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;

namespace InventoryManagement.Db.FactoryMethod.InventoryItem;

public class CreateInventoryItemFactory : InventoryItemFactory
{
    public override CreateInventoryItemCommand CreateInventoryItemCommandAsync(int inventoryItemId, int productId,
        int locationId, int quantity)
    {
        return new CreateInventoryItemCommand
        (
            inventoryItemId,
            productId,
            locationId,
            quantity
        );
    }
}