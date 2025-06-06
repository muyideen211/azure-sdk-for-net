// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting
{
    public partial class PassFailMetric : IUtf8JsonSerializable, IJsonModel<PassFailMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PassFailMetric>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PassFailMetric>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassFailMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PassFailMetric)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ClientMetric))
            {
                writer.WritePropertyName("clientMetric"u8);
                writer.WriteStringValue(ClientMetric.Value.ToString());
            }
            if (Optional.IsDefined(Aggregate))
            {
                writer.WritePropertyName("aggregate"u8);
                writer.WriteStringValue(Aggregate.Value.ToString());
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(RequestName))
            {
                writer.WritePropertyName("requestName"u8);
                writer.WriteStringValue(RequestName);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActualValue))
            {
                writer.WritePropertyName("actualValue"u8);
                writer.WriteNumberValue(ActualValue.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result.Value.ToString());
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

        PassFailMetric IJsonModel<PassFailMetric>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassFailMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PassFailMetric)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePassFailMetric(document.RootElement, options);
        }

        internal static PassFailMetric DeserializePassFailMetric(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PfMetrics? clientMetric = default;
            PassFailAggregationFunction? aggregate = default;
            string condition = default;
            string requestName = default;
            double? value = default;
            PassFailAction? action = default;
            double? actualValue = default;
            PassFailResult? result = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientMetric = new PfMetrics(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aggregate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregate = new PassFailAggregationFunction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("condition"u8))
                {
                    condition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestName"u8))
                {
                    requestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new PassFailAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actualValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actualValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = new PassFailResult(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PassFailMetric(
                clientMetric,
                aggregate,
                condition,
                requestName,
                value,
                action,
                actualValue,
                result,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PassFailMetric>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassFailMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureDeveloperLoadTestingContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PassFailMetric)} does not support writing '{options.Format}' format.");
            }
        }

        PassFailMetric IPersistableModel<PassFailMetric>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassFailMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePassFailMetric(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PassFailMetric)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PassFailMetric>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PassFailMetric FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePassFailMetric(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
