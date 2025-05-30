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

namespace Azure.ResourceManager.StandbyPool
{
    /// <summary>
    /// A class representing a collection of <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> and their operations.
    /// Each <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> in the collection will belong to the same instance of <see cref="StandbyVirtualMachinePoolResource"/>.
    /// To get a <see cref="StandbyVirtualMachinePoolRuntimeViewCollection"/> instance call the GetStandbyVirtualMachinePoolRuntimeViews method from an instance of <see cref="StandbyVirtualMachinePoolResource"/>.
    /// </summary>
    public partial class StandbyVirtualMachinePoolRuntimeViewCollection : ArmCollection, IEnumerable<StandbyVirtualMachinePoolRuntimeViewResource>, IAsyncEnumerable<StandbyVirtualMachinePoolRuntimeViewResource>
    {
        private readonly ClientDiagnostics _standbyVirtualMachinePoolRuntimeViewClientDiagnostics;
        private readonly StandbyVirtualMachinePoolRuntimeViewsRestOperations _standbyVirtualMachinePoolRuntimeViewRestClient;

        /// <summary> Initializes a new instance of the <see cref="StandbyVirtualMachinePoolRuntimeViewCollection"/> class for mocking. </summary>
        protected StandbyVirtualMachinePoolRuntimeViewCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyVirtualMachinePoolRuntimeViewCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StandbyVirtualMachinePoolRuntimeViewCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _standbyVirtualMachinePoolRuntimeViewClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StandbyPool", StandbyVirtualMachinePoolRuntimeViewResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StandbyVirtualMachinePoolRuntimeViewResource.ResourceType, out string standbyVirtualMachinePoolRuntimeViewApiVersion);
            _standbyVirtualMachinePoolRuntimeViewRestClient = new StandbyVirtualMachinePoolRuntimeViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, standbyVirtualMachinePoolRuntimeViewApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StandbyVirtualMachinePoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StandbyVirtualMachinePoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<Response<StandbyVirtualMachinePoolRuntimeViewResource>> GetAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.Get");
            scope.Start();
            try
            {
                var response = await _standbyVirtualMachinePoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachinePoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual Response<StandbyVirtualMachinePoolRuntimeViewResource> Get(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.Get");
            scope.Start();
            try
            {
                var response = _standbyVirtualMachinePoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachinePoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List StandbyVirtualMachinePoolRuntimeViewResource resources by StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_ListByStandbyPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StandbyVirtualMachinePoolRuntimeViewResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyVirtualMachinePoolRuntimeViewRestClient.CreateListByStandbyPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyVirtualMachinePoolRuntimeViewRestClient.CreateListByStandbyPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StandbyVirtualMachinePoolRuntimeViewResource(Client, StandbyVirtualMachinePoolRuntimeViewData.DeserializeStandbyVirtualMachinePoolRuntimeViewData(e)), _standbyVirtualMachinePoolRuntimeViewClientDiagnostics, Pipeline, "StandbyVirtualMachinePoolRuntimeViewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List StandbyVirtualMachinePoolRuntimeViewResource resources by StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_ListByStandbyPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StandbyVirtualMachinePoolRuntimeViewResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyVirtualMachinePoolRuntimeViewRestClient.CreateListByStandbyPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyVirtualMachinePoolRuntimeViewRestClient.CreateListByStandbyPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StandbyVirtualMachinePoolRuntimeViewResource(Client, StandbyVirtualMachinePoolRuntimeViewData.DeserializeStandbyVirtualMachinePoolRuntimeViewData(e)), _standbyVirtualMachinePoolRuntimeViewClientDiagnostics, Pipeline, "StandbyVirtualMachinePoolRuntimeViewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.Exists");
            scope.Start();
            try
            {
                var response = await _standbyVirtualMachinePoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual Response<bool> Exists(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.Exists");
            scope.Start();
            try
            {
                var response = _standbyVirtualMachinePoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<NullableResponse<StandbyVirtualMachinePoolRuntimeViewResource>> GetIfExistsAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _standbyVirtualMachinePoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StandbyVirtualMachinePoolRuntimeViewResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachinePoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual NullableResponse<StandbyVirtualMachinePoolRuntimeViewResource> GetIfExists(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyVirtualMachinePoolRuntimeViewClientDiagnostics.CreateScope("StandbyVirtualMachinePoolRuntimeViewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _standbyVirtualMachinePoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StandbyVirtualMachinePoolRuntimeViewResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachinePoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StandbyVirtualMachinePoolRuntimeViewResource> IEnumerable<StandbyVirtualMachinePoolRuntimeViewResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StandbyVirtualMachinePoolRuntimeViewResource> IAsyncEnumerable<StandbyVirtualMachinePoolRuntimeViewResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
