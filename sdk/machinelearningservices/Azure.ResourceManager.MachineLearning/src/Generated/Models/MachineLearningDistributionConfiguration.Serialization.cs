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

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownDistributionConfiguration))]
    public partial class MachineLearningDistributionConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningDistributionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDistributionConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDistributionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("distributionType"u8);
            writer.WriteStringValue(DistributionType.ToString());
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

        MachineLearningDistributionConfiguration IJsonModel<MachineLearningDistributionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDistributionConfiguration(document.RootElement, options);
        }

        internal static MachineLearningDistributionConfiguration DeserializeMachineLearningDistributionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("distributionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Mpi": return MpiDistributionConfiguration.DeserializeMpiDistributionConfiguration(element, options);
                    case "PyTorch": return PyTorchDistributionConfiguration.DeserializePyTorchDistributionConfiguration(element, options);
                    case "TensorFlow": return TensorFlowDistributionConfiguration.DeserializeTensorFlowDistributionConfiguration(element, options);
                }
            }
            return UnknownDistributionConfiguration.DeserializeUnknownDistributionConfiguration(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DistributionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  distributionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  distributionType: ");
                builder.AppendLine($"'{DistributionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningDistributionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDistributionConfiguration IPersistableModel<MachineLearningDistributionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningDistributionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDistributionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
