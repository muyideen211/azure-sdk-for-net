// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableNetworkCloudArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNetworkCloudArmClient"/> class for mocking. </summary>
        protected MockableNetworkCloudArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNetworkCloudArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNetworkCloudArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableNetworkCloudArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudBareMetalMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudBareMetalMachineResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudBareMetalMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudBareMetalMachineResource"/> object. </returns>
        public virtual NetworkCloudBareMetalMachineResource GetNetworkCloudBareMetalMachineResource(ResourceIdentifier id)
        {
            NetworkCloudBareMetalMachineResource.ValidateResourceId(id);
            return new NetworkCloudBareMetalMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudCloudServicesNetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudCloudServicesNetworkResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudCloudServicesNetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudCloudServicesNetworkResource"/> object. </returns>
        public virtual NetworkCloudCloudServicesNetworkResource GetNetworkCloudCloudServicesNetworkResource(ResourceIdentifier id)
        {
            NetworkCloudCloudServicesNetworkResource.ValidateResourceId(id);
            return new NetworkCloudCloudServicesNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudClusterManagerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudClusterManagerResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudClusterManagerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudClusterManagerResource"/> object. </returns>
        public virtual NetworkCloudClusterManagerResource GetNetworkCloudClusterManagerResource(ResourceIdentifier id)
        {
            NetworkCloudClusterManagerResource.ValidateResourceId(id);
            return new NetworkCloudClusterManagerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudClusterResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudClusterResource"/> object. </returns>
        public virtual NetworkCloudClusterResource GetNetworkCloudClusterResource(ResourceIdentifier id)
        {
            NetworkCloudClusterResource.ValidateResourceId(id);
            return new NetworkCloudClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudKubernetesClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudKubernetesClusterResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudKubernetesClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudKubernetesClusterResource"/> object. </returns>
        public virtual NetworkCloudKubernetesClusterResource GetNetworkCloudKubernetesClusterResource(ResourceIdentifier id)
        {
            NetworkCloudKubernetesClusterResource.ValidateResourceId(id);
            return new NetworkCloudKubernetesClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudL2NetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudL2NetworkResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudL2NetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudL2NetworkResource"/> object. </returns>
        public virtual NetworkCloudL2NetworkResource GetNetworkCloudL2NetworkResource(ResourceIdentifier id)
        {
            NetworkCloudL2NetworkResource.ValidateResourceId(id);
            return new NetworkCloudL2NetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudL3NetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudL3NetworkResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudL3NetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudL3NetworkResource"/> object. </returns>
        public virtual NetworkCloudL3NetworkResource GetNetworkCloudL3NetworkResource(ResourceIdentifier id)
        {
            NetworkCloudL3NetworkResource.ValidateResourceId(id);
            return new NetworkCloudL3NetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudRackSkuResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudRackSkuResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudRackSkuResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudRackSkuResource"/> object. </returns>
        public virtual NetworkCloudRackSkuResource GetNetworkCloudRackSkuResource(ResourceIdentifier id)
        {
            NetworkCloudRackSkuResource.ValidateResourceId(id);
            return new NetworkCloudRackSkuResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudRackResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudRackResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudRackResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudRackResource"/> object. </returns>
        public virtual NetworkCloudRackResource GetNetworkCloudRackResource(ResourceIdentifier id)
        {
            NetworkCloudRackResource.ValidateResourceId(id);
            return new NetworkCloudRackResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudStorageApplianceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudStorageApplianceResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudStorageApplianceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudStorageApplianceResource"/> object. </returns>
        public virtual NetworkCloudStorageApplianceResource GetNetworkCloudStorageApplianceResource(ResourceIdentifier id)
        {
            NetworkCloudStorageApplianceResource.ValidateResourceId(id);
            return new NetworkCloudStorageApplianceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudTrunkedNetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudTrunkedNetworkResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudTrunkedNetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudTrunkedNetworkResource"/> object. </returns>
        public virtual NetworkCloudTrunkedNetworkResource GetNetworkCloudTrunkedNetworkResource(ResourceIdentifier id)
        {
            NetworkCloudTrunkedNetworkResource.ValidateResourceId(id);
            return new NetworkCloudTrunkedNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudVirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudVirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudVirtualMachineResource"/> object. </returns>
        public virtual NetworkCloudVirtualMachineResource GetNetworkCloudVirtualMachineResource(ResourceIdentifier id)
        {
            NetworkCloudVirtualMachineResource.ValidateResourceId(id);
            return new NetworkCloudVirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudVolumeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudVolumeResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudVolumeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudVolumeResource"/> object. </returns>
        public virtual NetworkCloudVolumeResource GetNetworkCloudVolumeResource(ResourceIdentifier id)
        {
            NetworkCloudVolumeResource.ValidateResourceId(id);
            return new NetworkCloudVolumeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudBareMetalMachineKeySetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudBareMetalMachineKeySetResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudBareMetalMachineKeySetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudBareMetalMachineKeySetResource"/> object. </returns>
        public virtual NetworkCloudBareMetalMachineKeySetResource GetNetworkCloudBareMetalMachineKeySetResource(ResourceIdentifier id)
        {
            NetworkCloudBareMetalMachineKeySetResource.ValidateResourceId(id);
            return new NetworkCloudBareMetalMachineKeySetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudBmcKeySetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudBmcKeySetResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudBmcKeySetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudBmcKeySetResource"/> object. </returns>
        public virtual NetworkCloudBmcKeySetResource GetNetworkCloudBmcKeySetResource(ResourceIdentifier id)
        {
            NetworkCloudBmcKeySetResource.ValidateResourceId(id);
            return new NetworkCloudBmcKeySetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudClusterMetricsConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudClusterMetricsConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudClusterMetricsConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudClusterMetricsConfigurationResource"/> object. </returns>
        public virtual NetworkCloudClusterMetricsConfigurationResource GetNetworkCloudClusterMetricsConfigurationResource(ResourceIdentifier id)
        {
            NetworkCloudClusterMetricsConfigurationResource.ValidateResourceId(id);
            return new NetworkCloudClusterMetricsConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudAgentPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudAgentPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudAgentPoolResource"/> object. </returns>
        public virtual NetworkCloudAgentPoolResource GetNetworkCloudAgentPoolResource(ResourceIdentifier id)
        {
            NetworkCloudAgentPoolResource.ValidateResourceId(id);
            return new NetworkCloudAgentPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudKubernetesClusterFeatureResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudKubernetesClusterFeatureResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudKubernetesClusterFeatureResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudKubernetesClusterFeatureResource"/> object. </returns>
        public virtual NetworkCloudKubernetesClusterFeatureResource GetNetworkCloudKubernetesClusterFeatureResource(ResourceIdentifier id)
        {
            NetworkCloudKubernetesClusterFeatureResource.ValidateResourceId(id);
            return new NetworkCloudKubernetesClusterFeatureResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkCloudVirtualMachineConsoleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkCloudVirtualMachineConsoleResource.CreateResourceIdentifier" /> to create a <see cref="NetworkCloudVirtualMachineConsoleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkCloudVirtualMachineConsoleResource"/> object. </returns>
        public virtual NetworkCloudVirtualMachineConsoleResource GetNetworkCloudVirtualMachineConsoleResource(ResourceIdentifier id)
        {
            NetworkCloudVirtualMachineConsoleResource.ValidateResourceId(id);
            return new NetworkCloudVirtualMachineConsoleResource(Client, id);
        }
    }
}
