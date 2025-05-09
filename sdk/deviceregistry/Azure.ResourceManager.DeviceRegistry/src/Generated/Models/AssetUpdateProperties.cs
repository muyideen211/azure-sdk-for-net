// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> The updatable properties of the Asset. </summary>
    public partial class AssetUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="AssetUpdateProperties"/>. </summary>
        public AssetUpdateProperties()
        {
            Attributes = new ChangeTrackingDictionary<string, BinaryData>();
            Datasets = new ChangeTrackingList<DeviceRegistryDataset>();
            Events = new ChangeTrackingList<DeviceRegistryEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetUpdateProperties"/>. </summary>
        /// <param name="isEnabled"> Enabled/Disabled status of the asset. </param>
        /// <param name="displayName"> Human-readable display name. </param>
        /// <param name="description"> Human-readable description of the asset. </param>
        /// <param name="manufacturer"> Asset manufacturer name. </param>
        /// <param name="manufacturerUri"> Asset manufacturer URI. </param>
        /// <param name="model"> Asset model name. </param>
        /// <param name="productCode"> Asset product code. </param>
        /// <param name="hardwareRevision"> Revision number of the hardware. </param>
        /// <param name="softwareRevision"> Revision number of the software. </param>
        /// <param name="documentationUri"> Reference to the documentation. </param>
        /// <param name="serialNumber"> Asset serial number. </param>
        /// <param name="attributes"> A set of key-value pairs that contain custom attributes set by the customer. </param>
        /// <param name="defaultDatasetsConfiguration"> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultEventsConfiguration"> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultTopic"> Object that describes the default topic information for the asset. </param>
        /// <param name="datasets"> Array of datasets that are part of the asset. Each dataset describes the data points that make up the set. </param>
        /// <param name="events"> Array of events that are part of the asset. Each event can have per-event configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetUpdateProperties(bool? isEnabled, string displayName, string description, string manufacturer, Uri manufacturerUri, string model, string productCode, string hardwareRevision, string softwareRevision, Uri documentationUri, string serialNumber, IDictionary<string, BinaryData> attributes, string defaultDatasetsConfiguration, string defaultEventsConfiguration, DeviceRegistryTopic defaultTopic, IList<DeviceRegistryDataset> datasets, IList<DeviceRegistryEvent> events, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            DisplayName = displayName;
            Description = description;
            Manufacturer = manufacturer;
            ManufacturerUri = manufacturerUri;
            Model = model;
            ProductCode = productCode;
            HardwareRevision = hardwareRevision;
            SoftwareRevision = softwareRevision;
            DocumentationUri = documentationUri;
            SerialNumber = serialNumber;
            Attributes = attributes;
            DefaultDatasetsConfiguration = defaultDatasetsConfiguration;
            DefaultEventsConfiguration = defaultEventsConfiguration;
            DefaultTopic = defaultTopic;
            Datasets = datasets;
            Events = events;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enabled/Disabled status of the asset. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Human-readable display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Human-readable description of the asset. </summary>
        public string Description { get; set; }
        /// <summary> Asset manufacturer name. </summary>
        public string Manufacturer { get; set; }
        /// <summary> Asset manufacturer URI. </summary>
        public Uri ManufacturerUri { get; set; }
        /// <summary> Asset model name. </summary>
        public string Model { get; set; }
        /// <summary> Asset product code. </summary>
        public string ProductCode { get; set; }
        /// <summary> Revision number of the hardware. </summary>
        public string HardwareRevision { get; set; }
        /// <summary> Revision number of the software. </summary>
        public string SoftwareRevision { get; set; }
        /// <summary> Reference to the documentation. </summary>
        public Uri DocumentationUri { get; set; }
        /// <summary> Asset serial number. </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// A set of key-value pairs that contain custom attributes set by the customer.
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
        public IDictionary<string, BinaryData> Attributes { get; }
        /// <summary> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </summary>
        public string DefaultDatasetsConfiguration { get; set; }
        /// <summary> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </summary>
        public string DefaultEventsConfiguration { get; set; }
        /// <summary> Object that describes the default topic information for the asset. </summary>
        public DeviceRegistryTopic DefaultTopic { get; set; }
        /// <summary> Array of datasets that are part of the asset. Each dataset describes the data points that make up the set. </summary>
        public IList<DeviceRegistryDataset> Datasets { get; }
        /// <summary> Array of events that are part of the asset. Each event can have per-event configuration. </summary>
        public IList<DeviceRegistryEvent> Events { get; }
    }
}
