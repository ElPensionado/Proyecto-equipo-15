using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApp.IntegrationTest;

public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("a")]
    [InlineData("b")]
    [InlineData("d")]
    [InlineData("c")]
    [InlineData("index")]
    public async Task TestGetPages(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}