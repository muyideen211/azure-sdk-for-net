// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRoutePortAuthorizationResource : IJsonModel<ExpressRoutePortAuthorizationData>
    {
        private static ExpressRoutePortAuthorizationData s_dataDeserializationInstance;
        private static ExpressRoutePortAuthorizationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ExpressRoutePortAuthorizationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRoutePortAuthorizationData>)Data).Write(writer, options);

        ExpressRoutePortAuthorizationData IJsonModel<ExpressRoutePortAuthorizationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRoutePortAuthorizationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRoutePortAuthorizationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ExpressRoutePortAuthorizationData>(Data, options, AzureResourceManagerNetworkContext.Default);

        ExpressRoutePortAuthorizationData IPersistableModel<ExpressRoutePortAuthorizationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRoutePortAuthorizationData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<ExpressRoutePortAuthorizationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRoutePortAuthorizationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
