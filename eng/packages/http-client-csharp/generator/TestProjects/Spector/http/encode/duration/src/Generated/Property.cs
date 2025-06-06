// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Encode.Duration._Property
{
    public partial class Property
    {
        protected Property() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response Default(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> DefaultAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<DefaultDurationProperty> Default(DefaultDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<DefaultDurationProperty>> DefaultAsync(DefaultDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response Iso8601(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> Iso8601Async(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<ISO8601DurationProperty> Iso8601(ISO8601DurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<ISO8601DurationProperty>> Iso8601Async(ISO8601DurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response Int32Seconds(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> Int32SecondsAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<Int32SecondsDurationProperty> Int32Seconds(Int32SecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<Int32SecondsDurationProperty>> Int32SecondsAsync(Int32SecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response FloatSeconds(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> FloatSecondsAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<FloatSecondsDurationProperty> FloatSeconds(FloatSecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<FloatSecondsDurationProperty>> FloatSecondsAsync(FloatSecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response Float64Seconds(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> Float64SecondsAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<Float64SecondsDurationProperty> Float64Seconds(Float64SecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<Float64SecondsDurationProperty>> Float64SecondsAsync(Float64SecondsDurationProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response FloatSecondsArray(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> FloatSecondsArrayAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response<FloatSecondsDurationArrayProperty> FloatSecondsArray(FloatSecondsDurationArrayProperty body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<FloatSecondsDurationArrayProperty>> FloatSecondsArrayAsync(FloatSecondsDurationArrayProperty body, CancellationToken cancellationToken = default) => throw null;
    }
}
