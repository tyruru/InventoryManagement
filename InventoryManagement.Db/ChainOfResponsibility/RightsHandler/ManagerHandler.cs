using InventoryManagement.Db.ChainOfResponsibility.Handler;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.ChainOfResponsibility.RightsHandler;

public class ManagerHandler : ApproverHandler
{
    public override object Handle(ProductEntity product)
    {
        if (product.Price <= 50000)
        {
            return "Approved by Manager";
        } 
        return base.Handle(product);
    }
}