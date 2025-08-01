// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that gets TDE certificates in Base64 encoded format. </summary>
    public partial class GetTdeCertificatesSqlTaskInput
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

        /// <summary> Initializes a new instance of <see cref="GetTdeCertificatesSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Connection information for SQL Server. </param>
        /// <param name="backupFileShare"> Backup file share information for file share to be used for temporarily storing files. </param>
        /// <param name="selectedCertificates"> List containing certificate names and corresponding password to use for encrypting the exported certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionInfo"/>, <paramref name="backupFileShare"/> or <paramref name="selectedCertificates"/> is null. </exception>
        public GetTdeCertificatesSqlTaskInput(DataMigrationSqlConnectionInfo connectionInfo, DataMigrationFileShareInfo backupFileShare, IEnumerable<SelectedCertificateInput> selectedCertificates)
        {
            Argument.AssertNotNull(connectionInfo, nameof(connectionInfo));
            Argument.AssertNotNull(backupFileShare, nameof(backupFileShare));
            Argument.AssertNotNull(selectedCertificates, nameof(selectedCertificates));

            ConnectionInfo = connectionInfo;
            BackupFileShare = backupFileShare;
            SelectedCertificates = selectedCertificates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GetTdeCertificatesSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Connection information for SQL Server. </param>
        /// <param name="backupFileShare"> Backup file share information for file share to be used for temporarily storing files. </param>
        /// <param name="selectedCertificates"> List containing certificate names and corresponding password to use for encrypting the exported certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetTdeCertificatesSqlTaskInput(DataMigrationSqlConnectionInfo connectionInfo, DataMigrationFileShareInfo backupFileShare, IList<SelectedCertificateInput> selectedCertificates, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionInfo = connectionInfo;
            BackupFileShare = backupFileShare;
            SelectedCertificates = selectedCertificates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetTdeCertificatesSqlTaskInput"/> for deserialization. </summary>
        internal GetTdeCertificatesSqlTaskInput()
        {
        }

        /// <summary> Connection information for SQL Server. </summary>
        public DataMigrationSqlConnectionInfo ConnectionInfo { get; set; }
        /// <summary> Backup file share information for file share to be used for temporarily storing files. </summary>
        public DataMigrationFileShareInfo BackupFileShare { get; set; }
        /// <summary> List containing certificate names and corresponding password to use for encrypting the exported certificate. </summary>
        public IList<SelectedCertificateInput> SelectedCertificates { get; }
    }
}
