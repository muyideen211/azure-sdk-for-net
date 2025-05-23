// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class BgpConnectionOperationSource : IOperationSource<BgpConnectionResource>
    {
        private readonly ArmClient _client;

        internal BgpConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BgpConnectionResource IOperationSource<BgpConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BgpConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new BgpConnectionResource(_client, data);
        }

        async ValueTask<BgpConnectionResource> IOperationSource<BgpConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BgpConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new BgpConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
