// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WebSiteCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CloneWebApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CloneWebApp.json
            // this example is just showing the usage of "WebApps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            WebSiteData data = new WebSiteData(new AzureLocation("East US"))
            {
                CloningInfo = new CloningInfo(new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/testrg456/providers/Microsoft.Web/sites/srcsiteg478"))
                {
                    CanOverwrite = false,
                    CloneCustomHostNames = true,
                    CloneSourceControl = true,
                    SourceWebAppLocation = new AzureLocation("West Europe"),
                    HostingEnvironment = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/testrg456/providers/Microsoft.Web/hostingenvironments/aseforsites",
                    AppSettingsOverrides =
{
["Setting1"] = "NewValue1",
["Setting3"] = "NewValue5"
},
                    ConfigureLoadBalancing = false,
                },
                Kind = "app",
            };
            ArmOperation<WebSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            WebSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateFlexConsumptionFunctionApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CreateOrUpdateFunctionAppFlexConsumption.json
            // this example is just showing the usage of "WebApps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            WebSiteData data = new WebSiteData(new AzureLocation("East US"))
            {
                SiteConfig = new SiteConfigProperties
                {
                    AppSettings = {new AppServiceNameValuePair
{
Name = "AzureWebJobsStorage",
Value = "DefaultEndpointsProtocol=https;AccountName=StorageAccountName;AccountKey=Sanitized;EndpointSuffix=core.windows.net",
}, new AppServiceNameValuePair
{
Name = "APPLICATIONINSIGHTS_CONNECTION_STRING",
Value = "InstrumentationKey=Sanitized;IngestionEndpoint=Sanitized;LiveEndpoint=Sanitized",
}},
                },
                FunctionAppConfig = new FunctionAppConfig
                {
                    DeploymentStorage = new FunctionAppStorage
                    {
                        StorageType = FunctionAppStorageType.BlobContainer,
                        Value = new Uri("https://storageAccountName.blob.core.windows.net/containername"),
                        Authentication = new FunctionAppStorageAuthentication
                        {
                            AuthenticationType = FunctionAppStorageAccountAuthenticationType.StorageAccountConnectionString,
                            StorageAccountConnectionStringName = "TheAppSettingName",
                        },
                    },
                    Runtime = new FunctionAppRuntime
                    {
                        Name = FunctionAppRuntimeName.Python,
                        Version = "3.11",
                    },
                    ScaleAndConcurrency = new FunctionAppScaleAndConcurrency
                    {
                        FunctionAppMaximumInstanceCount = 100,
                        FunctionAppInstanceMemoryMB = 2048,
                    },
                },
                Kind = "functionapp,linux",
            };
            ArmOperation<WebSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            WebSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateFlexConsumptionFunctionAppWithDetails()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CreateOrUpdateFunctionAppFlexConsumptionWithDetails.json
            // this example is just showing the usage of "WebApps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            WebSiteData data = new WebSiteData(new AzureLocation("East US"))
            {
                SiteConfig = new SiteConfigProperties
                {
                    AppSettings = {new AppServiceNameValuePair
{
Name = "AzureWebJobsStorage",
Value = "DefaultEndpointsProtocol=https;AccountName=StorageAccountName;AccountKey=Sanitized;EndpointSuffix=core.windows.net",
}, new AppServiceNameValuePair
{
Name = "APPLICATIONINSIGHTS_CONNECTION_STRING",
Value = "InstrumentationKey=Sanitized;IngestionEndpoint=Sanitized;LiveEndpoint=Sanitized",
}},
                },
                FunctionAppConfig = new FunctionAppConfig
                {
                    DeploymentStorage = new FunctionAppStorage
                    {
                        StorageType = FunctionAppStorageType.BlobContainer,
                        Value = new Uri("https://storageAccountName.blob.core.windows.net/containername"),
                        Authentication = new FunctionAppStorageAuthentication
                        {
                            AuthenticationType = FunctionAppStorageAccountAuthenticationType.StorageAccountConnectionString,
                            StorageAccountConnectionStringName = "TheAppSettingName",
                        },
                    },
                    Runtime = new FunctionAppRuntime
                    {
                        Name = FunctionAppRuntimeName.Python,
                        Version = "3.11",
                    },
                    ScaleAndConcurrency = new FunctionAppScaleAndConcurrency
                    {
                        AlwaysReady = {new FunctionAppAlwaysReadyConfig
{
Name = "http",
AlwaysReadyInstanceCount = 2,
}},
                        FunctionAppMaximumInstanceCount = 100,
                        FunctionAppInstanceMemoryMB = 2048,
                        ConcurrentHttpPerInstanceConcurrency = 16,
                    },
                },
                Kind = "functionapp,linux",
            };
            ArmOperation<WebSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            WebSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateWebApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CreateOrUpdateWebApp.json
            // this example is just showing the usage of "WebApps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            WebSiteData data = new WebSiteData(new AzureLocation("East US"))
            {
                AppServicePlanId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/testrg123/providers/Microsoft.Web/serverfarms/DefaultAsp"),
                Kind = "app",
            };
            ArmOperation<WebSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            WebSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWebApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetWebApp.json
            // this example is just showing the usage of "WebApps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            WebSiteResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWebAppsByResourceGroup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/ListWebAppsByResourceGroup.json
            // this example is just showing the usage of "WebApps_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation and iterate over the result
            await foreach (WebSiteResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetWebApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetWebApp.json
            // this example is just showing the usage of "WebApps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetWebApp()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetWebApp.json
            // this example is just showing the usage of "WebApps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WebSiteResource
            WebSiteCollection collection = resourceGroupResource.GetWebSites();

            // invoke the operation
            string name = "sitef6141";
            NullableResponse<WebSiteResource> response = await collection.GetIfExistsAsync(name);
            WebSiteResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WebSiteData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
