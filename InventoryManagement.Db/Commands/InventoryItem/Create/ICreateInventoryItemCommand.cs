using InventoryManagement.Db.Commands.Core;

namespace InventoryManagement.Db.Commands.InventoryItem.Create;

public interface ICreateInventoryItemCommand : INoResponseAsyncCommand<CreateInventoryItemDto>
{
    
}