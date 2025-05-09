// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class NetworkFunctionDefinitionGroupOperationSource : IOperationSource<NetworkFunctionDefinitionGroupResource>
    {
        private readonly ArmClient _client;

        internal NetworkFunctionDefinitionGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFunctionDefinitionGroupResource IOperationSource<NetworkFunctionDefinitionGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFunctionDefinitionGroupData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridNetworkContext.Default);
            return new NetworkFunctionDefinitionGroupResource(_client, data);
        }

        async ValueTask<NetworkFunctionDefinitionGroupResource> IOperationSource<NetworkFunctionDefinitionGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFunctionDefinitionGroupData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridNetworkContext.Default);
            return await Task.FromResult(new NetworkFunctionDefinitionGroupResource(_client, data)).ConfigureAwait(false);
        }
    }
}
