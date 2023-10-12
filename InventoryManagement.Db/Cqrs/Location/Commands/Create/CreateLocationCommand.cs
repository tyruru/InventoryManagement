using InventoryManagement.Db.Cqrs.Core.Command;

namespace InventoryManagement.Db.Cqrs.Location.Commands.Create;

public sealed class CreateLocationCommand : ICommand
{
    public int  LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }

    public CreateLocationCommand(int locationId, string locationName, string locationAddress)
    {
        LocationId = locationId;
        LocationName = locationName;
        LocationAddress = locationAddress;
    }
}