using System.Security.Authentication;
using InventoryManagement.Api.Controllers.InventoryItem;
using InventoryManagement.Api.RestModels;
using Microsoft.AspNetCore.Mvc.Controllers;
using InventoryManagement.Db.Commands;
using InventoryManagement.Db.Commands.InventoryItem.Create;
using InventoryManagement.Db.Data;
using InventoryManagement.Db.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddInventoryManagementData(
        "USER ID=postgres;Password=1234;Server=localhost;Port=5432;Database=InventoryManagement2;Integrated Security=true;Pooling=true")
    .AddInventoryItemCommads()
    .AddLocationCommands()
    .AddProductCommands()
    .AddProviderCommands();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return new[] { api.GroupName };
        }
        
        if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }
        
        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });
    
    options.DocInclusionPredicate((name, api) => true);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();