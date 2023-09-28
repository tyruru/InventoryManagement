namespace InventoryManagement.Db.Commands.Core;

public interface IAsyncCommand
{
    Task Execute();
}

public interface IAsyncCommand<TResult>
{
    Task<TResult> Execute();
}

public interface IAsyncCommand<in Tdata, TResult>
{
    Task<TResult> Execute(Tdata data);
} 