using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;

namespace InventoryManagement.Db.TemplateMethod;


public class CreateInventoryItemProcessor : InventoryManagementTemplate
{
    protected override void UpdateInventoryItem(CreateInventoryItemCommand createInventoryItemCommand)
    {
        // Other update logic
    }
}