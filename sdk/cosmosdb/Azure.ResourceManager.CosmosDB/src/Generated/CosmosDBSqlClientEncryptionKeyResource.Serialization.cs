// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBSqlClientEncryptionKeyResource : IJsonModel<CosmosDBSqlClientEncryptionKeyData>
    {
        private static CosmosDBSqlClientEncryptionKeyData s_dataDeserializationInstance;
        private static CosmosDBSqlClientEncryptionKeyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<CosmosDBSqlClientEncryptionKeyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlClientEncryptionKeyData>)Data).Write(writer, options);

        CosmosDBSqlClientEncryptionKeyData IJsonModel<CosmosDBSqlClientEncryptionKeyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlClientEncryptionKeyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CosmosDBSqlClientEncryptionKeyData>(Data, options, AzureResourceManagerCosmosDBContext.Default);

        CosmosDBSqlClientEncryptionKeyData IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBSqlClientEncryptionKeyData>(data, options, AzureResourceManagerCosmosDBContext.Default);

        string IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBSqlClientEncryptionKeyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
