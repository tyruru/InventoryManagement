using InventoryManagement.Api.RestModels.Provider;
using InventoryManagement.Db.Commands.Provider;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Api.Controllers.Provider;

[ApiController]
[Route("Provider")]
[ApiExplorerSettings(GroupName = "Providers")]

public class CreateProviderController : ControllerBase
{
    private readonly ICreateProviderCommand _createProviderCommand;

    public CreateProviderController(ICreateProviderCommand createProviderCommand)
    {
        _createProviderCommand = createProviderCommand;
    }

    [HttpPost("Create")]

    public async Task<IActionResult> Create(CreateProviderRequest request)
    {
        CreateProviderDto dto = new(
            request.SupplierId,
            request.SupplierName,
            request.SupplierPhone);

        await _createProviderCommand.Execute(dto);

        return Ok();
    }
}