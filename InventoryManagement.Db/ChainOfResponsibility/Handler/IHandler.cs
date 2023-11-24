using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.ChainOfResponsibility.Handler;

public interface IHandler
{
    IHandler SetNextHandler(IHandler handler);
    object Handle(ProductEntity request);
}