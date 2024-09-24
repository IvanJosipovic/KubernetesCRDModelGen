using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>Storage version of v1api20230501.HealthProbeParameters The JSON object that contains the properties to send health probes to origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupSpecHealthProbeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

/// <summary>Storage version of v1api20230501.LoadBalancingSettingsParameters Round-Robin load balancing settings for a backend pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupSpecLoadBalancingSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public int? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sampleSize")]
    public int? SampleSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public int? SuccessfulSamplesRequired { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/Profile resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_OriginGroup_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20230501.HealthProbeParameters The JSON object that contains the properties to send health probes to origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20230501storageAfdOriginGroupSpecHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary>Storage version of v1api20230501.LoadBalancingSettingsParameters Round-Robin load balancing settings for a backend pool</summary>
    [JsonPropertyName("loadBalancingSettings")]
    public V1api20230501storageAfdOriginGroupSpecLoadBalancingSettings? LoadBalancingSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/Profile resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230501storageAfdOriginGroupSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionAffinityState")]
    public string? SessionAffinityState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupStatusConditions
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

/// <summary>Storage version of v1api20230501.HealthProbeParameters_STATUS The JSON object that contains the properties to send health probes to origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupStatusHealthProbeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

/// <summary>Storage version of v1api20230501.LoadBalancingSettingsParameters_STATUS Round-Robin load balancing settings for a backend pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupStatusLoadBalancingSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public int? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sampleSize")]
    public int? SampleSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public int? SuccessfulSamplesRequired { get; set; }
}

/// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_OriginGroup_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageAfdOriginGroupStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageAfdOriginGroupStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>Storage version of v1api20230501.HealthProbeParameters_STATUS The JSON object that contains the properties to send health probes to origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20230501storageAfdOriginGroupStatusHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20230501.LoadBalancingSettingsParameters_STATUS Round-Robin load balancing settings for a backend pool</summary>
    [JsonPropertyName("loadBalancingSettings")]
    public V1api20230501storageAfdOriginGroupStatusLoadBalancingSettings? LoadBalancingSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionAffinityState")]
    public string? SessionAffinityState { get; set; }

    /// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501storageAfdOriginGroupStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.AfdOriginGroup Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageAfdOriginGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageAfdOriginGroupSpec>, IStatus<V1api20230501storageAfdOriginGroupStatus>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "AfdOriginGroup";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigingroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_OriginGroup_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageAfdOriginGroupSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_OriginGroup_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230501storageAfdOriginGroupStatus? Status { get; set; }
}