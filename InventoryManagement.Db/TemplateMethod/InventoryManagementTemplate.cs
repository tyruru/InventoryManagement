using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.TemplateMethod;

public abstract class InventoryManagementTemplate
{
    public void ManageInventory(CreateInventoryItemCommand createInventoryItemCommand)
    {
        Validation(createInventoryItemCommand);
        UpdateInventoryItem(createInventoryItemCommand);
    }

    protected virtual void Validation(CreateInventoryItemCommand createInventoryItemCommand)
    {
        // Validation logic
    }
    
    protected virtual void UpdateInventoryItem(CreateInventoryItemCommand createInventoryItemCommand)
    {
        // Update logic 
    }
}