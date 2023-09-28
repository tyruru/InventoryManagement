using InventoryManagement.Db.Commands.Core;

namespace InventoryManagement.Db.Commands.Provider;

public interface ICreateProviderCommand : INoResponseAsyncCommand<CreateProviderDto>
{
    
}