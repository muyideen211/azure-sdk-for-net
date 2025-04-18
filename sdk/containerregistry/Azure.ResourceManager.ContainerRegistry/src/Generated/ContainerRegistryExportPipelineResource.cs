// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A Class representing a ContainerRegistryExportPipeline along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerRegistryExportPipelineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerRegistryExportPipelineResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerRegistryResource"/> using the GetContainerRegistryExportPipeline method.
    /// </summary>
    public partial class ContainerRegistryExportPipelineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerRegistryExportPipelineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="registryName"> The registryName. </param>
        /// <param name="exportPipelineName"> The exportPipelineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string exportPipelineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerRegistryExportPipelineExportPipelinesClientDiagnostics;
        private readonly ExportPipelinesRestOperations _containerRegistryExportPipelineExportPipelinesRestClient;
        private readonly ContainerRegistryExportPipelineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerRegistry/registries/exportPipelines";

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryExportPipelineResource"/> class for mocking. </summary>
        protected ContainerRegistryExportPipelineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryExportPipelineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerRegistryExportPipelineResource(ArmClient client, ContainerRegistryExportPipelineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryExportPipelineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerRegistryExportPipelineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryExportPipelineExportPipelinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerRegistryExportPipelineExportPipelinesApiVersion);
            _containerRegistryExportPipelineExportPipelinesRestClient = new ExportPipelinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryExportPipelineExportPipelinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerRegistryExportPipelineData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the properties of the export pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerRegistryExportPipelineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryExportPipelineExportPipelinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryExportPipelineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the export pipeline.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerRegistryExportPipelineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryExportPipelineExportPipelinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryExportPipelineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an export pipeline from a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerRegistryExportPipelineExportPipelinesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation(_containerRegistryExportPipelineExportPipelinesClientDiagnostics, Pipeline, _containerRegistryExportPipelineExportPipelinesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an export pipeline from a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Delete");
            scope.Start();
            try
            {
                var response = _containerRegistryExportPipelineExportPipelinesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainerRegistryArmOperation(_containerRegistryExportPipelineExportPipelinesClientDiagnostics, Pipeline, _containerRegistryExportPipelineExportPipelinesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an export pipeline for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating an export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryExportPipelineResource>> UpdateAsync(WaitUntil waitUntil, ContainerRegistryExportPipelineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Update");
            scope.Start();
            try
            {
                var response = await _containerRegistryExportPipelineExportPipelinesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryExportPipelineResource>(new ContainerRegistryExportPipelineOperationSource(Client), _containerRegistryExportPipelineExportPipelinesClientDiagnostics, Pipeline, _containerRegistryExportPipelineExportPipelinesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an export pipeline for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/exportPipelines/{exportPipelineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExportPipelines_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryExportPipelineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating an export pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryExportPipelineResource> Update(WaitUntil waitUntil, ContainerRegistryExportPipelineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryExportPipelineExportPipelinesClientDiagnostics.CreateScope("ContainerRegistryExportPipelineResource.Update");
            scope.Start();
            try
            {
                var response = _containerRegistryExportPipelineExportPipelinesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryExportPipelineResource>(new ContainerRegistryExportPipelineOperationSource(Client), _containerRegistryExportPipelineExportPipelinesClientDiagnostics, Pipeline, _containerRegistryExportPipelineExportPipelinesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
