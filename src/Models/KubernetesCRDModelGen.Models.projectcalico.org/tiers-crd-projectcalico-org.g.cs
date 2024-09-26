using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>TierSpec contains the specification for a security policy tier resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TierSpec
{
    /// <summary>DefaultAction specifies the action applied to workloads selected by a policy in the tier, but not rule matched the workload's traffic. [Default: Deny]</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>Order is an optional field that specifies the order in which the tier is applied. Tiers with higher "order" are applied after those with lower order.  If the order is omitted, it may be considered to be "infinite" - i.e. the tier will be applied last.  Tiers with identical order will be applied in alphanumerical order based on the Tier "Name".</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Tier : IKubernetesObject<V1ObjectMeta>, ISpec<V1TierSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Tier";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "tiers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TierSpec contains the specification for a security policy tier resource.</summary>
    [JsonPropertyName("spec")]
    public V1TierSpec? Spec { get; set; }
}