// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class HubVirtualNetworkConnectionResource : IJsonModel<HubVirtualNetworkConnectionData>
    {
        private static HubVirtualNetworkConnectionData s_dataDeserializationInstance;
        private static HubVirtualNetworkConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<HubVirtualNetworkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HubVirtualNetworkConnectionData>)Data).Write(writer, options);

        HubVirtualNetworkConnectionData IJsonModel<HubVirtualNetworkConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HubVirtualNetworkConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<HubVirtualNetworkConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<HubVirtualNetworkConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        HubVirtualNetworkConnectionData IPersistableModel<HubVirtualNetworkConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HubVirtualNetworkConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<HubVirtualNetworkConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HubVirtualNetworkConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
