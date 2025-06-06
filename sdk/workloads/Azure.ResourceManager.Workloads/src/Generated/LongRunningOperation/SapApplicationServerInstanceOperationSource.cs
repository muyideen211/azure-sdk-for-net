// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Workloads
{
    internal class SapApplicationServerInstanceOperationSource : IOperationSource<SapApplicationServerInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapApplicationServerInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapApplicationServerInstanceResource IOperationSource<SapApplicationServerInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapApplicationServerInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerWorkloadsContext.Default);
            return new SapApplicationServerInstanceResource(_client, data);
        }

        async ValueTask<SapApplicationServerInstanceResource> IOperationSource<SapApplicationServerInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapApplicationServerInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerWorkloadsContext.Default);
            return await Task.FromResult(new SapApplicationServerInstanceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
