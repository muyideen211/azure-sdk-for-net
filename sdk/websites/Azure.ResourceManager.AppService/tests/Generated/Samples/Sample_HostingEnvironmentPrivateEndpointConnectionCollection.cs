// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_HostingEnvironmentPrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApprovesOrRejectsAPrivateEndpointConnection()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection.json
            // this example is just showing the usage of "AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceEnvironmentResource created on azure
            // for more information of creating AppServiceEnvironmentResource, please refer to the document of AppServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier appServiceEnvironmentResourceId = AppServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceEnvironmentResource appServiceEnvironment = client.GetAppServiceEnvironmentResource(appServiceEnvironmentResourceId);

            // get the collection of this HostingEnvironmentPrivateEndpointConnectionResource
            HostingEnvironmentPrivateEndpointConnectionCollection collection = appServiceEnvironment.GetHostingEnvironmentPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "fa38656c-034e-43d8-adce-fe06ce039c98";
            RemotePrivateEndpointConnectionARMResourceData data = new RemotePrivateEndpointConnectionARMResourceData
            {
                PrivateLinkServiceConnectionState = new PrivateLinkConnectionState
                {
                    Status = "Approved",
                    Description = "Approved by johndoe@company.com",
                },
            };
            ArmOperation<HostingEnvironmentPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            HostingEnvironmentPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RemotePrivateEndpointConnectionARMResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAPrivateEndpointConnection()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/AppServiceEnvironments_GetPrivateEndpointConnection.json
            // this example is just showing the usage of "AppServiceEnvironments_GetPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceEnvironmentResource created on azure
            // for more information of creating AppServiceEnvironmentResource, please refer to the document of AppServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier appServiceEnvironmentResourceId = AppServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceEnvironmentResource appServiceEnvironment = client.GetAppServiceEnvironmentResource(appServiceEnvironmentResourceId);

            // get the collection of this HostingEnvironmentPrivateEndpointConnectionResource
            HostingEnvironmentPrivateEndpointConnectionCollection collection = appServiceEnvironment.GetHostingEnvironmentPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "fa38656c-034e-43d8-adce-fe06ce039c98";
            HostingEnvironmentPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RemotePrivateEndpointConnectionARMResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsTheListOfPrivateEndpointsAssociatedWithAHostingEnvironment()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/AppServiceEnvironments_GetPrivateEndpointConnectionList.json
            // this example is just showing the usage of "AppServiceEnvironments_GetPrivateEndpointConnectionList" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceEnvironmentResource created on azure
            // for more information of creating AppServiceEnvironmentResource, please refer to the document of AppServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier appServiceEnvironmentResourceId = AppServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceEnvironmentResource appServiceEnvironment = client.GetAppServiceEnvironmentResource(appServiceEnvironmentResourceId);

            // get the collection of this HostingEnvironmentPrivateEndpointConnectionResource
            HostingEnvironmentPrivateEndpointConnectionCollection collection = appServiceEnvironment.GetHostingEnvironmentPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (HostingEnvironmentPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RemotePrivateEndpointConnectionARMResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAPrivateEndpointConnection()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/AppServiceEnvironments_GetPrivateEndpointConnection.json
            // this example is just showing the usage of "AppServiceEnvironments_GetPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceEnvironmentResource created on azure
            // for more information of creating AppServiceEnvironmentResource, please refer to the document of AppServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier appServiceEnvironmentResourceId = AppServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceEnvironmentResource appServiceEnvironment = client.GetAppServiceEnvironmentResource(appServiceEnvironmentResourceId);

            // get the collection of this HostingEnvironmentPrivateEndpointConnectionResource
            HostingEnvironmentPrivateEndpointConnectionCollection collection = appServiceEnvironment.GetHostingEnvironmentPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "fa38656c-034e-43d8-adce-fe06ce039c98";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAPrivateEndpointConnection()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/AppServiceEnvironments_GetPrivateEndpointConnection.json
            // this example is just showing the usage of "AppServiceEnvironments_GetPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceEnvironmentResource created on azure
            // for more information of creating AppServiceEnvironmentResource, please refer to the document of AppServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier appServiceEnvironmentResourceId = AppServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceEnvironmentResource appServiceEnvironment = client.GetAppServiceEnvironmentResource(appServiceEnvironmentResourceId);

            // get the collection of this HostingEnvironmentPrivateEndpointConnectionResource
            HostingEnvironmentPrivateEndpointConnectionCollection collection = appServiceEnvironment.GetHostingEnvironmentPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "fa38656c-034e-43d8-adce-fe06ce039c98";
            NullableResponse<HostingEnvironmentPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            HostingEnvironmentPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RemotePrivateEndpointConnectionARMResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
