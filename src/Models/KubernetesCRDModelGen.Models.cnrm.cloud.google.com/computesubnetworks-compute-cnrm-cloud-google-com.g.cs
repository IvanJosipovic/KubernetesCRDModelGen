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
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSubnetworkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeSubnetwork>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSubnetworkList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesubnetworks";
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
    public IList<V1beta1ComputeSubnetwork> Items { get; set; }
}

/// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn't supported if the subnet 'purpose' field is set to subnetwork is 'REGIONAL_MANAGED_PROXY' or 'GLOBAL_MANAGED_PROXY'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpecLogConfig
{
    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Toggles the aggregation interval for collecting flow logs. Increasing the interval time will reduce the amount of generated flow logs for long lasting connections. Default is an interval of 5 seconds per connection. Default value: "INTERVAL_5_SEC" Possible values: ["INTERVAL_5_SEC", "INTERVAL_30_SEC", "INTERVAL_1_MIN", "INTERVAL_5_MIN", "INTERVAL_10_MIN", "INTERVAL_15_MIN"].</summary>
    [JsonPropertyName("aggregationInterval")]
    public string? AggregationInterval { get; set; }

    /// <summary>Export filter used to define which VPC flow logs should be logged, as as CEL expression. See https://cloud.google.com/vpc/docs/flow-logs#filtering for details on how to format this field. The default value is 'true', which evaluates to include everything.</summary>
    [JsonPropertyName("filterExpr")]
    public string? FilterExpr { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. The value of the field must be in [0, 1]. Set the sampling rate of VPC flow logs within the subnetwork where 1.0 means all collected logs are reported and 0.0 means no logs are reported. Default is 0.5 which means half of all collected logs are reported.</summary>
    [JsonPropertyName("flowSampling")]
    public double? FlowSampling { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Configures whether metadata fields should be added to the reported VPC flow logs. Default value: "INCLUDE_ALL_METADATA" Possible values: ["EXCLUDE_ALL_METADATA", "INCLUDE_ALL_METADATA", "CUSTOM_METADATA"].</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>List of metadata fields that should be added to reported logs. Can only be specified if VPC flow logs for this subnetwork is enabled and "metadata" is set to CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadataFields")]
    public IList<string>? MetadataFields { get; set; }
}

/// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
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
public partial class V1beta1ComputeSubnetworkSpecSecondaryIpRange
{
    /// <summary>The range of IP addresses belonging to this subnetwork secondary range. Provide this property when you create the subnetwork. Ranges must be unique and non-overlapping with all primary and secondary IP ranges within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string IpCidrRange { get; set; }

    /// <summary>The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM instance. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the subnetwork.</summary>
    [JsonPropertyName("rangeName")]
    public string RangeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpec
{
    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The range of internal addresses that are owned by this subnetwork. Provide this property when you create the subnetwork. For example, 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and non-overlapping within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string IpCidrRange { get; set; }

    /// <summary>The access type of IPv6 address this subnet holds. It's immutable and can only be specified during creation or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet cannot enable direct path. Possible values: ["EXTERNAL", "INTERNAL"].</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn't supported if the subnet 'purpose' field is set to subnetwork is 'REGIONAL_MANAGED_PROXY' or 'GLOBAL_MANAGED_PROXY'.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeSubnetworkSpecLogConfig? LogConfig { get; set; }

    /// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeSubnetworkSpecNetworkRef NetworkRef { get; set; }

    /// <summary>When enabled, VMs in this subnetwork without external IP addresses can access Google APIs and services by using Private Google Access.</summary>
    [JsonPropertyName("privateIpGoogleAccess")]
    public bool? PrivateIpGoogleAccess { get; set; }

    /// <summary>The private IPv6 google access type for the VMs in this subnet.</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Immutable. The purpose of the resource. This field can be either 'PRIVATE_RFC_1918', 'REGIONAL_MANAGED_PROXY', 'GLOBAL_MANAGED_PROXY', or 'PRIVATE_SERVICE_CONNECT'. A subnet with purpose set to 'REGIONAL_MANAGED_PROXY' is a user-created subnetwork that is reserved for regional Envoy-based load balancers. A subnetwork in a given region with purpose set to 'GLOBAL_MANAGED_PROXY' is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers. A subnetwork with purpose set to 'PRIVATE_SERVICE_CONNECT' reserves the subnet for hosting a Private Service Connect published service. Note that 'REGIONAL_MANAGED_PROXY' is the preferred setting for all regional Envoy load balancers. If unspecified, the purpose defaults to 'PRIVATE_RFC_1918'.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Immutable. The GCP region for this subnetwork.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The role of subnetwork. Currently, this field is only used when 'purpose' is 'REGIONAL_MANAGED_PROXY'. The value can be set to 'ACTIVE' or 'BACKUP'. An 'ACTIVE' subnetwork is one that is currently being used for Envoy-based load balancers in a region. A 'BACKUP' subnetwork is one that is ready to be promoted to 'ACTIVE' or is currently draining. Possible values: ["ACTIVE", "BACKUP"].</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryIpRange")]
    public IList<V1beta1ComputeSubnetworkSpecSecondaryIpRange>? SecondaryIpRange { get; set; }

    /// <summary>The stack type for this subnet to identify whether the IPv6 feature is enabled or not. If not specified IPV4_ONLY will be used. Possible values: ["IPV4_ONLY", "IPV4_IPV6"].</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkStatusConditions
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
public partial class V1beta1ComputeSubnetworkStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSubnetworkStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The range of external IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("externalIpv6Prefix")]
    public string? ExternalIpv6Prefix { get; set; }

    /// <summary>DEPRECATED. This field is not useful for users, and has been removed as an output. Fingerprint of this resource. This field is used internally during updates of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The gateway address for default routes to reach destination addresses outside this subnetwork.</summary>
    [JsonPropertyName("gatewayAddress")]
    public string? GatewayAddress { get; set; }

    /// <summary>The internal IPv6 address range that is assigned to this subnetwork.</summary>
    [JsonPropertyName("internalIpv6Prefix")]
    public string? InternalIpv6Prefix { get; set; }

    /// <summary>The range of internal IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("ipv6CidrRange")]
    public string? Ipv6CidrRange { get; set; }

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
public partial class V1beta1ComputeSubnetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSubnetworkSpec>, IStatus<V1beta1ComputeSubnetworkStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSubnetwork";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesubnetworks";
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
    public V1beta1ComputeSubnetworkSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSubnetworkStatus? Status { get; set; }
}