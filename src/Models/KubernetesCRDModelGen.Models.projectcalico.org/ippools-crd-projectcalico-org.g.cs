using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPPoolList : IKubernetesObject<V1ListMeta>, IItems<V1IPPool>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPoolList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
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
    public IList<V1IPPool> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolSpecIpip
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolSpec
{
    /// <summary></summary>
    [JsonPropertyName("allowedUses")]
    public IList<string>? AllowedUses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assignmentMode")]
    public string? AssignmentMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blockSize")]
    public int? BlockSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableBGPExport")]
    public bool? DisableBGPExport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipip")]
    public V1IPPoolSpecIpip? Ipip { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipipMode")]
    public string? IpipMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nat-outgoing")]
    public bool? NatOutgoing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natOutgoing1")]
    public bool? NatOutgoing1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vxlanMode")]
    public string? VxlanMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPPoolSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPool";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
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
    public V1IPPoolSpec? Spec { get; set; }
}
#nullable disable
