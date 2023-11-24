namespace InventoryManagement.Db.Builder;

public sealed class ProductDirector
{
    private readonly IProductBuilder _builder;

    public ProductDirector(IProductBuilder builder)
    {
        _builder = builder;
    }

    public void Construct(string name, int price, int quantity)
    {
        _builder.SetName(name);
        _builder.SetPrice(price);
        _builder.SetQuantity(quantity);
    }
}