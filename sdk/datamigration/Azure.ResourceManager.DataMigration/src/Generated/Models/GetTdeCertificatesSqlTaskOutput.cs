// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output of the task that gets TDE certificates in Base64 encoded format. </summary>
    public partial class GetTdeCertificatesSqlTaskOutput
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

        /// <summary> Initializes a new instance of <see cref="GetTdeCertificatesSqlTaskOutput"/>. </summary>
        internal GetTdeCertificatesSqlTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<DataMigrationReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="GetTdeCertificatesSqlTaskOutput"/>. </summary>
        /// <param name="base64EncodedCertificates"> Mapping from certificate name to base 64 encoded format. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetTdeCertificatesSqlTaskOutput(string base64EncodedCertificates, IReadOnlyList<DataMigrationReportableException> validationErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Base64EncodedCertificates = base64EncodedCertificates;
            ValidationErrors = validationErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Mapping from certificate name to base 64 encoded format. </summary>
        public string Base64EncodedCertificates { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<DataMigrationReportableException> ValidationErrors { get; }
    }
}
