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
public partial class V1IPAMBlockSpecAttributes
{
    /// <summary></summary>
    [JsonPropertyName("handle_id")]
    public string? HandleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondary")]
    public IDictionary<string, string>? Secondary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMBlockSpec
{
    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allocations")]
    public IList<int> Allocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("attributes")]
    public IList<V1IPAMBlockSpecAttributes> Attributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceNumber")]
    public long? SequenceNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceNumberForAllocation")]
    public IDictionary<string, long>? SequenceNumberForAllocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strictAffinity")]
    public bool StrictAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unallocated")]
    public IList<int> Unallocated { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMBlock : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPAMBlockSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMBlock";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamblocks";
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
    public V1IPAMBlockSpec? Spec { get; set; }
}