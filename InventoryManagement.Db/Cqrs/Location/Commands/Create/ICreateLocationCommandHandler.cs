using System.Windows.Input;
using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Location.Commands.Create;

public interface ICreateLocationCommandHandler : ICommandHandler<CreateLocationCommand>
{
    
}