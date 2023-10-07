using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands;


public class CreateInventoryItemCommandHandler : ICreateInventoryItemCommandHandler
{
    private readonly InventoryManagementDbContext _dbContext;

    public CreateInventoryItemCommandHandler(InventoryManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    async Task ICommandHandler<CreateInventoryItemCommand>.Handle(CreateInventoryItemCommand command)
    {
        InventoryItemEntity entity = new()
        {
            InventoryItemId = command.InventoryItemId,
            ProductId = command.ProductId,
            LocationId = command.LocationId,
            Quantity = command.Quantity
        };

        _dbContext.Add(entity);
        await _dbContext.SaveChangesAsync();
    }
    
    
}