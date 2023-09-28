namespace InventoryManagement.Db.Commands.Product.Create;

public class CreateProductDto
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }

    public CreateProductDto(int productId, float price, int quantity, string name)
    {
        ProductId = ProductId;
        Price = price;
        Quantity = quantity;
        Name = Name;
    }
}