// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NotificationHubs
{
    public partial class NotificationHubNamespaceAuthorizationRuleResource : IJsonModel<NotificationHubAuthorizationRuleData>
    {
        private static NotificationHubAuthorizationRuleData s_dataDeserializationInstance;
        private static NotificationHubAuthorizationRuleData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NotificationHubAuthorizationRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NotificationHubAuthorizationRuleData>)Data).Write(writer, options);

        NotificationHubAuthorizationRuleData IJsonModel<NotificationHubAuthorizationRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NotificationHubAuthorizationRuleData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NotificationHubAuthorizationRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NotificationHubAuthorizationRuleData>(Data, options, AzureResourceManagerNotificationHubsContext.Default);

        NotificationHubAuthorizationRuleData IPersistableModel<NotificationHubAuthorizationRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NotificationHubAuthorizationRuleData>(data, options, AzureResourceManagerNotificationHubsContext.Default);

        string IPersistableModel<NotificationHubAuthorizationRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NotificationHubAuthorizationRuleData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
