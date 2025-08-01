// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class ArcExtensionData : IUtf8JsonSerializable, IJsonModel<ArcExtensionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArcExtensionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArcExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcExtensionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AggregateState))
            {
                writer.WritePropertyName("aggregateState"u8);
                writer.WriteStringValue(AggregateState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PerNodeExtensionDetails))
            {
                writer.WritePropertyName("perNodeExtensionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in PerNodeExtensionDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy.Value.ToString());
            }
            writer.WritePropertyName("extensionParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(ArcExtensionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ArcExtensionType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(ShouldAutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(ShouldAutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                using (JsonDocument document = JsonDocument.Parse(Settings, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectedSettings, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(EnableAutomaticUpgrade))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        ArcExtensionData IJsonModel<ArcExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcExtensionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArcExtensionData(document.RootElement, options);
        }

        internal static ArcExtensionData DeserializeArcExtensionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            HciProvisioningState? provisioningState = default;
            ArcExtensionAggregateState? aggregateState = default;
            IReadOnlyList<PerNodeExtensionState> perNodeExtensionDetails = default;
            ArcExtensionManagedBy? managedBy = default;
            string forceUpdateTag = default;
            string publisher = default;
            string type0 = default;
            string typeHandlerVersion = default;
            bool? autoUpgradeMinorVersion = default;
            BinaryData settings = default;
            BinaryData protectedSettings = default;
            bool? enableAutomaticUpgrade = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerHciContext.Default);
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregateState = new ArcExtensionAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeExtensionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PerNodeExtensionState> array = new List<PerNodeExtensionState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeExtensionState.DeserializePerNodeExtensionState(item, options));
                            }
                            perNodeExtensionDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("managedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedBy = new ArcExtensionManagedBy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extensionParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("forceUpdateTag"u8))
                                {
                                    forceUpdateTag = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("publisher"u8))
                                {
                                    publisher = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("type"u8))
                                {
                                    type0 = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("typeHandlerVersion"u8))
                                {
                                    typeHandlerVersion = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("autoUpgradeMinorVersion"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    autoUpgradeMinorVersion = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("settings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    settings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("protectedSettings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    protectedSettings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("enableAutomaticUpgrade"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    enableAutomaticUpgrade = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
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
            return new ArcExtensionData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                aggregateState,
                perNodeExtensionDetails ?? new ChangeTrackingList<PerNodeExtensionState>(),
                managedBy,
                forceUpdateTag,
                publisher,
                type0,
                typeHandlerVersion,
                autoUpgradeMinorVersion,
                settings,
                protectedSettings,
                enableAutomaticUpgrade,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AggregateState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aggregateState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AggregateState))
                {
                    builder.Append("    aggregateState: ");
                    builder.AppendLine($"'{AggregateState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PerNodeExtensionDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    perNodeExtensionDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PerNodeExtensionDetails))
                {
                    if (PerNodeExtensionDetails.Any())
                    {
                        builder.Append("    perNodeExtensionDetails: ");
                        builder.AppendLine("[");
                        foreach (var item in PerNodeExtensionDetails)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    perNodeExtensionDetails: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    managedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedBy))
                {
                    builder.Append("    managedBy: ");
                    builder.AppendLine($"'{ManagedBy.Value.ToString()}'");
                }
            }

            builder.Append("    extensionParameters:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ForceUpdateTag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      forceUpdateTag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ForceUpdateTag))
                {
                    builder.Append("      forceUpdateTag: ");
                    if (ForceUpdateTag.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ForceUpdateTag}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ForceUpdateTag}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Publisher), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      publisher: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Publisher))
                {
                    builder.Append("      publisher: ");
                    if (Publisher.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Publisher}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Publisher}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcExtensionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcExtensionType))
                {
                    builder.Append("      type: ");
                    if (ArcExtensionType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ArcExtensionType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ArcExtensionType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TypeHandlerVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      typeHandlerVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TypeHandlerVersion))
                {
                    builder.Append("      typeHandlerVersion: ");
                    if (TypeHandlerVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TypeHandlerVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TypeHandlerVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ShouldAutoUpgradeMinorVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      autoUpgradeMinorVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ShouldAutoUpgradeMinorVersion))
                {
                    builder.Append("      autoUpgradeMinorVersion: ");
                    var boolValue = ShouldAutoUpgradeMinorVersion.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Settings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      settings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Settings))
                {
                    builder.Append("      settings: ");
                    builder.AppendLine($"'{Settings.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProtectedSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      protectedSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProtectedSettings))
                {
                    builder.Append("      protectedSettings: ");
                    builder.AppendLine($"'{ProtectedSettings.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnableAutomaticUpgrade), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      enableAutomaticUpgrade: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnableAutomaticUpgrade))
                {
                    builder.Append("      enableAutomaticUpgrade: ");
                    var boolValue = EnableAutomaticUpgrade.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("    }");
            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ArcExtensionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHciContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArcExtensionData)} does not support writing '{options.Format}' format.");
            }
        }

        ArcExtensionData IPersistableModel<ArcExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArcExtensionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArcExtensionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArcExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
