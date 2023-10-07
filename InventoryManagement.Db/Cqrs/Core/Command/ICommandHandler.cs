namespace InventoryManagement.Db.Cqrs.Core.Command;

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    Task Handle(TCommand command);
}