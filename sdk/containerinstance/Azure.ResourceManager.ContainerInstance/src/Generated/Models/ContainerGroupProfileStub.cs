// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The object that contains a reference to a Container Group Profile and it's other related properties. </summary>
    public partial class ContainerGroupProfileStub
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

        /// <summary> Initializes a new instance of <see cref="ContainerGroupProfileStub"/>. </summary>
        public ContainerGroupProfileStub()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupProfileStub"/>. </summary>
        /// <param name="resource"> A reference to the container group profile ARM resource hosted in ACI RP. </param>
        /// <param name="revision"> The revision of the CG profile is an optional property. If customer does not to provide a revision then NGroups will pickup the latest revision of CGProfile. </param>
        /// <param name="networkProfile"> A network profile for network settings of a ContainerGroupProfile. </param>
        /// <param name="storageProfile"> Storage profile for storage related settings of a container group profile. </param>
        /// <param name="containerGroupProperties"> Container Group properties which can be set while creating or updating the NGroups. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupProfileStub(WritableSubResource resource, int? revision, ContainerGroupNetworkProfile networkProfile, StorageProfile storageProfile, NGroupContainerGroupProperties containerGroupProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resource = resource;
            Revision = revision;
            NetworkProfile = networkProfile;
            StorageProfile = storageProfile;
            ContainerGroupProperties = containerGroupProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A reference to the container group profile ARM resource hosted in ACI RP. </summary>
        internal WritableSubResource Resource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ResourceId
        {
            get => Resource is null ? default : Resource.Id;
            set
            {
                if (Resource is null)
                    Resource = new WritableSubResource();
                Resource.Id = value;
            }
        }

        /// <summary> The revision of the CG profile is an optional property. If customer does not to provide a revision then NGroups will pickup the latest revision of CGProfile. </summary>
        public int? Revision { get; set; }
        /// <summary> A network profile for network settings of a ContainerGroupProfile. </summary>
        public ContainerGroupNetworkProfile NetworkProfile { get; set; }
        /// <summary> Storage profile for storage related settings of a container group profile. </summary>
        internal StorageProfile StorageProfile { get; set; }
        /// <summary> Gets the storage file shares. </summary>
        public IList<ContainerGroupFileShare> StorageFileShares
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new StorageProfile();
                return StorageProfile.FileShares;
            }
        }

        /// <summary> Container Group properties which can be set while creating or updating the NGroups. </summary>
        public NGroupContainerGroupProperties ContainerGroupProperties { get; set; }
    }
}
