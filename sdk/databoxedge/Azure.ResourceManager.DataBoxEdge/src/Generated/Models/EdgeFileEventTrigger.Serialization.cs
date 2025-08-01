// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeFileEventTrigger : IUtf8JsonSerializable, IJsonModel<EdgeFileEventTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeFileEventTrigger>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeFileEventTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileEventTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeFileEventTrigger)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sourceInfo"u8);
            writer.WriteObjectValue(SourceInfo, options);
            writer.WritePropertyName("sinkInfo"u8);
            writer.WriteObjectValue(SinkInfo, options);
            if (Optional.IsDefined(CustomContextTag))
            {
                writer.WritePropertyName("customContextTag"u8);
                writer.WriteStringValue(CustomContextTag);
            }
            writer.WriteEndObject();
        }

        EdgeFileEventTrigger IJsonModel<EdgeFileEventTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileEventTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeFileEventTrigger)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeFileEventTrigger(document.RootElement, options);
        }

        internal static EdgeFileEventTrigger DeserializeEdgeFileEventTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerEventType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            EdgeFileSourceInfo sourceInfo = default;
            DataBoxEdgeRoleSinkInfo sinkInfo = default;
            string customContextTag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new TriggerEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataBoxEdgeContext.Default);
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
                        if (property0.NameEquals("sourceInfo"u8))
                        {
                            sourceInfo = EdgeFileSourceInfo.DeserializeEdgeFileSourceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sinkInfo"u8))
                        {
                            sinkInfo = DataBoxEdgeRoleSinkInfo.DeserializeDataBoxEdgeRoleSinkInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customContextTag"u8))
                        {
                            customContextTag = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeFileEventTrigger(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                sourceInfo,
                sinkInfo,
                customContextTag);
        }

        BinaryData IPersistableModel<EdgeFileEventTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileEventTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeFileEventTrigger)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeFileEventTrigger IPersistableModel<EdgeFileEventTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeFileEventTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeFileEventTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeFileEventTrigger)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeFileEventTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
