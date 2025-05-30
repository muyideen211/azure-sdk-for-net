// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ApplicationGatewayResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayGet.json
            // this example is just showing the usage of "ApplicationGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ApplicationGatewayResource result = await applicationGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayDelete.json
            // this example is just showing the usage of "ApplicationGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateApplicationGatewayTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayUpdateTags.json
            // this example is just showing the usage of "ApplicationGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "AppGw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ApplicationGatewayResource result = await applicationGateway.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayStart.json
            // this example is just showing the usage of "ApplicationGateways_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.StartAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayStop.json
            // this example is just showing the usage of "ApplicationGateways_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.StopAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task BackendHealth_GetBackendHealth()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayBackendHealthGet.json
            // this example is just showing the usage of "ApplicationGateways_BackendHealth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "appgw";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ArmOperation<ApplicationGatewayBackendHealth> lro = await applicationGateway.BackendHealthAsync(WaitUntil.Completed);
            ApplicationGatewayBackendHealth result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task BackendHealthOnDemand_TestBackendHealth()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayBackendHealthTest.json
            // this example is just showing the usage of "ApplicationGateways_BackendHealthOnDemand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ApplicationGatewayOnDemandProbe probeRequest = new ApplicationGatewayOnDemandProbe
            {
                Protocol = ApplicationGatewayProtocol.Http,
                Path = "/",
                Timeout = 30,
                PickHostNameFromBackendHttpSettings = true,
                BackendAddressPoolId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendaddressPools/MFAnalyticsPool"),
                BackendHttpSettingsId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendHttpSettingsCollection/MFPoolSettings"),
            };
            ArmOperation<ApplicationGatewayBackendHealthOnDemand> lro = await applicationGateway.BackendHealthOnDemandAsync(WaitUntil.Completed, probeRequest);
            ApplicationGatewayBackendHealthOnDemand result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetApplicationGatewayPrivateLinkResources_ListsAllPrivateLinkResourcesOnApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ApplicationGatewayPrivateLinkResourceList.json
            // this example is just showing the usage of "ApplicationGatewayPrivateLinkResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayPrivateLinkResource item in applicationGateway.GetApplicationGatewayPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
