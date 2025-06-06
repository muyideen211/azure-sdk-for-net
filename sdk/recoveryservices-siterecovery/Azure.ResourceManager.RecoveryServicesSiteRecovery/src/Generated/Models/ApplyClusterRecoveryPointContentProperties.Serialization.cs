// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ApplyClusterRecoveryPointContentProperties : IUtf8JsonSerializable, IJsonModel<ApplyClusterRecoveryPointContentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplyClusterRecoveryPointContentProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplyClusterRecoveryPointContentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplyClusterRecoveryPointContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplyClusterRecoveryPointContentProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ClusterRecoveryPointId))
            {
                writer.WritePropertyName("clusterRecoveryPointId"u8);
                writer.WriteStringValue(ClusterRecoveryPointId);
            }
            if (Optional.IsCollectionDefined(IndividualNodeRecoveryPoints))
            {
                writer.WritePropertyName("individualNodeRecoveryPoints"u8);
                writer.WriteStartArray();
                foreach (var item in IndividualNodeRecoveryPoints)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("providerSpecificDetails"u8);
            writer.WriteObjectValue(ProviderSpecificDetails, options);
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

        ApplyClusterRecoveryPointContentProperties IJsonModel<ApplyClusterRecoveryPointContentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplyClusterRecoveryPointContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplyClusterRecoveryPointContentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplyClusterRecoveryPointContentProperties(document.RootElement, options);
        }

        internal static ApplyClusterRecoveryPointContentProperties DeserializeApplyClusterRecoveryPointContentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier clusterRecoveryPointId = default;
            IList<ResourceIdentifier> individualNodeRecoveryPoints = default;
            ApplyClusterRecoveryPointProviderSpecificContent providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("individualNodeRecoveryPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    individualNodeRecoveryPoints = array;
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    providerSpecificDetails = ApplyClusterRecoveryPointProviderSpecificContent.DeserializeApplyClusterRecoveryPointProviderSpecificContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplyClusterRecoveryPointContentProperties(clusterRecoveryPointId, individualNodeRecoveryPoints ?? new ChangeTrackingList<ResourceIdentifier>(), providerSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplyClusterRecoveryPointContentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplyClusterRecoveryPointContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApplyClusterRecoveryPointContentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ApplyClusterRecoveryPointContentProperties IPersistableModel<ApplyClusterRecoveryPointContentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplyClusterRecoveryPointContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplyClusterRecoveryPointContentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplyClusterRecoveryPointContentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplyClusterRecoveryPointContentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
