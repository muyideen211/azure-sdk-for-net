// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCircuitAuthorizationResource : IJsonModel<ExpressRouteCircuitAuthorizationData>
    {
        private static ExpressRouteCircuitAuthorizationData s_dataDeserializationInstance;
        private static ExpressRouteCircuitAuthorizationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ExpressRouteCircuitAuthorizationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteCircuitAuthorizationData>)Data).Write(writer, options);

        ExpressRouteCircuitAuthorizationData IJsonModel<ExpressRouteCircuitAuthorizationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteCircuitAuthorizationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRouteCircuitAuthorizationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ExpressRouteCircuitAuthorizationData>(Data, options, AzureResourceManagerNetworkContext.Default);

        ExpressRouteCircuitAuthorizationData IPersistableModel<ExpressRouteCircuitAuthorizationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRouteCircuitAuthorizationData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<ExpressRouteCircuitAuthorizationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRouteCircuitAuthorizationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
