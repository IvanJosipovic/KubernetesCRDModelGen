using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.protection.crossplane.io;
#nullable enable
/// <summary>A Usage defines a deletion blocking relationship between two resources.  Usages prevent accidental deletion of a single resource or deletion of resources with dependent resources.  Read the Crossplane documentation for [more information about Compositions](https://docs.crossplane.io/latest/concepts/usages).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UsageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Usage>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UsageList";
    public const string KubeGroup = "protection.crossplane.io";
    public const string KubePluralName = "usages";
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
    public IList<V1beta1Usage> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecByResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecByResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>By is the resource that is "using the other resource".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecBy
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1UsageSpecByResourceRef? ResourceRef { get; set; }

    /// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1UsageSpecByResourceSelector? ResourceSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecOfResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecOfResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace ensures an object in the supplied namespace is selected. Omit namespace to only match resources in the Usage's namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Of is the resource that is "being used".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpecOf
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1UsageSpecOfResourceRef? ResourceRef { get; set; }

    /// <summary>Selector to the resource. This field will be ignored if ResourceRef is set.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1UsageSpecOfResourceSelector? ResourceSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>UsageSpec defines the desired state of Usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageSpec
{
    /// <summary>By is the resource that is "using the other resource".</summary>
    [JsonPropertyName("by")]
    public V1beta1UsageSpecBy? By { get; set; }

    /// <summary>Of is the resource that is "being used".</summary>
    [JsonPropertyName("of")]
    public V1beta1UsageSpecOf Of { get; set; }

    /// <summary>Reason is the reason for blocking deletion of the resource.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>ReplayDeletion will trigger a deletion on the used resource during the deletion of the usage itself, if it was attempted to be deleted at least once.</summary>
    [JsonPropertyName("replayDeletion")]
    public bool? ReplayDeletion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageStatusConditions
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
#nullable disable

#nullable enable
/// <summary>UsageStatus defines the observed state of Usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UsageStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UsageStatusConditions>? Conditions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Usage defines a deletion blocking relationship between two resources.  Usages prevent accidental deletion of a single resource or deletion of resources with dependent resources.  Read the Crossplane documentation for [more information about Compositions](https://docs.crossplane.io/latest/concepts/usages).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Usage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UsageSpec>, IStatus<V1beta1UsageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Usage";
    public const string KubeGroup = "protection.crossplane.io";
    public const string KubePluralName = "usages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UsageSpec defines the desired state of Usage.</summary>
    [JsonPropertyName("spec")]
    public V1beta1UsageSpec Spec { get; set; }

    /// <summary>UsageStatus defines the observed state of Usage.</summary>
    [JsonPropertyName("status")]
    public V1beta1UsageStatus? Status { get; set; }
}
#nullable disable
