// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps
{
    internal class GitHubRepoOperationSource : IOperationSource<GitHubRepoResource>
    {
        private readonly ArmClient _client;

        internal GitHubRepoOperationSource(ArmClient client)
        {
            _client = client;
        }

        GitHubRepoResource IOperationSource<GitHubRepoResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GitHubRepoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSecurityDevOpsContext.Default);
            return new GitHubRepoResource(_client, data);
        }

        async ValueTask<GitHubRepoResource> IOperationSource<GitHubRepoResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GitHubRepoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSecurityDevOpsContext.Default);
            return await Task.FromResult(new GitHubRepoResource(_client, data)).ConfigureAwait(false);
        }
    }
}
