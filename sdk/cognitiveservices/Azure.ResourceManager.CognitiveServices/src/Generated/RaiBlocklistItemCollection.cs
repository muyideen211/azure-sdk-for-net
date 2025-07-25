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

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing a collection of <see cref="RaiBlocklistItemResource"/> and their operations.
    /// Each <see cref="RaiBlocklistItemResource"/> in the collection will belong to the same instance of <see cref="RaiBlocklistResource"/>.
    /// To get a <see cref="RaiBlocklistItemCollection"/> instance call the GetRaiBlocklistItems method from an instance of <see cref="RaiBlocklistResource"/>.
    /// </summary>
    public partial class RaiBlocklistItemCollection : ArmCollection, IEnumerable<RaiBlocklistItemResource>, IAsyncEnumerable<RaiBlocklistItemResource>
    {
        private readonly ClientDiagnostics _raiBlocklistItemClientDiagnostics;
        private readonly RaiBlocklistItemsRestOperations _raiBlocklistItemRestClient;

        /// <summary> Initializes a new instance of the <see cref="RaiBlocklistItemCollection"/> class for mocking. </summary>
        protected RaiBlocklistItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RaiBlocklistItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RaiBlocklistItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _raiBlocklistItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", RaiBlocklistItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RaiBlocklistItemResource.ResourceType, out string raiBlocklistItemApiVersion);
            _raiBlocklistItemRestClient = new RaiBlocklistItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, raiBlocklistItemApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RaiBlocklistResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RaiBlocklistResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the state of specified blocklist item associated with the Azure OpenAI account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="data"> Properties describing the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RaiBlocklistItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string raiBlocklistItemName, RaiBlocklistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, data, cancellationToken).ConfigureAwait(false);
                var uri = _raiBlocklistItemRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CognitiveServicesArmOperation<RaiBlocklistItemResource>(Response.FromValue(new RaiBlocklistItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Update the state of specified blocklist item associated with the Azure OpenAI account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="data"> Properties describing the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RaiBlocklistItemResource> CreateOrUpdate(WaitUntil waitUntil, string raiBlocklistItemName, RaiBlocklistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, data, cancellationToken);
                var uri = _raiBlocklistItemRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CognitiveServicesArmOperation<RaiBlocklistItemResource>(Response.FromValue(new RaiBlocklistItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the specified custom blocklist Item associated with the custom blocklist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<Response<RaiBlocklistItemResource>> GetAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified custom blocklist Item associated with the custom blocklist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual Response<RaiBlocklistItemResource> Get(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.Get");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the blocklist items associated with the custom blocklist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RaiBlocklistItemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RaiBlocklistItemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _raiBlocklistItemRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _raiBlocklistItemRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RaiBlocklistItemResource(Client, RaiBlocklistItemData.DeserializeRaiBlocklistItemData(e)), _raiBlocklistItemClientDiagnostics, Pipeline, "RaiBlocklistItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the blocklist items associated with the custom blocklist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RaiBlocklistItemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RaiBlocklistItemResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _raiBlocklistItemRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _raiBlocklistItemRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RaiBlocklistItemResource(Client, RaiBlocklistItemData.DeserializeRaiBlocklistItemData(e)), _raiBlocklistItemClientDiagnostics, Pipeline, "RaiBlocklistItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<NullableResponse<RaiBlocklistItemResource>> GetIfExistsAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RaiBlocklistItemResource>(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RaiBlocklistItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> The name of the RaiBlocklist Item associated with the custom blocklist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual NullableResponse<RaiBlocklistItemResource> GetIfExists(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RaiBlocklistItemResource>(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RaiBlocklistItemResource> IEnumerable<RaiBlocklistItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RaiBlocklistItemResource> IAsyncEnumerable<RaiBlocklistItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
