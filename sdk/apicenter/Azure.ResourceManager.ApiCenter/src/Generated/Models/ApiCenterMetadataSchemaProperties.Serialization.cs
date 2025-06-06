// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiCenter.Models
{
    public partial class ApiCenterMetadataSchemaProperties : IUtf8JsonSerializable, IJsonModel<ApiCenterMetadataSchemaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiCenterMetadataSchemaProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiCenterMetadataSchemaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterMetadataSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCenterMetadataSchemaProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("schema"u8);
            writer.WriteStringValue(Schema);
            if (Optional.IsCollectionDefined(AssignedTo))
            {
                writer.WritePropertyName("assignedTo"u8);
                writer.WriteStartArray();
                foreach (var item in AssignedTo)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ApiCenterMetadataSchemaProperties IJsonModel<ApiCenterMetadataSchemaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterMetadataSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCenterMetadataSchemaProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiCenterMetadataSchemaProperties(document.RootElement, options);
        }

        internal static ApiCenterMetadataSchemaProperties DeserializeApiCenterMetadataSchemaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string schema = default;
            IList<ApiCenterMetadataAssignment> assignedTo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schema"u8))
                {
                    schema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedTo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiCenterMetadataAssignment> array = new List<ApiCenterMetadataAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiCenterMetadataAssignment.DeserializeApiCenterMetadataAssignment(item, options));
                    }
                    assignedTo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiCenterMetadataSchemaProperties(schema, assignedTo ?? new ChangeTrackingList<ApiCenterMetadataAssignment>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiCenterMetadataSchemaProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterMetadataSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApiCenterMetadataSchemaProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ApiCenterMetadataSchemaProperties IPersistableModel<ApiCenterMetadataSchemaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterMetadataSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiCenterMetadataSchemaProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiCenterMetadataSchemaProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiCenterMetadataSchemaProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
