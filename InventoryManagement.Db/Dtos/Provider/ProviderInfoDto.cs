namespace InventoryManagement.Db.Dtos.Provider;

public sealed class ProviderInfoDto
{
    public int  SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierPhone { get; set; }

    public ProviderInfoDto(int supplierId, string supplierName, string supplierPhone)
    {
        SupplierId = supplierId;
        SupplierName = supplierName;
        SupplierPhone = supplierPhone;
    }
}