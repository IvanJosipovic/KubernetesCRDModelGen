using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Storage version of v1api20220401.DnsConfig Class containing DNS settings in a Traffic Manager profile.</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecDnsConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Storage version of v1api20220401.MonitorConfig_CustomHeaders</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecMonitorConfigCustomHeaders
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

/// <summary>Storage version of v1api20220401.MonitorConfig_ExpectedStatusCodeRanges</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecMonitorConfigExpectedStatusCodeRanges
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>Storage version of v1api20220401.MonitorConfig Class containing endpoint monitoring settings in a Traffic Manager profile.</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecMonitorConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401storageTrafficManagerProfileSpecMonitorConfigCustomHeaders>? CustomHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<V1api20220401storageTrafficManagerProfileSpecMonitorConfigExpectedStatusCodeRanges>? ExpectedStatusCodeRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileMonitorStatus")]
    public string? ProfileMonitorStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public int? ToleratedNumberOfFailures { get; set; }
}

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecOperatorSpecConfigMapsDnsConfigFqdn
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap being referenced. The ConfigMap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220401.TrafficManagerProfileOperatorConfigMaps</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("dnsConfigFqdn")]
    public V1api20220401storageTrafficManagerProfileSpecOperatorSpecConfigMapsDnsConfigFqdn? DnsConfigFqdn { get; set; }
}

/// <summary>Storage version of v1api20220401.TrafficManagerProfileOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220401.TrafficManagerProfileOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20220401storageTrafficManagerProfileSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20220401storageTrafficManagerProfileSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220401.Trafficmanagerprofile_Spec</summary>
public partial class V1api20220401storageTrafficManagerProfileSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedEndpointRecordTypes")]
    public IList<string>? AllowedEndpointRecordTypes { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20220401.DnsConfig Class containing DNS settings in a Traffic Manager profile.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20220401storageTrafficManagerProfileSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxReturn")]
    public int? MaxReturn { get; set; }

    /// <summary>Storage version of v1api20220401.MonitorConfig Class containing endpoint monitoring settings in a Traffic Manager profile.</summary>
    [JsonPropertyName("monitorConfig")]
    public V1api20220401storageTrafficManagerProfileSpecMonitorConfig? MonitorConfig { get; set; }

    /// <summary>Storage version of v1api20220401.TrafficManagerProfileOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220401storageTrafficManagerProfileSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220401storageTrafficManagerProfileSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficViewEnrollmentStatus")]
    public string? TrafficViewEnrollmentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusConditions
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

/// <summary>Storage version of v1api20220401.DnsConfig_STATUS Class containing DNS settings in a Traffic Manager profile.</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusDnsConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Storage version of v1api20220401.Endpoint_STATUS Class representing a Traffic Manager endpoint.</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220401.MonitorConfig_CustomHeaders_STATUS</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusMonitorConfigCustomHeaders
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

/// <summary>Storage version of v1api20220401.MonitorConfig_ExpectedStatusCodeRanges_STATUS</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusMonitorConfigExpectedStatusCodeRanges
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>Storage version of v1api20220401.MonitorConfig_STATUS Class containing endpoint monitoring settings in a Traffic Manager profile.</summary>
public partial class V1api20220401storageTrafficManagerProfileStatusMonitorConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401storageTrafficManagerProfileStatusMonitorConfigCustomHeaders>? CustomHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<V1api20220401storageTrafficManagerProfileStatusMonitorConfigExpectedStatusCodeRanges>? ExpectedStatusCodeRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileMonitorStatus")]
    public string? ProfileMonitorStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public int? ToleratedNumberOfFailures { get; set; }
}

/// <summary>Storage version of v1api20220401.Trafficmanagerprofile_STATUS</summary>
public partial class V1api20220401storageTrafficManagerProfileStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedEndpointRecordTypes")]
    public IList<string>? AllowedEndpointRecordTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220401storageTrafficManagerProfileStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20220401.DnsConfig_STATUS Class containing DNS settings in a Traffic Manager profile.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20220401storageTrafficManagerProfileStatusDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20220401storageTrafficManagerProfileStatusEndpoints>? Endpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxReturn")]
    public int? MaxReturn { get; set; }

    /// <summary>Storage version of v1api20220401.MonitorConfig_STATUS Class containing endpoint monitoring settings in a Traffic Manager profile.</summary>
    [JsonPropertyName("monitorConfig")]
    public V1api20220401storageTrafficManagerProfileStatusMonitorConfig? MonitorConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficViewEnrollmentStatus")]
    public string? TrafficViewEnrollmentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20220401.TrafficManagerProfile Generator information: - Generated from: /trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/trafficmanager.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</summary>
public partial class V1api20220401storageTrafficManagerProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220401storageTrafficManagerProfileSpec>, IStatus<V1api20220401storageTrafficManagerProfileStatus>
{
    public const string KubeApiVersion = "v1api20220401storage";
    public const string KubeKind = "TrafficManagerProfile";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220401.Trafficmanagerprofile_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220401storageTrafficManagerProfileSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220401.Trafficmanagerprofile_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220401storageTrafficManagerProfileStatus? Status { get; set; }
}