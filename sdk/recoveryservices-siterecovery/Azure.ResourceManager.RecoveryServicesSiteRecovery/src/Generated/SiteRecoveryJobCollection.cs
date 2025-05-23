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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryJobResource"/> and their operations.
    /// Each <see cref="SiteRecoveryJobResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SiteRecoveryJobCollection"/> instance call the GetSiteRecoveryJobs method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SiteRecoveryJobCollection : ArmCollection, IEnumerable<SiteRecoveryJobResource>, IAsyncEnumerable<SiteRecoveryJobResource>
    {
        private readonly ClientDiagnostics _siteRecoveryJobReplicationJobsClientDiagnostics;
        private readonly ReplicationJobsRestOperations _siteRecoveryJobReplicationJobsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryJobCollection"/> class for mocking. </summary>
        protected SiteRecoveryJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SiteRecoveryJobCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _siteRecoveryJobReplicationJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryJobResource.ResourceType, out string siteRecoveryJobReplicationJobsApiVersion);
            _siteRecoveryJobReplicationJobsRestClient = new ReplicationJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryJobReplicationJobsApiVersion);
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
        /// Get the details of an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryJobResource>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Azure Site Recovery job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<SiteRecoveryJobResource> Get(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryJobResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryJobReplicationJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryJobReplicationJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryJobResource(Client, SiteRecoveryJobData.DeserializeSiteRecoveryJobData(e)), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, "SiteRecoveryJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryJobResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryJobReplicationJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryJobReplicationJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryJobResource(Client, SiteRecoveryJobData.DeserializeSiteRecoveryJobData(e)), _siteRecoveryJobReplicationJobsClientDiagnostics, Pipeline, "SiteRecoveryJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryJobResource>> GetIfExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryJobReplicationJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryJobResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryJobResource> GetIfExists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _siteRecoveryJobReplicationJobsClientDiagnostics.CreateScope("SiteRecoveryJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryJobReplicationJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, jobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryJobResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryJobResource> IEnumerable<SiteRecoveryJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryJobResource> IAsyncEnumerable<SiteRecoveryJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
