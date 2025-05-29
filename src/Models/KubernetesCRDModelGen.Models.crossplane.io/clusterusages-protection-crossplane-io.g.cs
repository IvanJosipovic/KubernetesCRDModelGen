using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.protection.crossplane.io;
/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecByResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecByResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>By is the resource that is "using the other resource".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecBy
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1ClusterUsageSpecByResourceRef? ResourceRef { get; set; }

    /// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1ClusterUsageSpecByResourceSelector? ResourceSelector { get; set; }
}

/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecOfResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecOfResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Of is the resource that is "being used".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpecOf
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1ClusterUsageSpecOfResourceRef? ResourceRef { get; set; }

    /// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1ClusterUsageSpecOfResourceSelector? ResourceSelector { get; set; }
}

/// <summary>ClusterUsageSpec defines the desired state of a ClusterUsage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageSpec
{
    /// <summary>By is the resource that is "using the other resource".</summary>
    [JsonPropertyName("by")]
    public V1beta1ClusterUsageSpecBy? By { get; set; }

    /// <summary>Of is the resource that is "being used".</summary>
    [JsonPropertyName("of")]
    public V1beta1ClusterUsageSpecOf Of { get; set; }

    /// <summary>Reason is the reason for blocking deletion of the resource.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>ReplayDeletion will trigger a deletion on the used resource during the deletion of the usage itself, if it was attempted to be deleted at least once.</summary>
    [JsonPropertyName("replayDeletion")]
    public bool? ReplayDeletion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>UsageStatus defines the observed state of Usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterUsageStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterUsageStatusConditions>? Conditions { get; set; }
}

/// <summary>A ClusterUsage defines a deletion blocking relationship between two resources.  Usages prevent accidental deletion of a single resource or deletion of resources with dependent resources.  Read the Crossplane documentation for [more information about usages](https://docs.crossplane.io/latest/concepts/usages).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterUsage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterUsageSpec>, IStatus<V1beta1ClusterUsageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterUsage";
    public const string KubeGroup = "protection.crossplane.io";
    public const string KubePluralName = "clusterusages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterUsageSpec defines the desired state of a ClusterUsage.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterUsageSpec Spec { get; set; }

    /// <summary>UsageStatus defines the observed state of Usage.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterUsageStatus? Status { get; set; }
}

/// <summary>A ClusterUsage defines a deletion blocking relationship between two resources.  Usages prevent accidental deletion of a single resource or deletion of resources with dependent resources.  Read the Crossplane documentation for [more information about usages](https://docs.crossplane.io/latest/concepts/usages).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterUsageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ClusterUsage>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterUsageList";
    public const string KubeGroup = "protection.crossplane.io";
    public const string KubePluralName = "clusterusages";
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
    public IList<V1beta1ClusterUsage> Items { get; set; }
}