// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformUploadedUserSourceInfo : IUtf8JsonSerializable, IJsonModel<AppPlatformUploadedUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformUploadedUserSourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformUploadedUserSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
        }

        AppPlatformUploadedUserSourceInfo IJsonModel<AppPlatformUploadedUserSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformUploadedUserSourceInfo(document.RootElement, options);
        }

        internal static AppPlatformUploadedUserSourceInfo DeserializeAppPlatformUploadedUserSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Jar": return JarUploadedUserSourceInfo.DeserializeJarUploadedUserSourceInfo(element, options);
                    case "NetCoreZip": return NetCoreZipUploadedUserSourceInfo.DeserializeNetCoreZipUploadedUserSourceInfo(element, options);
                    case "Source": return SourceUploadedUserSourceInfo.DeserializeSourceUploadedUserSourceInfo(element, options);
                }
            }
            string relativePath = default;
            string type = "UploadedUserSourceInfo";
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformUploadedUserSourceInfo(type, version, serializedAdditionalRawData, relativePath);
        }

        BinaryData IPersistableModel<AppPlatformUploadedUserSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppPlatformContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformUploadedUserSourceInfo IPersistableModel<AppPlatformUploadedUserSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformUploadedUserSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformUploadedUserSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
