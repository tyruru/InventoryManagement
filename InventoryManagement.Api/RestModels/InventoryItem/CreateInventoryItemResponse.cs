namespace InventoryManagement.Api.RestModels;

public class CreateInventoryItemResponse
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }

    public CreateInventoryItemResponse(int inventoryItemId, int productId, int locationId, int quantity)
    {
        InventoryItemId = inventoryItemId;
        ProductId = productId;
        LocationId = locationId;
        Quantity = quantity;
    }
}