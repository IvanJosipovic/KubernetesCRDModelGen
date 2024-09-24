using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeExternalVPNGatewaySpecInterface
{
    /// <summary>Immutable. The numeric ID for this interface. Allowed values are based on the redundancy type of this external VPN gateway * '0 - SINGLE_IP_INTERNALLY_REDUNDANT' * '0, 1 - TWO_IPS_REDUNDANCY' * '0, 1, 2, 3 - FOUR_IPS_REDUNDANCY'.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Immutable. IP address of the interface in the external VPN gateway. Only IPv4 is supported. This IP address can be either from your on-premise gateway or another Cloud provider's VPN gateway, it cannot be an IP address from Google Compute Engine.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeExternalVPNGatewaySpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. A list of interfaces on this external VPN gateway.</summary>
    [JsonPropertyName("interface")]
    public IList<V1beta1ComputeExternalVPNGatewaySpecInterface>? Interface { get; set; }

    /// <summary>Immutable. Indicates the redundancy type of this external VPN gateway Possible values: ["FOUR_IPS_REDUNDANCY", "SINGLE_IP_INTERNALLY_REDUNDANT", "TWO_IPS_REDUNDANCY"].</summary>
    [JsonPropertyName("redundancyType")]
    public string? RedundancyType { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeExternalVPNGatewayStatusConditions
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
public partial class V1beta1ComputeExternalVPNGatewayStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeExternalVPNGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeExternalVPNGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeExternalVPNGatewaySpec>, IStatus<V1beta1ComputeExternalVPNGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeExternalVPNGateway";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeexternalvpngateways";
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
    public V1beta1ComputeExternalVPNGatewaySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeExternalVPNGatewayStatus? Status { get; set; }
}