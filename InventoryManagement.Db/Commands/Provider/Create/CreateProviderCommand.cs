using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Commands.Provider;

public class CreateProviderCommand : ICreateProviderCommand
{
    private readonly InventoryManagementDbContext _context;

    public CreateProviderCommand(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateProviderDto data)
    {
        ProviderEntity entity = new();
        
        _context.Providers.Add(entity);
        _context.SaveChangesAsync();
    }
    
}