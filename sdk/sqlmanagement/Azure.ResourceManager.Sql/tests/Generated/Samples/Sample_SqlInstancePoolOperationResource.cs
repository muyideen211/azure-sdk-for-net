// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlInstancePoolOperationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheInstancePoolManagementOperation()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetInstancePoolOperation.json
            // this example is just showing the usage of "InstancePoolOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlInstancePoolOperationResource created on azure
            // for more information of creating SqlInstancePoolOperationResource, please refer to the document of SqlInstancePoolOperationResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resource-group";
            string instancePoolName = "test-instance-pool";
            Guid operationId = Guid.Parse("c218773b-203f-4c7a-b174-6bd71fe20f72");
            ResourceIdentifier sqlInstancePoolOperationResourceId = SqlInstancePoolOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instancePoolName, operationId);
            SqlInstancePoolOperationResource sqlInstancePoolOperation = client.GetSqlInstancePoolOperationResource(sqlInstancePoolOperationResourceId);

            // invoke the operation
            SqlInstancePoolOperationResource result = await sqlInstancePoolOperation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlInstancePoolOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
