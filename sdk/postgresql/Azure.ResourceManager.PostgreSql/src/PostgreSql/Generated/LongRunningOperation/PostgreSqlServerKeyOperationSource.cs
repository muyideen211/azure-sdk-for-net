// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlServerKeyOperationSource : IOperationSource<PostgreSqlServerKeyResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlServerKeyOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlServerKeyResource IOperationSource<PostgreSqlServerKeyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlServerKeyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPostgreSqlContext.Default);
            return new PostgreSqlServerKeyResource(_client, data);
        }

        async ValueTask<PostgreSqlServerKeyResource> IOperationSource<PostgreSqlServerKeyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlServerKeyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPostgreSqlContext.Default);
            return await Task.FromResult(new PostgreSqlServerKeyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
