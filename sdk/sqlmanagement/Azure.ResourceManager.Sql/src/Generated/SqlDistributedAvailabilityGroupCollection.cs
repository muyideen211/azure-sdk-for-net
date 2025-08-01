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
    /// A class representing a collection of <see cref="SqlDistributedAvailabilityGroupResource"/> and their operations.
    /// Each <see cref="SqlDistributedAvailabilityGroupResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="SqlDistributedAvailabilityGroupCollection"/> instance call the GetSqlDistributedAvailabilityGroups method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class SqlDistributedAvailabilityGroupCollection : ArmCollection, IEnumerable<SqlDistributedAvailabilityGroupResource>, IAsyncEnumerable<SqlDistributedAvailabilityGroupResource>
    {
        private readonly ClientDiagnostics _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics;
        private readonly DistributedAvailabilityGroupsRestOperations _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDistributedAvailabilityGroupCollection"/> class for mocking. </summary>
        protected SqlDistributedAvailabilityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDistributedAvailabilityGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlDistributedAvailabilityGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlDistributedAvailabilityGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlDistributedAvailabilityGroupResource.ResourceType, out string sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsApiVersion);
            _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient = new DistributedAvailabilityGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a distributed availability group between Sql On-Prem and Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="data"> The distributed availability group info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlDistributedAvailabilityGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string distributedAvailabilityGroupName, SqlDistributedAvailabilityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlDistributedAvailabilityGroupResource>(new SqlDistributedAvailabilityGroupOperationSource(Client), _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics, Pipeline, _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a distributed availability group between Sql On-Prem and Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="data"> The distributed availability group info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlDistributedAvailabilityGroupResource> CreateOrUpdate(WaitUntil waitUntil, string distributedAvailabilityGroupName, SqlDistributedAvailabilityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlDistributedAvailabilityGroupResource>(new SqlDistributedAvailabilityGroupOperationSource(Client), _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics, Pipeline, _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a distributed availability group info.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlDistributedAvailabilityGroupResource>> GetAsync(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a distributed availability group info.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual Response<SqlDistributedAvailabilityGroupResource> Get(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of a distributed availability groups in instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_ListByInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlDistributedAvailabilityGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlDistributedAvailabilityGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlDistributedAvailabilityGroupResource(Client, SqlDistributedAvailabilityGroupData.DeserializeSqlDistributedAvailabilityGroupData(e)), _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics, Pipeline, "SqlDistributedAvailabilityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of a distributed availability groups in instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_ListByInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlDistributedAvailabilityGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlDistributedAvailabilityGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlDistributedAvailabilityGroupResource(Client, SqlDistributedAvailabilityGroupData.DeserializeSqlDistributedAvailabilityGroupData(e)), _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics, Pipeline, "SqlDistributedAvailabilityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlDistributedAvailabilityGroupResource>> GetIfExistsAsync(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlDistributedAvailabilityGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlDistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DistributedAvailabilityGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDistributedAvailabilityGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual NullableResponse<SqlDistributedAvailabilityGroupResource> GetIfExists(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsClientDiagnostics.CreateScope("SqlDistributedAvailabilityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlDistributedAvailabilityGroupDistributedAvailabilityGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlDistributedAvailabilityGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlDistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlDistributedAvailabilityGroupResource> IEnumerable<SqlDistributedAvailabilityGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlDistributedAvailabilityGroupResource> IAsyncEnumerable<SqlDistributedAvailabilityGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
