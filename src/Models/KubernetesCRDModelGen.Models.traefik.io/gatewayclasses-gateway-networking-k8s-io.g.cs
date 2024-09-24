using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
/// <summary>ParametersRef is a reference to a resource that contains the configuration parameters corresponding to the GatewayClass. This is optional if the controller does not require any additional configuration.   ParametersRef can reference a standard Kubernetes resource, i.e. ConfigMap, or an implementation-specific custom resource. The resource can be cluster-scoped or namespace-scoped.   If the referent cannot be found, the GatewayClass's "InvalidParameters" status condition will be true.   A Gateway for this GatewayClass may provide its own `parametersRef`. When both are specified, the merging behavior is implementation specific. It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.   Support: Implementation-specific</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Spec defines the desired state of GatewayClass.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
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

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Status defines the current state of GatewayClass.   Implementations MUST populate status on all GatewayClass resources which specify their controller name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayClassStatus
{
    /// <summary>Conditions is the current status from the controller for this GatewayClass.   Controllers should prefer to publish conditions using values of GatewayClassConditionType for the type of each Condition.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GatewayClassStatusConditions>? Conditions { get; set; }
}

/// <summary>GatewayClass describes a class of Gateways available to the user for creating Gateway resources.   It is recommended that this resource be used as a template for Gateways. This means that a Gateway is based on the state of the GatewayClass at the time it was created and changes to the GatewayClass or associated parameters are not propagated down to existing Gateways. This recommendation is intended to limit the blast radius of changes to GatewayClass or associated parameters. If implementations choose to propagate GatewayClass changes to existing Gateways, that MUST be clearly documented by the implementation.   Whenever one or more Gateways are using a GatewayClass, implementations SHOULD add the `gateway-exists-finalizer.gateway.networking.k8s.io` finalizer on the associated GatewayClass. This ensures that a GatewayClass associated with a Gateway is not deleted while in use.   GatewayClass is a Cluster level resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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