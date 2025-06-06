// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    internal partial class TranslationStatusSummary : IUtf8JsonSerializable, IJsonModel<TranslationStatusSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TranslationStatusSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TranslationStatusSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationStatusSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslationStatusSummary)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("total"u8);
            writer.WriteNumberValue(Total);
            writer.WritePropertyName("failed"u8);
            writer.WriteNumberValue(Failed);
            writer.WritePropertyName("success"u8);
            writer.WriteNumberValue(Success);
            writer.WritePropertyName("inProgress"u8);
            writer.WriteNumberValue(InProgress);
            writer.WritePropertyName("notYetStarted"u8);
            writer.WriteNumberValue(NotYetStarted);
            writer.WritePropertyName("cancelled"u8);
            writer.WriteNumberValue(Cancelled);
            writer.WritePropertyName("totalCharacterCharged"u8);
            writer.WriteNumberValue(TotalCharacterCharged);
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

        TranslationStatusSummary IJsonModel<TranslationStatusSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationStatusSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslationStatusSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranslationStatusSummary(document.RootElement, options);
        }

        internal static TranslationStatusSummary DeserializeTranslationStatusSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int total = default;
            int failed = default;
            int success = default;
            int inProgress = default;
            int notYetStarted = default;
            int cancelled = default;
            long totalCharacterCharged = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("success"u8))
                {
                    success = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"u8))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notYetStarted"u8))
                {
                    notYetStarted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cancelled"u8))
                {
                    cancelled = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalCharacterCharged"u8))
                {
                    totalCharacterCharged = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TranslationStatusSummary(
                total,
                failed,
                success,
                inProgress,
                notYetStarted,
                cancelled,
                totalCharacterCharged,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TranslationStatusSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationStatusSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAITranslationDocumentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TranslationStatusSummary)} does not support writing '{options.Format}' format.");
            }
        }

        TranslationStatusSummary IPersistableModel<TranslationStatusSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationStatusSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTranslationStatusSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranslationStatusSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranslationStatusSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranslationStatusSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTranslationStatusSummary(document.RootElement);
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
