// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    /// <summary> Marketplace details. </summary>
    public partial class PureStorageMarketplaceDetails
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

        /// <summary> Initializes a new instance of <see cref="PureStorageMarketplaceDetails"/>. </summary>
        /// <param name="offerDetails"> Offer details of the marketplace subscription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerDetails"/> is null. </exception>
        public PureStorageMarketplaceDetails(PureStorageOfferDetails offerDetails)
        {
            Argument.AssertNotNull(offerDetails, nameof(offerDetails));

            OfferDetails = offerDetails;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageMarketplaceDetails"/>. </summary>
        /// <param name="subscriptionId"> Marketplace subscription ID. </param>
        /// <param name="subscriptionStatus"> Marketplace subscription status. </param>
        /// <param name="offerDetails"> Offer details of the marketplace subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PureStorageMarketplaceDetails(string subscriptionId, PureStorageMarketplaceSubscriptionStatus? subscriptionStatus, PureStorageOfferDetails offerDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubscriptionId = subscriptionId;
            SubscriptionStatus = subscriptionStatus;
            OfferDetails = offerDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageMarketplaceDetails"/> for deserialization. </summary>
        internal PureStorageMarketplaceDetails()
        {
        }

        /// <summary> Marketplace subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> Marketplace subscription status. </summary>
        public PureStorageMarketplaceSubscriptionStatus? SubscriptionStatus { get; set; }
        /// <summary> Offer details of the marketplace subscription. </summary>
        public PureStorageOfferDetails OfferDetails { get; set; }
    }
}
