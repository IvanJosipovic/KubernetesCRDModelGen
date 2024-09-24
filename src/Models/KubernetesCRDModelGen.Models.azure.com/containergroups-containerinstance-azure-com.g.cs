using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerinstance.azure.com;
public partial class V1api20211001storageContainerGroupSpecContainersEnvironmentVariablesSecureValue
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("secureValue")]
    public V1api20211001storageContainerGroupSpecContainersEnvironmentVariablesSecureValue? SecureValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersLivenessProbeExec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersLivenessProbeHttpGet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001storageContainerGroupSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersLivenessProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerExec The container execution command, for liveness or readiness probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001storageContainerGroupSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerHttpGet The container Http Get settings, for liveness or readiness probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001storageContainerGroupSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersReadinessProbeExec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersReadinessProbeHttpGet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001storageContainerGroupSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersReadinessProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerExec The container execution command, for liveness or readiness probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001storageContainerGroupSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerHttpGet The container Http Get settings, for liveness or readiness probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001storageContainerGroupSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersResourcesLimitsGpu
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersResourcesLimits
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Storage version of v1api20211001.GpuResource The GPU resource.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001storageContainerGroupSpecContainersResourcesLimitsGpu? Gpu { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersResourcesRequestsGpu
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersResourcesRequests
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Storage version of v1api20211001.GpuResource The GPU resource.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001storageContainerGroupSpecContainersResourcesRequestsGpu? Gpu { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceLimits The resource limits.</summary>
    [JsonPropertyName("limits")]
    public V1api20211001storageContainerGroupSpecContainersResourcesLimits? Limits { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceRequests The resource requests.</summary>
    [JsonPropertyName("requests")]
    public V1api20211001storageContainerGroupSpecContainersResourcesRequests? Requests { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainersVolumeMounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecContainers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001storageContainerGroupSpecContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerProbe The container probe, for liveness or readiness</summary>
    [JsonPropertyName("livenessProbe")]
    public V1api20211001storageContainerGroupSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001storageContainerGroupSpecContainersPorts>? Ports { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerProbe The container probe, for liveness or readiness</summary>
    [JsonPropertyName("readinessProbe")]
    public V1api20211001storageContainerGroupSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceRequirements The resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V1api20211001storageContainerGroupSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001storageContainerGroupSpecContainersVolumeMounts>? VolumeMounts { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecDiagnosticsLogAnalytics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("workspaceKey")]
    public V1api20211001storageContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceKey? WorkspaceKey { get; set; }

    /// <summary>WorkspaceResourceReference: The workspace resource id for log analytics</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20211001storageContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecDiagnostics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.LogAnalytics Container group log analytics information.</summary>
    [JsonPropertyName("logAnalytics")]
    public V1api20211001storageContainerGroupSpecDiagnosticsLogAnalytics? LogAnalytics { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecDnsConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public string? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searchDomains")]
    public string? SearchDomains { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecEncryptionProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211001storageContainerGroupSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211001storageContainerGroupSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecImageRegistryCredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecImageRegistryCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityUrl")]
    public string? IdentityUrl { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20211001storageContainerGroupSpecImageRegistryCredentialsPassword? Password { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecInitContainersEnvironmentVariablesSecureValue
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecInitContainersEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("secureValue")]
    public V1api20211001storageContainerGroupSpecInitContainersEnvironmentVariablesSecureValue? SecureValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecInitContainersVolumeMounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecInitContainers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001storageContainerGroupSpecInitContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001storageContainerGroupSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecIpAddressPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecIpAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public string? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsNameLabel")]
    public string? DnsNameLabel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001storageContainerGroupSpecIpAddressPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecSubnetIdsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecSubnetIds
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Resource ID of virtual network and subnet.</summary>
    [JsonPropertyName("reference")]
    public V1api20211001storageContainerGroupSpecSubnetIdsReference Reference { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecVolumesAzureFile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountKey")]
    public string? StorageAccountKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecVolumesGitRepo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

public partial class V1api20211001storageContainerGroupSpecVolumes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.AzureFileVolume The properties of the Azure File volume. Azure File shares are mounted as volumes.</summary>
    [JsonPropertyName("azureFile")]
    public V1api20211001storageContainerGroupSpecVolumesAzureFile? AzureFile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emptyDir")]
    public IDictionary<string, JsonNode>? EmptyDir { get; set; }

    /// <summary>Storage version of v1api20211001.GitRepoVolume Represents a volume that is populated with the contents of a git repository</summary>
    [JsonPropertyName("gitRepo")]
    public V1api20211001storageContainerGroupSpecVolumesGitRepo? GitRepo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secret")]
    public IDictionary<string, string>? Secret { get; set; }
}

public partial class V1api20211001storageContainerGroupSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1api20211001storageContainerGroupSpecContainers>? Containers { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroupDiagnostics Container group diagnostic information.</summary>
    [JsonPropertyName("diagnostics")]
    public V1api20211001storageContainerGroupSpecDiagnostics? Diagnostics { get; set; }

    /// <summary>Storage version of v1api20211001.DnsConfiguration DNS configuration for the container group.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20211001storageContainerGroupSpecDnsConfig? DnsConfig { get; set; }

    /// <summary>Storage version of v1api20211001.EncryptionProperties The container group encryption properties.</summary>
    [JsonPropertyName("encryptionProperties")]
    public V1api20211001storageContainerGroupSpecEncryptionProperties? EncryptionProperties { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroupIdentity Identity for the container group.</summary>
    [JsonPropertyName("identity")]
    public V1api20211001storageContainerGroupSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public IList<V1api20211001storageContainerGroupSpecImageRegistryCredentials>? ImageRegistryCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1api20211001storageContainerGroupSpecInitContainers>? InitContainers { get; set; }

    /// <summary>Storage version of v1api20211001.IpAddress IP address for the container group.</summary>
    [JsonPropertyName("ipAddress")]
    public V1api20211001storageContainerGroupSpecIpAddress? IpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211001storageContainerGroupSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetIds")]
    public IList<V1api20211001storageContainerGroupSpecSubnetIds>? SubnetIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20211001storageContainerGroupSpecVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersInstanceViewCurrentState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersInstanceViewEvents
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersInstanceViewPreviousState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersInstanceView
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerState_STATUS The container instance state.</summary>
    [JsonPropertyName("currentState")]
    public V1api20211001storageContainerGroupStatusContainersInstanceViewCurrentState? CurrentState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001storageContainerGroupStatusContainersInstanceViewEvents>? Events { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerState_STATUS The container instance state.</summary>
    [JsonPropertyName("previousState")]
    public V1api20211001storageContainerGroupStatusContainersInstanceViewPreviousState? PreviousState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersLivenessProbeExec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersLivenessProbeHttpGet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001storageContainerGroupStatusContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersLivenessProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerExec_STATUS The container execution command, for liveness or readiness probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001storageContainerGroupStatusContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerHttpGet_STATUS The container Http Get settings, for liveness or readiness probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001storageContainerGroupStatusContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersReadinessProbeExec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersReadinessProbeHttpGet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001storageContainerGroupStatusContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersReadinessProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerExec_STATUS The container execution command, for liveness or readiness probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001storageContainerGroupStatusContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerHttpGet_STATUS The container Http Get settings, for liveness or readiness probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001storageContainerGroupStatusContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersResourcesLimitsGpu
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersResourcesLimits
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Storage version of v1api20211001.GpuResource_STATUS The GPU resource.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001storageContainerGroupStatusContainersResourcesLimitsGpu? Gpu { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersResourcesRequestsGpu
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersResourcesRequests
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Storage version of v1api20211001.GpuResource_STATUS The GPU resource.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001storageContainerGroupStatusContainersResourcesRequestsGpu? Gpu { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceLimits_STATUS The resource limits.</summary>
    [JsonPropertyName("limits")]
    public V1api20211001storageContainerGroupStatusContainersResourcesLimits? Limits { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceRequests_STATUS The resource requests.</summary>
    [JsonPropertyName("requests")]
    public V1api20211001storageContainerGroupStatusContainersResourcesRequests? Requests { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainersVolumeMounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusContainers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001storageContainerGroupStatusContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerProperties_InstanceView_STATUS</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001storageContainerGroupStatusContainersInstanceView? InstanceView { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerProbe_STATUS The container probe, for liveness or readiness</summary>
    [JsonPropertyName("livenessProbe")]
    public V1api20211001storageContainerGroupStatusContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001storageContainerGroupStatusContainersPorts>? Ports { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerProbe_STATUS The container probe, for liveness or readiness</summary>
    [JsonPropertyName("readinessProbe")]
    public V1api20211001storageContainerGroupStatusContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceRequirements_STATUS The resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V1api20211001storageContainerGroupStatusContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001storageContainerGroupStatusContainersVolumeMounts>? VolumeMounts { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusDiagnosticsLogAnalytics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusDiagnostics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.LogAnalytics_STATUS Container group log analytics information.</summary>
    [JsonPropertyName("logAnalytics")]
    public V1api20211001storageContainerGroupStatusDiagnosticsLogAnalytics? LogAnalytics { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusDnsConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public string? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searchDomains")]
    public string? SearchDomains { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusEncryptionProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211001storageContainerGroupStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusImageRegistryCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityUrl")]
    public string? IdentityUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersEnvironmentVariables
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersInstanceViewCurrentState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersInstanceViewEvents
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersInstanceViewPreviousState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersInstanceView
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerState_STATUS The container instance state.</summary>
    [JsonPropertyName("currentState")]
    public V1api20211001storageContainerGroupStatusInitContainersInstanceViewCurrentState? CurrentState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001storageContainerGroupStatusInitContainersInstanceViewEvents>? Events { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerState_STATUS The container instance state.</summary>
    [JsonPropertyName("previousState")]
    public V1api20211001storageContainerGroupStatusInitContainersInstanceViewPreviousState? PreviousState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainersVolumeMounts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInitContainers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001storageContainerGroupStatusInitContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Storage version of v1api20211001.InitContainerPropertiesDefinition_InstanceView_STATUS</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001storageContainerGroupStatusInitContainersInstanceView? InstanceView { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001storageContainerGroupStatusInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInstanceViewEvents
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusInstanceView
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001storageContainerGroupStatusInstanceViewEvents>? Events { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusIpAddressPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusIpAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public string? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsNameLabel")]
    public string? DnsNameLabel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001storageContainerGroupStatusIpAddressPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusSubnetIds
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusVolumesAzureFile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountKey")]
    public string? StorageAccountKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusVolumesGitRepo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

public partial class V1api20211001storageContainerGroupStatusVolumes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.AzureFileVolume_STATUS The properties of the Azure File volume. Azure File shares are mounted as volumes.</summary>
    [JsonPropertyName("azureFile")]
    public V1api20211001storageContainerGroupStatusVolumesAzureFile? AzureFile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emptyDir")]
    public IDictionary<string, JsonNode>? EmptyDir { get; set; }

    /// <summary>Storage version of v1api20211001.GitRepoVolume_STATUS Represents a volume that is populated with the contents of a git repository</summary>
    [JsonPropertyName("gitRepo")]
    public V1api20211001storageContainerGroupStatusVolumesGitRepo? GitRepo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secret")]
    public IDictionary<string, string>? Secret { get; set; }
}

public partial class V1api20211001storageContainerGroupStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211001storageContainerGroupStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1api20211001storageContainerGroupStatusContainers>? Containers { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroupDiagnostics_STATUS Container group diagnostic information.</summary>
    [JsonPropertyName("diagnostics")]
    public V1api20211001storageContainerGroupStatusDiagnostics? Diagnostics { get; set; }

    /// <summary>Storage version of v1api20211001.DnsConfiguration_STATUS DNS configuration for the container group.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20211001storageContainerGroupStatusDnsConfig? DnsConfig { get; set; }

    /// <summary>Storage version of v1api20211001.EncryptionProperties_STATUS The container group encryption properties.</summary>
    [JsonPropertyName("encryptionProperties")]
    public V1api20211001storageContainerGroupStatusEncryptionProperties? EncryptionProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroupIdentity_STATUS Identity for the container group.</summary>
    [JsonPropertyName("identity")]
    public V1api20211001storageContainerGroupStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public IList<V1api20211001storageContainerGroupStatusImageRegistryCredentials>? ImageRegistryCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1api20211001storageContainerGroupStatusInitContainers>? InitContainers { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroup_Properties_InstanceView_STATUS</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001storageContainerGroupStatusInstanceView? InstanceView { get; set; }

    /// <summary>Storage version of v1api20211001.IpAddress_STATUS IP address for the container group.</summary>
    [JsonPropertyName("ipAddress")]
    public V1api20211001storageContainerGroupStatusIpAddress? IpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetIds")]
    public IList<V1api20211001storageContainerGroupStatusSubnetIds>? SubnetIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20211001storageContainerGroupStatusVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001storageContainerGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211001storageContainerGroupSpec>, IStatus<V1api20211001storageContainerGroupStatus>
{
    public const string KubeApiVersion = "v1api20211001storage";
    public const string KubeKind = "ContainerGroup";
    public const string KubeGroup = "containerinstance.azure.com";
    public const string KubePluralName = "containergroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroup_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211001storageContainerGroupSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211001.ContainerGroup_STATUS A container group.</summary>
    [JsonPropertyName("status")]
    public V1api20211001storageContainerGroupStatus? Status { get; set; }
}