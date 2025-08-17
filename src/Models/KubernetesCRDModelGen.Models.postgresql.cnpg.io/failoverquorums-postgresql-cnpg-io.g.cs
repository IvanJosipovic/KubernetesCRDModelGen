using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
#nullable enable
/// <summary>FailoverQuorum contains the information about the current failover quorum status of a PG cluster. It is updated by the instance manager of the primary node and reset to zero by the operator to trigger an update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FailoverQuorumList : IKubernetesObject<V1ListMeta>, IItems<V1FailoverQuorum>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FailoverQuorumList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "failoverquorums";
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
    public IList<V1FailoverQuorum> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Most recently observed status of the failover quorum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FailoverQuorumStatus
{
    /// <summary>Contains the latest reported Method value.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Primary is the name of the primary instance that updated this object the latest time.</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>StandbyNames is the list of potentially synchronous instance names.</summary>
    [JsonPropertyName("standbyNames")]
    public IList<string>? StandbyNames { get; set; }

    /// <summary>StandbyNumber is the number of synchronous standbys that transactions need to wait for replies from.</summary>
    [JsonPropertyName("standbyNumber")]
    public int? StandbyNumber { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FailoverQuorum contains the information about the current failover quorum status of a PG cluster. It is updated by the instance manager of the primary node and reset to zero by the operator to trigger an update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FailoverQuorum : IKubernetesObject<V1ObjectMeta>, IStatus<V1FailoverQuorumStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FailoverQuorum";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "failoverquorums";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Most recently observed status of the failover quorum.</summary>
    [JsonPropertyName("status")]
    public V1FailoverQuorumStatus? Status { get; set; }
}
#nullable disable
