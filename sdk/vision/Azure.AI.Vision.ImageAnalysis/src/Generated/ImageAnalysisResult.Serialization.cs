// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImageAnalysisResult : IUtf8JsonSerializable, IJsonModel<ImageAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageAnalysisResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ImageAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Caption))
            {
                writer.WritePropertyName("captionResult"u8);
                writer.WriteObjectValue(Caption, options);
            }
            if (Optional.IsDefined(DenseCaptions))
            {
                writer.WritePropertyName("denseCaptionsResult"u8);
                writer.WriteObjectValue(DenseCaptions, options);
            }
            writer.WritePropertyName("metadata"u8);
            writer.WriteObjectValue(Metadata, options);
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
            if (Optional.IsDefined(Objects))
            {
                writer.WritePropertyName("objectsResult"u8);
                writer.WriteObjectValue(Objects, options);
            }
            if (Optional.IsDefined(People))
            {
                writer.WritePropertyName("peopleResult"u8);
                writer.WriteObjectValue(People, options);
            }
            if (Optional.IsDefined(Read))
            {
                writer.WritePropertyName("readResult"u8);
                writer.WriteObjectValue(Read, options);
            }
            if (Optional.IsDefined(SmartCrops))
            {
                writer.WritePropertyName("smartCropsResult"u8);
                writer.WriteObjectValue(SmartCrops, options);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tagsResult"u8);
                writer.WriteObjectValue(Tags, options);
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

        ImageAnalysisResult IJsonModel<ImageAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageAnalysisResult(document.RootElement, options);
        }

        internal static ImageAnalysisResult DeserializeImageAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CaptionResult captionResult = default;
            DenseCaptionsResult denseCaptionsResult = default;
            ImageMetadata metadata = default;
            string modelVersion = default;
            ObjectsResult objectsResult = default;
            PeopleResult peopleResult = default;
            ReadResult readResult = default;
            SmartCropsResult smartCropsResult = default;
            TagsResult tagsResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("captionResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    captionResult = CaptionResult.DeserializeCaptionResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("denseCaptionsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    denseCaptionsResult = DenseCaptionsResult.DeserializeDenseCaptionsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = ImageMetadata.DeserializeImageMetadata(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectsResult = ObjectsResult.DeserializeObjectsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("peopleResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peopleResult = PeopleResult.DeserializePeopleResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("readResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readResult = ReadResult.DeserializeReadResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("smartCropsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartCropsResult = SmartCropsResult.DeserializeSmartCropsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tagsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagsResult = TagsResult.DeserializeTagsResult(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ImageAnalysisResult(
                captionResult,
                denseCaptionsResult,
                metadata,
                modelVersion,
                objectsResult,
                peopleResult,
                readResult,
                smartCropsResult,
                tagsResult,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIVisionImageAnalysisContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support writing '{options.Format}' format.");
            }
        }

        ImageAnalysisResult IPersistableModel<ImageAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeImageAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageAnalysisResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeImageAnalysisResult(document.RootElement);
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
