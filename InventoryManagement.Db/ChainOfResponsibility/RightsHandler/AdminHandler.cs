using System.Reflection.Metadata;
using InventoryManagement.Db.ChainOfResponsibility.Handler;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.ChainOfResponsibility.RightsHandler;

public class AdminHandler : ApproverHandler
{
   public override object Handle(ProductEntity product)
   {
      return "Approved by administrator";
   }
}