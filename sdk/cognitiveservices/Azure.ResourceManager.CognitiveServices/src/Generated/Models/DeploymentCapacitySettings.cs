// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Internal use only. </summary>
    public partial class DeploymentCapacitySettings
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

        /// <summary> Initializes a new instance of <see cref="DeploymentCapacitySettings"/>. </summary>
        public DeploymentCapacitySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentCapacitySettings"/>. </summary>
        /// <param name="designatedCapacity"> The designated capacity. </param>
        /// <param name="priority"> The priority of this capacity setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeploymentCapacitySettings(int? designatedCapacity, int? priority, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DesignatedCapacity = designatedCapacity;
            Priority = priority;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The designated capacity. </summary>
        [WirePath("designatedCapacity")]
        public int? DesignatedCapacity { get; set; }
        /// <summary> The priority of this capacity setting. </summary>
        [WirePath("priority")]
        public int? Priority { get; set; }
    }
}
