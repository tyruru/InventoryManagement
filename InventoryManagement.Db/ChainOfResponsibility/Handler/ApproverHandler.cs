using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.ChainOfResponsibility.Handler;

public abstract class ApproverHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNextHandler(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object Handle(ProductEntity request)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}