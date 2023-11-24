using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Builder;

public interface IProductBuilder
{
    void SetPrice(int price);
    void SetQuantity(int quantity);
    void SetName(string name);

    ProductEntity GetResult();
}