// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Represents a message delta i.e. any changed fields on a message during streaming. </summary>
    public partial class MessageDeltaChunk
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MessageDeltaChunk"/>. </summary>
        /// <param name="id"> The identifier of the message, which can be referenced in API endpoints. </param>
        /// <param name="delta"> The delta containing the fields that have changed on the Message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="delta"/> is null. </exception>
        internal MessageDeltaChunk(string id, MessageDelta delta)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(delta, nameof(delta));

            Id = id;
            Delta = delta;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaChunk"/>. </summary>
        /// <param name="id"> The identifier of the message, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `thread.message.delta`. </param>
        /// <param name="delta"> The delta containing the fields that have changed on the Message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDeltaChunk(string id, MessageDeltaChunkObject @object, MessageDelta delta, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Delta = delta;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaChunk"/> for deserialization. </summary>
        internal MessageDeltaChunk()
        {
        }

        /// <summary> The identifier of the message, which can be referenced in API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always `thread.message.delta`. </summary>
        public MessageDeltaChunkObject Object { get; } = MessageDeltaChunkObject.ThreadMessageDelta;

        /// <summary> The delta containing the fields that have changed on the Message. </summary>
        public MessageDelta Delta { get; }
    }
}
