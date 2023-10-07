namespace InventoryManagement.Db.Dtos.Product;

public sealed class ProductInfoDto
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }

    public ProductInfoDto(int productId, int price, int quantity, string name)
    {
        ProductId = productId;
        Price = price;
        Quantity = quantity;
        Name = name;
    }
}