using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeRegionSSLPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeRegionSSLPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeRegionSSLPolicyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionsslpolicies";
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
    public IList<V1alpha1ComputeRegionSSLPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionSSLPolicySpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionSSLPolicySpec
{
    /// <summary>A list of features enabled when the selected profile is CUSTOM. The method returns the set of features that can be specified in this list. This field must be empty if the profile is not CUSTOM.  See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport) for which ciphers are available to use. **Note**: this argument *must* be present when using the 'CUSTOM' profile. This argument *must not* be present when using any other profile.</summary>
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

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeRegionSSLPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The region where the regional SSL policy resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionSSLPolicyStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionSSLPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeRegionSSLPolicyStatusConditions>? Conditions { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeRegionSSLPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeRegionSSLPolicySpec>, IStatus<V1alpha1ComputeRegionSSLPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeRegionSSLPolicy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionsslpolicies";
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
    public V1alpha1ComputeRegionSSLPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeRegionSSLPolicyStatus? Status { get; set; }
}
#nullable disable
