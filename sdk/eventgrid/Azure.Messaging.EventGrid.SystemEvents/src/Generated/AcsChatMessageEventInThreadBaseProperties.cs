// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all thread-level chat message events. </summary>
    public partial class AcsChatMessageEventInThreadBaseProperties : AcsChatEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatMessageEventInThreadBaseProperties"/>. </summary>
        /// <param name="senderCommunicationIdentifier"> The communication identifier of the sender. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderCommunicationIdentifier"/> is null. </exception>
        internal AcsChatMessageEventInThreadBaseProperties(CommunicationIdentifierModel senderCommunicationIdentifier)
        {
            Argument.AssertNotNull(senderCommunicationIdentifier, nameof(senderCommunicationIdentifier));

            SenderCommunicationIdentifier = senderCommunicationIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatMessageEventInThreadBaseProperties"/>. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="messageId"> The chat message id. </param>
        /// <param name="senderCommunicationIdentifier"> The communication identifier of the sender. </param>
        /// <param name="senderDisplayName"> The display name of the sender. </param>
        /// <param name="composeTime"> The original compose time of the message. </param>
        /// <param name="type"> The type of the message. </param>
        /// <param name="version"> The version of the message. </param>
        internal AcsChatMessageEventInThreadBaseProperties(string transactionId, string threadId, IDictionary<string, BinaryData> serializedAdditionalRawData, string messageId, CommunicationIdentifierModel senderCommunicationIdentifier, string senderDisplayName, DateTimeOffset? composeTime, string type, long? version) : base(transactionId, threadId, serializedAdditionalRawData)
        {
            MessageId = messageId;
            SenderCommunicationIdentifier = senderCommunicationIdentifier;
            SenderDisplayName = senderDisplayName;
            ComposeTime = composeTime;
            Type = type;
            Version = version;
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatMessageEventInThreadBaseProperties"/> for deserialization. </summary>
        internal AcsChatMessageEventInThreadBaseProperties()
        {
        }

        /// <summary> The chat message id. </summary>
        public string MessageId { get; }
        /// <summary> The communication identifier of the sender. </summary>
        public CommunicationIdentifierModel SenderCommunicationIdentifier { get; }
        /// <summary> The display name of the sender. </summary>
        public string SenderDisplayName { get; }
        /// <summary> The original compose time of the message. </summary>
        public DateTimeOffset? ComposeTime { get; }
        /// <summary> The type of the message. </summary>
        public string Type { get; }
        /// <summary> The version of the message. </summary>
        public long? Version { get; }
    }
}
