// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(BigDataPoolResourceInfoConverter))]
    public partial class BigDataPoolResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale);
            }
            if (Optional.IsDefined(CreationDate))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreationDate.Value, "O");
            }
            if (Optional.IsDefined(AutoPause))
            {
                writer.WritePropertyName("autoPause"u8);
                writer.WriteObjectValue(AutoPause);
            }
            if (Optional.IsDefined(IsComputeIsolationEnabled))
            {
                writer.WritePropertyName("isComputeIsolationEnabled"u8);
                writer.WriteBooleanValue(IsComputeIsolationEnabled.Value);
            }
            if (Optional.IsDefined(SessionLevelPackagesEnabled))
            {
                writer.WritePropertyName("sessionLevelPackagesEnabled"u8);
                writer.WriteBooleanValue(SessionLevelPackagesEnabled.Value);
            }
            if (Optional.IsDefined(CacheSize))
            {
                writer.WritePropertyName("cacheSize"u8);
                writer.WriteNumberValue(CacheSize.Value);
            }
            if (Optional.IsDefined(DynamicExecutorAllocation))
            {
                writer.WritePropertyName("dynamicExecutorAllocation"u8);
                writer.WriteObjectValue(DynamicExecutorAllocation);
            }
            if (Optional.IsDefined(SparkEventsFolder))
            {
                writer.WritePropertyName("sparkEventsFolder"u8);
                writer.WriteStringValue(SparkEventsFolder);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(LibraryRequirements))
            {
                writer.WritePropertyName("libraryRequirements"u8);
                writer.WriteObjectValue(LibraryRequirements);
            }
            if (Optional.IsCollectionDefined(CustomLibraries))
            {
                writer.WritePropertyName("customLibraries"u8);
                writer.WriteStartArray();
                foreach (var item in CustomLibraries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SparkConfigProperties))
            {
                writer.WritePropertyName("sparkConfigProperties"u8);
                writer.WriteObjectValue(SparkConfigProperties);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(DefaultSparkLogFolder))
            {
                writer.WritePropertyName("defaultSparkLogFolder"u8);
                writer.WriteStringValue(DefaultSparkLogFolder);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize.Value.ToString());
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily"u8);
                writer.WriteStringValue(NodeSizeFamily.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BigDataPoolResourceInfo DeserializeBigDataPoolResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string location = default;
            string id = default;
            string name = default;
            string type = default;
            string provisioningState = default;
            AutoScaleProperties autoScale = default;
            DateTimeOffset? creationDate = default;
            AutoPauseProperties autoPause = default;
            bool? isComputeIsolationEnabled = default;
            bool? sessionLevelPackagesEnabled = default;
            int? cacheSize = default;
            DynamicExecutorAllocation dynamicExecutorAllocation = default;
            string sparkEventsFolder = default;
            int? nodeCount = default;
            LibraryRequirements libraryRequirements = default;
            IList<LibraryInfo> customLibraries = default;
            LibraryRequirements sparkConfigProperties = default;
            string sparkVersion = default;
            string defaultSparkLogFolder = default;
            NodeSize? nodeSize = default;
            NodeSizeFamily? nodeSizeFamily = default;
            DateTimeOffset? lastSucceededTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoScale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScale = AutoScaleProperties.DeserializeAutoScaleProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoPause"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoPause = AutoPauseProperties.DeserializeAutoPauseProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isComputeIsolationEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isComputeIsolationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sessionLevelPackagesEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionLevelPackagesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cacheSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cacheSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dynamicExecutorAllocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicExecutorAllocation = DynamicExecutorAllocation.DeserializeDynamicExecutorAllocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkEventsFolder"u8))
                        {
                            sparkEventsFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("libraryRequirements"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            libraryRequirements = LibraryRequirements.DeserializeLibraryRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customLibraries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LibraryInfo> array = new List<LibraryInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LibraryInfo.DeserializeLibraryInfo(item));
                            }
                            customLibraries = array;
                            continue;
                        }
                        if (property0.NameEquals("sparkConfigProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkConfigProperties = LibraryRequirements.DeserializeLibraryRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            sparkVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSparkLogFolder"u8))
                        {
                            defaultSparkLogFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSize = new NodeSize(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeSizeFamily"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSizeFamily = new NodeSizeFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSucceededTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSucceededTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BigDataPoolResourceInfo(
                id,
                name,
                type,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                autoScale,
                creationDate,
                autoPause,
                isComputeIsolationEnabled,
                sessionLevelPackagesEnabled,
                cacheSize,
                dynamicExecutorAllocation,
                sparkEventsFolder,
                nodeCount,
                libraryRequirements,
                customLibraries ?? new ChangeTrackingList<LibraryInfo>(),
                sparkConfigProperties,
                sparkVersion,
                defaultSparkLogFolder,
                nodeSize,
                nodeSizeFamily,
                lastSucceededTimestamp);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new BigDataPoolResourceInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBigDataPoolResourceInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class BigDataPoolResourceInfoConverter : JsonConverter<BigDataPoolResourceInfo>
        {
            public override void Write(Utf8JsonWriter writer, BigDataPoolResourceInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override BigDataPoolResourceInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBigDataPoolResourceInfo(document.RootElement);
            }
        }
    }
}
