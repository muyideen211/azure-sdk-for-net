// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisChildPackageConverter))]
    public partial class SsisChildPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("packagePath"u8);
            writer.WriteObjectValue<object>(PackagePath);
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            writer.WritePropertyName("packageContent"u8);
            writer.WriteObjectValue<object>(PackageContent);
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            writer.WriteEndObject();
        }

        internal static SsisChildPackage DeserializeSsisChildPackage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object packagePath = default;
            string packageName = default;
            object packageContent = default;
            string packageLastModifiedDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    packagePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageContent"u8))
                {
                    packageContent = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("packageLastModifiedDate"u8))
                {
                    packageLastModifiedDate = property.Value.GetString();
                    continue;
                }
            }
            return new SsisChildPackage(packagePath, packageName, packageContent, packageLastModifiedDate);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SsisChildPackage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSsisChildPackage(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SsisChildPackageConverter : JsonConverter<SsisChildPackage>
        {
            public override void Write(Utf8JsonWriter writer, SsisChildPackage model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisChildPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisChildPackage(document.RootElement);
            }
        }
    }
}
