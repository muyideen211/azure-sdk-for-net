// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> virtualNetworkAddress resource properties. </summary>
    public partial class CloudVmClusterVirtualNetworkAddressProperties
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

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterVirtualNetworkAddressProperties"/>. </summary>
        public CloudVmClusterVirtualNetworkAddressProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterVirtualNetworkAddressProperties"/>. </summary>
        /// <param name="ipAddress"> Virtual network Address address. </param>
        /// <param name="vipVmOcid"> Virtual Machine OCID. </param>
        /// <param name="vipOcid"> Application VIP OCID. </param>
        /// <param name="domain"> Virtual network address fully qualified domain name. </param>
        /// <param name="lifecycleDetails"> Additional information about the current lifecycle state of the application virtual IP (VIP) address. </param>
        /// <param name="provisioningState"> Azure resource provisioning state. </param>
        /// <param name="lifecycleState"> virtual network address lifecycle state. </param>
        /// <param name="assignedOn"> The date and time when the create operation for the application virtual IP (VIP) address completed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudVmClusterVirtualNetworkAddressProperties(string ipAddress, string vipVmOcid, string vipOcid, string domain, string lifecycleDetails, OracleDatabaseProvisioningState? provisioningState, VirtualNetworkAddressLifecycleState? lifecycleState, DateTimeOffset? assignedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddress = ipAddress;
            VipVmOcid = vipVmOcid;
            VipOcid = vipOcid;
            Domain = domain;
            LifecycleDetails = lifecycleDetails;
            ProvisioningState = provisioningState;
            LifecycleState = lifecycleState;
            AssignedOn = assignedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Virtual network Address address. </summary>
        public string IPAddress { get; set; }
        /// <summary> Virtual Machine OCID. </summary>
        public string VipVmOcid { get; set; }
        /// <summary> Application VIP OCID. </summary>
        public string VipOcid { get; }
        /// <summary> Virtual network address fully qualified domain name. </summary>
        public string Domain { get; }
        /// <summary> Additional information about the current lifecycle state of the application virtual IP (VIP) address. </summary>
        public string LifecycleDetails { get; }
        /// <summary> Azure resource provisioning state. </summary>
        public OracleDatabaseProvisioningState? ProvisioningState { get; }
        /// <summary> virtual network address lifecycle state. </summary>
        public VirtualNetworkAddressLifecycleState? LifecycleState { get; }
        /// <summary> The date and time when the create operation for the application virtual IP (VIP) address completed. </summary>
        public DateTimeOffset? AssignedOn { get; }
    }
}
