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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPlatform : IUtf8JsonSerializable, IJsonModel<MobileNetworkPlatform>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPlatform>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MobileNetworkPlatform>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatform>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatform)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PlatformType))
            {
                writer.WritePropertyName("platformType"u8);
                writer.WriteStringValue(PlatformType.Value.ToString());
            }
            if (Optional.IsDefined(VersionState))
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Optional.IsDefined(MinimumPlatformSoftwareVersion))
            {
                writer.WritePropertyName("minimumPlatformSoftwareVersion"u8);
                writer.WriteStringValue(MinimumPlatformSoftwareVersion);
            }
            if (Optional.IsDefined(MaximumPlatformSoftwareVersion))
            {
                writer.WritePropertyName("maximumPlatformSoftwareVersion"u8);
                writer.WriteStringValue(MaximumPlatformSoftwareVersion);
            }
            if (Optional.IsDefined(RecommendedVersion))
            {
                writer.WritePropertyName("recommendedVersion"u8);
                writer.WriteStringValue(RecommendedVersion.Value.ToString());
            }
            if (Optional.IsDefined(ObsoleteVersion))
            {
                writer.WritePropertyName("obsoleteVersion"u8);
                writer.WriteStringValue(ObsoleteVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HaUpgradesAvailable))
            {
                writer.WritePropertyName("haUpgradesAvailable"u8);
                writer.WriteStartArray();
                foreach (var item in HaUpgradesAvailable)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        MobileNetworkPlatform IJsonModel<MobileNetworkPlatform>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatform>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatform)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPlatform(document.RootElement, options);
        }

        internal static MobileNetworkPlatform DeserializeMobileNetworkPlatform(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkPlatformType? platformType = default;
            MobileNetworkVersionState? versionState = default;
            string minimumPlatformSoftwareVersion = default;
            string maximumPlatformSoftwareVersion = default;
            MobileNetworkRecommendedVersion? recommendedVersion = default;
            MobileNetworkObsoleteVersion? obsoleteVersion = default;
            IList<string> haUpgradesAvailable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformType = new MobileNetworkPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new MobileNetworkVersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumPlatformSoftwareVersion"u8))
                {
                    minimumPlatformSoftwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumPlatformSoftwareVersion"u8))
                {
                    maximumPlatformSoftwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedVersion = new MobileNetworkRecommendedVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("obsoleteVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    obsoleteVersion = new MobileNetworkObsoleteVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("haUpgradesAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    haUpgradesAvailable = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MobileNetworkPlatform(
                platformType,
                versionState,
                minimumPlatformSoftwareVersion,
                maximumPlatformSoftwareVersion,
                recommendedVersion,
                obsoleteVersion,
                haUpgradesAvailable ?? new ChangeTrackingList<string>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  platformType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlatformType))
                {
                    builder.Append("  platformType: ");
                    builder.AppendLine($"'{PlatformType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VersionState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  versionState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VersionState))
                {
                    builder.Append("  versionState: ");
                    builder.AppendLine($"'{VersionState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinimumPlatformSoftwareVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimumPlatformSoftwareVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinimumPlatformSoftwareVersion))
                {
                    builder.Append("  minimumPlatformSoftwareVersion: ");
                    if (MinimumPlatformSoftwareVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MinimumPlatformSoftwareVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MinimumPlatformSoftwareVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaximumPlatformSoftwareVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maximumPlatformSoftwareVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaximumPlatformSoftwareVersion))
                {
                    builder.Append("  maximumPlatformSoftwareVersion: ");
                    if (MaximumPlatformSoftwareVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MaximumPlatformSoftwareVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MaximumPlatformSoftwareVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RecommendedVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  recommendedVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RecommendedVersion))
                {
                    builder.Append("  recommendedVersion: ");
                    builder.AppendLine($"'{RecommendedVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ObsoleteVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  obsoleteVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ObsoleteVersion))
                {
                    builder.Append("  obsoleteVersion: ");
                    builder.AppendLine($"'{ObsoleteVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HaUpgradesAvailable), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  haUpgradesAvailable: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(HaUpgradesAvailable))
                {
                    if (HaUpgradesAvailable.Any())
                    {
                        builder.Append("  haUpgradesAvailable: ");
                        builder.AppendLine("[");
                        foreach (var item in HaUpgradesAvailable)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MobileNetworkPlatform>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatform>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMobileNetworkContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatform)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkPlatform IPersistableModel<MobileNetworkPlatform>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatform>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMobileNetworkPlatform(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatform)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPlatform>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
