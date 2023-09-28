namespace InventoryManagement.Api.RestModels.Product;

public class CreateProductRequest
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
}