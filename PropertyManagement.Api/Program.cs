using PropertyManagement.Core.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IPropertyService, InMemoryPropertyService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => Results.Redirect("/swagger"))
    .ExcludeFromDescription();

var properties = app.MapGroup("/api/properties").WithTags("Properties");

properties.MapGet("/", async (IPropertyService service) =>
    Results.Ok(await service.GetPropertiesAsync()))
    .WithName("GetProperties")
    .WithSummary("Returns all properties from the temporary in-memory data source.");

properties.MapGet("/{id:int}", async (int id, IPropertyService service) =>
{
    var property = await service.GetPropertyAsync(id);
    return property is null ? Results.NotFound() : Results.Ok(property);
})
.WithName("GetPropertyById")
.WithSummary("Returns one property by id.");

app.MapGet("/api/units", async (IPropertyService service) =>
    Results.Ok(await service.GetUnitsAsync()))
    .WithTags("Units")
    .WithName("GetUnits")
    .WithSummary("Returns all units from the temporary in-memory data source.");

app.MapGet("/api/tenants", async (IPropertyService service) =>
    Results.Ok(await service.GetTenantsAsync()))
    .WithTags("Tenants")
    .WithName("GetTenants")
    .WithSummary("Returns all tenants from the temporary in-memory data source.");

app.Run();

public partial class Program;
