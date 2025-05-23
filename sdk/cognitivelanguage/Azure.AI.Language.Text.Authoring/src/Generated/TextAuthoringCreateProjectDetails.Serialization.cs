// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class TextAuthoringCreateProjectDetails : IUtf8JsonSerializable, IJsonModel<TextAuthoringCreateProjectDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringCreateProjectDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringCreateProjectDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringCreateProjectDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringCreateProjectDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("projectKind"u8);
            writer.WriteStringValue(ProjectKind.ToString());
            writer.WritePropertyName("storageInputContainerName"u8);
            writer.WriteStringValue(StorageInputContainerName);
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings, options);
            }
            writer.WritePropertyName("projectName"u8);
            writer.WriteStringValue(ProjectName);
            if (Optional.IsDefined(Multilingual))
            {
                writer.WritePropertyName("multilingual"u8);
                writer.WriteBooleanValue(Multilingual.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(Language);
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

        TextAuthoringCreateProjectDetails IJsonModel<TextAuthoringCreateProjectDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringCreateProjectDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringCreateProjectDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringCreateProjectDetails(document.RootElement, options);
        }

        internal static TextAuthoringCreateProjectDetails DeserializeTextAuthoringCreateProjectDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextAuthoringProjectKind projectKind = default;
            string storageInputContainerName = default;
            TextAuthoringProjectSettings settings = default;
            string projectName = default;
            bool? multilingual = default;
            string description = default;
            string language = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new TextAuthoringProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageInputContainerName"u8))
                {
                    storageInputContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = TextAuthoringProjectSettings.DeserializeTextAuthoringProjectSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multilingual"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multilingual = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringCreateProjectDetails(
                projectKind,
                storageInputContainerName,
                settings,
                projectName,
                multilingual,
                description,
                language,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringCreateProjectDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringCreateProjectDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringCreateProjectDetails)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringCreateProjectDetails IPersistableModel<TextAuthoringCreateProjectDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringCreateProjectDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringCreateProjectDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringCreateProjectDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringCreateProjectDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringCreateProjectDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringCreateProjectDetails(document.RootElement);
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
