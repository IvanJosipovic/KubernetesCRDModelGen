using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>IPReservationSpec contains the specification for an IPReservation resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPReservationSpec
{
    /// <summary>ReservedCIDRs is a list of CIDRs and/or IP addresses that Calico IPAM will exclude from new allocations.</summary>
    [JsonPropertyName("reservedCIDRs")]
    public IList<string>? ReservedCIDRs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPReservationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPReservation";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipreservations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IPReservationSpec contains the specification for an IPReservation resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPReservationSpec? Spec { get; set; }
}