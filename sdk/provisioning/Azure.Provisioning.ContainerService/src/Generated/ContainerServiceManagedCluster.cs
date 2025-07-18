// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// ContainerServiceManagedCluster.
/// </summary>
public partial class ContainerServiceManagedCluster : ProvisionableResource
{
    /// <summary>
    /// The name of the managed cluster resource.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The Azure Active Directory configuration.
    /// </summary>
    public ManagedClusterAadProfile AadProfile 
    {
        get { Initialize(); return _aadProfile!; }
        set { Initialize(); AssignOrReplace(ref _aadProfile, value); }
    }
    private ManagedClusterAadProfile? _aadProfile;

    /// <summary>
    /// The profile of managed cluster add-on.
    /// </summary>
    public BicepDictionary<ManagedClusterAddonProfile> AddonProfiles 
    {
        get { Initialize(); return _addonProfiles!; }
        set { Initialize(); _addonProfiles!.Assign(value); }
    }
    private BicepDictionary<ManagedClusterAddonProfile>? _addonProfiles;

    /// <summary>
    /// The agent pool properties.
    /// </summary>
    public BicepList<ManagedClusterAgentPoolProfile> AgentPoolProfiles 
    {
        get { Initialize(); return _agentPoolProfiles!; }
        set { Initialize(); _agentPoolProfiles!.Assign(value); }
    }
    private BicepList<ManagedClusterAgentPoolProfile>? _agentPoolProfiles;

    /// <summary>
    /// The access profile for managed cluster API server.
    /// </summary>
    public ManagedClusterApiServerAccessProfile ApiServerAccessProfile 
    {
        get { Initialize(); return _apiServerAccessProfile!; }
        set { Initialize(); AssignOrReplace(ref _apiServerAccessProfile, value); }
    }
    private ManagedClusterApiServerAccessProfile? _apiServerAccessProfile;

    /// <summary>
    /// Parameters to be applied to the cluster-autoscaler when enabled.
    /// </summary>
    public ManagedClusterAutoScalerProfile AutoScalerProfile 
    {
        get { Initialize(); return _autoScalerProfile!; }
        set { Initialize(); AssignOrReplace(ref _autoScalerProfile, value); }
    }
    private ManagedClusterAutoScalerProfile? _autoScalerProfile;

    /// <summary>
    /// The auto upgrade configuration.
    /// </summary>
    public ManagedClusterAutoUpgradeProfile AutoUpgradeProfile 
    {
        get { Initialize(); return _autoUpgradeProfile!; }
        set { Initialize(); AssignOrReplace(ref _autoUpgradeProfile, value); }
    }
    private ManagedClusterAutoUpgradeProfile? _autoUpgradeProfile;

    /// <summary>
    /// Metrics profile for the Azure Monitor managed service for Prometheus
    /// addon. Collect out-of-the-box Kubernetes infrastructure metrics to
    /// send to an Azure Monitor Workspace and configure additional scraping
    /// for custom targets. See aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    public ManagedClusterMonitorProfileMetrics AzureMonitorMetrics 
    {
        get { Initialize(); return _azureMonitorMetrics!; }
        set { Initialize(); AssignOrReplace(ref _azureMonitorMetrics, value); }
    }
    private ManagedClusterMonitorProfileMetrics? _azureMonitorMetrics;

    /// <summary>
    /// The identity of the managed cluster, if configured.
    /// </summary>
    public ManagedClusterIdentity ClusterIdentity 
    {
        get { Initialize(); return _clusterIdentity!; }
        set { Initialize(); AssignOrReplace(ref _clusterIdentity, value); }
    }
    private ManagedClusterIdentity? _clusterIdentity;

    /// <summary>
    /// If set to true, getting static credentials will be disabled for this
    /// cluster. This must only be used on Managed Clusters that are AAD
    /// enabled. For more details see [disable local
    /// accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    public BicepValue<bool> DisableLocalAccounts 
    {
        get { Initialize(); return _disableLocalAccounts!; }
        set { Initialize(); _disableLocalAccounts!.Assign(value); }
    }
    private BicepValue<bool>? _disableLocalAccounts;

    /// <summary>
    /// This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;.
    /// </summary>
    public BicepValue<ResourceIdentifier> DiskEncryptionSetId 
    {
        get { Initialize(); return _diskEncryptionSetId!; }
        set { Initialize(); _diskEncryptionSetId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _diskEncryptionSetId;

    /// <summary>
    /// This cannot be updated once the Managed Cluster has been created.
    /// </summary>
    public BicepValue<string> DnsPrefix 
    {
        get { Initialize(); return _dnsPrefix!; }
        set { Initialize(); _dnsPrefix!.Assign(value); }
    }
    private BicepValue<string>? _dnsPrefix;

    /// <summary>
    /// (DEPRECATED) Whether to enable Kubernetes pod security policy
    /// (preview). PodSecurityPolicy was deprecated in Kubernetes v1.21, and
    /// removed from Kubernetes in v1.25. Learn more at https://aka.ms/k8s/psp
    /// and https://aka.ms/aks/psp.
    /// </summary>
    public BicepValue<bool> EnablePodSecurityPolicy 
    {
        get { Initialize(); return _enablePodSecurityPolicy!; }
        set { Initialize(); _enablePodSecurityPolicy!.Assign(value); }
    }
    private BicepValue<bool>? _enablePodSecurityPolicy;

    /// <summary>
    /// Whether to enable Kubernetes Role-Based Access Control.
    /// </summary>
    public BicepValue<bool> EnableRbac 
    {
        get { Initialize(); return _enableRbac!; }
        set { Initialize(); _enableRbac!.Assign(value); }
    }
    private BicepValue<bool>? _enableRbac;

    /// <summary>
    /// The extended location of the Virtual Machine.
    /// </summary>
    public ExtendedAzureLocation ExtendedLocation 
    {
        get { Initialize(); return _extendedLocation!; }
        set { Initialize(); AssignOrReplace(ref _extendedLocation, value); }
    }
    private ExtendedAzureLocation? _extendedLocation;

    /// <summary>
    /// This cannot be updated once the Managed Cluster has been created.
    /// </summary>
    public BicepValue<string> FqdnSubdomain 
    {
        get { Initialize(); return _fqdnSubdomain!; }
        set { Initialize(); _fqdnSubdomain!.Assign(value); }
    }
    private BicepValue<string>? _fqdnSubdomain;

    /// <summary>
    /// Configurations for provisioning the cluster with HTTP proxy servers.
    /// </summary>
    public ManagedClusterHttpProxyConfig HttpProxyConfig 
    {
        get { Initialize(); return _httpProxyConfig!; }
        set { Initialize(); AssignOrReplace(ref _httpProxyConfig, value); }
    }
    private ManagedClusterHttpProxyConfig? _httpProxyConfig;

    /// <summary>
    /// Identities associated with the cluster.
    /// </summary>
    public BicepDictionary<ContainerServiceUserAssignedIdentity> IdentityProfile 
    {
        get { Initialize(); return _identityProfile!; }
        set { Initialize(); _identityProfile!.Assign(value); }
    }
    private BicepDictionary<ContainerServiceUserAssignedIdentity>? _identityProfile;

    /// <summary>
    /// Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and
    /// &lt;major.minor&gt; (e.g. 1.20) are supported. When
    /// &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same
    /// &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14)
    /// will not trigger an upgrade, even if a newer patch version is
    /// available. When you upgrade a supported AKS cluster, Kubernetes minor
    /// versions cannot be skipped. All upgrades must be performed
    /// sequentially by major version number. For example, upgrades between
    /// 1.14.x -&gt; 1.15.x or 1.15.x -&gt; 1.16.x are allowed, however 1.14.x
    /// -&gt; 1.16.x is not allowed. See [upgrading an AKS
    /// cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for
    /// more details.
    /// </summary>
    public BicepValue<string> KubernetesVersion 
    {
        get { Initialize(); return _kubernetesVersion!; }
        set { Initialize(); _kubernetesVersion!.Assign(value); }
    }
    private BicepValue<string>? _kubernetesVersion;

    /// <summary>
    /// The profile for Linux VMs in the Managed Cluster.
    /// </summary>
    public ContainerServiceLinuxProfile LinuxProfile 
    {
        get { Initialize(); return _linuxProfile!; }
        set { Initialize(); AssignOrReplace(ref _linuxProfile, value); }
    }
    private ContainerServiceLinuxProfile? _linuxProfile;

    /// <summary>
    /// The network configuration profile.
    /// </summary>
    public ContainerServiceNetworkProfile NetworkProfile 
    {
        get { Initialize(); return _networkProfile!; }
        set { Initialize(); AssignOrReplace(ref _networkProfile, value); }
    }
    private ContainerServiceNetworkProfile? _networkProfile;

    /// <summary>
    /// The name of the resource group containing agent pool nodes.
    /// </summary>
    public BicepValue<string> NodeResourceGroup 
    {
        get { Initialize(); return _nodeResourceGroup!; }
        set { Initialize(); _nodeResourceGroup!.Assign(value); }
    }
    private BicepValue<string>? _nodeResourceGroup;

    /// <summary>
    /// The OIDC issuer profile of the Managed Cluster.
    /// </summary>
    public ManagedClusterOidcIssuerProfile OidcIssuerProfile 
    {
        get { Initialize(); return _oidcIssuerProfile!; }
        set { Initialize(); AssignOrReplace(ref _oidcIssuerProfile, value); }
    }
    private ManagedClusterOidcIssuerProfile? _oidcIssuerProfile;

    /// <summary>
    /// See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity)
    /// for more details on AAD pod identity integration.
    /// </summary>
    public ManagedClusterPodIdentityProfile PodIdentityProfile 
    {
        get { Initialize(); return _podIdentityProfile!; }
        set { Initialize(); AssignOrReplace(ref _podIdentityProfile, value); }
    }
    private ManagedClusterPodIdentityProfile? _podIdentityProfile;

    /// <summary>
    /// Private link resources associated with the cluster.
    /// </summary>
    public BicepList<ContainerServicePrivateLinkResourceData> PrivateLinkResources 
    {
        get { Initialize(); return _privateLinkResources!; }
        set { Initialize(); _privateLinkResources!.Assign(value); }
    }
    private BicepList<ContainerServicePrivateLinkResourceData>? _privateLinkResources;

    /// <summary>
    /// Allow or deny public network access for AKS.
    /// </summary>
    public BicepValue<ContainerServicePublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<ContainerServicePublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// Security profile for the managed cluster.
    /// </summary>
    public ManagedClusterSecurityProfile SecurityProfile 
    {
        get { Initialize(); return _securityProfile!; }
        set { Initialize(); AssignOrReplace(ref _securityProfile, value); }
    }
    private ManagedClusterSecurityProfile? _securityProfile;

    /// <summary>
    /// Service mesh profile for a managed cluster.
    /// </summary>
    public ServiceMeshProfile ServiceMeshProfile 
    {
        get { Initialize(); return _serviceMeshProfile!; }
        set { Initialize(); AssignOrReplace(ref _serviceMeshProfile, value); }
    }
    private ServiceMeshProfile? _serviceMeshProfile;

    /// <summary>
    /// Information about a service principal identity for the cluster to use
    /// for manipulating Azure APIs.
    /// </summary>
    public ManagedClusterServicePrincipalProfile ServicePrincipalProfile 
    {
        get { Initialize(); return _servicePrincipalProfile!; }
        set { Initialize(); AssignOrReplace(ref _servicePrincipalProfile, value); }
    }
    private ManagedClusterServicePrincipalProfile? _servicePrincipalProfile;

    /// <summary>
    /// The managed cluster SKU.
    /// </summary>
    public ManagedClusterSku Sku 
    {
        get { Initialize(); return _sku!; }
        set { Initialize(); AssignOrReplace(ref _sku, value); }
    }
    private ManagedClusterSku? _sku;

    /// <summary>
    /// Storage profile for the managed cluster.
    /// </summary>
    public ManagedClusterStorageProfile StorageProfile 
    {
        get { Initialize(); return _storageProfile!; }
        set { Initialize(); AssignOrReplace(ref _storageProfile, value); }
    }
    private ManagedClusterStorageProfile? _storageProfile;

    /// <summary>
    /// The support plan for the Managed Cluster. If unspecified, the default
    /// is &apos;KubernetesOfficial&apos;.
    /// </summary>
    public BicepValue<KubernetesSupportPlan> SupportPlan 
    {
        get { Initialize(); return _supportPlan!; }
        set { Initialize(); _supportPlan!.Assign(value); }
    }
    private BicepValue<KubernetesSupportPlan>? _supportPlan;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Settings for overrides.
    /// </summary>
    public UpgradeOverrideSettings UpgradeOverrideSettings 
    {
        get { Initialize(); return _upgradeOverrideSettings!; }
        set { Initialize(); AssignOrReplace(ref _upgradeOverrideSettings, value); }
    }
    private UpgradeOverrideSettings? _upgradeOverrideSettings;

    /// <summary>
    /// The profile for Windows VMs in the Managed Cluster.
    /// </summary>
    public ManagedClusterWindowsProfile WindowsProfile 
    {
        get { Initialize(); return _windowsProfile!; }
        set { Initialize(); AssignOrReplace(ref _windowsProfile, value); }
    }
    private ManagedClusterWindowsProfile? _windowsProfile;

    /// <summary>
    /// Workload Auto-scaler profile for the managed cluster.
    /// </summary>
    public ManagedClusterWorkloadAutoScalerProfile WorkloadAutoScalerProfile 
    {
        get { Initialize(); return _workloadAutoScalerProfile!; }
        set { Initialize(); AssignOrReplace(ref _workloadAutoScalerProfile, value); }
    }
    private ManagedClusterWorkloadAutoScalerProfile? _workloadAutoScalerProfile;

    /// <summary>
    /// The Azure Portal requires certain Cross-Origin Resource Sharing (CORS)
    /// headers to be sent in some responses, which Kubernetes APIServer
    /// doesn&apos;t handle by default. This special FQDN supports CORS,
    /// allowing the Azure Portal to function properly.
    /// </summary>
    public BicepValue<string> AzurePortalFqdn 
    {
        get { Initialize(); return _azurePortalFqdn!; }
    }
    private BicepValue<string>? _azurePortalFqdn;

    /// <summary>
    /// If kubernetesVersion was a fully specified version
    /// &lt;major.minor.patch&gt;, this field will be exactly equal to it. If
    /// kubernetesVersion was &lt;major.minor&gt;, this field will contain the
    /// full &lt;major.minor.patch&gt; version being used.
    /// </summary>
    public BicepValue<string> CurrentKubernetesVersion 
    {
        get { Initialize(); return _currentKubernetesVersion!; }
    }
    private BicepValue<string>? _currentKubernetesVersion;

    /// <summary>
    /// The FQDN of the master pool.
    /// </summary>
    public BicepValue<string> Fqdn 
    {
        get { Initialize(); return _fqdn!; }
    }
    private BicepValue<string>? _fqdn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The max number of agent pools for the managed cluster.
    /// </summary>
    public BicepValue<int> MaxAgentPools 
    {
        get { Initialize(); return _maxAgentPools!; }
    }
    private BicepValue<int>? _maxAgentPools;

    /// <summary>
    /// Tells whether the cluster is Running or Stopped.
    /// </summary>
    public BicepValue<ContainerServiceStateCode> PowerStateCode 
    {
        get { Initialize(); return _powerStateCode!; }
    }
    private BicepValue<ContainerServiceStateCode>? _powerStateCode;

    /// <summary>
    /// The FQDN of private cluster.
    /// </summary>
    public BicepValue<string> PrivateFqdn 
    {
        get { Initialize(); return _privateFqdn!; }
    }
    private BicepValue<string>? _privateFqdn;

    /// <summary>
    /// The current provisioning state.
    /// </summary>
    public BicepValue<string> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<string>? _provisioningState;

    /// <summary>
    /// The resourceUID uniquely identifies ManagedClusters that reuse ARM
    /// ResourceIds (i.e: create, delete, create sequence).
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId 
    {
        get { Initialize(); return _resourceId!; }
    }
    private BicepValue<ResourceIdentifier>? _resourceId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerServiceManagedCluster
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerServiceManagedCluster.</param>
    public ContainerServiceManagedCluster(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerService/managedClusters", resourceVersion ?? "2025-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerServiceManagedCluster.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _aadProfile = DefineModelProperty<ManagedClusterAadProfile>("AadProfile", ["properties", "aadProfile"]);
        _addonProfiles = DefineDictionaryProperty<ManagedClusterAddonProfile>("AddonProfiles", ["properties", "addonProfiles"]);
        _agentPoolProfiles = DefineListProperty<ManagedClusterAgentPoolProfile>("AgentPoolProfiles", ["properties", "agentPoolProfiles"]);
        _apiServerAccessProfile = DefineModelProperty<ManagedClusterApiServerAccessProfile>("ApiServerAccessProfile", ["properties", "apiServerAccessProfile"]);
        _autoScalerProfile = DefineModelProperty<ManagedClusterAutoScalerProfile>("AutoScalerProfile", ["properties", "autoScalerProfile"]);
        _autoUpgradeProfile = DefineModelProperty<ManagedClusterAutoUpgradeProfile>("AutoUpgradeProfile", ["properties", "autoUpgradeProfile"]);
        _azureMonitorMetrics = DefineModelProperty<ManagedClusterMonitorProfileMetrics>("AzureMonitorMetrics", ["properties", "azureMonitorProfile", "metrics"]);
        _clusterIdentity = DefineModelProperty<ManagedClusterIdentity>("ClusterIdentity", ["identity"]);
        _disableLocalAccounts = DefineProperty<bool>("DisableLocalAccounts", ["properties", "disableLocalAccounts"]);
        _diskEncryptionSetId = DefineProperty<ResourceIdentifier>("DiskEncryptionSetId", ["properties", "diskEncryptionSetID"]);
        _dnsPrefix = DefineProperty<string>("DnsPrefix", ["properties", "dnsPrefix"]);
        _enablePodSecurityPolicy = DefineProperty<bool>("EnablePodSecurityPolicy", ["properties", "enablePodSecurityPolicy"]);
        _enableRbac = DefineProperty<bool>("EnableRbac", ["properties", "enableRBAC"]);
        _extendedLocation = DefineModelProperty<ExtendedAzureLocation>("ExtendedLocation", ["extendedLocation"]);
        _fqdnSubdomain = DefineProperty<string>("FqdnSubdomain", ["properties", "fqdnSubdomain"]);
        _httpProxyConfig = DefineModelProperty<ManagedClusterHttpProxyConfig>("HttpProxyConfig", ["properties", "httpProxyConfig"]);
        _identityProfile = DefineDictionaryProperty<ContainerServiceUserAssignedIdentity>("IdentityProfile", ["properties", "identityProfile"]);
        _kubernetesVersion = DefineProperty<string>("KubernetesVersion", ["properties", "kubernetesVersion"]);
        _linuxProfile = DefineModelProperty<ContainerServiceLinuxProfile>("LinuxProfile", ["properties", "linuxProfile"]);
        _networkProfile = DefineModelProperty<ContainerServiceNetworkProfile>("NetworkProfile", ["properties", "networkProfile"]);
        _nodeResourceGroup = DefineProperty<string>("NodeResourceGroup", ["properties", "nodeResourceGroup"]);
        _oidcIssuerProfile = DefineModelProperty<ManagedClusterOidcIssuerProfile>("OidcIssuerProfile", ["properties", "oidcIssuerProfile"]);
        _podIdentityProfile = DefineModelProperty<ManagedClusterPodIdentityProfile>("PodIdentityProfile", ["properties", "podIdentityProfile"]);
        _privateLinkResources = DefineListProperty<ContainerServicePrivateLinkResourceData>("PrivateLinkResources", ["properties", "privateLinkResources"]);
        _publicNetworkAccess = DefineProperty<ContainerServicePublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _securityProfile = DefineModelProperty<ManagedClusterSecurityProfile>("SecurityProfile", ["properties", "securityProfile"]);
        _serviceMeshProfile = DefineModelProperty<ServiceMeshProfile>("ServiceMeshProfile", ["properties", "serviceMeshProfile"]);
        _servicePrincipalProfile = DefineModelProperty<ManagedClusterServicePrincipalProfile>("ServicePrincipalProfile", ["properties", "servicePrincipalProfile"]);
        _sku = DefineModelProperty<ManagedClusterSku>("Sku", ["sku"]);
        _storageProfile = DefineModelProperty<ManagedClusterStorageProfile>("StorageProfile", ["properties", "storageProfile"]);
        _supportPlan = DefineProperty<KubernetesSupportPlan>("SupportPlan", ["properties", "supportPlan"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _upgradeOverrideSettings = DefineModelProperty<UpgradeOverrideSettings>("UpgradeOverrideSettings", ["properties", "upgradeSettings", "overrideSettings"]);
        _windowsProfile = DefineModelProperty<ManagedClusterWindowsProfile>("WindowsProfile", ["properties", "windowsProfile"]);
        _workloadAutoScalerProfile = DefineModelProperty<ManagedClusterWorkloadAutoScalerProfile>("WorkloadAutoScalerProfile", ["properties", "workloadAutoScalerProfile"]);
        _azurePortalFqdn = DefineProperty<string>("AzurePortalFqdn", ["properties", "azurePortalFQDN"], isOutput: true);
        _currentKubernetesVersion = DefineProperty<string>("CurrentKubernetesVersion", ["properties", "currentKubernetesVersion"], isOutput: true);
        _fqdn = DefineProperty<string>("Fqdn", ["properties", "fqdn"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _maxAgentPools = DefineProperty<int>("MaxAgentPools", ["properties", "maxAgentPools"], isOutput: true);
        _powerStateCode = DefineProperty<ContainerServiceStateCode>("PowerStateCode", ["properties", "powerState", "code"], isOutput: true);
        _privateFqdn = DefineProperty<string>("PrivateFqdn", ["properties", "privateFQDN"], isOutput: true);
        _provisioningState = DefineProperty<string>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _resourceId = DefineProperty<ResourceIdentifier>("ResourceId", ["properties", "resourceUID"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerServiceManagedCluster resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-04-01.
        /// </summary>
        public static readonly string V2025_04_01 = "2025-04-01";

        /// <summary>
        /// 2025-03-01.
        /// </summary>
        public static readonly string V2025_03_01 = "2025-03-01";

        /// <summary>
        /// 2025-02-01.
        /// </summary>
        public static readonly string V2025_02_01 = "2025-02-01";

        /// <summary>
        /// 2025-01-01.
        /// </summary>
        public static readonly string V2025_01_01 = "2025-01-01";

        /// <summary>
        /// 2024-10-01.
        /// </summary>
        public static readonly string V2024_10_01 = "2024-10-01";

        /// <summary>
        /// 2024-09-01.
        /// </summary>
        public static readonly string V2024_09_01 = "2024-09-01";

        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2024-07-01.
        /// </summary>
        public static readonly string V2024_07_01 = "2024-07-01";

        /// <summary>
        /// 2024-06-01.
        /// </summary>
        public static readonly string V2024_06_01 = "2024-06-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2024-02-01.
        /// </summary>
        public static readonly string V2024_02_01 = "2024-02-01";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2023-10-01.
        /// </summary>
        public static readonly string V2023_10_01 = "2023-10-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-06-01.
        /// </summary>
        public static readonly string V2023_06_01 = "2023-06-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-08-01.
        /// </summary>
        public static readonly string V2022_08_01 = "2022-08-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-04-01.
        /// </summary>
        public static readonly string V2022_04_01 = "2022-04-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2022-01-01.
        /// </summary>
        public static readonly string V2022_01_01 = "2022-01-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-07-01.
        /// </summary>
        public static readonly string V2021_07_01 = "2021-07-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-11-01.
        /// </summary>
        public static readonly string V2020_11_01 = "2020-11-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-07-01.
        /// </summary>
        public static readonly string V2020_07_01 = "2020-07-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2020-02-01.
        /// </summary>
        public static readonly string V2020_02_01 = "2020-02-01";

        /// <summary>
        /// 2020-01-01.
        /// </summary>
        public static readonly string V2020_01_01 = "2020-01-01";

        /// <summary>
        /// 2019-11-01.
        /// </summary>
        public static readonly string V2019_11_01 = "2019-11-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-02-01.
        /// </summary>
        public static readonly string V2019_02_01 = "2019-02-01";

        /// <summary>
        /// 2018-03-31.
        /// </summary>
        public static readonly string V2018_03_31 = "2018-03-31";

        /// <summary>
        /// 2017-08-31.
        /// </summary>
        public static readonly string V2017_08_31 = "2017-08-31";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerServiceManagedCluster
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerServiceManagedCluster.</param>
    /// <returns>The existing ContainerServiceManagedCluster resource.</returns>
    public static ContainerServiceManagedCluster FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerServiceManagedCluster
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerServiceBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{ContainerServiceBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerServiceBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{ContainerServiceBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
