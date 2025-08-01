// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that gets the list of tables for a provided list of PostgreSQL databases. </summary>
    public partial class GetUserTablesPostgreSqlTaskInput
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

        /// <summary> Initializes a new instance of <see cref="GetUserTablesPostgreSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Information for connecting to PostgreSQL source. </param>
        /// <param name="selectedDatabases"> List of PostgreSQL databases for which to collect tables. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public GetUserTablesPostgreSqlTaskInput(DataMigrationPostgreSqlConnectionInfo connectionInfo, IEnumerable<string> selectedDatabases)
        {
            Argument.AssertNotNull(connectionInfo, nameof(connectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));

            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GetUserTablesPostgreSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Information for connecting to PostgreSQL source. </param>
        /// <param name="selectedDatabases"> List of PostgreSQL databases for which to collect tables. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetUserTablesPostgreSqlTaskInput(DataMigrationPostgreSqlConnectionInfo connectionInfo, IList<string> selectedDatabases, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetUserTablesPostgreSqlTaskInput"/> for deserialization. </summary>
        internal GetUserTablesPostgreSqlTaskInput()
        {
        }

        /// <summary> Information for connecting to PostgreSQL source. </summary>
        public DataMigrationPostgreSqlConnectionInfo ConnectionInfo { get; set; }
        /// <summary> List of PostgreSQL databases for which to collect tables. </summary>
        public IList<string> SelectedDatabases { get; }
    }
}
