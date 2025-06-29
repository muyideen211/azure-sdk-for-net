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
using Azure.ResourceManager.ContainerInstance.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    internal partial class ContainersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ContainersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ContainersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListLogsRequestUri(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail, bool? timestamps)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/logs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (tail != null)
            {
                uri.AppendQuery("tail", tail.Value, true);
            }
            if (timestamps != null)
            {
                uri.AppendQuery("timestamps", timestamps.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListLogsRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail, bool? timestamps)
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
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/logs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (tail != null)
            {
                uri.AppendQuery("tail", tail.Value, true);
            }
            if (timestamps != null)
            {
                uri.AppendQuery("timestamps", timestamps.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the logs for a specified container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="tail"> The number of lines to show from the tail of the container instance log. If not provided, all available logs are shown up to 4mb. </param>
        /// <param name="timestamps"> If true, adds a timestamp at the beginning of every line of log output. If not provided, defaults to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerLogs>> ListLogsAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail = null, bool? timestamps = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var message = CreateListLogsRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, tail, timestamps);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerLogs value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ContainerLogs.DeserializeContainerLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the logs for a specified container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="tail"> The number of lines to show from the tail of the container instance log. If not provided, all available logs are shown up to 4mb. </param>
        /// <param name="timestamps"> If true, adds a timestamp at the beginning of every line of log output. If not provided, defaults to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerLogs> ListLogs(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail = null, bool? timestamps = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var message = CreateListLogsRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, tail, timestamps);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerLogs value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ContainerLogs.DeserializeContainerLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateExecuteCommandRequestUri(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/exec", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateExecuteCommandRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/exec", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Executes a command for a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="content"> The request for the exec command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, <paramref name="containerName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerExecResult>> ExecuteCommandAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateExecuteCommandRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerExecResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ContainerExecResult.DeserializeContainerExecResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Executes a command for a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="content"> The request for the exec command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, <paramref name="containerName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerExecResult> ExecuteCommand(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateExecuteCommandRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerExecResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ContainerExecResult.DeserializeContainerExecResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateAttachRequestUri(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/attach", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateAttachRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/attach", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Attach to the output stream of a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerAttachResult>> AttachAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var message = CreateAttachRequest(subscriptionId, resourceGroupName, containerGroupName, containerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAttachResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ContainerAttachResult.DeserializeContainerAttachResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Attach to the output stream of a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/> or <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerAttachResult> Attach(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(containerGroupName, nameof(containerGroupName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var message = CreateAttachRequest(subscriptionId, resourceGroupName, containerGroupName, containerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAttachResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ContainerAttachResult.DeserializeContainerAttachResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
