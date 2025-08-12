using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
/// <summary>Configuration affecting VMs onboarded into the mesh. See more details at: https://istio.io/docs/reference/config/networking/workload-entry.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadEntrySpec
{
    /// <summary>Address associated with the network endpoint without the port.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>One or more labels associated with the endpoint.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The locality associated with the endpoint.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Network enables Istio to group endpoints resident in the same L3 domain/network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Set of ports associated with the endpoint.</summary>
    [JsonPropertyName("ports")]
    public IDictionary<string, int>? Ports { get; set; }

    /// <summary>The service account associated with the workload if a sidecar is present in the workload.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The load balancing weight associated with the endpoint.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1WorkloadEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V1WorkloadEntrySpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "WorkloadEntry";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "workloadentries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting VMs onboarded into the mesh. See more details at: https://istio.io/docs/reference/config/networking/workload-entry.html</summary>
    [JsonPropertyName("spec")]
    public V1WorkloadEntrySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1WorkloadEntryList : IKubernetesObject<V1ListMeta>, IItems<V1WorkloadEntry>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "WorkloadEntryList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "workloadentries";
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
    public IList<V1WorkloadEntry> Items { get; set; }
}