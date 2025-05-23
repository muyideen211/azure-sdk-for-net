// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RoutingRuleRouteDestination : IUtf8JsonSerializable, IJsonModel<RoutingRuleRouteDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingRuleRouteDestination>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoutingRuleRouteDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleRouteDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleRouteDestination)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DestinationType.ToString());
            writer.WritePropertyName("destinationAddress"u8);
            writer.WriteStringValue(DestinationAddress);
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

        RoutingRuleRouteDestination IJsonModel<RoutingRuleRouteDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleRouteDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleRouteDestination)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingRuleRouteDestination(document.RootElement, options);
        }

        internal static RoutingRuleRouteDestination DeserializeRoutingRuleRouteDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RoutingRuleDestinationType type = default;
            string destinationAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new RoutingRuleDestinationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("destinationAddress"u8))
                {
                    destinationAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoutingRuleRouteDestination(type, destinationAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingRuleRouteDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleRouteDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleRouteDestination)} does not support writing '{options.Format}' format.");
            }
        }

        RoutingRuleRouteDestination IPersistableModel<RoutingRuleRouteDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleRouteDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoutingRuleRouteDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleRouteDestination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingRuleRouteDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
