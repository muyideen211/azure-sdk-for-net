// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a QuotaRequestDetail along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="QuotaRequestDetailResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetQuotaRequestDetailResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetQuotaRequestDetail method.
    /// </summary>
    public partial class QuotaRequestDetailResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="QuotaRequestDetailResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="id"> The id. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string id)
        {
            var resourceId = $"{scope}/providers/Microsoft.Quota/quotaRequests/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _quotaRequestDetailQuotaRequestStatusClientDiagnostics;
        private readonly QuotaRequestStatusRestOperations _quotaRequestDetailQuotaRequestStatusRestClient;
        private readonly QuotaRequestDetailData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/quotaRequests";

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailResource"/> class for mocking. </summary>
        protected QuotaRequestDetailResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal QuotaRequestDetailResource(ArmClient client, QuotaRequestDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal QuotaRequestDetailResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _quotaRequestDetailQuotaRequestStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string quotaRequestDetailQuotaRequestStatusApiVersion);
            _quotaRequestDetailQuotaRequestStatusRestClient = new QuotaRequestStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaRequestDetailQuotaRequestStatusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual QuotaRequestDetailData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QuotaRequestDetailResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailResource.Get");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaRequestDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QuotaRequestDetailResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailResource.Get");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
