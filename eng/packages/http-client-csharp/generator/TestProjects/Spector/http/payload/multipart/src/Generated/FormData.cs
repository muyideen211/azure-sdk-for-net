// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Payload.MultiPart._FormData.HttpParts;

namespace Payload.MultiPart._FormData
{
    public partial class FormData
    {
        protected FormData() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response Basic(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> BasicAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response FileArrayAndBasic(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> FileArrayAndBasicAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response JsonPart(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> JsonPartAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response BinaryArrayParts(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> BinaryArrayPartsAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response MultiBinaryParts(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> MultiBinaryPartsAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response CheckFileNameAndContentType(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> CheckFileNameAndContentTypeAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Response AnonymousModel(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual Task<Response> AnonymousModelAsync(RequestContent content, string contentType, RequestContext context = null) => throw null;

        public virtual FormDataHttpParts GetFormDataHttpPartsClient() => throw null;
    }
}
