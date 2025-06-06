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
    [JsonConverter(typeof(LinkConnectionConverter))]
    public partial class LinkConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceDatabase))
            {
                writer.WritePropertyName("sourceDatabase"u8);
                writer.WriteObjectValue(SourceDatabase);
            }
            if (Optional.IsDefined(TargetDatabase))
            {
                writer.WritePropertyName("targetDatabase"u8);
                writer.WriteObjectValue(TargetDatabase);
            }
            if (Optional.IsDefined(LandingZone))
            {
                writer.WritePropertyName("landingZone"u8);
                writer.WriteObjectValue(LandingZone);
            }
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute"u8);
                writer.WriteObjectValue(Compute);
            }
            writer.WriteEndObject();
        }

        internal static LinkConnection DeserializeLinkConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkConnectionSourceDatabase sourceDatabase = default;
            LinkConnectionTargetDatabase targetDatabase = default;
            LinkConnectionLandingZone landingZone = default;
            LinkConnectionCompute compute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceDatabase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceDatabase = LinkConnectionSourceDatabase.DeserializeLinkConnectionSourceDatabase(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatabase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDatabase = LinkConnectionTargetDatabase.DeserializeLinkConnectionTargetDatabase(property.Value);
                    continue;
                }
                if (property.NameEquals("landingZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    landingZone = LinkConnectionLandingZone.DeserializeLinkConnectionLandingZone(property.Value);
                    continue;
                }
                if (property.NameEquals("compute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compute = LinkConnectionCompute.DeserializeLinkConnectionCompute(property.Value);
                    continue;
                }
            }
            return new LinkConnection(sourceDatabase, targetDatabase, landingZone, compute);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkConnection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkConnection(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkConnectionConverter : JsonConverter<LinkConnection>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnection model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkConnection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnection(document.RootElement);
            }
        }
    }
}
