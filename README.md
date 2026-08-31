[![](https://img.shields.io/nuget/v/soenneker.openai.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openai.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openai.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openai.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openai.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openai.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openai.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openai.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenAI.OpenApiClient

Typed request builders and models for calling OpenAI's REST API from .NET.

## Installation

```bash
dotnet add package Soenneker.OpenAI.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.OpenAI.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new OpenAIOpenApiClient(adapter);
var models = await client.Models.GetAsync(cancellationToken: cancellationToken);
```

The client defaults to `https://api.openai.com/v1`. It exposes the API as Kiota request builders, including models, responses, chat completions, files, images, audio, and batches.

For application registration, configuration-based credentials, and managed client reuse, use [`Soenneker.OpenAI.OpenApiClientUtil`](https://github.com/soenneker/soenneker.openai.openapiclientutil).
