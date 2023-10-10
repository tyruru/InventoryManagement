namespace InventoryManagement.Db.Data.Repositories.Factory;

public interface IRepositoryFactory
{
    IRepository Instantiate<TEntity>(InventoryManagementDbContext context) where TEntity : class;
}