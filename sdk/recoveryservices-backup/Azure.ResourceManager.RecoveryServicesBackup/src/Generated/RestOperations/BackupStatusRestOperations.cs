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
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal partial class BackupStatusRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BackupStatusRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BackupStatusRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, AzureLocation location, BackupStatusContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/backupStatus", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation location, BackupStatusContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/backupStatus", false);
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

        /// <summary> Get the container backup status. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="location"> Azure region to hit Api. </param>
        /// <param name="content"> Container Backup Status Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupStatusResult>> GetAsync(string subscriptionId, AzureLocation location, BackupStatusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetRequest(subscriptionId, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupStatusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = BackupStatusResult.DeserializeBackupStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the container backup status. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="location"> Azure region to hit Api. </param>
        /// <param name="content"> Container Backup Status Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupStatusResult> Get(string subscriptionId, AzureLocation location, BackupStatusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetRequest(subscriptionId, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupStatusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = BackupStatusResult.DeserializeBackupStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
