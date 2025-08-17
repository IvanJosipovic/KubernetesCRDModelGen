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
public partial class V1CalicoNodeStatusList : IKubernetesObject<V1ListMeta>, IItems<V1CalicoNodeStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CalicoNodeStatusList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "caliconodestatuses";
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
    public IList<V1CalicoNodeStatus> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusSpec
{
    /// <summary></summary>
    [JsonPropertyName("classes")]
    public IList<string>? Classes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatePeriodSeconds")]
    public int? UpdatePeriodSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV4
{
    /// <summary></summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV6
{
    /// <summary></summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgent
{
    /// <summary></summary>
    [JsonPropertyName("birdV4")]
    public V1CalicoNodeStatusStatusAgentBirdV4? BirdV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("birdV6")]
    public V1CalicoNodeStatusStatusAgentBirdV6? BirdV6 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV4
{
    /// <summary></summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV6
{
    /// <summary></summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgp
{
    /// <summary></summary>
    [JsonPropertyName("numberEstablishedV4")]
    public int NumberEstablishedV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numberEstablishedV6")]
    public int NumberEstablishedV6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numberNotEstablishedV4")]
    public int NumberNotEstablishedV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numberNotEstablishedV6")]
    public int NumberNotEstablishedV6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peersV4")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV4>? PeersV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peersV6")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV6>? PeersV6 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom
{
    /// <summary></summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom? LearnedFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom
{
    /// <summary></summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom? LearnedFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutes
{
    /// <summary></summary>
    [JsonPropertyName("routesV4")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV4>? RoutesV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routesV6")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV6>? RoutesV6 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatus
{
    /// <summary></summary>
    [JsonPropertyName("agent")]
    public V1CalicoNodeStatusStatusAgent? Agent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bgp")]
    public V1CalicoNodeStatusStatusBgp? Bgp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routes")]
    public V1CalicoNodeStatusStatusRoutes? Routes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CalicoNodeStatus : IKubernetesObject<V1ObjectMeta>, ISpec<V1CalicoNodeStatusSpec>, IStatus<V1CalicoNodeStatusStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CalicoNodeStatus";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "caliconodestatuses";
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
    public V1CalicoNodeStatusSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1CalicoNodeStatusStatus? Status { get; set; }
}
#nullable disable
