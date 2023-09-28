namespace InventoryManagement.Db.Commands.Core;

public interface INoResponseAsyncCommand<in Tdata>
{
    Task Execute(Tdata data);
}