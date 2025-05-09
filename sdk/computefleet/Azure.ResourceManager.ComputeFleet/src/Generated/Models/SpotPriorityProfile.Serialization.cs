// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class SpotPriorityProfile : IUtf8JsonSerializable, IJsonModel<SpotPriorityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpotPriorityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpotPriorityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpotPriorityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpotPriorityProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(MaxPricePerVm))
            {
                writer.WritePropertyName("maxPricePerVM"u8);
                writer.WriteNumberValue(MaxPricePerVm.Value);
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy"u8);
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(AllocationStrategy))
            {
                writer.WritePropertyName("allocationStrategy"u8);
                writer.WriteStringValue(AllocationStrategy.Value.ToString());
            }
            if (Optional.IsDefined(IsMaintainEnabled))
            {
                writer.WritePropertyName("maintain"u8);
                writer.WriteBooleanValue(IsMaintainEnabled.Value);
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

        SpotPriorityProfile IJsonModel<SpotPriorityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpotPriorityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpotPriorityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpotPriorityProfile(document.RootElement, options);
        }

        internal static SpotPriorityProfile DeserializeSpotPriorityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? capacity = default;
            int? minCapacity = default;
            float? maxPricePerVm = default;
            ComputeFleetEvictionPolicy? evictionPolicy = default;
            SpotAllocationStrategy? allocationStrategy = default;
            bool? maintain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPricePerVM"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPricePerVm = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("evictionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evictionPolicy = new ComputeFleetEvictionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationStrategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationStrategy = new SpotAllocationStrategy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maintain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintain = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SpotPriorityProfile(
                capacity,
                minCapacity,
                maxPricePerVm,
                evictionPolicy,
                allocationStrategy,
                maintain,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpotPriorityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpotPriorityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeFleetContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SpotPriorityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        SpotPriorityProfile IPersistableModel<SpotPriorityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpotPriorityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSpotPriorityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpotPriorityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpotPriorityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
