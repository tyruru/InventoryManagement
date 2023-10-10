using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Db.Data.Repositories.Provider;

public class ProviderRepository : IProviderRepository
{
    private readonly InventoryManagementDbContext _context;

    public ProviderRepository(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Create(ProviderEntity entity)
    {
        await _context.Providers.AddAsync(entity);
    }

    public async Task<ProviderEntity?> FindSingle(int supplierId)
    {
        return await _context.Providers.SingleOrDefaultAsync(p => p.SupplierId == supplierId);
    }
}