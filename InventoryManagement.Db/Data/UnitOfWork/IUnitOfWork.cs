using InventoryManagement.Db.Data.Repositories;

namespace InventoryManagement.Db.Data.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    Task Commit();

    IRepository Repository<TEntity>() where TEntity : class;
}