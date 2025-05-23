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
    /// A class representing a collection of <see cref="CloudServiceOSFamilyResource"/> and their operations.
    /// Each <see cref="CloudServiceOSFamilyResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="CloudServiceOSFamilyCollection"/> instance call the GetCloudServiceOSFamilies method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class CloudServiceOSFamilyCollection : ArmCollection, IEnumerable<CloudServiceOSFamilyResource>, IAsyncEnumerable<CloudServiceOSFamilyResource>
    {
        private readonly ClientDiagnostics _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceOSFamilyCollection"/> class for mocking. </summary>
        protected CloudServiceOSFamilyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceOSFamilyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        internal CloudServiceOSFamilyCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CloudServiceOSFamilyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudServiceOSFamilyResource.ResourceType, out string cloudServiceOSFamilyCloudServiceOperatingSystemsApiVersion);
            _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceOSFamilyCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual async Task<Response<CloudServiceOSFamilyResource>> GetAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSFamilyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<CloudServiceOSFamilyResource> Get(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSFamilyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_ListOSFamilies</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceOSFamilyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceOSFamilyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.CreateListOSFamiliesRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.CreateListOSFamiliesNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudServiceOSFamilyResource(Client, CloudServiceOSFamilyData.DeserializeCloudServiceOSFamilyData(e)), _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics, Pipeline, "CloudServiceOSFamilyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_ListOSFamilies</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceOSFamilyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceOSFamilyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.CreateListOSFamiliesRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.CreateListOSFamiliesNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudServiceOSFamilyResource(Client, CloudServiceOSFamilyData.DeserializeCloudServiceOSFamilyData(e)), _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics, Pipeline, "CloudServiceOSFamilyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<bool> Exists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudServiceOSFamilyResource>> GetIfExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceOSFamilyResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSFamilyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSFamily</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSFamilyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual NullableResponse<CloudServiceOSFamilyResource> GetIfExists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _cloudServiceOSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, new AzureLocation(_location), osFamilyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceOSFamilyResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSFamilyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudServiceOSFamilyResource> IEnumerable<CloudServiceOSFamilyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceOSFamilyResource> IAsyncEnumerable<CloudServiceOSFamilyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
