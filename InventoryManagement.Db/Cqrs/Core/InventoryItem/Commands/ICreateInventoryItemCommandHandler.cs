using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands;

public interface ICreateInventoryItemCommandHandler : ICommandHandler<CreateInventoryItemCommand>
{
    
}