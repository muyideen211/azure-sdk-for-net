// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DataMigrationBackupFileInfo : IUtf8JsonSerializable, IJsonModel<DataMigrationBackupFileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMigrationBackupFileInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataMigrationBackupFileInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationBackupFileInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FileLocation))
            {
                writer.WritePropertyName("fileLocation"u8);
                writer.WriteStringValue(FileLocation);
            }
            if (Optional.IsDefined(FamilySequenceNumber))
            {
                writer.WritePropertyName("familySequenceNumber"u8);
                writer.WriteNumberValue(FamilySequenceNumber.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        DataMigrationBackupFileInfo IJsonModel<DataMigrationBackupFileInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationBackupFileInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMigrationBackupFileInfo(document.RootElement, options);
        }

        internal static DataMigrationBackupFileInfo DeserializeDataMigrationBackupFileInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileLocation = default;
            int? familySequenceNumber = default;
            DataMigrationBackupFileStatus? status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileLocation"u8))
                {
                    fileLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("familySequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familySequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataMigrationBackupFileStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataMigrationBackupFileInfo(fileLocation, familySequenceNumber, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMigrationBackupFileInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataMigrationBackupFileInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataMigrationBackupFileInfo IPersistableModel<DataMigrationBackupFileInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataMigrationBackupFileInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMigrationBackupFileInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMigrationBackupFileInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
