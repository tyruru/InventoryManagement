
using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Provider.Commands;

public class CreateProviderCommand : ICommand
{
    public int  SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierPhone { get; set; }

    public CreateProviderCommand(int supplierId, string supplierName, string supplierPhone)
    {
        SupplierId = supplierId;
        SupplierName = supplierName;
        SupplierPhone = supplierPhone;
    }
}