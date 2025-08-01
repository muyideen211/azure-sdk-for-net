// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerJobStepCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAJobStepWithAllPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/CreateOrUpdateJobStepMax.json
            // this example is just showing the usage of "JobSteps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation
            string stepName = "step1";
            SqlServerJobStepData data = new SqlServerJobStepData
            {
                StepId = 1,
                TargetGroup = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Sql/servers/server1/jobAgents/agent1/targetGroups/targetGroup1",
                Credential = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Sql/servers/server1/jobAgents/agent1/credentials/cred1",
                Action = new JobStepAction("select 2")
                {
                    ActionType = JobStepActionType.TSql,
                    Source = JobStepActionSource.Inline,
                },
                Output = new JobStepOutput("server3", "database3", "mytable5678")
                {
                    OutputType = JobStepOutputType.SqlDatabase,
                    SubscriptionId = Guid.Parse("3501b905-a848-4b5d-96e8-b253f62d735a"),
                    ResourceGroupName = "group3",
                    SchemaName = "myschema1234",
                    Credential = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Sql/servers/server1/jobAgents/agent1/credentials/cred0",
                },
                ExecutionOptions = new JobStepExecutionOptions
                {
                    TimeoutSeconds = 1234,
                    RetryAttempts = 42,
                    InitialRetryIntervalSeconds = 11,
                    MaximumRetryIntervalSeconds = 222,
                    RetryIntervalBackoffMultiplier = 3,
                },
            };
            ArmOperation<SqlServerJobStepResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, stepName, data);
            SqlServerJobStepResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobStepData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAJobStepWithMinimalPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/CreateOrUpdateJobStepMin.json
            // this example is just showing the usage of "JobSteps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation
            string stepName = "step1";
            SqlServerJobStepData data = new SqlServerJobStepData
            {
                TargetGroup = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/group1/providers/Microsoft.Sql/servers/server1/jobAgents/agent1/targetGroups/targetGroup0",
                Action = new JobStepAction("select 1"),
            };
            ArmOperation<SqlServerJobStepResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, stepName, data);
            SqlServerJobStepResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobStepData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheLatestVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByJob.json
            // this example is just showing the usage of "JobSteps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation
            string stepName = "step1";
            SqlServerJobStepResource result = await collection.GetAsync(stepName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobStepData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListJobStepsForTheLatestVersionOfAJob()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ListJobStepsByJob.json
            // this example is just showing the usage of "JobSteps_ListByJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation and iterate over the result
            await foreach (SqlServerJobStepResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerJobStepData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetTheLatestVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByJob.json
            // this example is just showing the usage of "JobSteps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation
            string stepName = "step1";
            bool result = await collection.ExistsAsync(stepName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetTheLatestVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByJob.json
            // this example is just showing the usage of "JobSteps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobResource created on azure
            // for more information of creating SqlServerJobResource, please refer to the document of SqlServerJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            ResourceIdentifier sqlServerJobResourceId = SqlServerJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName);
            SqlServerJobResource sqlServerJob = client.GetSqlServerJobResource(sqlServerJobResourceId);

            // get the collection of this SqlServerJobStepResource
            SqlServerJobStepCollection collection = sqlServerJob.GetSqlServerJobSteps();

            // invoke the operation
            string stepName = "step1";
            NullableResponse<SqlServerJobStepResource> response = await collection.GetIfExistsAsync(stepName);
            SqlServerJobStepResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerJobStepData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
