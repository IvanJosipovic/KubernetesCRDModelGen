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

/// <summary>IPAMBlockSpec contains the specification for an IPAMBlock resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMBlockSpec
{
    /// <summary>Affinity of the block, if this block has one. If set, it will be of the form "host:&lt;hostname&gt;". If not set, this block is not affine to a host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>Array of allocations in-use within this block. nil entries mean the allocation is free. For non-nil entries at index i, the index is the ordinal of the allocation within this block and the value is the index of the associated attributes in the Attributes array.</summary>
    [JsonPropertyName("allocations")]
    public IList<int> Allocations { get; set; }

    /// <summary>Attributes is an array of arbitrary metadata associated with allocations in the block. To find attributes for a given allocation, use the value of the allocation's entry in the Allocations array as the index of the element in this array.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1IPAMBlockSpecAttributes> Attributes { get; set; }

    /// <summary>The block's CIDR.</summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary>Deleted is an internal boolean used to workaround a limitation in the Kubernetes API whereby deletion will not return a conflict error if the block has been updated. It should not be set manually.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>We store a sequence number that is updated each time the block is written. Each allocation will also store the sequence number of the block at the time of its creation. When releasing an IP, passing the sequence number associated with the allocation allows us to protect against a race condition and ensure the IP hasn't been released and re-allocated since the release request.</summary>
    [JsonPropertyName("sequenceNumber")]
    public long? SequenceNumber { get; set; }

    /// <summary>Map of allocated ordinal within the block to sequence number of the block at the time of allocation. Kubernetes does not allow numerical keys for maps, so the key is cast to a string.</summary>
    [JsonPropertyName("sequenceNumberForAllocation")]
    public IDictionary<string, long>? SequenceNumberForAllocation { get; set; }

    /// <summary>StrictAffinity on the IPAMBlock is deprecated and no longer used by the code. Use IPAMConfig StrictAffinity instead.</summary>
    [JsonPropertyName("strictAffinity")]
    public bool StrictAffinity { get; set; }

    /// <summary>Unallocated is an ordered list of allocations which are free in the block.</summary>
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

    /// <summary>IPAMBlockSpec contains the specification for an IPAMBlock resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPAMBlockSpec? Spec { get; set; }
}