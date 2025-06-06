// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class RoutingPreferenceUnbilledPrefix : IUtf8JsonSerializable, IJsonModel<RoutingPreferenceUnbilledPrefix>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingPreferenceUnbilledPrefix>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoutingPreferenceUnbilledPrefix>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingPreferenceUnbilledPrefix>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureRegion))
            {
                writer.WritePropertyName("azureRegion"u8);
                writer.WriteStringValue(AzureRegion.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerAsn"u8);
                writer.WriteNumberValue(PeerAsn.Value);
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

        RoutingPreferenceUnbilledPrefix IJsonModel<RoutingPreferenceUnbilledPrefix>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingPreferenceUnbilledPrefix>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingPreferenceUnbilledPrefix(document.RootElement, options);
        }

        internal static RoutingPreferenceUnbilledPrefix DeserializeRoutingPreferenceUnbilledPrefix(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prefix = default;
            AzureLocation? azureRegion = default;
            int? peerAsn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoutingPreferenceUnbilledPrefix(prefix, azureRegion, peerAsn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingPreferenceUnbilledPrefix>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingPreferenceUnbilledPrefix>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPeeringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support writing '{options.Format}' format.");
            }
        }

        RoutingPreferenceUnbilledPrefix IPersistableModel<RoutingPreferenceUnbilledPrefix>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingPreferenceUnbilledPrefix>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoutingPreferenceUnbilledPrefix(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingPreferenceUnbilledPrefix)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingPreferenceUnbilledPrefix>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
