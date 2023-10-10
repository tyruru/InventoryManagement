using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Data.Repositories.ProductiId;

public interface IProductRepository : IRepository
{
    Task Create(ProductEntity entity);

    Task<ProductEntity?> FindSingle(int productId);
}