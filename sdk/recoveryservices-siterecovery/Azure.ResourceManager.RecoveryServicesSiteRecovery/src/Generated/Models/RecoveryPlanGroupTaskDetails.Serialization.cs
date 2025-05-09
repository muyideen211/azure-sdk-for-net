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
    public partial class RecoveryPlanGroupTaskDetails : IUtf8JsonSerializable, IJsonModel<RecoveryPlanGroupTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanGroupTaskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPlanGroupTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RpGroupType))
            {
                writer.WritePropertyName("rpGroupType"u8);
                writer.WriteStringValue(RpGroupType);
            }
        }

        RecoveryPlanGroupTaskDetails IJsonModel<RecoveryPlanGroupTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanGroupTaskDetails(document.RootElement, options);
        }

        internal static RecoveryPlanGroupTaskDetails DeserializeRecoveryPlanGroupTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RecoveryPlanShutdownGroupTaskDetails": return RecoveryPlanShutdownGroupTaskDetails.DeserializeRecoveryPlanShutdownGroupTaskDetails(element, options);
                }
            }
            string name = default;
            string groupId = default;
            string rpGroupType = default;
            string instanceType = "RecoveryPlanGroupTaskDetails";
            IReadOnlyList<AsrTask> childTasks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpGroupType"u8))
                {
                    rpGroupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("childTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AsrTask> array = new List<AsrTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsrTask.DeserializeAsrTask(item, options));
                    }
                    childTasks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPlanGroupTaskDetails(
                instanceType,
                childTasks ?? new ChangeTrackingList<AsrTask>(),
                serializedAdditionalRawData,
                name,
                groupId,
                rpGroupType);
        }

        BinaryData IPersistableModel<RecoveryPlanGroupTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanGroupTaskDetails IPersistableModel<RecoveryPlanGroupTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecoveryPlanGroupTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanGroupTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
