using System.Collections.Concurrent;
using InventoryManagement.Db.Data.Repositories;
using InventoryManagement.Db.Data.Repositories.Factory;
using Microsoft.EntityFrameworkCore.Storage;

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
        await using IDbContextTransaction transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (System.Exception ex)
        {
            await transaction.RollbackAsync();
            
            throw;
        }
        
    }

    public IRepository Repository<TEntity>() where TEntity : class
    {
        if (!_repositories.TryGetValue(typeof(TEntity), out object? repository))
        {
            repository = _repositoryFactory.Instantiate<TEntity>(_context);
            _repositories.TryAdd(typeof(TEntity), repository);
        }

        return (IRepository)repository;
    }
    
    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}