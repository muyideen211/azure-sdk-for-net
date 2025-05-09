// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsEntityResource : IJsonModel<SecurityInsightsEntity>
    {
        void IJsonModel<SecurityInsightsEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsEntity>)Data).Write(writer, options);

        SecurityInsightsEntity IJsonModel<SecurityInsightsEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsEntity>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsEntity>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SecurityInsightsEntity>(Data, options, AzureResourceManagerSecurityInsightsContext.Default);

        SecurityInsightsEntity IPersistableModel<SecurityInsightsEntity>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsEntity>(data, options, AzureResourceManagerSecurityInsightsContext.Default);

        string IPersistableModel<SecurityInsightsEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsEntity>)Data).GetFormatFromOptions(options);
    }
}
