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
    internal partial class UnknownPlannedFailoverProviderSpecificFailoverContent : IUtf8JsonSerializable, IJsonModel<PlannedFailoverProviderSpecificFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlannedFailoverProviderSpecificFailoverContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PlannedFailoverProviderSpecificFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverProviderSpecificFailoverContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        PlannedFailoverProviderSpecificFailoverContent IJsonModel<PlannedFailoverProviderSpecificFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverProviderSpecificFailoverContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlannedFailoverProviderSpecificFailoverContent(document.RootElement, options);
        }

        internal static UnknownPlannedFailoverProviderSpecificFailoverContent DeserializeUnknownPlannedFailoverProviderSpecificFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownPlannedFailoverProviderSpecificFailoverContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverProviderSpecificFailoverContent)} does not support writing '{options.Format}' format.");
            }
        }

        PlannedFailoverProviderSpecificFailoverContent IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePlannedFailoverProviderSpecificFailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverProviderSpecificFailoverContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlannedFailoverProviderSpecificFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
