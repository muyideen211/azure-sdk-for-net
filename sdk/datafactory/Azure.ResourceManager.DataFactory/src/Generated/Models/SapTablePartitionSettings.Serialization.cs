// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SapTablePartitionSettings : IUtf8JsonSerializable, IJsonModel<SapTablePartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapTablePartitionSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapTablePartitionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapTablePartitionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapTablePartitionSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                JsonSerializer.Serialize(writer, PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                JsonSerializer.Serialize(writer, PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                JsonSerializer.Serialize(writer, PartitionLowerBound);
            }
            if (Optional.IsDefined(MaxPartitionsNumber))
            {
                writer.WritePropertyName("maxPartitionsNumber"u8);
                JsonSerializer.Serialize(writer, MaxPartitionsNumber);
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

        SapTablePartitionSettings IJsonModel<SapTablePartitionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapTablePartitionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapTablePartitionSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapTablePartitionSettings(document.RootElement, options);
        }

        internal static SapTablePartitionSettings DeserializeSapTablePartitionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> partitionColumnName = default;
            DataFactoryElement<string> partitionUpperBound = default;
            DataFactoryElement<string> partitionLowerBound = default;
            DataFactoryElement<int> maxPartitionsNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxPartitionsNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPartitionsNumber = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapTablePartitionSettings(partitionColumnName, partitionUpperBound, partitionLowerBound, maxPartitionsNumber, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapTablePartitionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapTablePartitionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SapTablePartitionSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SapTablePartitionSettings IPersistableModel<SapTablePartitionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapTablePartitionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSapTablePartitionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapTablePartitionSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapTablePartitionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
