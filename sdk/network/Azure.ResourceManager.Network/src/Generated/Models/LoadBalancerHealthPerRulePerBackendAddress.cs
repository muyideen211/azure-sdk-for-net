// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The information about health per rule per backend address. </summary>
    public partial class LoadBalancerHealthPerRulePerBackendAddress
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

        /// <summary> Initializes a new instance of <see cref="LoadBalancerHealthPerRulePerBackendAddress"/>. </summary>
        internal LoadBalancerHealthPerRulePerBackendAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerHealthPerRulePerBackendAddress"/>. </summary>
        /// <param name="ipAddress"> The IP address belonging to the backend address. </param>
        /// <param name="networkInterfaceIPConfigurationResourceId"> Resource ID of the Network Interface IP Configuration. </param>
        /// <param name="state"> The current health of the backend instances that is associated to the LB rule. </param>
        /// <param name="reason"> The explanation of the State. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadBalancerHealthPerRulePerBackendAddress(string ipAddress, ResourceIdentifier networkInterfaceIPConfigurationResourceId, string state, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddress = ipAddress;
            NetworkInterfaceIPConfigurationResourceId = networkInterfaceIPConfigurationResourceId;
            State = state;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IP address belonging to the backend address. </summary>
        public string IPAddress { get; }
        /// <summary> Resource ID of the Network Interface IP Configuration. </summary>
        public ResourceIdentifier NetworkInterfaceIPConfigurationResourceId { get; }
        /// <summary> The current health of the backend instances that is associated to the LB rule. </summary>
        public string State { get; }
        /// <summary> The explanation of the State. </summary>
        public string Reason { get; }
    }
}
