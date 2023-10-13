using InventoryManagement.Api.RestModels.Provider;

namespace InventoryManagement.Api.RestModels.Product;

public class CreateProductResponse
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }

    public CreateProductResponse(int productId, float price, int quantity, string name)
    {
        ProductId = productId;
        Price = price;
        Quantity = quantity;
        Name = name;
    }
}