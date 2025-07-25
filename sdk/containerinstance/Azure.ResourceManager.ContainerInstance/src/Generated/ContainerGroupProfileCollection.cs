// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerGroupProfileResource"/> and their operations.
    /// Each <see cref="ContainerGroupProfileResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ContainerGroupProfileCollection"/> instance call the GetContainerGroupProfiles method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ContainerGroupProfileCollection : ArmCollection, IEnumerable<ContainerGroupProfileResource>, IAsyncEnumerable<ContainerGroupProfileResource>
    {
        private readonly ClientDiagnostics _containerGroupProfileCGProfileClientDiagnostics;
        private readonly CGProfileRestOperations _containerGroupProfileCGProfileRestClient;
        private readonly ClientDiagnostics _containerGroupProfileCGProfilesClientDiagnostics;
        private readonly CGProfilesRestOperations _containerGroupProfileCGProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupProfileCollection"/> class for mocking. </summary>
        protected ContainerGroupProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerGroupProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerGroupProfileCGProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerGroupProfileResource.ResourceType, out string containerGroupProfileCGProfileApiVersion);
            _containerGroupProfileCGProfileRestClient = new CGProfileRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerGroupProfileCGProfileApiVersion);
            _containerGroupProfileCGProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerGroupProfileResource.ResourceType, out string containerGroupProfileCGProfilesApiVersion);
            _containerGroupProfileCGProfilesRestClient = new CGProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerGroupProfileCGProfilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a CGProfile if it doesn't exist or update an existing CGProfile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="data"> The ContainerGroupProfile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerGroupProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerGroupProfileName, ContainerGroupProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileCGProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, data, cancellationToken).ConfigureAwait(false);
                var uri = _containerGroupProfileCGProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ContainerInstanceArmOperation<ContainerGroupProfileResource>(Response.FromValue(new ContainerGroupProfileResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a CGProfile if it doesn't exist or update an existing CGProfile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="data"> The ContainerGroupProfile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerGroupProfileResource> CreateOrUpdate(WaitUntil waitUntil, string containerGroupProfileName, ContainerGroupProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerGroupProfileCGProfileRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, data, cancellationToken);
                var uri = _containerGroupProfileCGProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ContainerInstanceArmOperation<ContainerGroupProfileResource>(Response.FromValue(new ContainerGroupProfileResource(Client, response), response.GetRawResponse()), rehydrationToken);
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

        /// <summary>
        /// Get the properties of the specified container group profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual async Task<Response<ContainerGroupProfileResource>> GetAsync(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileCGProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of the specified container group profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual Response<ContainerGroupProfileResource> Get(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _containerGroupProfileCGProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all container group profiles under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerGroupProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerGroupProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupProfileCGProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupProfileCGProfilesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), _containerGroupProfileCGProfilesClientDiagnostics, Pipeline, "ContainerGroupProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all container group profiles under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerGroupProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerGroupProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupProfileCGProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupProfileCGProfilesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), _containerGroupProfileCGProfilesClientDiagnostics, Pipeline, "ContainerGroupProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileCGProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerGroupProfileCGProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerGroupProfileResource>> GetIfExistsAsync(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileCGProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupProfileResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfile_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupProfileName"> ContainerGroupProfile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupProfileName"/> is null. </exception>
        public virtual NullableResponse<ContainerGroupProfileResource> GetIfExists(string containerGroupProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerGroupProfileName, nameof(containerGroupProfileName));

            using var scope = _containerGroupProfileCGProfileClientDiagnostics.CreateScope("ContainerGroupProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerGroupProfileCGProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerGroupProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupProfileResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerGroupProfileResource> IEnumerable<ContainerGroupProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerGroupProfileResource> IAsyncEnumerable<ContainerGroupProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
