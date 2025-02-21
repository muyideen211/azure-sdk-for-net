// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubAuthorizationRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_EventHubAuthorizationRuleGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleGet.json
            // this example is just showing the usage of "EventHubs_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubAuthorizationRuleResource created on azure
            // for more information of creating EventHubAuthorizationRuleResource, please refer to the document of EventHubAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            string authorizationRuleName = "sdk-Authrules-2513";
            ResourceIdentifier eventHubAuthorizationRuleResourceId = EventHubAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName, authorizationRuleName);
            EventHubAuthorizationRuleResource eventHubAuthorizationRule = client.GetEventHubAuthorizationRuleResource(eventHubAuthorizationRuleResourceId);

            // invoke the operation
            EventHubAuthorizationRuleResource result = await eventHubAuthorizationRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_EventHubAuthorizationRuleDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleDelete.json
            // this example is just showing the usage of "EventHubs_DeleteAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubAuthorizationRuleResource created on azure
            // for more information of creating EventHubAuthorizationRuleResource, please refer to the document of EventHubAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            string authorizationRuleName = "sdk-Authrules-2513";
            ResourceIdentifier eventHubAuthorizationRuleResourceId = EventHubAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName, authorizationRuleName);
            EventHubAuthorizationRuleResource eventHubAuthorizationRule = client.GetEventHubAuthorizationRuleResource(eventHubAuthorizationRuleResourceId);

            // invoke the operation
            await eventHubAuthorizationRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_EventHubAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleCreate.json
            // this example is just showing the usage of "EventHubs_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubAuthorizationRuleResource created on azure
            // for more information of creating EventHubAuthorizationRuleResource, please refer to the document of EventHubAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            string authorizationRuleName = "sdk-Authrules-2513";
            ResourceIdentifier eventHubAuthorizationRuleResourceId = EventHubAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName, authorizationRuleName);
            EventHubAuthorizationRuleResource eventHubAuthorizationRule = client.GetEventHubAuthorizationRuleResource(eventHubAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsAuthorizationRuleData data = new EventHubsAuthorizationRuleData
            {
                Rights = { EventHubsAccessRight.Listen, EventHubsAccessRight.Send },
            };
            ArmOperation<EventHubAuthorizationRuleResource> lro = await eventHubAuthorizationRule.UpdateAsync(WaitUntil.Completed, data);
            EventHubAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetKeys_EventHubAuthorizationRuleListKey()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleListKey.json
            // this example is just showing the usage of "EventHubs_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubAuthorizationRuleResource created on azure
            // for more information of creating EventHubAuthorizationRuleResource, please refer to the document of EventHubAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-960";
            string eventHubName = "sdk-EventHub-532";
            string authorizationRuleName = "sdk-Authrules-2513";
            ResourceIdentifier eventHubAuthorizationRuleResourceId = EventHubAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName, authorizationRuleName);
            EventHubAuthorizationRuleResource eventHubAuthorizationRule = client.GetEventHubAuthorizationRuleResource(eventHubAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsAccessKeys result = await eventHubAuthorizationRule.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKeys_EventHubAuthorizationRuleRegenerateKey()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleRegenerateKey.json
            // this example is just showing the usage of "EventHubs_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubAuthorizationRuleResource created on azure
            // for more information of creating EventHubAuthorizationRuleResource, please refer to the document of EventHubAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-960";
            string eventHubName = "sdk-EventHub-532";
            string authorizationRuleName = "sdk-Authrules-1534";
            ResourceIdentifier eventHubAuthorizationRuleResourceId = EventHubAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName, authorizationRuleName);
            EventHubAuthorizationRuleResource eventHubAuthorizationRule = client.GetEventHubAuthorizationRuleResource(eventHubAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsRegenerateAccessKeyContent content = new EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType.PrimaryKey);
            EventHubsAccessKeys result = await eventHubAuthorizationRule.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
