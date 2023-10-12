
using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Create;

public sealed class CreateProductCommand : ICommand
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }

    public CreateProductCommand(int productId, int price, int quantity, string name)
    {
        ProductId = productId;
        Price = price;
        Quantity = quantity;
        Name = name;
    }
}