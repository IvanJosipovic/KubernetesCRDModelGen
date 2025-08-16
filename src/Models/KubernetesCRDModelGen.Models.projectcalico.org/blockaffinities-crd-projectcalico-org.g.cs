using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BlockAffinityList : IKubernetesObject<V1ListMeta>, IItems<V1BlockAffinity>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BlockAffinityList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "blockaffinities";
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
    public IList<V1BlockAffinity> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BlockAffinitySpec
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public string Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("node")]
    public string Node { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BlockAffinity : IKubernetesObject<V1ObjectMeta>, ISpec<V1BlockAffinitySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BlockAffinity";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "blockaffinities";
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
    public V1BlockAffinitySpec? Spec { get; set; }
}