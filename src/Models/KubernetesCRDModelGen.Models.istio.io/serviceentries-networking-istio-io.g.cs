using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
public partial class V1beta1ServiceEntrySpecEndpoints
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

public enum V1beta1ServiceEntrySpecLocationEnum
{
    [EnumMember(Value = "MESH_EXTERNAL"), JsonStringEnumMemberName("MESH_EXTERNAL")]
    /// <summary>MESH_EXTERNAL</summary>
    MESHEXTERNAL,
    [EnumMember(Value = "MESH_INTERNAL"), JsonStringEnumMemberName("MESH_INTERNAL")]
    /// <summary>MESH_INTERNAL</summary>
    MESHINTERNAL
}

public partial class V1beta1ServiceEntrySpecPorts
{
    /// <summary>Label assigned to the port.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A valid non-negative integer port number.</summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>The protocol exposed on the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The port number on the endpoint where the traffic will be received.</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

public enum V1beta1ServiceEntrySpecResolutionEnum
{
    [EnumMember(Value = "NONE"), JsonStringEnumMemberName("NONE")]
    /// <summary>NONE</summary>
    NONE,
    [EnumMember(Value = "STATIC"), JsonStringEnumMemberName("STATIC")]
    /// <summary>STATIC</summary>
    STATIC,
    [EnumMember(Value = "DNS"), JsonStringEnumMemberName("DNS")]
    /// <summary>DNS</summary>
    DNS,
    [EnumMember(Value = "DNS_ROUND_ROBIN"), JsonStringEnumMemberName("DNS_ROUND_ROBIN")]
    /// <summary>DNS_ROUND_ROBIN</summary>
    DNSROUNDROBIN
}

public partial class V1beta1ServiceEntrySpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

public partial class V1beta1ServiceEntrySpec
{
    /// <summary>The virtual IP addresses associated with the service.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    /// <summary>One or more endpoints associated with the service.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1beta1ServiceEntrySpecEndpoints>? Endpoints { get; set; }

    /// <summary>A list of namespaces to which this service is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The hosts associated with the ServiceEntry.</summary>
    [JsonPropertyName("hosts")]
    public IList<string> Hosts { get; set; }

    /// <summary>Specify whether the service should be considered external to the mesh or part of the mesh.  Valid Options: MESH_EXTERNAL, MESH_INTERNAL</summary>
    [JsonPropertyName("location")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceEntrySpecLocationEnum>))]
    public V1beta1ServiceEntrySpecLocationEnum? Location { get; set; }

    /// <summary>The ports associated with the external service.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1ServiceEntrySpecPorts>? Ports { get; set; }

    /// <summary>Service resolution mode for the hosts.  Valid Options: NONE, STATIC, DNS, DNS_ROUND_ROBIN</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceEntrySpecResolutionEnum>))]
    public V1beta1ServiceEntrySpecResolutionEnum? Resolution { get; set; }

    /// <summary>If specified, the proxy will verify that the server certificate's subject alternate name matches one of the specified values.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }

    /// <summary>Applicable only for MESH_INTERNAL services.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1beta1ServiceEntrySpecWorkloadSelector? WorkloadSelector { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceEntrySpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceEntry";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "serviceentries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting service registry. See more details at: https://istio.io/docs/reference/config/networking/service-entry.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceEntrySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}