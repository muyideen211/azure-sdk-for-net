// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The location capability. </summary>
    public partial class SqlLocationCapabilities
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

        /// <summary> Initializes a new instance of <see cref="SqlLocationCapabilities"/>. </summary>
        internal SqlLocationCapabilities()
        {
            SupportedServerVersions = new ChangeTrackingList<SqlServerVersionCapability>();
            SupportedManagedInstanceVersions = new ChangeTrackingList<ManagedInstanceVersionCapability>();
            SupportedJobAgentVersions = new ChangeTrackingList<JobAgentVersionCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlLocationCapabilities"/>. </summary>
        /// <param name="name"> The location name. </param>
        /// <param name="supportedServerVersions"> The list of supported server versions. </param>
        /// <param name="supportedManagedInstanceVersions"> The list of supported managed instance versions. </param>
        /// <param name="supportedJobAgentVersions"> The list of supported job agent versions. </param>
        /// <param name="isZoneResilientProvisioningAllowed"> Whether or not the subscription is allowed to provision zone resilient resources. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlLocationCapabilities(string name, IReadOnlyList<SqlServerVersionCapability> supportedServerVersions, IReadOnlyList<ManagedInstanceVersionCapability> supportedManagedInstanceVersions, IReadOnlyList<JobAgentVersionCapability> supportedJobAgentVersions, bool? isZoneResilientProvisioningAllowed, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SupportedServerVersions = supportedServerVersions;
            SupportedManagedInstanceVersions = supportedManagedInstanceVersions;
            SupportedJobAgentVersions = supportedJobAgentVersions;
            IsZoneResilientProvisioningAllowed = isZoneResilientProvisioningAllowed;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location name. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The list of supported server versions. </summary>
        [WirePath("supportedServerVersions")]
        public IReadOnlyList<SqlServerVersionCapability> SupportedServerVersions { get; }
        /// <summary> The list of supported managed instance versions. </summary>
        [WirePath("supportedManagedInstanceVersions")]
        public IReadOnlyList<ManagedInstanceVersionCapability> SupportedManagedInstanceVersions { get; }
        /// <summary> The list of supported job agent versions. </summary>
        [WirePath("supportedJobAgentVersions")]
        public IReadOnlyList<JobAgentVersionCapability> SupportedJobAgentVersions { get; }
        /// <summary> Whether or not the subscription is allowed to provision zone resilient resources. </summary>
        [WirePath("isZoneResilientProvisioningAllowed")]
        public bool? IsZoneResilientProvisioningAllowed { get; }
        /// <summary> The status of the capability. </summary>
        [WirePath("status")]
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        [WirePath("reason")]
        public string Reason { get; }
    }
}
