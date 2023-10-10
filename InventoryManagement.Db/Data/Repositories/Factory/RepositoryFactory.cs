using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.InventoryItem;
using InventoryManagement.Db.Data.Repositories.Location;
using InventoryManagement.Db.Data.Repositories.ProductiId;
using InventoryManagement.Db.Data.Repositories.Provider;
using InventoryManagement.Db.Exception;


namespace InventoryManagement.Db.Data.Repositories.Factory;

public class RepositoryFactory : IRepositoryFactory
{
    public IRepository Instantiate<TEntity>(InventoryManagementDbContext context) where TEntity : class
    {
        return typeof(TEntity).Name switch
        {
            nameof(InventoryItemEntity) => new InventoryItemRepository(context),
            nameof(LocationEntity) => new LocationRepository(context),
            nameof(ProductEntity) => new ProductRepository(context),
            nameof(ProviderEntity) => new ProviderRepository(context),
            _ => throw new UnsupportedRepositoryTypeException(typeof(TEntity).Name)
        };
    }
}