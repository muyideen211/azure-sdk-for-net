// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> P2SConnectionConfiguration Resource. </summary>
    public partial class P2SConnectionConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="P2SConnectionConfiguration"/>. </summary>
        public P2SConnectionConfiguration()
        {
            ConfigurationPolicyGroups = new ChangeTrackingList<WritableSubResource>();
            PreviousConfigurationPolicyGroupAssociations = new ChangeTrackingList<VpnServerConfigurationPolicyGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="P2SConnectionConfiguration"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="vpnClientAddressPool"> The reference to the address space resource which represents Address space for P2S VpnClient. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        /// <param name="enableInternetSecurity"> Flag indicating whether the enable internet security flag is turned on for the P2S Connections or not. </param>
        /// <param name="configurationPolicyGroups"> List of Configuration Policy Groups that this P2SConnectionConfiguration is attached to. </param>
        /// <param name="previousConfigurationPolicyGroupAssociations"> List of previous Configuration Policy Groups that this P2SConnectionConfiguration was attached to. </param>
        /// <param name="provisioningState"> The provisioning state of the P2SConnectionConfiguration resource. </param>
        internal P2SConnectionConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, VirtualNetworkAddressSpace vpnClientAddressPool, RoutingConfiguration routingConfiguration, bool? enableInternetSecurity, IList<WritableSubResource> configurationPolicyGroups, IReadOnlyList<VpnServerConfigurationPolicyGroupData> previousConfigurationPolicyGroupAssociations, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            VpnClientAddressPool = vpnClientAddressPool;
            RoutingConfiguration = routingConfiguration;
            EnableInternetSecurity = enableInternetSecurity;
            ConfigurationPolicyGroups = configurationPolicyGroups;
            PreviousConfigurationPolicyGroupAssociations = previousConfigurationPolicyGroupAssociations;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the address space resource which represents Address space for P2S VpnClient. </summary>
        public VirtualNetworkAddressSpace VpnClientAddressPool { get; set; }
        /// <summary> The Routing Configuration indicating the associated and propagated route tables on this connection. </summary>
        public RoutingConfiguration RoutingConfiguration { get; set; }
        /// <summary> Flag indicating whether the enable internet security flag is turned on for the P2S Connections or not. </summary>
        public bool? EnableInternetSecurity { get; set; }
        /// <summary> List of Configuration Policy Groups that this P2SConnectionConfiguration is attached to. </summary>
        public IList<WritableSubResource> ConfigurationPolicyGroups { get; }
        /// <summary> List of previous Configuration Policy Groups that this P2SConnectionConfiguration was attached to. </summary>
        public IReadOnlyList<VpnServerConfigurationPolicyGroupData> PreviousConfigurationPolicyGroupAssociations { get; }
        /// <summary> The provisioning state of the P2SConnectionConfiguration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
