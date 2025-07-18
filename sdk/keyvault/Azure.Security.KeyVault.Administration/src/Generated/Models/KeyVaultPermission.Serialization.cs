// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role definition permissions. </summary>
    public partial class KeyVaultPermission : IJsonModel<KeyVaultPermission>
    {
        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<KeyVaultPermission>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<KeyVaultPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultPermission)} does not support writing '{format}' format.");
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (string item in Actions)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotActions))
            {
                writer.WritePropertyName("notActions"u8);
                writer.WriteStartArray();
                foreach (string item in NotActions)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataActions))
            {
                writer.WritePropertyName("dataActions"u8);
                writer.WriteStartArray();
                foreach (KeyVaultDataAction item in DataActions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotDataActions))
            {
                writer.WritePropertyName("notDataActions"u8);
                writer.WriteStartArray();
                foreach (KeyVaultDataAction item in NotDataActions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        KeyVaultPermission IJsonModel<KeyVaultPermission>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual KeyVaultPermission JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<KeyVaultPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultPermission)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultPermission(document.RootElement, options);
        }

        /// <param name="element"> The JSON element to deserialize. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        internal static KeyVaultPermission DeserializeKeyVaultPermission(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> actions = default;
            IList<string> notActions = default;
            IList<KeyVaultDataAction> dataActions = default;
            IList<KeyVaultDataAction> notDataActions = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("actions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    actions = array;
                    continue;
                }
                if (prop.NameEquals("notActions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    notActions = array;
                    continue;
                }
                if (prop.NameEquals("dataActions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultDataAction> array = new List<KeyVaultDataAction>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(new KeyVaultDataAction(item.GetString()));
                    }
                    dataActions = array;
                    continue;
                }
                if (prop.NameEquals("notDataActions"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultDataAction> array = new List<KeyVaultDataAction>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(new KeyVaultDataAction(item.GetString()));
                    }
                    notDataActions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new KeyVaultPermission(actions ?? new ChangeTrackingList<string>(), notActions ?? new ChangeTrackingList<string>(), dataActions ?? new ChangeTrackingList<KeyVaultDataAction>(), notDataActions ?? new ChangeTrackingList<KeyVaultDataAction>(), additionalBinaryDataProperties);
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<KeyVaultPermission>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<KeyVaultPermission>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureSecurityKeyVaultAdministrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultPermission)} does not support writing '{options.Format}' format.");
            }
        }

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        KeyVaultPermission IPersistableModel<KeyVaultPermission>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual KeyVaultPermission PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<KeyVaultPermission>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeKeyVaultPermission(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultPermission)} does not support reading '{options.Format}' format.");
            }
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<KeyVaultPermission>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
