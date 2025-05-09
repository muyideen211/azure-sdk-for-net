// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Cdn
{
    internal class FrontDoorCustomDomainOperationSource : IOperationSource<FrontDoorCustomDomainResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorCustomDomainOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorCustomDomainResource IOperationSource<FrontDoorCustomDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorCustomDomainData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return new FrontDoorCustomDomainResource(_client, data);
        }

        async ValueTask<FrontDoorCustomDomainResource> IOperationSource<FrontDoorCustomDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorCustomDomainData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return await Task.FromResult(new FrontDoorCustomDomainResource(_client, data)).ConfigureAwait(false);
        }
    }
}
