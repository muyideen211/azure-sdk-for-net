// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The input definition information for a function tool as used to configure an agent. </summary>
    public partial class FunctionToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="FunctionToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalFunction"> The definition of the concrete function that the function tool should call. </param>
        internal FunctionToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalFunctionDefinition internalFunction) : base(type, serializedAdditionalRawData)
        {
            InternalFunction = internalFunction;
        }

        /// <summary> Initializes a new instance of <see cref="FunctionToolDefinition"/> for deserialization. </summary>
        internal FunctionToolDefinition()
        {
        }
    }
}
