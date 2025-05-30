// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownRestoreTargetInfoBase))]
    public partial class RestoreTargetInfoBase : IUtf8JsonSerializable, IJsonModel<RestoreTargetInfoBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreTargetInfoBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RestoreTargetInfoBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (Optional.IsDefined(RestoreLocation))
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
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

        RestoreTargetInfoBase IJsonModel<RestoreTargetInfoBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreTargetInfoBase(document.RootElement, options);
        }

        internal static RestoreTargetInfoBase DeserializeRestoreTargetInfoBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ItemLevelRestoreTargetInfo": return ItemLevelRestoreTargetInfo.DeserializeItemLevelRestoreTargetInfo(element, options);
                    case "RestoreFilesTargetInfo": return RestoreFilesTargetInfo.DeserializeRestoreFilesTargetInfo(element, options);
                    case "RestoreTargetInfo": return RestoreTargetInfo.DeserializeRestoreTargetInfo(element, options);
                }
            }
            return UnknownRestoreTargetInfoBase.DeserializeUnknownRestoreTargetInfoBase(element, options);
        }

        BinaryData IPersistableModel<RestoreTargetInfoBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataProtectionBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support writing '{options.Format}' format.");
            }
        }

        RestoreTargetInfoBase IPersistableModel<RestoreTargetInfoBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRestoreTargetInfoBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfoBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreTargetInfoBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
