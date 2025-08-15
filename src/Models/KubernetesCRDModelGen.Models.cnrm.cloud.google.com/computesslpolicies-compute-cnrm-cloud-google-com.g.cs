using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSSLPolicySpec
{
    /// <summary>Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. This can be one of 'COMPATIBLE', 'MODERN', 'RESTRICTED', or 'CUSTOM'. If using 'CUSTOM', the set of SSL features to enable must be specified in the 'customFeatures' field.  See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for which ciphers are available to use. **Note**: this argument *must* be present when using the 'CUSTOM' profile. This argument *must not* be present when using any other profile.</summary>
    [JsonPropertyName("customFeatures")]
    public IList<string>? CustomFeatures { get; set; }

    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The minimum version of SSL protocol that can be used by the clients to establish a connection with the load balancer. Default value: "TLS_1_0" Possible values: ["TLS_1_0", "TLS_1_1", "TLS_1_2"].</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>Profile specifies the set of SSL features that can be used by the load balancer when negotiating SSL with clients. If using 'CUSTOM', the set of SSL features to enable must be specified in the 'customFeatures' field.  See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for information on what cipher suites each profile provides. If 'CUSTOM' is used, the 'custom_features' attribute **must be set**. Default value: "COMPATIBLE" Possible values: ["COMPATIBLE", "MODERN", "RESTRICTED", "CUSTOM"].</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSSLPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSSLPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSSLPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The list of features enabled in the SSL policy.</summary>
    [JsonPropertyName("enabledFeatures")]
    public IList<string>? EnabledFeatures { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSSLPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSSLPolicySpec>, IStatus<V1beta1ComputeSSLPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSSLPolicy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesslpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeSSLPolicySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSSLPolicyStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSSLPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeSSLPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSSLPolicyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesslpolicies";
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
    public IList<V1beta1ComputeSSLPolicy> Items { get; set; }
}