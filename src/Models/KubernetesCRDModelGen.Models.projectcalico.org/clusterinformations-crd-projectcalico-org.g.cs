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
public partial class V1ClusterInformationList : IKubernetesObject<V1ListMeta>, IItems<V1ClusterInformation>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterInformationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "clusterinformations";
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
    public IList<V1ClusterInformation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterInformationSpec
{
    /// <summary></summary>
    [JsonPropertyName("calicoVersion")]
    public string? CalicoVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterGUID")]
    public string? ClusterGUID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datastoreReady")]
    public bool? DatastoreReady { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variant")]
    public string? Variant { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterInformation : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterInformationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterInformation";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "clusterinformations";
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
    public V1ClusterInformationSpec? Spec { get; set; }
}
#nullable disable
