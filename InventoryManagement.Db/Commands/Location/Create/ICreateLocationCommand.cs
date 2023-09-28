using InventoryManagement.Db.Commands.Core;

namespace InventoryManagement.Db.Commands.Location.Create;

public interface ICreateLocationCommand : INoResponseAsyncCommand<CreateLocationDto>
{
    
}