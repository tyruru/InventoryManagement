using System.Reflection.Metadata.Ecma335;

namespace InventoryManagement.Db.Data.Entities;

public class ProductEntity
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
}