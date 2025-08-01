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
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class DscCompilationJobData : IUtf8JsonSerializable, IJsonModel<DscCompilationJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscCompilationJobData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DscCompilationJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscCompilationJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscCompilationJobData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedBy))
            {
                writer.WritePropertyName("startedBy"u8);
                writer.WriteStringValue(StartedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(RunOn))
            {
                writer.WritePropertyName("runOn"u8);
                writer.WriteStringValue(RunOn);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StatusDetails))
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(Exception))
            {
                writer.WritePropertyName("exception"u8);
                writer.WriteStringValue(Exception);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastStatusModifiedOn))
            {
                if (LastStatusModifiedOn != null)
                {
                    writer.WritePropertyName("lastStatusModifiedTime"u8);
                    writer.WriteStringValue(LastStatusModifiedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("lastStatusModifiedTime");
                }
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        DscCompilationJobData IJsonModel<DscCompilationJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscCompilationJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscCompilationJobData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscCompilationJobData(document.RootElement, options);
        }

        internal static DscCompilationJobData DeserializeDscCompilationJobData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DscConfigurationAssociationProperty configuration = default;
            string startedBy = default;
            Guid? jobId = default;
            DateTimeOffset? creationTime = default;
            JobProvisioningState? provisioningState = default;
            string runOn = default;
            AutomationJobStatus? status = default;
            string statusDetails = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string exception = default;
            DateTimeOffset? lastModifiedTime = default;
            DateTimeOffset? lastStatusModifiedTime = default;
            IDictionary<string, string> parameters = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAutomationContext.Default);
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
                        if (property0.NameEquals("configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configuration = DscConfigurationAssociationProperty.DeserializeDscConfigurationAssociationProperty(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("startedBy"u8))
                        {
                            startedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("jobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new JobProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("runOn"u8))
                        {
                            runOn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new AutomationJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"u8))
                        {
                            statusDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                startTime = null;
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("exception"u8))
                        {
                            exception = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                lastStatusModifiedTime = null;
                                continue;
                            }
                            lastStatusModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
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
            return new DscCompilationJobData(
                id,
                name,
                type,
                systemData,
                configuration,
                startedBy,
                jobId,
                creationTime,
                provisioningState,
                runOn,
                status,
                statusDetails,
                startTime,
                endTime,
                exception,
                lastModifiedTime,
                lastStatusModifiedTime,
                parameters ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscCompilationJobData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscCompilationJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAutomationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DscCompilationJobData)} does not support writing '{options.Format}' format.");
            }
        }

        DscCompilationJobData IPersistableModel<DscCompilationJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscCompilationJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDscCompilationJobData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscCompilationJobData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscCompilationJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
