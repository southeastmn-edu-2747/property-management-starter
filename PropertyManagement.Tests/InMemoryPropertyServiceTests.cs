using Xunit;
using PropertyManagement.Core.Services;

namespace PropertyManagement.Tests;

public class InMemoryPropertyServiceTests
{
    [Fact]
    public async Task GetPropertiesAsync_ReturnsStarterProperties()
    {
        var service = new InMemoryPropertyService();

        var properties = await service.GetPropertiesAsync();

        Assert.NotEmpty(properties);
    }

    [Fact]
    public async Task GetPropertyAsync_WithUnknownId_ReturnsNull()
    {
        var service = new InMemoryPropertyService();

        var property = await service.GetPropertyAsync(9999);

        Assert.Null(property);
    }
}
