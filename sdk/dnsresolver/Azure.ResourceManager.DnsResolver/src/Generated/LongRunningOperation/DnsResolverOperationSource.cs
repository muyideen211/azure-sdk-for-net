// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsResolverOperationSource : IOperationSource<DnsResolverResource>
    {
        private readonly ArmClient _client;

        internal DnsResolverOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsResolverResource IOperationSource<DnsResolverResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDnsResolverContext.Default);
            return new DnsResolverResource(_client, data);
        }

        async ValueTask<DnsResolverResource> IOperationSource<DnsResolverResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDnsResolverContext.Default);
            return await Task.FromResult(new DnsResolverResource(_client, data)).ConfigureAwait(false);
        }
    }
}
