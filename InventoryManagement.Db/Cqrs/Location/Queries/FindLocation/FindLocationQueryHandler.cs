using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.Location;
using InventoryManagement.Db.Dtos.Location;

namespace InventoryManagement.Db.Cqrs.Location.Queries.FindLocation;

public class FindLocationQueryHandler : IFindLocationQueryHandler
{
    private readonly ILocationRepository _repository;

    public FindLocationQueryHandler(ILocationRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<LocationInfoDto?> Handle(FindLocationQuery query)
    {
        LocationEntity? entity = await _repository.FindSingle(query.Id);

        return entity != null ? new LocationInfoDto(entity.LocationId, entity.LocationAddress, entity.LocationName) : default;
    }
}