// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the HybridComputeMachine data model.
    /// Describes a hybrid machine.
    /// </summary>
    public partial class HybridComputeMachineData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridComputeMachineData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<HybridComputeMachineExtensionData>();
            ErrorDetails = new ChangeTrackingList<ResponseError>();
            Extensions = new ChangeTrackingList<MachineExtensionInstanceView>();
            DetectedProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resources"> The list of extensions affiliated to the machine. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="kind"> Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc. </param>
        /// <param name="locationData"> Metadata pertaining to the geographic location of the resource. </param>
        /// <param name="agentConfiguration"> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </param>
        /// <param name="serviceStatuses"> Statuses of dependent services that are reported back to ARM. </param>
        /// <param name="hardwareProfile"> Information about the machine's hardware. </param>
        /// <param name="storageProfile"> Information about the machine's storage. </param>
        /// <param name="firmwareProfile"> Information about the machine's firmware. </param>
        /// <param name="cloudMetadata"> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </param>
        /// <param name="agentUpgrade"> The info of the machine w.r.t Agent Upgrade. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the hybrid machine. </param>
        /// <param name="licenseProfile"> Specifies the License related properties for a machine. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="status"> The status of the hybrid machine agent. </param>
        /// <param name="lastStatusChange"> The time of the last status change. </param>
        /// <param name="errorDetails"> Details about the error state. </param>
        /// <param name="agentVersion"> The hybrid machine agent full version. </param>
        /// <param name="vmId"> Specifies the hybrid machine unique ID. </param>
        /// <param name="displayName"> Specifies the hybrid machine display name. </param>
        /// <param name="machineFqdn"> Specifies the hybrid machine FQDN. </param>
        /// <param name="clientPublicKey"> Public Key that the client provides to be used during initial resource onboarding. </param>
        /// <param name="osName"> The Operating System running on the hybrid machine. </param>
        /// <param name="osVersion"> The version of Operating System running on the hybrid machine. </param>
        /// <param name="osType"> The type of Operating System (windows/linux). </param>
        /// <param name="vmUuid"> Specifies the Arc Machine's unique SMBIOS ID. </param>
        /// <param name="extensions"> Machine Extensions information (deprecated field). </param>
        /// <param name="osSku"> Specifies the Operating System product SKU. </param>
        /// <param name="osEdition"> The edition of the Operating System. </param>
        /// <param name="domainName"> Specifies the Windows domain name. </param>
        /// <param name="adFqdn"> Specifies the AD fully qualified display name. </param>
        /// <param name="dnsFqdn"> Specifies the DNS fully qualified display name. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this machine is assigned to, if any. </param>
        /// <param name="parentClusterResourceId"> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </param>
        /// <param name="msSqlDiscovered"> Specifies whether any MS SQL instance is discovered on the machine. </param>
        /// <param name="detectedProperties"> Detected properties from the machine. </param>
        /// <param name="networkProfile"> Information about the network the machine is on. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridComputeMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IReadOnlyList<HybridComputeMachineExtensionData> resources, ManagedServiceIdentity identity, ArcKindEnum? kind, HybridComputeLocation locationData, AgentConfiguration agentConfiguration, HybridComputeServiceStatuses serviceStatuses, HybridComputeHardwareProfile hardwareProfile, StorageProfile storageProfile, HybridComputeFirmwareProfile firmwareProfile, HybridComputeCloudMetadata cloudMetadata, AgentUpgrade agentUpgrade, HybridComputeOSProfile osProfile, LicenseProfileMachineInstanceView licenseProfile, string provisioningState, HybridComputeStatusType? status, DateTimeOffset? lastStatusChange, IReadOnlyList<ResponseError> errorDetails, string agentVersion, Guid? vmId, string displayName, string machineFqdn, string clientPublicKey, string osName, string osVersion, string osType, Guid? vmUuid, IList<MachineExtensionInstanceView> extensions, string osSku, string osEdition, string domainName, string adFqdn, string dnsFqdn, ResourceIdentifier privateLinkScopeResourceId, ResourceIdentifier parentClusterResourceId, string msSqlDiscovered, IReadOnlyDictionary<string, string> detectedProperties, HybridComputeNetworkProfile networkProfile, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resources = resources;
            Identity = identity;
            Kind = kind;
            LocationData = locationData;
            AgentConfiguration = agentConfiguration;
            ServiceStatuses = serviceStatuses;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            FirmwareProfile = firmwareProfile;
            CloudMetadata = cloudMetadata;
            AgentUpgrade = agentUpgrade;
            OSProfile = osProfile;
            LicenseProfile = licenseProfile;
            ProvisioningState = provisioningState;
            Status = status;
            LastStatusChange = lastStatusChange;
            ErrorDetails = errorDetails;
            AgentVersion = agentVersion;
            VmId = vmId;
            DisplayName = displayName;
            MachineFqdn = machineFqdn;
            ClientPublicKey = clientPublicKey;
            OSName = osName;
            OSVersion = osVersion;
            OSType = osType;
            VmUuid = vmUuid;
            Extensions = extensions;
            OSSku = osSku;
            OSEdition = osEdition;
            DomainName = domainName;
            ADFqdn = adFqdn;
            DnsFqdn = dnsFqdn;
            PrivateLinkScopeResourceId = privateLinkScopeResourceId;
            ParentClusterResourceId = parentClusterResourceId;
            MSSqlDiscovered = msSqlDiscovered;
            DetectedProperties = detectedProperties;
            NetworkProfile = networkProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeMachineData"/> for deserialization. </summary>
        internal HybridComputeMachineData()
        {
        }

        /// <summary> The list of extensions affiliated to the machine. </summary>
        [WirePath("resources")]
        public IReadOnlyList<HybridComputeMachineExtensionData> Resources { get; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc. </summary>
        [WirePath("kind")]
        public ArcKindEnum? Kind { get; set; }
        /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
        [WirePath("properties.locationData")]
        public HybridComputeLocation LocationData { get; set; }
        /// <summary> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </summary>
        [WirePath("properties.agentConfiguration")]
        public AgentConfiguration AgentConfiguration { get; }
        /// <summary> Statuses of dependent services that are reported back to ARM. </summary>
        [WirePath("properties.serviceStatuses")]
        public HybridComputeServiceStatuses ServiceStatuses { get; set; }
        /// <summary> Information about the machine's hardware. </summary>
        [WirePath("properties.hardwareProfile")]
        public HybridComputeHardwareProfile HardwareProfile { get; }
        /// <summary> Information about the machine's storage. </summary>
        internal StorageProfile StorageProfile { get; }
        /// <summary> The disks on the machine. </summary>
        [WirePath("properties.storageProfile.disks")]
        public IReadOnlyList<HybridComputeDisk> StorageDisks
        {
            get => StorageProfile?.Disks;
        }

        /// <summary> Information about the machine's firmware. </summary>
        [WirePath("properties.firmwareProfile")]
        public HybridComputeFirmwareProfile FirmwareProfile { get; }
        /// <summary> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </summary>
        internal HybridComputeCloudMetadata CloudMetadata { get; set; }
        /// <summary> Specifies the cloud provider (Azure/AWS/GCP...). </summary>
        [WirePath("properties.cloudMetadata.provider")]
        public string CloudMetadataProvider
        {
            get => CloudMetadata is null ? default : CloudMetadata.Provider;
        }

        /// <summary> The info of the machine w.r.t Agent Upgrade. </summary>
        [WirePath("properties.agentUpgrade")]
        public AgentUpgrade AgentUpgrade { get; set; }
        /// <summary> Specifies the operating system settings for the hybrid machine. </summary>
        [WirePath("properties.osProfile")]
        public HybridComputeOSProfile OSProfile { get; set; }
        /// <summary> Specifies the License related properties for a machine. </summary>
        [WirePath("properties.licenseProfile")]
        public LicenseProfileMachineInstanceView LicenseProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> The status of the hybrid machine agent. </summary>
        [WirePath("properties.status")]
        public HybridComputeStatusType? Status { get; }
        /// <summary> The time of the last status change. </summary>
        [WirePath("properties.lastStatusChange")]
        public DateTimeOffset? LastStatusChange { get; }
        /// <summary> Details about the error state. </summary>
        [WirePath("properties.errorDetails")]
        public IReadOnlyList<ResponseError> ErrorDetails { get; }
        /// <summary> The hybrid machine agent full version. </summary>
        [WirePath("properties.agentVersion")]
        public string AgentVersion { get; }
        /// <summary> Specifies the hybrid machine unique ID. </summary>
        [WirePath("properties.vmId")]
        public Guid? VmId { get; set; }
        /// <summary> Specifies the hybrid machine display name. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; }
        /// <summary> Specifies the hybrid machine FQDN. </summary>
        [WirePath("properties.machineFqdn")]
        public string MachineFqdn { get; }
        /// <summary> Public Key that the client provides to be used during initial resource onboarding. </summary>
        [WirePath("properties.clientPublicKey")]
        public string ClientPublicKey { get; set; }
        /// <summary> The Operating System running on the hybrid machine. </summary>
        [WirePath("properties.osName")]
        public string OSName { get; }
        /// <summary> The version of Operating System running on the hybrid machine. </summary>
        [WirePath("properties.osVersion")]
        public string OSVersion { get; }
        /// <summary> The type of Operating System (windows/linux). </summary>
        [WirePath("properties.osType")]
        public string OSType { get; set; }
        /// <summary> Specifies the Arc Machine's unique SMBIOS ID. </summary>
        [WirePath("properties.vmUuid")]
        public Guid? VmUuid { get; }
        /// <summary> Machine Extensions information (deprecated field). </summary>
        [WirePath("properties.extensions")]
        public IList<MachineExtensionInstanceView> Extensions { get; }
        /// <summary> Specifies the Operating System product SKU. </summary>
        [WirePath("properties.osSku")]
        public string OSSku { get; }
        /// <summary> The edition of the Operating System. </summary>
        [WirePath("properties.osEdition")]
        public string OSEdition { get; }
        /// <summary> Specifies the Windows domain name. </summary>
        [WirePath("properties.domainName")]
        public string DomainName { get; }
        /// <summary> Specifies the AD fully qualified display name. </summary>
        [WirePath("properties.adFqdn")]
        public string ADFqdn { get; }
        /// <summary> Specifies the DNS fully qualified display name. </summary>
        [WirePath("properties.dnsFqdn")]
        public string DnsFqdn { get; }
        /// <summary> The resource id of the private link scope this machine is assigned to, if any. </summary>
        [WirePath("properties.privateLinkScopeResourceId")]
        public ResourceIdentifier PrivateLinkScopeResourceId { get; set; }
        /// <summary> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </summary>
        [WirePath("properties.parentClusterResourceId")]
        public ResourceIdentifier ParentClusterResourceId { get; set; }
        /// <summary> Specifies whether any MS SQL instance is discovered on the machine. </summary>
        [WirePath("properties.mssqlDiscovered")]
        public string MSSqlDiscovered { get; set; }
        /// <summary> Detected properties from the machine. </summary>
        [WirePath("properties.detectedProperties")]
        public IReadOnlyDictionary<string, string> DetectedProperties { get; }
        /// <summary> Information about the network the machine is on. </summary>
        internal HybridComputeNetworkProfile NetworkProfile { get; }
        /// <summary> The list of network interfaces. </summary>
        [WirePath("properties.networkProfile.networkInterfaces")]
        public IReadOnlyList<HybridComputeNetworkInterface> NetworkInterfaces
        {
            get => NetworkProfile?.NetworkInterfaces;
        }
    }
}
