using PropertyManagement.Core.Models;

namespace PropertyManagement.Core.Services;

public interface IPropertyService
{
    Task<IReadOnlyList<Property>> GetPropertiesAsync();
    Task<Property?> GetPropertyAsync(int id);
    Task<IReadOnlyList<Unit>> GetUnitsAsync();
    Task<IReadOnlyList<Tenant>> GetTenantsAsync();
}
