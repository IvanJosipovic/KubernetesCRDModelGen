using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgenetwork.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkSubnetSpecNetworkRef
{
    /// <summary>Allowed value: The `name` field of an `EdgeNetworkNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkSubnetSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkSubnetSpec
{
    /// <summary>Immutable. A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The ranges of ipv4 addresses that are owned by this subnetwork, in CIDR format.</summary>
    [JsonPropertyName("ipv4Cidr")]
    public IList<string>? Ipv4Cidr { get; set; }

    /// <summary>Immutable. The ranges of ipv6 addresses that are owned by this subnetwork, in CIDR format.</summary>
    [JsonPropertyName("ipv6Cidr")]
    public IList<string>? Ipv6Cidr { get; set; }

    /// <summary>Immutable. The Google Cloud region to which the target Distributed Cloud Edge zone belongs.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public V1beta1EdgeNetworkSubnetSpecNetworkRef NetworkRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EdgeNetworkSubnetSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The subnetId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. VLAN ID for this subnetwork. If not specified, one is assigned automatically.</summary>
    [JsonPropertyName("vlanId")]
    public int? VlanId { get; set; }

    /// <summary>Immutable. The name of the target Distributed Cloud Edge zone.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkSubnetStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkSubnetStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EdgeNetworkSubnetStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the subnet was created. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: '2014-10-02T15:01:23Z' and '2014-10-02T15:01:23.045123456Z'.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The canonical name of this resource, with format 'projects/{{project}}/locations/{{location}}/zones/{{zone}}/subnets/{{subnet_id}}'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Current stage of the resource to the device by config push.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The time when the subnet was last updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: '2014-10-02T15:01:23Z' and '2014-10-02T15:01:23.045123456Z'.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeNetworkSubnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EdgeNetworkSubnetSpec>, IStatus<V1beta1EdgeNetworkSubnetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeNetworkSubnet";
    public const string KubeGroup = "edgenetwork.cnrm.cloud.google.com";
    public const string KubePluralName = "edgenetworksubnets";
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
    public V1beta1EdgeNetworkSubnetSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1EdgeNetworkSubnetStatus? Status { get; set; }
}