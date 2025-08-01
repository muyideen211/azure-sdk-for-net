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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VCenterInventoryItemData : IUtf8JsonSerializable, IJsonModel<VCenterInventoryItemData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VCenterInventoryItemData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VCenterInventoryItemData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VCenterInventoryItemData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VCenterInventoryItemData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("inventoryType"u8);
            writer.WriteStringValue(InventoryType.ToString());
            if (Optional.IsDefined(ManagedResourceId))
            {
                writer.WritePropertyName("managedResourceId"u8);
                writer.WriteStringValue(ManagedResourceId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId"u8);
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(MoName))
            {
                writer.WritePropertyName("moName"u8);
                writer.WriteStringValue(MoName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        VCenterInventoryItemData IJsonModel<VCenterInventoryItemData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VCenterInventoryItemData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VCenterInventoryItemData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVCenterInventoryItemData(document.RootElement, options);
        }

        internal static VCenterInventoryItemData DeserializeVCenterInventoryItemData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            VCenterInventoryType inventoryType = default;
            string managedResourceId = default;
            string moRefId = default;
            string moName = default;
            VMwareResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConnectedVMwarevSphereContext.Default);
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
                        if (property0.NameEquals("inventoryType"u8))
                        {
                            inventoryType = new VCenterInventoryType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedResourceId"u8))
                        {
                            managedResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"u8))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"u8))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VMwareResourceProvisioningState(property0.Value.GetString());
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
            return new VCenterInventoryItemData(
                id,
                name,
                type,
                systemData,
                kind,
                inventoryType,
                managedResourceId,
                moRefId,
                moName,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VCenterInventoryItemData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VCenterInventoryItemData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConnectedVMwarevSphereContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VCenterInventoryItemData)} does not support writing '{options.Format}' format.");
            }
        }

        VCenterInventoryItemData IPersistableModel<VCenterInventoryItemData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VCenterInventoryItemData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVCenterInventoryItemData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VCenterInventoryItemData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VCenterInventoryItemData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
