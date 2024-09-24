using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>NetworkSetSpec contains the specification for a NetworkSet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkSetSpec
{
    /// <summary>The list of IP networks that belong to this set.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }
}

/// <summary>NetworkSet is the Namespaced-equivalent of the GlobalNetworkSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1NetworkSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1NetworkSetSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "NetworkSet";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "networksets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSetSpec contains the specification for a NetworkSet resource.</summary>
    [JsonPropertyName("spec")]
    public V1NetworkSetSpec? Spec { get; set; }
}