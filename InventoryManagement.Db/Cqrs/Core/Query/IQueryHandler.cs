namespace InventoryManagement.Db.Cqrs.Core.Query;

public interface IQueryHandler <in TQuery, TResult> where TQuery : IQuery
{
    Task<TResult> Handle(TQuery query);
}