using FluentAssertions;

namespace E2E;

public class UnitTest1: CustomWebApplicationFactory
{
    [Fact]
    public async Task Test1()
    {
        var response = await CreateClient().GetAsync("/WeatherForecast");
        response.Should().Be200Ok();
    }
}