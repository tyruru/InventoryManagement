using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Builder;

public sealed class ConcreteProductBuilder : IProductBuilder
{
    private readonly ProductEntity _product = new ProductEntity();

    public void SetName(string name)
    {
        _product.Name = name;
    }

    public void SetPrice(int price)
    {
        _product.Price = price;
    }

    public void SetQuantity(int quantity)
    {
        _product.Quantity = quantity;
    }

    public ProductEntity GetResult()
    {
        return _product;
    }
}