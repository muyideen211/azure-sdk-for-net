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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WorkflowRunActionRepetitionIndex : IUtf8JsonSerializable, IJsonModel<WorkflowRunActionRepetitionIndex>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkflowRunActionRepetitionIndex>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkflowRunActionRepetitionIndex>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowRunActionRepetitionIndex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowRunActionRepetitionIndex)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ScopeName))
            {
                writer.WritePropertyName("scopeName"u8);
                writer.WriteStringValue(ScopeName);
            }
            writer.WritePropertyName("itemIndex"u8);
            writer.WriteNumberValue(ItemIndex);
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

        WorkflowRunActionRepetitionIndex IJsonModel<WorkflowRunActionRepetitionIndex>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowRunActionRepetitionIndex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowRunActionRepetitionIndex)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkflowRunActionRepetitionIndex(document.RootElement, options);
        }

        internal static WorkflowRunActionRepetitionIndex DeserializeWorkflowRunActionRepetitionIndex(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scopeName = default;
            int itemIndex = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scopeName"u8))
                {
                    scopeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIndex"u8))
                {
                    itemIndex = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkflowRunActionRepetitionIndex(scopeName, itemIndex, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScopeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scopeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScopeName))
                {
                    builder.Append("  scopeName: ");
                    if (ScopeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScopeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScopeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ItemIndex), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  itemIndex: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  itemIndex: ");
                builder.AppendLine($"{ItemIndex}");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WorkflowRunActionRepetitionIndex>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowRunActionRepetitionIndex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkflowRunActionRepetitionIndex)} does not support writing '{options.Format}' format.");
            }
        }

        WorkflowRunActionRepetitionIndex IPersistableModel<WorkflowRunActionRepetitionIndex>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowRunActionRepetitionIndex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkflowRunActionRepetitionIndex(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkflowRunActionRepetitionIndex)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkflowRunActionRepetitionIndex>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
