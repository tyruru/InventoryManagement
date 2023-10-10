using InventoryManagement.Db.Data.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Db.Data.Repositories.Location;

public sealed class LocationRepository : ILocationRepository
{
    private readonly InventoryManagementDbContext _context;

    public LocationRepository(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Create(LocationEntity entity)
    {
        await _context.Locations.AddAsync(entity);
    }

    public async Task<LocationEntity?> FindSingle(int locationId)
    {
        return await _context.Locations.SingleOrDefaultAsync(p => p.LocationId == locationId);
    }
}