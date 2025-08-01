// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents.Persistent
{
    internal partial class SubmitToolOutputsToRunRequest : IUtf8JsonSerializable, IJsonModel<SubmitToolOutputsToRunRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubmitToolOutputsToRunRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubmitToolOutputsToRunRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsToRunRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitToolOutputsToRunRequest)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ToolOutputs))
            {
                writer.WritePropertyName("tool_outputs"u8);
                writer.WriteStartArray();
                foreach (var item in ToolOutputs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ToolApprovals))
            {
                writer.WritePropertyName("tool_approvals"u8);
                writer.WriteStartArray();
                foreach (var item in ToolApprovals)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Stream))
            {
                if (Stream != null)
                {
                    writer.WritePropertyName("stream"u8);
                    writer.WriteBooleanValue(Stream.Value);
                }
                else
                {
                    writer.WriteNull("stream");
                }
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

        SubmitToolOutputsToRunRequest IJsonModel<SubmitToolOutputsToRunRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsToRunRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitToolOutputsToRunRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubmitToolOutputsToRunRequest(document.RootElement, options);
        }

        internal static SubmitToolOutputsToRunRequest DeserializeSubmitToolOutputsToRunRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ToolOutput> toolOutputs = default;
            IReadOnlyList<ToolApproval> toolApprovals = default;
            bool? stream = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToolOutput> array = new List<ToolOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolOutput.DeserializeToolOutput(item, options));
                    }
                    toolOutputs = array;
                    continue;
                }
                if (property.NameEquals("tool_approvals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToolApproval> array = new List<ToolApproval>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToolApproval.DeserializeToolApproval(item, options));
                    }
                    toolApprovals = array;
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stream = null;
                        continue;
                    }
                    stream = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubmitToolOutputsToRunRequest(toolOutputs ?? new ChangeTrackingList<ToolOutput>(), toolApprovals ?? new ChangeTrackingList<ToolApproval>(), stream, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubmitToolOutputsToRunRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsToRunRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIAgentsPersistentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SubmitToolOutputsToRunRequest)} does not support writing '{options.Format}' format.");
            }
        }

        SubmitToolOutputsToRunRequest IPersistableModel<SubmitToolOutputsToRunRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitToolOutputsToRunRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSubmitToolOutputsToRunRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubmitToolOutputsToRunRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubmitToolOutputsToRunRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SubmitToolOutputsToRunRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSubmitToolOutputsToRunRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
