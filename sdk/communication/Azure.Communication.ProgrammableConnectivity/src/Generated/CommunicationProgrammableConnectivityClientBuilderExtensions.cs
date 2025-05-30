// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Diagnostics.CodeAnalysis;
using Azure.Communication.ProgrammableConnectivity;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ProgrammableConnectivityClient"/> to client builder. </summary>
    public static partial class CommunicationProgrammableConnectivityClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ProgrammableConnectivityClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> An Azure Programmable Connectivity Endpoint providing access to Network APIs, for example https://{region}.apcgatewayapi.azure.com. </param>
        public static IAzureClientBuilder<ProgrammableConnectivityClient, ProgrammableConnectivityClientOptions> AddProgrammableConnectivityClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ProgrammableConnectivityClient, ProgrammableConnectivityClientOptions>((options, cred) => new ProgrammableConnectivityClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="ProgrammableConnectivityClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        [RequiresUnreferencedCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        [RequiresDynamicCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static IAzureClientBuilder<ProgrammableConnectivityClient, ProgrammableConnectivityClientOptions> AddProgrammableConnectivityClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ProgrammableConnectivityClient, ProgrammableConnectivityClientOptions>(configuration);
        }
    }
}
