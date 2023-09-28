using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Commands.Location.Create;

public class CreateLocationCommand : ICreateLocationCommand
{
    private readonly InventoryManagementDbContext _context;

    public CreateLocationCommand(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateLocationDto data)
    {
        LocationEntity entity = new();

        _context.Locations.Add(entity);
        _context.SaveChangesAsync();
    }
}