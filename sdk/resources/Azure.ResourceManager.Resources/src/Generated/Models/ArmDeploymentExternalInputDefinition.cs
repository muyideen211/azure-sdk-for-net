// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment external input definition for parameterization. </summary>
    public partial class ArmDeploymentExternalInputDefinition
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

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentExternalInputDefinition"/>. </summary>
        /// <param name="kind"> The kind of external input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> is null. </exception>
        public ArmDeploymentExternalInputDefinition(string kind)
        {
            Argument.AssertNotNull(kind, nameof(kind));

            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentExternalInputDefinition"/>. </summary>
        /// <param name="kind"> The kind of external input. </param>
        /// <param name="config"> Configuration for the external input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentExternalInputDefinition(string kind, BinaryData config, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Config = config;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentExternalInputDefinition"/> for deserialization. </summary>
        internal ArmDeploymentExternalInputDefinition()
        {
        }

        /// <summary> The kind of external input. </summary>
        [WirePath("kind")]
        public string Kind { get; }
        /// <summary>
        /// Configuration for the external input.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("config")]
        public BinaryData Config { get; set; }
    }
}
