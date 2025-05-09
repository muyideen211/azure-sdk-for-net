// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Details of the Receive operation response. </summary>
    public partial class ReceiveResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="ReceiveResult"/>. </summary>
        internal ReceiveResult()
        {
            Details = new ChangeTrackingList<ReceiveDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="ReceiveResult"/>. </summary>
        /// <param name="details"> Array of receive responses, one per cloud event. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal ReceiveResult(IReadOnlyList<ReceiveDetails> details, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Details = details;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Array of receive responses, one per cloud event. </summary>
        public IReadOnlyList<ReceiveDetails> Details { get; }
    }
}
