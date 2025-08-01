// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QueryAnalysisValidationResult : IUtf8JsonSerializable, IJsonModel<QueryAnalysisValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryAnalysisValidationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QueryAnalysisValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryAnalysisValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryAnalysisValidationResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(QueryResults))
            {
                writer.WritePropertyName("queryResults"u8);
                writer.WriteObjectValue(QueryResults, options);
            }
            if (Optional.IsDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteObjectValue(ValidationErrors, options);
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

        QueryAnalysisValidationResult IJsonModel<QueryAnalysisValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryAnalysisValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryAnalysisValidationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryAnalysisValidationResult(document.RootElement, options);
        }

        internal static QueryAnalysisValidationResult DeserializeQueryAnalysisValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            QueryExecutionResult queryResults = default;
            MigrationValidationError validationErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryResults = QueryExecutionResult.DeserializeQueryExecutionResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationErrors = MigrationValidationError.DeserializeMigrationValidationError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QueryAnalysisValidationResult(queryResults, validationErrors, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryAnalysisValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryAnalysisValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(QueryAnalysisValidationResult)} does not support writing '{options.Format}' format.");
            }
        }

        QueryAnalysisValidationResult IPersistableModel<QueryAnalysisValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryAnalysisValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeQueryAnalysisValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryAnalysisValidationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryAnalysisValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
