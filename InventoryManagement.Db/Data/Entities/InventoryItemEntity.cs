namespace InventoryManagement.Db.Data.Entities;

public class InventoryItemEntity
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }
}