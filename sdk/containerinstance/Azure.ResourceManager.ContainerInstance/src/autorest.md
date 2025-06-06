# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
azure-arm: true
library-name: ContainerInstance
namespace: Azure.ResourceManager.ContainerInstance
require: https://github.com/Azure/azure-rest-api-specs/blob/10b3107f2eafcd428a208ec5858f3ca9261b1123/specification/containerinstance/resource-manager/readme.md
#tag: package-preview-2024-05
output-folder: $(this-folder)/Generated
clear-output-folder: true
sample-gen:
  output-folder: $(this-folder)/../tests/Generated
  clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false
use-model-reader-writer: true

# mgmt-debug:
#  show-serialized-names: true

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

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
  TCP: Tcp
  UDP: Udp
  Noreuse: NoReuse

override-operation-name:
  Location_ListCachedImages: GetCachedImagesWithLocation
  Location_ListCapabilities: GetCapabilitiesWithLocation
  Location_ListUsage: GetUsagesWithLocation
  Containers_ExecuteCommand: ExecuteContainerCommand
  Containers_ListLogs: GetContainerLogs

# If the model is generally used across the RP or we need to avoid duplication, prepend the RP name.
# If the model is used by a single container instance, simply use Container prefix in the rename-mapping section as it's simpler and consistent with the original pattern in swagger.
prepend-rp-prefix:
  - UsageListResult
  - UsageName
  - OperatingSystemTypes
  - AzureFileVolume
  - GitRepoVolume
  - Container

rename-mapping:
  Logs: ContainerLogs
  Event: ContainerEvent
  AzureFileVolume.readOnly: IsReadOnly
  VolumeMount.readOnly: IsReadOnly
  CapabilitiesCapabilities: ContainerSupportedCapabilities
  ContainerProbe.timeoutSeconds: TimeoutInSeconds
  ContainerProbe.initialDelaySeconds: InitialDelayInSeconds
  ContainerProbe.periodSeconds: PeriodInSeconds
  Scheme: ContainerHttpGetScheme
  Port: ContainerGroupPort
  IpAddress.ip: -|ip-address
  IpAddress: ContainerGroupIPAddress
  GpuResource: ContainerGpuResourceInfo
  ContainerGroupPropertiesInstanceView: ContainerGroupInstanceView
  ContainerPropertiesInstanceView: ContainerInstanceView
  ContainerAttachResponse: ContainerAttachResult
  ContainerExecResponse: ContainerExecResult
  ContainerGroupSubnetId.id: -|arm-id
  InitContainerDefinition: InitContainerDefinitionContent
  LogAnalytics.workspaceResourceId: -|arm-id
  ResourceRequests: ContainerResourceRequestsContent
  DnsConfiguration: ContainerGroupDnsConfiguration
  EncryptionProperties: ContainerGroupEncryptionProperties
  HttpHeader: ContainerHttpHeader
  ImageRegistryCredential: ContainerGroupImageRegistryCredential
  Volume: ContainerVolume
  VolumeMount: ContainerVolumeMount
  Capabilities: ContainerCapabilities
  CapabilitiesListResult: ContainerCapabilitiesListResult
  ResourceLimits: ContainerResourceLimits
  ResourceRequirements: ContainerResourceRequirements
  EnvironmentVariable: ContainerEnvironmentVariable
  GpuSku: ContainerGpuSku
  LogAnalytics: ContainerGroupLogAnalytics
  LogAnalyticsLogType: ContainerGroupLogAnalyticsLogType
  SecurityContextDefinition: ContainerSecurityContextDefinition
  SecurityContextCapabilitiesDefinition: ContainerSecurityContextCapabilitiesDefinition
  SecurityContextDefinition.privileged: IsPrivileged
  ContainerGroupProperties.properties.osType: ContainerGroupOsType
```
