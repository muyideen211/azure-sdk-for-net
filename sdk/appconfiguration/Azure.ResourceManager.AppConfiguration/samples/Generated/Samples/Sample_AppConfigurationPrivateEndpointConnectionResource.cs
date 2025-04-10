// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppConfiguration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppConfiguration.Samples
{
    public partial class Sample_AppConfigurationPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionGetConnection()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2024-05-01/examples/ConfigurationStoresGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationPrivateEndpointConnectionResource created on azure
            // for more information of creating AppConfigurationPrivateEndpointConnectionResource, please refer to the document of AppConfigurationPrivateEndpointConnectionResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier appConfigurationPrivateEndpointConnectionResourceId = AppConfigurationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
            AppConfigurationPrivateEndpointConnectionResource appConfigurationPrivateEndpointConnection = client.GetAppConfigurationPrivateEndpointConnectionResource(appConfigurationPrivateEndpointConnectionResourceId);

            // invoke the operation
            AppConfigurationPrivateEndpointConnectionResource result = await appConfigurationPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2024-05-01/examples/ConfigurationStoresDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationPrivateEndpointConnectionResource created on azure
            // for more information of creating AppConfigurationPrivateEndpointConnectionResource, please refer to the document of AppConfigurationPrivateEndpointConnectionResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier appConfigurationPrivateEndpointConnectionResourceId = AppConfigurationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
            AppConfigurationPrivateEndpointConnectionResource appConfigurationPrivateEndpointConnection = client.GetAppConfigurationPrivateEndpointConnectionResource(appConfigurationPrivateEndpointConnectionResourceId);

            // invoke the operation
            await appConfigurationPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PrivateEndpointConnectionUpdate()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2024-05-01/examples/ConfigurationStoresUpdatePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppConfigurationPrivateEndpointConnectionResource created on azure
            // for more information of creating AppConfigurationPrivateEndpointConnectionResource, please refer to the document of AppConfigurationPrivateEndpointConnectionResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            string resourceGroupName = "myResourceGroup";
            string configStoreName = "contoso";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier appConfigurationPrivateEndpointConnectionResourceId = AppConfigurationPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
            AppConfigurationPrivateEndpointConnectionResource appConfigurationPrivateEndpointConnection = client.GetAppConfigurationPrivateEndpointConnectionResource(appConfigurationPrivateEndpointConnectionResourceId);

            // invoke the operation
            AppConfigurationPrivateEndpointConnectionData data = new AppConfigurationPrivateEndpointConnectionData
            {
                ConnectionState = new AppConfigurationPrivateLinkServiceConnectionState
                {
                    Status = AppConfigurationPrivateLinkServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<AppConfigurationPrivateEndpointConnectionResource> lro = await appConfigurationPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            AppConfigurationPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppConfigurationPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
