using System.Collections.Concurrent;
using InventoryManagement.Db.Data.Repositories;
using InventoryManagement.Db.Data.Repositories.Factory;

namespace InventoryManagement.Db.Data.UnitOfWork;

public class UnitOfWork
{
    private readonly InventoryManagementDbContext _context;
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ConcurrentDictionary<Type, object> _repositories;

    public UnitOfWork(InventoryManagementDbContext context, IRepositoryFactory repositoryFactory)
    {
        _context = context;
        _repositoryFactory = repositoryFactory;
        _repositories = new ConcurrentDictionary<Type, object>();
    }

    public async Task Commit()
    {
        
    }
}