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
public partial class V1IPAMConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("autoAllocateBlocks")]
    public bool AutoAllocateBlocks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxBlocksPerHost")]
    public int? MaxBlocksPerHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strictAffinity")]
    public bool StrictAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPAMConfigSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMConfig";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamconfigs";
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
    public V1IPAMConfigSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMConfigList : IKubernetesObject<V1ListMeta>, IItems<V1IPAMConfig>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMConfigList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamconfigs";
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
    public IList<V1IPAMConfig> Items { get; set; }
}