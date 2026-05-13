using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace DotnetPlayground.Tests;

public class SmokeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public SmokeTests(WebApplicationFactory<Program> factory) => _factory = factory;

    [Theory]
    [InlineData("/")]
    [InlineData("/About")]
    [InlineData("/healthz")]
    public async Task Get_EndpointsReturnSuccess(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
    }
}
