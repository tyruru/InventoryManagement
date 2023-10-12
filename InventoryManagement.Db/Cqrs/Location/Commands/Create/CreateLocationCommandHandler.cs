using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.Location;
using InventoryManagement.Db.Data.UnitOfWork;

namespace InventoryManagement.Db.Cqrs.Location.Commands.Create;

public sealed class CreateLocationCommandHandler : ICreateLocationCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateLocationCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    async Task ICommandHandler<CreateLocationCommand>.Handle(CreateLocationCommand command)
    {
        LocationEntity locationEntity = new()
        {
            LocationId = command.LocationId,
            LocationAddress = command.LocationAddress,
            LocationName = command.LocationName,
        };

        await ((ILocationRepository) _unitOfWork.Repository<LocationEntity>()).Create(locationEntity);

        await _unitOfWork.Commit();
    }
}
