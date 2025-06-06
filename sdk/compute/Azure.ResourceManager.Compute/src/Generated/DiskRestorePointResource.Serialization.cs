// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class DiskRestorePointResource : IJsonModel<DiskRestorePointData>
    {
        private static DiskRestorePointData s_dataDeserializationInstance;
        private static DiskRestorePointData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DiskRestorePointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DiskRestorePointData>)Data).Write(writer, options);

        DiskRestorePointData IJsonModel<DiskRestorePointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DiskRestorePointData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DiskRestorePointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DiskRestorePointData>(Data, options, AzureResourceManagerComputeContext.Default);

        DiskRestorePointData IPersistableModel<DiskRestorePointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DiskRestorePointData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<DiskRestorePointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DiskRestorePointData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
