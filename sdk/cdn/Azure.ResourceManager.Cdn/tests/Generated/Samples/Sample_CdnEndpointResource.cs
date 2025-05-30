// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_CdnEndpointResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_EndpointsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_Get.json
            // this example is just showing the usage of "CdnEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            CdnEndpointResource result = await cdnEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_EndpointsDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_Delete.json
            // this example is just showing the usage of "CdnEndpoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            await cdnEndpoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_EndpointsUpdate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_Update.json
            // this example is just showing the usage of "CdnEndpoints_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            CdnEndpointPatch patch = new CdnEndpointPatch
            {
                Tags =
{
["additionalProperties"] = "Tag1"
},
            };
            ArmOperation<CdnEndpointResource> lro = await cdnEndpoint.UpdateAsync(WaitUntil.Completed, patch);
            CdnEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_EndpointsStart()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_Start.json
            // this example is just showing the usage of "CdnEndpoints_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            ArmOperation<CdnEndpointResource> lro = await cdnEndpoint.StartAsync(WaitUntil.Completed);
            CdnEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_EndpointsStop()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_Stop.json
            // this example is just showing the usage of "CdnEndpoints_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            ArmOperation<CdnEndpointResource> lro = await cdnEndpoint.StopAsync(WaitUntil.Completed);
            CdnEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task PurgeContent_EndpointsPurgeContent()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_PurgeContent.json
            // this example is just showing the usage of "CdnEndpoints_PurgeContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            PurgeContent content = new PurgeContent(new string[] { "/folder1" });
            await cdnEndpoint.PurgeContentAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task LoadContent_EndpointsLoadContent()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_LoadContent.json
            // this example is just showing the usage of "CdnEndpoints_LoadContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            LoadContent content = new LoadContent(new string[] { "/folder1" });
            await cdnEndpoint.LoadContentAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateCustomDomain_EndpointsValidateCustomDomain()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_ValidateCustomDomain.json
            // this example is just showing the usage of "CdnEndpoints_ValidateCustomDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation
            ValidateCustomDomainContent content = new ValidateCustomDomainContent("www.someDomain.com");
            ValidateCustomDomainResult result = await cdnEndpoint.ValidateCustomDomainAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetResourceUsages_EndpointsListResourceUsage()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/Endpoints_ListResourceUsage.json
            // this example is just showing the usage of "CdnEndpoints_ListResourceUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // invoke the operation and iterate over the result
            await foreach (CdnUsage item in cdnEndpoint.GetResourceUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
