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
    public partial class VmInstanceGuestAgentData : IUtf8JsonSerializable, IJsonModel<VmInstanceGuestAgentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmInstanceGuestAgentData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmInstanceGuestAgentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmInstanceGuestAgentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmInstanceGuestAgentData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
            }
            if (Optional.IsDefined(HttpProxyConfig))
            {
                writer.WritePropertyName("httpProxyConfig"u8);
                writer.WriteObjectValue(HttpProxyConfig, options);
            }
            if (Optional.IsDefined(ProvisioningAction))
            {
                writer.WritePropertyName("provisioningAction"u8);
                writer.WriteStringValue(ProvisioningAction.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomResourceName))
            {
                writer.WritePropertyName("customResourceName"u8);
                writer.WriteStringValue(CustomResourceName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        VmInstanceGuestAgentData IJsonModel<VmInstanceGuestAgentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmInstanceGuestAgentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmInstanceGuestAgentData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmInstanceGuestAgentData(document.RootElement, options);
        }

        internal static VmInstanceGuestAgentData DeserializeVmInstanceGuestAgentData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string uuid = default;
            VmInstanceGuestCredential credentials = default;
            ResourceIdentifier privateLinkScopeResourceId = default;
            HttpProxyConfiguration httpProxyConfig = default;
            GuestAgentProvisioningAction? provisioningAction = default;
            string status = default;
            string customResourceName = default;
            IReadOnlyList<VMwareResourceStatus> statuses = default;
            VMwareResourceProvisioningState? provisioningState = default;
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
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("credentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credentials = VmInstanceGuestCredential.DeserializeVmInstanceGuestCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopeResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkScopeResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("httpProxyConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpProxyConfig = HttpProxyConfiguration.DeserializeHttpProxyConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningAction = new GuestAgentProvisioningAction(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"u8))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareResourceStatus> array = new List<VMwareResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item, options));
                            }
                            statuses = array;
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
            return new VmInstanceGuestAgentData(
                id,
                name,
                type,
                systemData,
                uuid,
                credentials,
                privateLinkScopeResourceId,
                httpProxyConfig,
                provisioningAction,
                status,
                customResourceName,
                statuses ?? new ChangeTrackingList<VMwareResourceStatus>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmInstanceGuestAgentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmInstanceGuestAgentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConnectedVMwarevSphereContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VmInstanceGuestAgentData)} does not support writing '{options.Format}' format.");
            }
        }

        VmInstanceGuestAgentData IPersistableModel<VmInstanceGuestAgentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmInstanceGuestAgentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVmInstanceGuestAgentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmInstanceGuestAgentData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmInstanceGuestAgentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
