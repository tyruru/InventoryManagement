namespace InventoryManagement.Db.Dtos.InventoryItem;

public sealed class InventoryItemInfoDto
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }
    
    
    public InventoryItemInfoDto(int inventoryItemId, int productId, int locationId, int quantity)
    {
        InventoryItemId = inventoryItemId;
        ProductId = productId;
        LocationId = locationId;
        Quantity = quantity;
    }
}