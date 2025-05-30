// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppConnectedEnvironmentStorage.
/// </summary>
public partial class ContainerAppConnectedEnvironmentStorage : ProvisionableResource
{
    /// <summary>
    /// Name of the storage.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Azure file properties.
    /// </summary>
    public ContainerAppAzureFileProperties ConnectedEnvironmentStorageAzureFile 
    {
        get { Initialize(); return _connectedEnvironmentStorageAzureFile!; }
        set { Initialize(); AssignOrReplace(ref _connectedEnvironmentStorageAzureFile, value); }
    }
    private ContainerAppAzureFileProperties? _connectedEnvironmentStorageAzureFile;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerAppConnectedEnvironment.
    /// </summary>
    public ContainerAppConnectedEnvironment? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ContainerAppConnectedEnvironment>? _parent;

    /// <summary>
    /// Creates a new ContainerAppConnectedEnvironmentStorage.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ContainerAppConnectedEnvironmentStorage resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppConnectedEnvironmentStorage.</param>
    public ContainerAppConnectedEnvironmentStorage(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.App/connectedEnvironments/storages", resourceVersion ?? "2024-03-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppConnectedEnvironmentStorage.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _connectedEnvironmentStorageAzureFile = DefineModelProperty<ContainerAppAzureFileProperties>("ConnectedEnvironmentStorageAzureFile", ["properties", "azureFile"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ContainerAppConnectedEnvironment>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppConnectedEnvironmentStorage resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerAppConnectedEnvironmentStorage.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ContainerAppConnectedEnvironmentStorage resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppConnectedEnvironmentStorage.</param>
    /// <returns>The existing ContainerAppConnectedEnvironmentStorage resource.</returns>
    public static ContainerAppConnectedEnvironmentStorage FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
