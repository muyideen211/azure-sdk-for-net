// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Playwright.Models
{
    /// <summary> The check availability result. </summary>
    public partial class PlaywrightNameAvailabilityResult
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

        /// <summary> Initializes a new instance of <see cref="PlaywrightNameAvailabilityResult"/>. </summary>
        internal PlaywrightNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlaywrightNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlaywrightNameAvailabilityResult(bool? isNameAvailable, PlaywrightNameUnavailableReason? reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates if the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason why the given name is not available. </summary>
        public PlaywrightNameUnavailableReason? Reason { get; }
        /// <summary> Detailed reason why the given name is not available. </summary>
        public string Message { get; }
    }
}
