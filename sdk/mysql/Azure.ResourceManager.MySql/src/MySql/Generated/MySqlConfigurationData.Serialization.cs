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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlConfigurationData : IUtf8JsonSerializable, IJsonModel<MySqlConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlConfigurationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MySqlConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlConfigurationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (options.Format != "W" && Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (options.Format != "W" && Optional.IsDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues"u8);
                writer.WriteStringValue(AllowedValues);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            writer.WriteEndObject();
        }

        MySqlConfigurationData IJsonModel<MySqlConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlConfigurationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlConfigurationData(document.RootElement, options);
        }

        internal static MySqlConfigurationData DeserializeMySqlConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string value = default;
            string description = default;
            string defaultValue = default;
            string dataType = default;
            string allowedValues = default;
            string source = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerMySqlContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("value"u8))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultValue"u8))
                        {
                            defaultValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataType"u8))
                        {
                            dataType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedValues"u8))
                        {
                            allowedValues = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MySqlConfigurationData(
                id,
                name,
                type,
                systemData,
                value,
                description,
                defaultValue,
                dataType,
                allowedValues,
                source,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMySqlContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MySqlConfigurationData)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlConfigurationData IPersistableModel<MySqlConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMySqlConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlConfigurationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
