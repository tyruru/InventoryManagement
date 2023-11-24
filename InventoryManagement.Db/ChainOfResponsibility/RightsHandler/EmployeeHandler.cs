using InventoryManagement.Db.ChainOfResponsibility.Handler;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.ChainOfResponsibility.RightsHandler;

public class EmployeeHandler : ApproverHandler
{
    public override object Handle(ProductEntity product)
    {
        if (product.Price <= 10000)
        {
            return "Approved by Employee";
        }
        return base.Handle(product);
    }
}