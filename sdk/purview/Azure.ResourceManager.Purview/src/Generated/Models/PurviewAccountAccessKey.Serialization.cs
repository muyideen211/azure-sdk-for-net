// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountAccessKey : IUtf8JsonSerializable, IJsonModel<PurviewAccountAccessKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewAccountAccessKey>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PurviewAccountAccessKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewAccountAccessKey)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AtlasKafkaPrimaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaPrimaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaPrimaryEndpoint);
            }
            if (Optional.IsDefined(AtlasKafkaSecondaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaSecondaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaSecondaryEndpoint);
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

        PurviewAccountAccessKey IJsonModel<PurviewAccountAccessKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewAccountAccessKey)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewAccountAccessKey(document.RootElement, options);
        }

        internal static PurviewAccountAccessKey DeserializePurviewAccountAccessKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string atlasKafkaPrimaryEndpoint = default;
            string atlasKafkaSecondaryEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("atlasKafkaPrimaryEndpoint"u8))
                {
                    atlasKafkaPrimaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("atlasKafkaSecondaryEndpoint"u8))
                {
                    atlasKafkaSecondaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PurviewAccountAccessKey(atlasKafkaPrimaryEndpoint, atlasKafkaSecondaryEndpoint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewAccountAccessKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPurviewContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PurviewAccountAccessKey)} does not support writing '{options.Format}' format.");
            }
        }

        PurviewAccountAccessKey IPersistableModel<PurviewAccountAccessKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePurviewAccountAccessKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurviewAccountAccessKey)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewAccountAccessKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
