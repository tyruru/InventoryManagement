using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Provider.Commands;

public interface ICreateProviderCommandHandler : ICommandHandler<CreateProviderCommand>
{
    
}