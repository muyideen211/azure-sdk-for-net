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

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceProvisioningServicesPrivateLinkResource"/> and their operations.
    /// Each <see cref="DeviceProvisioningServicesPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="DeviceProvisioningServiceResource"/>.
    /// To get a <see cref="DeviceProvisioningServicesPrivateLinkResourceCollection"/> instance call the GetDeviceProvisioningServicesPrivateLinkResources method from an instance of <see cref="DeviceProvisioningServiceResource"/>.
    /// </summary>
    public partial class DeviceProvisioningServicesPrivateLinkResourceCollection : ArmCollection, IEnumerable<DeviceProvisioningServicesPrivateLinkResource>, IAsyncEnumerable<DeviceProvisioningServicesPrivateLinkResource>
    {
        private readonly ClientDiagnostics _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics;
        private readonly GroupIdInformationsRestOperations _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected DeviceProvisioningServicesPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", DeviceProvisioningServicesPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceProvisioningServicesPrivateLinkResource.ResourceType, out string deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsApiVersion);
            _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient = new GroupIdInformationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceProvisioningServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceProvisioningServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified private link resource for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServicesPrivateLinkResource>> GetAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<DeviceProvisioningServicesPrivateLinkResource> Get(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResources(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private link resources for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_ListPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceProvisioningServicesPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceProvisioningServicesPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new DeviceProvisioningServicesPrivateLinkResource(Client, DeviceProvisioningServicesPrivateLinkResourceData.DeserializeDeviceProvisioningServicesPrivateLinkResourceData(e)), _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics, Pipeline, "DeviceProvisioningServicesPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List private link resources for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_ListPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceProvisioningServicesPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceProvisioningServicesPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new DeviceProvisioningServicesPrivateLinkResource(Client, DeviceProvisioningServicesPrivateLinkResourceData.DeserializeDeviceProvisioningServicesPrivateLinkResourceData(e)), _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics, Pipeline, "DeviceProvisioningServicesPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResources(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<NullableResponse<DeviceProvisioningServicesPrivateLinkResource>> GetIfExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeviceProvisioningServicesPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupIdInformation_GetPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual NullableResponse<DeviceProvisioningServicesPrivateLinkResource> GetIfExists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateLinkResourceGroupIdInformationsRestClient.GetPrivateLinkResources(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeviceProvisioningServicesPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceProvisioningServicesPrivateLinkResource> IEnumerable<DeviceProvisioningServicesPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceProvisioningServicesPrivateLinkResource> IAsyncEnumerable<DeviceProvisioningServicesPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
