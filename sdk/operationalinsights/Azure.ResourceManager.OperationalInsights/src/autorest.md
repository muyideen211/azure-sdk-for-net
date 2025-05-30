# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
azure-arm: true
csharp: true
library-name: OperationalInsights
namespace: Azure.ResourceManager.OperationalInsights
require: https://github.com/Azure/azure-rest-api-specs/blob/b713df239eb640a56fb4b4db9648ad4bf1388e3b/specification/operationalinsights/resource-manager/readme.md
output-folder: $(this-folder)/Generated
clear-output-folder: true
sample-gen:
  output-folder: $(this-folder)/../tests/Generated
  clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false
  lenient-model-deduplication: true
use-model-reader-writer: true
enable-bicep-serialization: true
# mgmt-debug:
#   show-serialized-names: true

format-by-name-rules:
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'
  'clusterId': 'uuid'
  'dataExportId': 'uuid'
  '*ResourceId': 'arm-id'
  'queryPackId': 'uuid'
  'customerId': 'uuid'
  'azureAsyncOperationId': 'uuid'

acronym-mapping:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag

prepend-rp-prefix:
  - Cluster
  - DataExport
  - DataSource
  - LinkedService
  - SavedSearch
  - Table
  - Workspace
  - AvailableServiceTier
  - BillingType
  - CapacityReservationProperties
  - ClusterEntityStatus
  - ClusterReplicationProperties
  - ClusterReplicationState
  - ClusterSku
  - Column
  - DataIngestionStatus
  - DataSourceKind
  - DataSourceType
  - IntelligencePack
  - KeyVaultProperties
  - LinkedServiceEntityStatus
  - ManagementGroup
  - MetricName
  - PublicNetworkAccessType
  - RestoredLogs
  - Schema
  - SearchSchemaValue
  - StorageAccount
  - Tag
  - UsageMetric
  - WorkspaceCapping
  - WorkspaceEntityStatus
  - WorkspaceFailoverProperties
  - WorkspaceFailoverState
  - WorkspaceFeatures
  - WorkspaceReplicationProperties
  - WorkspaceReplicationState
  - WorkspaceSku

rename-mapping:
  LinkedStorageAccountsResource: OperationalInsightsLinkedStorageAccounts
  Cluster.properties.createdDate: -|date-time-rfc1123
  Cluster.properties.lastModifiedDate: -|date-time-rfc1123
  DataExport.properties.createdDate: -|date-time-rfc1123
  DataExport.properties.lastModifiedDate: -|date-time-rfc1123
  AssociatedWorkspace.associateDate: AssociatedOn|date-time-rfc1123
  AssociatedWorkspace.workspaceId: -|uuid
  Workspace.properties.createdDate: -|date-time
  Workspace.properties.modifiedDate: -|date-time
  WorkspacePatch.properties.createdDate: -|date-time
  WorkspacePatch.properties.modifiedDate: -|date-time
  DataExport.properties.enable: IsEnabled
  AvailableServiceTier.enabled: IsEnabled
  AvailableServiceTier.lastSkuUpdate: LastSkuUpdatedOn|date-time
  CapacityReservationProperties.lastSkuUpdate: LastSkuUpdatedOn|date-time
  WorkspaceSku.lastSkuUpdate: LastSkuUpdatedOn|date-time
  IntelligencePack.enabled: IsEnabled
  WorkspaceFeatures.disableLocalAuth: IsLocalAuthDisabled
  WorkspaceFeatures.enableDataExport: IsDataExportEnabled
  WorkspaceFeatures.enableLogAccessUsingOnlyResourcePermissions: IsLogAccessUsingOnlyResourcePermissionsEnabled
  WorkspaceFeatures.unifiedSentinelBillingOnly: IsUnifiedSentinelBillingOnly
  PrivateLinkScopedResource: OperationalInsightsPrivateLinkScopedResourceInfo
  LogAnalyticsQueryPack.properties.timeCreated: CreatedOn
  LogAnalyticsQueryPack.properties.timeModified: ModifiedOn
  LogAnalyticsQueryPackQuery.properties.id: ApplicationId|uuid
  LogAnalyticsQueryPackQuery.properties.timeCreated: CreatedOn
  LogAnalyticsQueryPackQuery.properties.timeModified: ModifiedOn
  LogAnalyticsQueryPackQuery: LogAnalyticsQuery
  ClusterReplicationProperties.enabled: IsReplicationEnabled
  ClusterSkuNameEnum: OperationalInsightsClusterSkuName
  ColumnDataTypeHintEnum: OperationalInsightsColumnDataTypeHint
  ColumnTypeEnum: OperationalInsightsColumnType
  ProvisioningStateEnum: OperationalInsightsTableProvisioningState
  SourceEnum: OperationalInsightsTableCreator
  TablePlanEnum: OperationalInsightsTablePlan
  TableSubTypeEnum: OperationalInsightsTableSubType
  TableTypeEnum: OperationalInsightsTableType
  WorkspaceSkuNameEnum: OperationalInsightsWorkspaceSkuName
  SkuNameEnum: OperationalInsightsSkuName
  AssociatedWorkspace: OperationalInsightsClusterAssociatedWorkspace
  CoreSummary: OperationalInsightsSearchCoreSummary
  LogAnalyticsQueryPackQuerySearchProperties: LogAnalyticsQuerySearchProperties
  LogAnalyticsQueryPackQueryPropertiesRelated: LogAnalyticsQueryRelatedMetadata
  LogAnalyticsQueryPackQuerySearchPropertiesRelated: LogAnalyticsQuerySearchRelatedMetadata
  PurgeState: OperationalInsightsWorkspacePurgeState
  SharedKeys: OperationalInsightsWorkspaceSharedKeys
  WorkspacePurgeResponse: OperationalInsightsWorkspacePurgeResult
  WorkspacePurgeStatusResponse: OperationalInsightsWorkspacePurgeStatusResult
  WorkspaceReplicationProperties.enabled: IsReplicationEnabled
  RestoredLogs: OperationalInsightsTableRestoredLogs
  SearchResults: OperationalInsightsTableSearchResults
  ResultStatistics: OperationalInsightsTableResultStatistics
  ResultStatistics.scannedGb: ScannedGB
  WorkspaceCapping.dailyQuotaGb: DailyQuotaInGB
  Table.properties.retentionInDaysAsDefault: IsRetentionInDaysAsDefault
  Table.properties.totalRetentionInDaysAsDefault: IsTotalRetentionInDaysAsDefault
  ManagementGroup.properties.created: CreatedOn
  ManagementGroup.properties.dataReceived: DataReceivedOn
  StorageAccount.id: -|arm-id
  WorkspacePurgeResponse.operationId: OperationStringId
  WorkspacePurgeBody: OperationalInsightsWorkspacePurgeContent
  WorkspacePurgeBodyFilters: OperationalInsightsWorkspacePurgeFilter
  Capacity: OperationalInsightsClusterCapacity
  CapacityReservationLevel: OperationalInsightsWorkspaceCapacityReservationLevel

keep-plural-resource-data:
  - OperationalInsightsLinkedStorageAccounts

override-operation-name:
  WorkspacePurge_GetPurgeStatus: GetPurgeStatus
  SharedKeys_GetSharedKeys: GetSharedKeys
  WorkspacePurge_Purge: Purge
  DeletedWorkspaces_List: GetDeletedWorkspaces
  DeletedWorkspaces_ListByResourceGroup: GetDeletedWorkspaces

operations-to-skip-lro-api-version-override:
- Clusters_CreateOrUpdate

directive:
  - remove-operation: OperationStatuses_Get
  # The `type` is reserved name
  - from: Tables.json
    where: $.definitions
    transform: >
      $.Column.properties.type['x-ms-client-name'] = 'ColumnType';
  - from: DataExports.json
    where: $.definitions
    transform: >
      $.Destination.properties.type['x-ms-enum'].name = 'OperationalInsightsDataExportDestinationType';
      $.Destination.properties.type['x-ms-client-name'] = 'DestinationType';
  - from: LinkedStorageAccounts.json
    where: $.definitions
    transform: >
      $.LinkedStorageAccountsProperties.properties.storageAccountIds.items['x-ms-format'] = 'arm-id';
  - from: Gateways.json
    where: $.parameters
    transform: >
      $.GatewayIdParameter.format = 'uuid';
  - from: DataSources.json
    where: $.paths['/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources'].get.parameters[?(@.name === '$skiptoken')]
    transform: >
      $['x-ms-client-name'] = 'skipToken';

```
