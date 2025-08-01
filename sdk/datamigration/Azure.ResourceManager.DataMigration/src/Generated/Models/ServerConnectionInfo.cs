// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Defines the connection properties of a server
    /// Please note <see cref="ServerConnectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataMigrationMISqlConnectionInfo"/>, <see cref="DataMigrationMongoDBConnectionInfo"/>, <see cref="DataMigrationMySqlConnectionInfo"/>, <see cref="DataMigrationOracleConnectionInfo"/>, <see cref="DataMigrationPostgreSqlConnectionInfo"/> and <see cref="DataMigrationSqlConnectionInfo"/>.
    /// </summary>
    public abstract partial class ServerConnectionInfo
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServerConnectionInfo"/>. </summary>
        protected ServerConnectionInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServerConnectionInfo"/>. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerConnectionInfo(string connectionInfoType, string userName, string password, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionInfoType = connectionInfoType;
            UserName = userName;
            Password = password;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of connection info. </summary>
        internal string ConnectionInfoType { get; set; }
        /// <summary> User name. </summary>
        public string UserName { get; set; }
        /// <summary> Password credential. </summary>
        public string Password { get; set; }
    }
}
