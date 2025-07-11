// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Data.SchemaRegistry.Models;

namespace Azure.Data.SchemaRegistry
{
    /// <summary> SchemaRegistryClient is a client for registering and retrieving schemas from the Azure Schema Registry service. </summary>
    public partial class SchemaRegistryClient
    {
        private readonly Uri _endpoint;
        /// <summary> A credential used to authenticate to the service. </summary>
        private readonly TokenCredential _tokenCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://eventhubs.azure.net/.default" };
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary>
        /// [Protocol Method] Gets the list of schema groups user is authorized to access.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Pageable<BinaryData> GetSchemaGroups(RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaGroups");
            scope.Start();
            try
            {
                return new SchemaRegistryClientGetSchemaGroupsCollectionResult(this, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the list of schema groups user is authorized to access.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual AsyncPageable<BinaryData> GetSchemaGroupsAsync(RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaGroups");
            scope.Start();
            try
            {
                return new SchemaRegistryClientGetSchemaGroupsAsyncCollectionResult(this, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of schema groups user is authorized to access. </summary>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Pageable<string> GetSchemaGroups(CancellationToken cancellationToken = default)
        {
            return new SchemaRegistryClientGetSchemaGroupsCollectionResultOfT(this, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Gets the list of schema groups user is authorized to access. </summary>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual AsyncPageable<string> GetSchemaGroupsAsync(CancellationToken cancellationToken = default)
        {
            return new SchemaRegistryClientGetSchemaGroupsAsyncCollectionResultOfT(this, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary>
        /// [Protocol Method] Gets the list of all versions of one schema.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Pageable<BinaryData> GetSchemaVersions(string groupName, string schemaName, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaVersions");
            scope.Start();
            try
            {
                return new SchemaRegistryClientGetSchemaVersionsCollectionResult(this, groupName, schemaName, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the list of all versions of one schema.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual AsyncPageable<BinaryData> GetSchemaVersionsAsync(string groupName, string schemaName, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaVersions");
            scope.Start();
            try
            {
                return new SchemaRegistryClientGetSchemaVersionsAsyncCollectionResult(this, groupName, schemaName, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of all versions of one schema. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Pageable<int> GetSchemaVersions(string groupName, string schemaName, CancellationToken cancellationToken = default)
        {
            return new SchemaRegistryClientGetSchemaVersionsCollectionResultOfT(this, groupName, schemaName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Gets the list of all versions of one schema. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual AsyncPageable<int> GetSchemaVersionsAsync(string groupName, string schemaName, CancellationToken cancellationToken = default)
        {
            return new SchemaRegistryClientGetSchemaVersionsAsyncCollectionResultOfT(this, groupName, schemaName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary>
        /// [Protocol Method] Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetSchemaById(string id, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaByIdRequest(id, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetSchemaByIdAsync(string id, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaById");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaByIdRequest(id, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested. </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Response<BinaryData> GetSchemaById(string id, CancellationToken cancellationToken = default)
        {
            Response result = GetSchemaById(id, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue(result.Content, result);
        }

        /// <summary> Gets a registered schema by its unique ID.  Azure Schema Registry guarantees that ID is unique within a namespace. Operation response type is based on serialization of schema requested. </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual async Task<Response<BinaryData>> GetSchemaByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            Response result = await GetSchemaByIdAsync(id, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue(result.Content, result);
        }

        /// <summary>
        /// [Protocol Method] Gets one specific version of one schema.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="schemaVersion"> Version number of specific schema. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetSchemaByVersion(string groupName, string schemaName, int schemaVersion, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaByVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaByVersionRequest(groupName, schemaName, schemaVersion, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets one specific version of one schema.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="schemaVersion"> Version number of specific schema. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetSchemaByVersionAsync(string groupName, string schemaName, int schemaVersion, RequestContext context)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaByVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaByVersionRequest(groupName, schemaName, schemaVersion, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets one specific version of one schema. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="schemaVersion"> Version number of specific schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Response<BinaryData> GetSchemaByVersion(string groupName, string schemaName, int schemaVersion, CancellationToken cancellationToken = default)
        {
            Response result = GetSchemaByVersion(groupName, schemaName, schemaVersion, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue(result.Content, result);
        }

        /// <summary> Gets one specific version of one schema. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="schemaVersion"> Version number of specific schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual async Task<Response<BinaryData>> GetSchemaByVersionAsync(string groupName, string schemaName, int schemaVersion, CancellationToken cancellationToken = default)
        {
            Response result = await GetSchemaByVersionAsync(groupName, schemaName, schemaVersion, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue(result.Content, result);
        }

        /// <summary>
        /// [Protocol Method] Gets the properties referencing an existing schema within the specified schema group, as matched by schema content comparison.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetSchemaPropertiesByContent(string groupName, string schemaName, string contentType, RequestContent content, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaPropertiesByContent");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaPropertiesByContentRequest(groupName, schemaName, contentType, content, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the properties referencing an existing schema within the specified schema group, as matched by schema content comparison.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetSchemaPropertiesByContentAsync(string groupName, string schemaName, string contentType, RequestContent content, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.GetSchemaPropertiesByContent");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSchemaPropertiesByContentRequest(groupName, schemaName, contentType, content, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties referencing an existing schema within the specified schema group, as matched by schema content comparison. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Response GetSchemaPropertiesByContent(string groupName, string schemaName, SchemaContentTypeValues contentType, BinaryData schemaContent, CancellationToken cancellationToken = default)
        {
            return GetSchemaPropertiesByContent(groupName, schemaName, contentType.ToSerialString(), RequestContent.Create(schemaContent), cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Gets the properties referencing an existing schema within the specified schema group, as matched by schema content comparison. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual async Task<Response> GetSchemaPropertiesByContentAsync(string groupName, string schemaName, SchemaContentTypeValues contentType, BinaryData schemaContent, CancellationToken cancellationToken = default)
        {
            return await GetSchemaPropertiesByContentAsync(groupName, schemaName, contentType.ToSerialString(), RequestContent.Create(schemaContent), cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
        }

        /// <summary>
        /// [Protocol Method] Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response RegisterSchema(string groupName, string schemaName, string contentType, RequestContent content, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.RegisterSchema");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRegisterSchemaRequest(groupName, schemaName, contentType, content, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> RegisterSchemaAsync(string groupName, string schemaName, string contentType, RequestContent content, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("SchemaRegistryClient.RegisterSchema");
            scope.Start();
            try
            {
                using HttpMessage message = CreateRegisterSchemaRequest(groupName, schemaName, contentType, content, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual Response RegisterSchema(string groupName, string schemaName, SchemaContentTypeValues contentType, BinaryData schemaContent, CancellationToken cancellationToken = default)
        {
            return RegisterSchema(groupName, schemaName, contentType.ToSerialString(), RequestContent.Create(schemaContent), cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Register new schema. If schema of specified name does not exist in specified group, schema is created at version 1. If schema of specified name exists already in specified group, schema is created at latest version + 1. </summary>
        /// <param name="groupName"> Name of schema group. </param>
        /// <param name="schemaName"> Name of schema. </param>
        /// <param name="contentType"> The content type for given schema. </param>
        /// <param name="schemaContent"> String representation (UTF-8) of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        internal virtual async Task<Response> RegisterSchemaAsync(string groupName, string schemaName, SchemaContentTypeValues contentType, BinaryData schemaContent, CancellationToken cancellationToken = default)
        {
            return await RegisterSchemaAsync(groupName, schemaName, contentType.ToSerialString(), RequestContent.Create(schemaContent), cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
        }
    }
}
