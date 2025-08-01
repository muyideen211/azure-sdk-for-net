// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceProvisioningServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceProvisioningServices.Samples
{
    public partial class Sample_DeviceProvisioningServiceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetValidSkus_DPSGetValidSku()
        {
            // Generated from example definition: 2025-02-01-preview/DPSGetValidSku.json
            // this example is just showing the usage of "ProvisioningServiceDescriptions_ListValidSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // invoke the operation and iterate over the result
            await foreach (DeviceProvisioningServicesSkuDefinition item in deviceProvisioningService.GetValidSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
