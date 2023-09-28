using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Commands.InventoryItem.Create;

public class CreateInventoryItemDto
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }

    public CreateInventoryItemDto(int inventoryItemId, int productId, int locationId, int quantity)
    {
        InventoryItemId = inventoryItemId;
        ProductId = productId;
        LocationId = locationId;
        Quantity = quantity;
    }
}
