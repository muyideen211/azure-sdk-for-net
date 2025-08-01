// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AtaSolutionProperties : IUtf8JsonSerializable, IJsonModel<AtaSolutionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtaSolutionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtaSolutionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtaSolutionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtaSolutionProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(LastEventReceived))
            {
                writer.WritePropertyName("lastEventReceived"u8);
                writer.WriteStringValue(LastEventReceived);
            }
            foreach (var item in AdditionalProperties)
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

        AtaSolutionProperties IJsonModel<AtaSolutionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtaSolutionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtaSolutionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtaSolutionProperties(document.RootElement, options);
        }

        internal static AtaSolutionProperties DeserializeAtaSolutionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string lastEventReceived = default;
            string deviceVendor = default;
            string deviceType = default;
            WritableSubResource workspace = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastEventReceived"u8))
                {
                    lastEventReceived = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceVendor"u8))
                {
                    deviceVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceType"u8))
                {
                    deviceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspace = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerSecurityCenterContext.Default);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AtaSolutionProperties(deviceVendor, deviceType, workspace, additionalProperties, lastEventReceived);
        }

        BinaryData IPersistableModel<AtaSolutionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtaSolutionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AtaSolutionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AtaSolutionProperties IPersistableModel<AtaSolutionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtaSolutionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAtaSolutionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtaSolutionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtaSolutionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
