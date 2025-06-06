// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricIPExtendedCommunityResource : IJsonModel<NetworkFabricIPExtendedCommunityData>
    {
        private static NetworkFabricIPExtendedCommunityData s_dataDeserializationInstance;
        private static NetworkFabricIPExtendedCommunityData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NetworkFabricIPExtendedCommunityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricIPExtendedCommunityData>)Data).Write(writer, options);

        NetworkFabricIPExtendedCommunityData IJsonModel<NetworkFabricIPExtendedCommunityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricIPExtendedCommunityData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkFabricIPExtendedCommunityData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkFabricIPExtendedCommunityData>(Data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        NetworkFabricIPExtendedCommunityData IPersistableModel<NetworkFabricIPExtendedCommunityData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkFabricIPExtendedCommunityData>(data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        string IPersistableModel<NetworkFabricIPExtendedCommunityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkFabricIPExtendedCommunityData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
