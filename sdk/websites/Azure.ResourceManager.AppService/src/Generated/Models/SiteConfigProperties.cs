// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Configuration of an App Service app. </summary>
    public partial class SiteConfigProperties
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

        /// <summary> Initializes a new instance of <see cref="SiteConfigProperties"/>. </summary>
        public SiteConfigProperties()
        {
            DefaultDocuments = new ChangeTrackingList<string>();
            AppSettings = new ChangeTrackingList<AppServiceNameValuePair>();
            Metadata = new ChangeTrackingList<AppServiceNameValuePair>();
            ConnectionStrings = new ChangeTrackingList<ConnStringInfo>();
            HandlerMappings = new ChangeTrackingList<HttpRequestHandlerMapping>();
            VirtualApplications = new ChangeTrackingList<VirtualApplication>();
            IPSecurityRestrictions = new ChangeTrackingList<AppServiceIPSecurityRestriction>();
            ScmIPSecurityRestrictions = new ChangeTrackingList<AppServiceIPSecurityRestriction>();
            AzureStorageAccounts = new ChangeTrackingDictionary<string, AppServiceStorageAccessInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteConfigProperties"/>. </summary>
        /// <param name="numberOfWorkers"> Number of workers. </param>
        /// <param name="defaultDocuments"> Default documents. </param>
        /// <param name="netFrameworkVersion"> .NET Framework version. </param>
        /// <param name="phpVersion"> Version of PHP. </param>
        /// <param name="pythonVersion"> Version of Python. </param>
        /// <param name="nodeVersion"> Version of Node.js. </param>
        /// <param name="powerShellVersion"> Version of PowerShell. </param>
        /// <param name="linuxFxVersion"> Linux App Framework and version. </param>
        /// <param name="windowsFxVersion"> Xenon App Framework and version. </param>
        /// <param name="isRequestTracingEnabled"> &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="requestTracingExpirationOn"> Request tracing expiration time. </param>
        /// <param name="isRemoteDebuggingEnabled"> &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="remoteDebuggingVersion"> Remote debugging version. </param>
        /// <param name="isHttpLoggingEnabled"> &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="useManagedIdentityCreds"> Flag to use Managed Identity Creds for ACR pull. </param>
        /// <param name="acrUserManagedIdentityId"> If using user managed identity, the user managed identity ClientId. </param>
        /// <param name="logsDirectorySizeLimit"> HTTP logs directory size limit. </param>
        /// <param name="isDetailedErrorLoggingEnabled"> &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="publishingUsername"> Publishing user name. </param>
        /// <param name="appSettings"> Application settings. This property is not returned in response to normal create and read requests since it may contain sensitive information. </param>
        /// <param name="metadata"> Application metadata. This property cannot be retrieved, since it may contain secrets. </param>
        /// <param name="connectionStrings"> Connection strings. This property is not returned in response to normal create and read requests since it may contain sensitive information. </param>
        /// <param name="machineKey"> Site MachineKey. </param>
        /// <param name="handlerMappings"> Handler mappings. </param>
        /// <param name="documentRoot"> Document root. </param>
        /// <param name="scmType"> SCM type. </param>
        /// <param name="use32BitWorkerProcess"> &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isWebSocketsEnabled"> &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isAlwaysOn"> &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="javaVersion"> Java version. </param>
        /// <param name="javaContainer"> Java container. </param>
        /// <param name="javaContainerVersion"> Java container version. </param>
        /// <param name="appCommandLine"> App command line to launch. </param>
        /// <param name="managedPipelineMode"> Managed pipeline mode. </param>
        /// <param name="virtualApplications"> Virtual applications. </param>
        /// <param name="loadBalancing"> Site load balancing. </param>
        /// <param name="experiments"> This is work around for polymorphic types. </param>
        /// <param name="limits"> Site limits. </param>
        /// <param name="isAutoHealEnabled"> &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="autoHealRules"> Auto Heal rules. </param>
        /// <param name="tracingOptions"> Tracing options. </param>
        /// <param name="vnetName"> Virtual Network name. </param>
        /// <param name="isVnetRouteAllEnabled"> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </param>
        /// <param name="vnetPrivatePortsCount"> The number of private ports assigned to this app. These will be assigned dynamically on runtime. </param>
        /// <param name="cors"> Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="push"> Push endpoint settings. </param>
        /// <param name="apiDefinition"> Information about the formal API definition for the app. </param>
        /// <param name="apiManagementConfig"> Azure API management settings linked to the app. </param>
        /// <param name="autoSwapSlotName"> Auto-swap slot name. </param>
        /// <param name="isLocalMySqlEnabled"> &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="managedServiceIdentityId"> Managed Service Identity Id. </param>
        /// <param name="xManagedServiceIdentityId"> Explicit Managed Service Identity Id. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="ipSecurityRestrictions"> IP security restrictions for main. </param>
        /// <param name="ipSecurityRestrictionsDefaultAction"> Default action for main access restriction if no rules are matched. </param>
        /// <param name="scmIPSecurityRestrictions"> IP security restrictions for scm. </param>
        /// <param name="scmIPSecurityRestrictionsDefaultAction"> Default action for scm access restriction if no rules are matched. </param>
        /// <param name="allowIPSecurityRestrictionsForScmToUseMain"> IP security restrictions for scm to use main. </param>
        /// <param name="isHttp20Enabled"> Http20Enabled: configures a web site to allow clients to connect over http2.0. </param>
        /// <param name="http20ProxyFlag"> Http20ProxyFlag: Configures a website to allow http2.0 to pass be proxied all the way to the app. 0 = disabled, 1 = pass through all http2 traffic, 2 = pass through gRPC only. </param>
        /// <param name="minTlsVersion"> MinTlsVersion: configures the minimum version of TLS required for SSL requests. </param>
        /// <param name="minTlsCipherSuite"> The minimum strength TLS cipher suite allowed for an application. </param>
        /// <param name="scmMinTlsVersion"> ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site. </param>
        /// <param name="ftpsState"> State of FTP / FTPS service. </param>
        /// <param name="preWarmedInstanceCount">
        /// Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </param>
        /// <param name="functionAppScaleLimit">
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to the Consumption and Elastic Premium Plans
        /// </param>
        /// <param name="elasticWebAppScaleLimit">
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to apps in plans where ElasticScaleEnabled is &lt;code&gt;true&lt;/code&gt;
        /// </param>
        /// <param name="healthCheckPath"> Health check path. </param>
        /// <param name="isFunctionsRuntimeScaleMonitoringEnabled">
        /// Gets or sets a value indicating whether functions runtime scale monitoring is enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but will instead call to the
        /// runtime to get scale status.
        /// </param>
        /// <param name="websiteTimeZone"> Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database values https://www.iana.org/time-zones (for a quick reference see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones. </param>
        /// <param name="minimumElasticInstanceCount">
        /// Number of minimum instance count for a site
        /// This setting only applies to the Elastic Plans
        /// </param>
        /// <param name="azureStorageAccounts"> List of Azure Storage Accounts. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block all public traffic. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteConfigProperties(int? numberOfWorkers, IList<string> defaultDocuments, string netFrameworkVersion, string phpVersion, string pythonVersion, string nodeVersion, string powerShellVersion, string linuxFxVersion, string windowsFxVersion, bool? isRequestTracingEnabled, DateTimeOffset? requestTracingExpirationOn, bool? isRemoteDebuggingEnabled, string remoteDebuggingVersion, bool? isHttpLoggingEnabled, bool? useManagedIdentityCreds, string acrUserManagedIdentityId, int? logsDirectorySizeLimit, bool? isDetailedErrorLoggingEnabled, string publishingUsername, IList<AppServiceNameValuePair> appSettings, IList<AppServiceNameValuePair> metadata, IList<ConnStringInfo> connectionStrings, SiteMachineKey machineKey, IList<HttpRequestHandlerMapping> handlerMappings, string documentRoot, ScmType? scmType, bool? use32BitWorkerProcess, bool? isWebSocketsEnabled, bool? isAlwaysOn, string javaVersion, string javaContainer, string javaContainerVersion, string appCommandLine, ManagedPipelineMode? managedPipelineMode, IList<VirtualApplication> virtualApplications, SiteLoadBalancing? loadBalancing, RoutingRuleExperiments experiments, SiteLimits limits, bool? isAutoHealEnabled, AutoHealRules autoHealRules, string tracingOptions, string vnetName, bool? isVnetRouteAllEnabled, int? vnetPrivatePortsCount, AppServiceCorsSettings cors, WebAppPushSettings push, AppServiceApiDefinitionInfo apiDefinition, ApiManagementConfig apiManagementConfig, string autoSwapSlotName, bool? isLocalMySqlEnabled, int? managedServiceIdentityId, int? xManagedServiceIdentityId, string keyVaultReferenceIdentity, IList<AppServiceIPSecurityRestriction> ipSecurityRestrictions, SiteDefaultAction? ipSecurityRestrictionsDefaultAction, IList<AppServiceIPSecurityRestriction> scmIPSecurityRestrictions, SiteDefaultAction? scmIPSecurityRestrictionsDefaultAction, bool? allowIPSecurityRestrictionsForScmToUseMain, bool? isHttp20Enabled, int? http20ProxyFlag, AppServiceSupportedTlsVersion? minTlsVersion, AppServiceTlsCipherSuite? minTlsCipherSuite, AppServiceSupportedTlsVersion? scmMinTlsVersion, AppServiceFtpsState? ftpsState, int? preWarmedInstanceCount, int? functionAppScaleLimit, int? elasticWebAppScaleLimit, string healthCheckPath, bool? isFunctionsRuntimeScaleMonitoringEnabled, string websiteTimeZone, int? minimumElasticInstanceCount, IDictionary<string, AppServiceStorageAccessInfo> azureStorageAccounts, string publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            NodeVersion = nodeVersion;
            PowerShellVersion = powerShellVersion;
            LinuxFxVersion = linuxFxVersion;
            WindowsFxVersion = windowsFxVersion;
            IsRequestTracingEnabled = isRequestTracingEnabled;
            RequestTracingExpirationOn = requestTracingExpirationOn;
            IsRemoteDebuggingEnabled = isRemoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            IsHttpLoggingEnabled = isHttpLoggingEnabled;
            UseManagedIdentityCreds = useManagedIdentityCreds;
            AcrUserManagedIdentityId = acrUserManagedIdentityId;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            IsDetailedErrorLoggingEnabled = isDetailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
            AppSettings = appSettings;
            Metadata = metadata;
            ConnectionStrings = connectionStrings;
            MachineKey = machineKey;
            HandlerMappings = handlerMappings;
            DocumentRoot = documentRoot;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            IsWebSocketsEnabled = isWebSocketsEnabled;
            IsAlwaysOn = isAlwaysOn;
            JavaVersion = javaVersion;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            AppCommandLine = appCommandLine;
            ManagedPipelineMode = managedPipelineMode;
            VirtualApplications = virtualApplications;
            LoadBalancing = loadBalancing;
            Experiments = experiments;
            Limits = limits;
            IsAutoHealEnabled = isAutoHealEnabled;
            AutoHealRules = autoHealRules;
            TracingOptions = tracingOptions;
            VnetName = vnetName;
            IsVnetRouteAllEnabled = isVnetRouteAllEnabled;
            VnetPrivatePortsCount = vnetPrivatePortsCount;
            Cors = cors;
            Push = push;
            ApiDefinition = apiDefinition;
            ApiManagementConfig = apiManagementConfig;
            AutoSwapSlotName = autoSwapSlotName;
            IsLocalMySqlEnabled = isLocalMySqlEnabled;
            ManagedServiceIdentityId = managedServiceIdentityId;
            XManagedServiceIdentityId = xManagedServiceIdentityId;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            IPSecurityRestrictions = ipSecurityRestrictions;
            IPSecurityRestrictionsDefaultAction = ipSecurityRestrictionsDefaultAction;
            ScmIPSecurityRestrictions = scmIPSecurityRestrictions;
            ScmIPSecurityRestrictionsDefaultAction = scmIPSecurityRestrictionsDefaultAction;
            AllowIPSecurityRestrictionsForScmToUseMain = allowIPSecurityRestrictionsForScmToUseMain;
            IsHttp20Enabled = isHttp20Enabled;
            Http20ProxyFlag = http20ProxyFlag;
            MinTlsVersion = minTlsVersion;
            MinTlsCipherSuite = minTlsCipherSuite;
            ScmMinTlsVersion = scmMinTlsVersion;
            FtpsState = ftpsState;
            PreWarmedInstanceCount = preWarmedInstanceCount;
            FunctionAppScaleLimit = functionAppScaleLimit;
            ElasticWebAppScaleLimit = elasticWebAppScaleLimit;
            HealthCheckPath = healthCheckPath;
            IsFunctionsRuntimeScaleMonitoringEnabled = isFunctionsRuntimeScaleMonitoringEnabled;
            WebsiteTimeZone = websiteTimeZone;
            MinimumElasticInstanceCount = minimumElasticInstanceCount;
            AzureStorageAccounts = azureStorageAccounts;
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of workers. </summary>
        [WirePath("numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }
        /// <summary> Default documents. </summary>
        [WirePath("defaultDocuments")]
        public IList<string> DefaultDocuments { get; set; }
        /// <summary> .NET Framework version. </summary>
        [WirePath("netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }
        /// <summary> Version of PHP. </summary>
        [WirePath("phpVersion")]
        public string PhpVersion { get; set; }
        /// <summary> Version of Python. </summary>
        [WirePath("pythonVersion")]
        public string PythonVersion { get; set; }
        /// <summary> Version of Node.js. </summary>
        [WirePath("nodeVersion")]
        public string NodeVersion { get; set; }
        /// <summary> Version of PowerShell. </summary>
        [WirePath("powerShellVersion")]
        public string PowerShellVersion { get; set; }
        /// <summary> Linux App Framework and version. </summary>
        [WirePath("linuxFxVersion")]
        public string LinuxFxVersion { get; set; }
        /// <summary> Xenon App Framework and version. </summary>
        [WirePath("windowsFxVersion")]
        public string WindowsFxVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("requestTracingEnabled")]
        public bool? IsRequestTracingEnabled { get; set; }
        /// <summary> Request tracing expiration time. </summary>
        [WirePath("requestTracingExpirationTime")]
        public DateTimeOffset? RequestTracingExpirationOn { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("remoteDebuggingEnabled")]
        public bool? IsRemoteDebuggingEnabled { get; set; }
        /// <summary> Remote debugging version. </summary>
        [WirePath("remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("httpLoggingEnabled")]
        public bool? IsHttpLoggingEnabled { get; set; }
        /// <summary> Flag to use Managed Identity Creds for ACR pull. </summary>
        [WirePath("acrUseManagedIdentityCreds")]
        public bool? UseManagedIdentityCreds { get; set; }
        /// <summary> If using user managed identity, the user managed identity ClientId. </summary>
        [WirePath("acrUserManagedIdentityID")]
        public string AcrUserManagedIdentityId { get; set; }
        /// <summary> HTTP logs directory size limit. </summary>
        [WirePath("logsDirectorySizeLimit")]
        public int? LogsDirectorySizeLimit { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("detailedErrorLoggingEnabled")]
        public bool? IsDetailedErrorLoggingEnabled { get; set; }
        /// <summary> Publishing user name. </summary>
        [WirePath("publishingUsername")]
        public string PublishingUsername { get; set; }
        /// <summary> Application settings. This property is not returned in response to normal create and read requests since it may contain sensitive information. </summary>
        [WirePath("appSettings")]
        public IList<AppServiceNameValuePair> AppSettings { get; set; }
        /// <summary> Application metadata. This property cannot be retrieved, since it may contain secrets. </summary>
        [WirePath("metadata")]
        public IList<AppServiceNameValuePair> Metadata { get; set; }
        /// <summary> Connection strings. This property is not returned in response to normal create and read requests since it may contain sensitive information. </summary>
        [WirePath("connectionStrings")]
        public IList<ConnStringInfo> ConnectionStrings { get; set; }
        /// <summary> Site MachineKey. </summary>
        [WirePath("machineKey")]
        public SiteMachineKey MachineKey { get; }
        /// <summary> Handler mappings. </summary>
        [WirePath("handlerMappings")]
        public IList<HttpRequestHandlerMapping> HandlerMappings { get; set; }
        /// <summary> Document root. </summary>
        [WirePath("documentRoot")]
        public string DocumentRoot { get; set; }
        /// <summary> SCM type. </summary>
        [WirePath("scmType")]
        public ScmType? ScmType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("use32BitWorkerProcess")]
        public bool? Use32BitWorkerProcess { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("webSocketsEnabled")]
        public bool? IsWebSocketsEnabled { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("alwaysOn")]
        public bool? IsAlwaysOn { get; set; }
        /// <summary> Java version. </summary>
        [WirePath("javaVersion")]
        public string JavaVersion { get; set; }
        /// <summary> Java container. </summary>
        [WirePath("javaContainer")]
        public string JavaContainer { get; set; }
        /// <summary> Java container version. </summary>
        [WirePath("javaContainerVersion")]
        public string JavaContainerVersion { get; set; }
        /// <summary> App command line to launch. </summary>
        [WirePath("appCommandLine")]
        public string AppCommandLine { get; set; }
        /// <summary> Managed pipeline mode. </summary>
        [WirePath("managedPipelineMode")]
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }
        /// <summary> Virtual applications. </summary>
        [WirePath("virtualApplications")]
        public IList<VirtualApplication> VirtualApplications { get; set; }
        /// <summary> Site load balancing. </summary>
        [WirePath("loadBalancing")]
        public SiteLoadBalancing? LoadBalancing { get; set; }
        /// <summary> This is work around for polymorphic types. </summary>
        internal RoutingRuleExperiments Experiments { get; set; }
        /// <summary> List of ramp-up rules. </summary>
        [WirePath("experiments.rampUpRules")]
        public IList<RampUpRule> ExperimentsRampUpRules
        {
            get
            {
                if (Experiments is null)
                    Experiments = new RoutingRuleExperiments();
                return Experiments.RampUpRules;
            }
        }

        /// <summary> Site limits. </summary>
        [WirePath("limits")]
        public SiteLimits Limits { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("autoHealEnabled")]
        public bool? IsAutoHealEnabled { get; set; }
        /// <summary> Auto Heal rules. </summary>
        [WirePath("autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }
        /// <summary> Tracing options. </summary>
        [WirePath("tracingOptions")]
        public string TracingOptions { get; set; }
        /// <summary> Virtual Network name. </summary>
        [WirePath("vnetName")]
        public string VnetName { get; set; }
        /// <summary> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </summary>
        [WirePath("vnetRouteAllEnabled")]
        public bool? IsVnetRouteAllEnabled { get; set; }
        /// <summary> The number of private ports assigned to this app. These will be assigned dynamically on runtime. </summary>
        [WirePath("vnetPrivatePortsCount")]
        public int? VnetPrivatePortsCount { get; set; }
        /// <summary> Cross-Origin Resource Sharing (CORS) settings. </summary>
        [WirePath("cors")]
        public AppServiceCorsSettings Cors { get; set; }
        /// <summary> Push endpoint settings. </summary>
        [WirePath("push")]
        public WebAppPushSettings Push { get; set; }
        /// <summary> Information about the formal API definition for the app. </summary>
        internal AppServiceApiDefinitionInfo ApiDefinition { get; set; }
        /// <summary> The URL of the API definition. </summary>
        [WirePath("apiDefinition.url")]
        public Uri ApiDefinitionUri
        {
            get => ApiDefinition is null ? default : ApiDefinition.Uri;
            set
            {
                if (ApiDefinition is null)
                    ApiDefinition = new AppServiceApiDefinitionInfo();
                ApiDefinition.Uri = value;
            }
        }

        /// <summary> Azure API management settings linked to the app. </summary>
        internal ApiManagementConfig ApiManagementConfig { get; set; }
        /// <summary> APIM-Api Identifier. </summary>
        [WirePath("apiManagementConfig.id")]
        public string ApiManagementConfigId
        {
            get => ApiManagementConfig is null ? default : ApiManagementConfig.Id;
            set
            {
                if (ApiManagementConfig is null)
                    ApiManagementConfig = new ApiManagementConfig();
                ApiManagementConfig.Id = value;
            }
        }

        /// <summary> Auto-swap slot name. </summary>
        [WirePath("autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("localMySqlEnabled")]
        public bool? IsLocalMySqlEnabled { get; set; }
        /// <summary> Managed Service Identity Id. </summary>
        [WirePath("managedServiceIdentityId")]
        public int? ManagedServiceIdentityId { get; set; }
        /// <summary> Explicit Managed Service Identity Id. </summary>
        [WirePath("xManagedServiceIdentityId")]
        public int? XManagedServiceIdentityId { get; set; }
        /// <summary> Identity to use for Key Vault Reference authentication. </summary>
        [WirePath("keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }
        /// <summary> IP security restrictions for main. </summary>
        [WirePath("ipSecurityRestrictions")]
        public IList<AppServiceIPSecurityRestriction> IPSecurityRestrictions { get; set; }
        /// <summary> Default action for main access restriction if no rules are matched. </summary>
        [WirePath("ipSecurityRestrictionsDefaultAction")]
        public SiteDefaultAction? IPSecurityRestrictionsDefaultAction { get; set; }
        /// <summary> IP security restrictions for scm. </summary>
        [WirePath("scmIpSecurityRestrictions")]
        public IList<AppServiceIPSecurityRestriction> ScmIPSecurityRestrictions { get; set; }
        /// <summary> Default action for scm access restriction if no rules are matched. </summary>
        [WirePath("scmIpSecurityRestrictionsDefaultAction")]
        public SiteDefaultAction? ScmIPSecurityRestrictionsDefaultAction { get; set; }
        /// <summary> IP security restrictions for scm to use main. </summary>
        [WirePath("scmIpSecurityRestrictionsUseMain")]
        public bool? AllowIPSecurityRestrictionsForScmToUseMain { get; set; }
        /// <summary> Http20Enabled: configures a web site to allow clients to connect over http2.0. </summary>
        [WirePath("http20Enabled")]
        public bool? IsHttp20Enabled { get; set; }
        /// <summary> Http20ProxyFlag: Configures a website to allow http2.0 to pass be proxied all the way to the app. 0 = disabled, 1 = pass through all http2 traffic, 2 = pass through gRPC only. </summary>
        [WirePath("http20ProxyFlag")]
        public int? Http20ProxyFlag { get; set; }
        /// <summary> MinTlsVersion: configures the minimum version of TLS required for SSL requests. </summary>
        [WirePath("minTlsVersion")]
        public AppServiceSupportedTlsVersion? MinTlsVersion { get; set; }
        /// <summary> The minimum strength TLS cipher suite allowed for an application. </summary>
        [WirePath("minTlsCipherSuite")]
        public AppServiceTlsCipherSuite? MinTlsCipherSuite { get; set; }
        /// <summary> ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site. </summary>
        [WirePath("scmMinTlsVersion")]
        public AppServiceSupportedTlsVersion? ScmMinTlsVersion { get; set; }
        /// <summary> State of FTP / FTPS service. </summary>
        [WirePath("ftpsState")]
        public AppServiceFtpsState? FtpsState { get; set; }
        /// <summary>
        /// Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </summary>
        [WirePath("preWarmedInstanceCount")]
        public int? PreWarmedInstanceCount { get; set; }
        /// <summary>
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to the Consumption and Elastic Premium Plans
        /// </summary>
        [WirePath("functionAppScaleLimit")]
        public int? FunctionAppScaleLimit { get; set; }
        /// <summary>
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to apps in plans where ElasticScaleEnabled is &lt;code&gt;true&lt;/code&gt;
        /// </summary>
        [WirePath("elasticWebAppScaleLimit")]
        public int? ElasticWebAppScaleLimit { get; set; }
        /// <summary> Health check path. </summary>
        [WirePath("healthCheckPath")]
        public string HealthCheckPath { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether functions runtime scale monitoring is enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but will instead call to the
        /// runtime to get scale status.
        /// </summary>
        [WirePath("functionsRuntimeScaleMonitoringEnabled")]
        public bool? IsFunctionsRuntimeScaleMonitoringEnabled { get; set; }
        /// <summary> Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database values https://www.iana.org/time-zones (for a quick reference see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones. </summary>
        [WirePath("websiteTimeZone")]
        public string WebsiteTimeZone { get; set; }
        /// <summary>
        /// Number of minimum instance count for a site
        /// This setting only applies to the Elastic Plans
        /// </summary>
        [WirePath("minimumElasticInstanceCount")]
        public int? MinimumElasticInstanceCount { get; set; }
        /// <summary> List of Azure Storage Accounts. </summary>
        [WirePath("azureStorageAccounts")]
        public IDictionary<string, AppServiceStorageAccessInfo> AzureStorageAccounts { get; set; }
        /// <summary> Property to allow or block all public traffic. </summary>
        [WirePath("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }
    }
}
