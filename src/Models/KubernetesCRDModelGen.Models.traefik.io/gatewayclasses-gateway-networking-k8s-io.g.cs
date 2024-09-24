using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
public partial class V1GatewayClassSpecParametersRef
{
    /// <summary>Group is the group of the referent.</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>Kind is kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the referent. This field is required when referring to a Namespace-scoped resource and MUST be unset when referring to a Cluster-scoped resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1GatewayClassSpec
{
    /// <summary>ControllerName is the name of the controller that is managing Gateways of this class. The value of this field MUST be a domain prefixed path.   Example: "example.net/gateway-controller".   This field is not mutable and cannot be empty.   Support: Core</summary>
    [JsonPropertyName("controllerName")]
    public string ControllerName { get; set; }

    /// <summary>Description helps describe a GatewayClass with more details.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ParametersRef is a reference to a resource that contains the configuration parameters corresponding to the GatewayClass. This is optional if the controller does not require any additional configuration.   ParametersRef can reference a standard Kubernetes resource, i.e. ConfigMap, or an implementation-specific custom resource. The resource can be cluster-scoped or namespace-scoped.   If the referent cannot be found, the GatewayClass's "InvalidParameters" status condition will be true.   A Gateway for this GatewayClass may provide its own `parametersRef`. When both are specified, the merging behavior is implementation specific. It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.   Support: Implementation-specific</summary>
    [JsonPropertyName("parametersRef")]
    public V1GatewayClassSpecParametersRef? ParametersRef { get; set; }
}

public enum V1GatewayClassStatusConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

public partial class V1GatewayClassStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1GatewayClassStatusConditionsStatusEnum>))]
    public V1GatewayClassStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1GatewayClassStatus
{
    /// <summary>Conditions is the current status from the controller for this GatewayClass.   Controllers should prefer to publish conditions using values of GatewayClassConditionType for the type of each Condition.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GatewayClassStatusConditions>? Conditions { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GatewayClass : IKubernetesObject<V1ObjectMeta>, ISpec<V1GatewayClassSpec>, IStatus<V1GatewayClassStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GatewayClass";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gatewayclasses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of GatewayClass.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayClassSpec Spec { get; set; }

    /// <summary>Status defines the current state of GatewayClass.   Implementations MUST populate status on all GatewayClass resources which specify their controller name.</summary>
    [JsonPropertyName("status")]
    public V1GatewayClassStatus? Status { get; set; }
}