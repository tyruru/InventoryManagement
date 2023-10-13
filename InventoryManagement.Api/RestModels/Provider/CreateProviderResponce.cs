namespace InventoryManagement.Api.RestModels.Provider;

public class CreateProviderResponce
{
    public int  SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierPhone { get; set; }

    public CreateProviderResponce(int supplierId, string supplierName, string supplierPhone)
    {
        SupplierId = supplierId;
        SupplierName = supplierName;
        SupplierPhone = supplierPhone;
    }
}