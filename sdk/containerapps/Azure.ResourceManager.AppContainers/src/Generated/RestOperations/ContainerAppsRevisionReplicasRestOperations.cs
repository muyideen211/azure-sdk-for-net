// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers
{
    internal partial class ContainerAppsRevisionReplicasRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ContainerAppsRevisionReplicasRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ContainerAppsRevisionReplicasRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetReplicaRequestUri(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, string replicaName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/containerApps/", false);
            uri.AppendPath(containerAppName, true);
            uri.AppendPath("/revisions/", false);
            uri.AppendPath(revisionName, true);
            uri.AppendPath("/replicas/", false);
            uri.AppendPath(replicaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetReplicaRequest(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, string replicaName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/containerApps/", false);
            uri.AppendPath(containerAppName, true);
            uri.AppendPath("/revisions/", false);
            uri.AppendPath(revisionName, true);
            uri.AppendPath("/replicas/", false);
            uri.AppendPath(replicaName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a replica for a Container App Revision. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/>, <paramref name="revisionName"/> or <paramref name="replicaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/>, <paramref name="revisionName"/> or <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerAppReplicaData>> GetReplicaAsync(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var message = CreateGetReplicaRequest(subscriptionId, resourceGroupName, containerAppName, revisionName, replicaName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAppReplicaData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ContainerAppReplicaData.DeserializeContainerAppReplicaData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerAppReplicaData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a replica for a Container App Revision. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/>, <paramref name="revisionName"/> or <paramref name="replicaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/>, <paramref name="revisionName"/> or <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerAppReplicaData> GetReplica(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var message = CreateGetReplicaRequest(subscriptionId, resourceGroupName, containerAppName, revisionName, replicaName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAppReplicaData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ContainerAppReplicaData.DeserializeContainerAppReplicaData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerAppReplicaData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListReplicasRequestUri(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/containerApps/", false);
            uri.AppendPath(containerAppName, true);
            uri.AppendPath("/revisions/", false);
            uri.AppendPath(revisionName, true);
            uri.AppendPath("/replicas", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListReplicasRequest(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/containerApps/", false);
            uri.AppendPath(containerAppName, true);
            uri.AppendPath("/revisions/", false);
            uri.AppendPath(revisionName, true);
            uri.AppendPath("/replicas", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List replicas for a Container App Revision. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/> or <paramref name="revisionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/> or <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReplicaCollection>> ListReplicasAsync(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var message = CreateListReplicasRequest(subscriptionId, resourceGroupName, containerAppName, revisionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReplicaCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ReplicaCollection.DeserializeReplicaCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List replicas for a Container App Revision. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="revisionName"> Name of the Container App Revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/> or <paramref name="revisionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerAppName"/> or <paramref name="revisionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReplicaCollection> ListReplicas(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNullOrEmpty(revisionName, nameof(revisionName));

            using var message = CreateListReplicasRequest(subscriptionId, resourceGroupName, containerAppName, revisionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReplicaCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ReplicaCollection.DeserializeReplicaCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
