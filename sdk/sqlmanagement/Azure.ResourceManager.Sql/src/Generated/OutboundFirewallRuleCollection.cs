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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="OutboundFirewallRuleResource"/> and their operations.
    /// Each <see cref="OutboundFirewallRuleResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get an <see cref="OutboundFirewallRuleCollection"/> instance call the GetOutboundFirewallRules method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class OutboundFirewallRuleCollection : ArmCollection, IEnumerable<OutboundFirewallRuleResource>, IAsyncEnumerable<OutboundFirewallRuleResource>
    {
        private readonly ClientDiagnostics _outboundFirewallRuleClientDiagnostics;
        private readonly OutboundFirewallRulesRestOperations _outboundFirewallRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRuleCollection"/> class for mocking. </summary>
        protected OutboundFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OutboundFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundFirewallRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", OutboundFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OutboundFirewallRuleResource.ResourceType, out string outboundFirewallRuleApiVersion);
            _outboundFirewallRuleRestClient = new OutboundFirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, outboundFirewallRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a outbound firewall rule with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual async Task<ArmOperation<OutboundFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<OutboundFirewallRuleResource>(new OutboundFirewallRuleOperationSource(Client), _outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn).Request, response, OperationFinalStateVia.Location);
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
        /// Create a outbound firewall rule with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual ArmOperation<OutboundFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken);
                var operation = new SqlArmOperation<OutboundFirewallRuleResource>(new OutboundFirewallRuleOperationSource(Client), _outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an outbound firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual async Task<Response<OutboundFirewallRuleResource>> GetAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an outbound firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual Response<OutboundFirewallRuleResource> Get(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all outbound firewall rules on a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundFirewallRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _outboundFirewallRuleRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _outboundFirewallRuleRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new OutboundFirewallRuleResource(Client, OutboundFirewallRuleData.DeserializeOutboundFirewallRuleData(e)), _outboundFirewallRuleClientDiagnostics, Pipeline, "OutboundFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all outbound firewall rules on a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundFirewallRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _outboundFirewallRuleRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _outboundFirewallRuleRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new OutboundFirewallRuleResource(Client, OutboundFirewallRuleData.DeserializeOutboundFirewallRuleData(e)), _outboundFirewallRuleClientDiagnostics, Pipeline, "OutboundFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual async Task<NullableResponse<OutboundFirewallRuleResource>> GetIfExistsAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<OutboundFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OutboundFirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OutboundFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleFqdn"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual NullableResponse<OutboundFirewallRuleResource> GetIfExists(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<OutboundFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OutboundFirewallRuleResource> IEnumerable<OutboundFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundFirewallRuleResource> IAsyncEnumerable<OutboundFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
