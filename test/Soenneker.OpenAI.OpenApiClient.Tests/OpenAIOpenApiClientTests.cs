using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenAI.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenAIOpenApiClientTests : FixturedUnitTest
{
    public OpenAIOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
