using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Api.RestModels;


public class CreateInventoryItemRequest
{
    public int InventoryItemId { get; set; }
    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public int Quantity { get; set; }
}