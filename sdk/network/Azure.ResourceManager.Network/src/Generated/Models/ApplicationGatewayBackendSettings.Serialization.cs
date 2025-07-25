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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendSettings : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayBackendSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayBackendSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayBackendSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayBackendSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(Probe))
            {
                writer.WritePropertyName("probe"u8);
                ((IJsonModel<WritableSubResource>)Probe).Write(writer, options);
            }
            if (Optional.IsCollectionDefined(TrustedRootCertificates))
            {
                writer.WritePropertyName("trustedRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(PickHostNameFromBackendAddress))
            {
                writer.WritePropertyName("pickHostNameFromBackendAddress"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendAddress.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ApplicationGatewayBackendSettings IJsonModel<ApplicationGatewayBackendSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayBackendSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayBackendSettings(document.RootElement, options);
        }

        internal static ApplicationGatewayBackendSettings DeserializeApplicationGatewayBackendSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            int? port = default;
            ApplicationGatewayProtocol? protocol = default;
            int? timeout = default;
            WritableSubResource probe = default;
            IList<WritableSubResource> trustedRootCertificates = default;
            string hostName = default;
            bool? pickHostNameFromBackendAddress = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probe = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerNetworkContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("trustedRootCertificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerNetworkContext.Default));
                            }
                            trustedRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pickHostNameFromBackendAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
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
            return new ApplicationGatewayBackendSettings(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                port,
                protocol,
                timeout,
                probe,
                trustedRootCertificates ?? new ChangeTrackingList<WritableSubResource>(),
                hostName,
                pickHostNameFromBackendAddress,
                provisioningState);
        }

        BinaryData IPersistableModel<ApplicationGatewayBackendSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayBackendSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayBackendSettings IPersistableModel<ApplicationGatewayBackendSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayBackendSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayBackendSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayBackendSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
