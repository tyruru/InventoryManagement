namespace InventoryManagement.Db.Commands.Provider;

public class CreateProviderDto
{
    public int  SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierPhone { get; set; }

    public CreateProviderDto(int supplierId, string supplierName, string supplierPhone)
    {
        SupplierId = supplierId;
        SupplierName = supplierName;
        SupplierPhone = supplierPhone;
    }
}