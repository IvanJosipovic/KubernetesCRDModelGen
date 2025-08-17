using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
#nullable enable
/// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint Generator information: - Generated from: /trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/trafficmanager.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/AzureEndpoints/{endpointName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1api20220401storageTrafficManagerProfilesAzureEndpoint>
{
    public const string KubeApiVersion = "v1api20220401storage";
    public const string KubeKind = "TrafficManagerProfilesAzureEndpointList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofilesazureendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpoint> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.EndpointProperties_CustomHeaders</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecCustomHeaders
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
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpointOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/TrafficManagerProfile resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.EndpointProperties_Subnets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecSubnets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("first")]
    public string? First { get; set; }

    /// <summary></summary>
    [JsonPropertyName("last")]
    public string? Last { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public int? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TargetResourceReference: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpecTargetResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alwaysServe")]
    public string? AlwaysServe { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointSpecCustomHeaders>? CustomHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointLocation")]
    public string? EndpointLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointMonitorStatus")]
    public string? EndpointMonitorStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointStatus")]
    public string? EndpointStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("geoMapping")]
    public IList<string>? GeoMapping { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpoints")]
    public int? MinChildEndpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpointsIPv4")]
    public int? MinChildEndpointsIPv4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpointsIPv6")]
    public int? MinChildEndpointsIPv6 { get; set; }

    /// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpointOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/TrafficManagerProfile resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220401storageTrafficManagerProfilesAzureEndpointSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnets")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointSpecSubnets>? Subnets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>TargetResourceReference: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.</summary>
    [JsonPropertyName("targetResourceReference")]
    public V1api20220401storageTrafficManagerProfilesAzureEndpointSpecTargetResourceReference? TargetResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.EndpointProperties_CustomHeaders_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointStatusCustomHeaders
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.EndpointProperties_Subnets_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointStatusSubnets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("first")]
    public string? First { get; set; }

    /// <summary></summary>
    [JsonPropertyName("last")]
    public string? Last { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public int? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpointStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alwaysServe")]
    public string? AlwaysServe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointStatusCustomHeaders>? CustomHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointLocation")]
    public string? EndpointLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointMonitorStatus")]
    public string? EndpointMonitorStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointStatus")]
    public string? EndpointStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("geoMapping")]
    public IList<string>? GeoMapping { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpoints")]
    public int? MinChildEndpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpointsIPv4")]
    public int? MinChildEndpointsIPv4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minChildEndpointsIPv6")]
    public int? MinChildEndpointsIPv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnets")]
    public IList<V1api20220401storageTrafficManagerProfilesAzureEndpointStatusSubnets>? Subnets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint Generator information: - Generated from: /trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/trafficmanager.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/AzureEndpoints/{endpointName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401storageTrafficManagerProfilesAzureEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220401storageTrafficManagerProfilesAzureEndpointSpec>, IStatus<V1api20220401storageTrafficManagerProfilesAzureEndpointStatus>
{
    public const string KubeApiVersion = "v1api20220401storage";
    public const string KubeKind = "TrafficManagerProfilesAzureEndpoint";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofilesazureendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220401storageTrafficManagerProfilesAzureEndpointSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220401.TrafficManagerProfilesAzureEndpoint_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220401storageTrafficManagerProfilesAzureEndpointStatus? Status { get; set; }
}
#nullable disable
