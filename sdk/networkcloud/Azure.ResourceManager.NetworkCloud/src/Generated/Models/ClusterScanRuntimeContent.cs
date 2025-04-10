// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterScanRuntimeParameters defines the parameters for the cluster scan runtime operation. </summary>
    public partial class ClusterScanRuntimeContent
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

        /// <summary> Initializes a new instance of <see cref="ClusterScanRuntimeContent"/>. </summary>
        public ClusterScanRuntimeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterScanRuntimeContent"/>. </summary>
        /// <param name="scanActivity"> The choice of if the scan operation should run the scan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterScanRuntimeContent(ClusterScanRuntimeParametersScanActivity? scanActivity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScanActivity = scanActivity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The choice of if the scan operation should run the scan. </summary>
        public ClusterScanRuntimeParametersScanActivity? ScanActivity { get; set; }
    }
}
