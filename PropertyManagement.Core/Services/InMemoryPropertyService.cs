using PropertyManagement.Core.Models;

namespace PropertyManagement.Core.Services;

/// <summary>
/// Temporary starter implementation used before the application is connected to EF Core.
/// Students will replace this approach as the semester progresses.
/// </summary>
public class InMemoryPropertyService : IPropertyService
{
    private static readonly List<Property> Properties =
    [
        new() { Id = 1, Name = "Lakeside Apartments", Address = "125 Lake Street", City = "Winona", State = "MN", PostalCode = "55987" },
        new() { Id = 2, Name = "River View Homes", Address = "420 River Road", City = "Red Wing", State = "MN", PostalCode = "55066" }
    ];

    private static readonly List<Unit> Units =
    [
        new() { Id = 1, PropertyId = 1, UnitNumber = "101", Bedrooms = 1, Bathrooms = 1, MonthlyRent = 975m, IsAvailable = false },
        new() { Id = 2, PropertyId = 1, UnitNumber = "102", Bedrooms = 2, Bathrooms = 1, MonthlyRent = 1225m, IsAvailable = true },
        new() { Id = 3, PropertyId = 2, UnitNumber = "A", Bedrooms = 3, Bathrooms = 2, MonthlyRent = 1650m, IsAvailable = true }
    ];

    private static readonly List<Tenant> Tenants =
    [
        new() { Id = 1, FirstName = "Jordan", LastName = "Lee", Email = "jordan.lee@example.com", Phone = "507-555-0101" },
        new() { Id = 2, FirstName = "Morgan", LastName = "Patel", Email = "morgan.patel@example.com", Phone = "651-555-0142" }
    ];

    public Task<IReadOnlyList<Property>> GetPropertiesAsync() =>
        Task.FromResult<IReadOnlyList<Property>>(Properties);

    public Task<Property?> GetPropertyAsync(int id) =>
        Task.FromResult(Properties.FirstOrDefault(p => p.Id == id));

    public Task<IReadOnlyList<Unit>> GetUnitsAsync() =>
        Task.FromResult<IReadOnlyList<Unit>>(Units);

    public Task<IReadOnlyList<Tenant>> GetTenantsAsync() =>
        Task.FromResult<IReadOnlyList<Tenant>>(Tenants);
}
