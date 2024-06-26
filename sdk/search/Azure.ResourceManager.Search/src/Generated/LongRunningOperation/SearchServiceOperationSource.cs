// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Search
{
    internal class SearchServiceOperationSource : IOperationSource<SearchServiceResource>
    {
        private readonly ArmClient _client;

        internal SearchServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SearchServiceResource IOperationSource<SearchServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SearchServiceData.DeserializeSearchServiceData(document.RootElement);
            return new SearchServiceResource(_client, data);
        }

        async ValueTask<SearchServiceResource> IOperationSource<SearchServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SearchServiceData.DeserializeSearchServiceData(document.RootElement);
            return new SearchServiceResource(_client, data);
        }
    }
}
