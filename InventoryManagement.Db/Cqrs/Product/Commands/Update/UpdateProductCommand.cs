using ICommand = InventoryManagement.Db.Cqrs.Core.Command.ICommand;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Update;

public class UpdateProductCommand : ICommand
{
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }

    public UpdateProductCommand(int productId, float price, int quantity, string name)
    {
        
    }
}