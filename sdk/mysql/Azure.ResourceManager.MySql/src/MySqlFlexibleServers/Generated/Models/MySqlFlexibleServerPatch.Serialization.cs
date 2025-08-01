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

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerPatch : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MySqlFlexibleServerPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage, options);
            }
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup"u8);
                writer.WriteObjectValue(Backup, options);
            }
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                writer.WriteObjectValue(HighAvailability, options);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow, options);
            }
            if (Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (Optional.IsDefined(DataEncryption))
            {
                writer.WritePropertyName("dataEncryption"u8);
                writer.WriteObjectValue(DataEncryption, options);
            }
            if (Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteObjectValue(Network, options);
            }
            writer.WriteEndObject();
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

        MySqlFlexibleServerPatch IJsonModel<MySqlFlexibleServerPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerPatch(document.RootElement, options);
        }

        internal static MySqlFlexibleServerPatch DeserializeMySqlFlexibleServerPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            MySqlFlexibleServerSku sku = default;
            IDictionary<string, string> tags = default;
            string administratorLoginPassword = default;
            MySqlFlexibleServerVersion? version = default;
            MySqlFlexibleServerStorage storage = default;
            MySqlFlexibleServerBackupProperties backup = default;
            MySqlFlexibleServerHighAvailability highAvailability = default;
            MySqlFlexibleServerMaintenanceWindow maintenanceWindow = default;
            MySqlFlexibleServerReplicationRole? replicationRole = default;
            MySqlFlexibleServerDataEncryption dataEncryption = default;
            MySqlFlexibleServerNetwork network = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerMySqlContext.Default);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MySqlFlexibleServerSku.DeserializeMySqlFlexibleServerSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new MySqlFlexibleServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storage = MySqlFlexibleServerStorage.DeserializeMySqlFlexibleServerStorage(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("backup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backup = MySqlFlexibleServerBackupProperties.DeserializeMySqlFlexibleServerBackupProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("highAvailability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailability = MySqlFlexibleServerHighAvailability.DeserializeMySqlFlexibleServerHighAvailability(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = MySqlFlexibleServerMaintenanceWindow.DeserializeMySqlFlexibleServerMaintenanceWindow(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new MySqlFlexibleServerReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataEncryption = MySqlFlexibleServerDataEncryption.DeserializeMySqlFlexibleServerDataEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("network"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            network = MySqlFlexibleServerNetwork.DeserializeMySqlFlexibleServerNetwork(property0.Value, options);
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
            return new MySqlFlexibleServerPatch(
                identity,
                sku,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                administratorLoginPassword,
                version,
                storage,
                backup,
                highAvailability,
                maintenanceWindow,
                replicationRole,
                dataEncryption,
                network,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMySqlContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerPatch)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerPatch IPersistableModel<MySqlFlexibleServerPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMySqlFlexibleServerPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
