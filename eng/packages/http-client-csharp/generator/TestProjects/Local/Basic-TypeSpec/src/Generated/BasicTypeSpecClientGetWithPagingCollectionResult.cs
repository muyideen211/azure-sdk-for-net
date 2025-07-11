// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BasicTypeSpec
{
    internal partial class BasicTypeSpecClientGetWithPagingCollectionResult : Pageable<BinaryData>
    {
        private readonly BasicTypeSpecClient _client;
        private readonly RequestContext _context;

        /// <summary> Initializes a new instance of BasicTypeSpecClientGetWithPagingCollectionResult, which is used to iterate over the pages of a collection. </summary>
        /// <param name="client"> The BasicTypeSpecClient client used to send requests. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        public BasicTypeSpecClientGetWithPagingCollectionResult(BasicTypeSpecClient client, RequestContext context) : base(context?.CancellationToken ?? default)
        {
            _client = client;
            _context = context;
        }

        /// <summary> Gets the pages of BasicTypeSpecClientGetWithPagingCollectionResult as an enumerable collection. </summary>
        /// <param name="continuationToken"> A continuation token indicating where to resume paging. </param>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <returns> The pages of BasicTypeSpecClientGetWithPagingCollectionResult as an enumerable collection. </returns>
        public override IEnumerable<Page<BinaryData>> AsPages(string continuationToken, int? pageSizeHint)
        {
            Response response = GetNextResponse(pageSizeHint, null);
            PageThingModel responseWithType = (PageThingModel)response;
            List<BinaryData> items = new List<BinaryData>();
            foreach (var item in responseWithType.Items)
            {
                items.Add(BinaryData.FromObjectAsJson(item));
            }
            yield return Page<BinaryData>.FromValues(items, null, response);
        }

        /// <summary> Get next page. </summary>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <param name="continuationToken"> A continuation token indicating where to resume paging. </param>
        private Response GetNextResponse(int? pageSizeHint, string continuationToken)
        {
            HttpMessage message = _client.CreateGetWithPagingRequest(_context);
            using DiagnosticScope scope = _client.ClientDiagnostics.CreateScope("BasicTypeSpecClient.GetWithPaging");
            scope.Start();
            try
            {
                return _client.Pipeline.ProcessMessage(message, _context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
