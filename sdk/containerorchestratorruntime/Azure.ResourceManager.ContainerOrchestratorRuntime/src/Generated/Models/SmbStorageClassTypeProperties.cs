// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> The properties of SMB StorageClass. </summary>
    public partial class SmbStorageClassTypeProperties : StorageClassTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="SmbStorageClassTypeProperties"/>. </summary>
        /// <param name="source"> SMB Source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public SmbStorageClassTypeProperties(string source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
            Type = StorageClassType.Smb;
        }

        /// <summary> Initializes a new instance of <see cref="SmbStorageClassTypeProperties"/>. </summary>
        /// <param name="type"> Type of the storage class. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="source"> SMB Source. </param>
        /// <param name="subDir"> Sub directory under share. If the sub directory doesn't exist, driver will create it. </param>
        /// <param name="username"> Server username. </param>
        /// <param name="password"> Server password. </param>
        /// <param name="domain"> Server domain. </param>
        internal SmbStorageClassTypeProperties(StorageClassType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string source, string subDir, string username, string password, string domain) : base(type, serializedAdditionalRawData)
        {
            Source = source;
            SubDir = subDir;
            Username = username;
            Password = password;
            Domain = domain;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="SmbStorageClassTypeProperties"/> for deserialization. </summary>
        internal SmbStorageClassTypeProperties()
        {
        }

        /// <summary> SMB Source. </summary>
        public string Source { get; set; }
        /// <summary> Sub directory under share. If the sub directory doesn't exist, driver will create it. </summary>
        public string SubDir { get; set; }
        /// <summary> Server username. </summary>
        public string Username { get; set; }
        /// <summary> Server password. </summary>
        public string Password { get; set; }
        /// <summary> Server domain. </summary>
        public string Domain { get; set; }
    }
}
