using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenAI.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenAIOpenApiClientTests : HostedUnitTest
{
    public OpenAIOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
