using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;

namespace InventoryManagement.Db.FactoryMethod.InventoryItem;

public abstract class InventoryItemFactory
{
    public abstract CreateInventoryItemCommand CreateInventoryItemCommandAsync(int inventoryItemId, int productId, int locationId, int quantity);
}