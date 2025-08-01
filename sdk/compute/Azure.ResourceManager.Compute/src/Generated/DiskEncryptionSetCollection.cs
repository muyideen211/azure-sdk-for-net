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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskEncryptionSetResource"/> and their operations.
    /// Each <see cref="DiskEncryptionSetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DiskEncryptionSetCollection"/> instance call the GetDiskEncryptionSets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DiskEncryptionSetCollection : ArmCollection, IEnumerable<DiskEncryptionSetResource>, IAsyncEnumerable<DiskEncryptionSetResource>
    {
        private readonly ClientDiagnostics _diskEncryptionSetClientDiagnostics;
        private readonly DiskEncryptionSetsRestOperations _diskEncryptionSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class for mocking. </summary>
        protected DiskEncryptionSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskEncryptionSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskEncryptionSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DiskEncryptionSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskEncryptionSetResource.ResourceType, out string diskEncryptionSetApiVersion);
            _diskEncryptionSetRestClient = new DiskEncryptionSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskEncryptionSetApiVersion);
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
        /// Creates or updates a disk encryption set
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskEncryptionSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diskEncryptionSetName, DiskEncryptionSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<DiskEncryptionSetResource>(new DiskEncryptionSetOperationSource(Client), _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a disk encryption set
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="data"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiskEncryptionSetResource> CreateOrUpdate(WaitUntil waitUntil, string diskEncryptionSetName, DiskEncryptionSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data, cancellationToken);
                var operation = new ComputeArmOperation<DiskEncryptionSetResource>(new DiskEncryptionSetOperationSource(Client), _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a disk encryption set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<Response<DiskEncryptionSetResource>> GetAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a disk encryption set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<DiskEncryptionSetResource> Get(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the disk encryption sets under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskEncryptionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskEncryptionSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskEncryptionSetRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskEncryptionSetRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskEncryptionSetResource(Client, DiskEncryptionSetData.DeserializeDiskEncryptionSetData(e)), _diskEncryptionSetClientDiagnostics, Pipeline, "DiskEncryptionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disk encryption sets under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskEncryptionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskEncryptionSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskEncryptionSetRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskEncryptionSetRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskEncryptionSetResource(Client, DiskEncryptionSetData.DeserializeDiskEncryptionSetData(e)), _diskEncryptionSetClientDiagnostics, Pipeline, "DiskEncryptionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DiskEncryptionSetResource>> GetIfExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DiskEncryptionSetResource>(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual NullableResponse<DiskEncryptionSetResource> GetIfExists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DiskEncryptionSetResource>(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskEncryptionSetResource> IEnumerable<DiskEncryptionSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskEncryptionSetResource> IAsyncEnumerable<DiskEncryptionSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
