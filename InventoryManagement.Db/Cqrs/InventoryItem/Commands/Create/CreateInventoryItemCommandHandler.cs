using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.InventoryItem;
using InventoryManagement.Db.Data.UnitOfWork;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;

public sealed class CreateInventoryItemCommandHandler : ICreateInventoryItemCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateInventoryItemCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    async Task ICommandHandler<CreateInventoryItemCommand>.Handle(CreateInventoryItemCommand command)
    {
        InventoryItemEntity inventoryItemEntity = new()
        {
            InventoryItemId = command.InventoryItemId,
            ProductId = command.ProductId,
            LocationId = command.LocationId,
            Quantity = command.Quantity
        };

        await ((IInventoryItemRepository) _unitOfWork.Repository<InventoryItemEntity>()).Create(inventoryItemEntity);

        await _unitOfWork.Commit();
    }
}