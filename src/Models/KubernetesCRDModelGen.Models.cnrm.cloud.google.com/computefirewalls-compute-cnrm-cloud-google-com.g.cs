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
public partial class V1beta1ComputeFirewallList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeFirewall>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeFirewallList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computefirewalls";
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
    public IList<V1beta1ComputeFirewall> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecAllow
{
    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.  Example inputs include: ["22"], ["80","443"], and ["12345-12349"].</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, sctp, ipip, all), or the IP protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecDeny
{
    /// <summary>An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.  Example inputs include: ["22"], ["80","443"], and ["12345-12349"].</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule. This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, sctp, ipip, all), or the IP protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary>This field denotes the logging options for a particular firewall rule. If defined, logging is enabled, and logs will be exported to Cloud Logging.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecLogConfig
{
    /// <summary>This field denotes whether to include or exclude metadata for firewall logs. Possible values: ["EXCLUDE_ALL_METADATA", "INCLUDE_ALL_METADATA"].</summary>
    [JsonPropertyName("metadata")]
    public string Metadata { get; set; }
}

/// <summary>The network to attach this firewall to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecNetworkRef
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

/// <summary>If source service accounts are specified, the firewall will apply only to traffic originating from an instance with a service account in this list. Source service accounts cannot be used to control traffic to an instance's external IP address because service accounts are associated with an instance, not an IP address. sourceRanges can be set at the same time as sourceServiceAccounts. If both are set, the firewall will apply to traffic that has source IP address within sourceRanges OR the source IP belongs to an instance with service account listed in sourceServiceAccount. The connection does not need to match both properties for the firewall to apply. sourceServiceAccounts cannot be used at the same time as sourceTags or targetTags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecSourceServiceAccounts
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of service accounts indicating sets of instances located in the network that may make network connections as specified in allowed[]. targetServiceAccounts cannot be used at the same time as targetTags or sourceTags. If neither targetServiceAccounts nor targetTags are specified, the firewall rule applies to all instances on the specified network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallSpecTargetServiceAccounts
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
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
public partial class V1beta1ComputeFirewallSpec
{
    /// <summary>The list of ALLOW rules specified by this firewall. Each rule specifies a protocol and port-range tuple that describes a permitted connection.</summary>
    [JsonPropertyName("allow")]
    public IList<V1beta1ComputeFirewallSpecAllow>? Allow { get; set; }

    /// <summary>The list of DENY rules specified by this firewall. Each rule specifies a protocol and port-range tuple that describes a denied connection.</summary>
    [JsonPropertyName("deny")]
    public IList<V1beta1ComputeFirewallSpecDeny>? Deny { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If destination ranges are specified, the firewall will apply only to traffic that has destination IP address in these ranges. These ranges must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.</summary>
    [JsonPropertyName("destinationRanges")]
    public IList<string>? DestinationRanges { get; set; }

    /// <summary>Immutable. Direction of traffic to which this firewall applies; default is INGRESS. Note: For INGRESS traffic, one of 'source_ranges', 'source_tags' or 'source_service_accounts' is required. Possible values: ["INGRESS", "EGRESS"].</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Denotes whether the firewall rule is disabled, i.e not applied to the network it is associated with. When set to true, the firewall rule is not enforced and the network behaves as if it did not exist. If this is unspecified, the firewall rule will be enabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>DEPRECATED. Deprecated in favor of log_config. This field denotes whether to enable logging for a particular firewall rule. If logging is enabled, logs will be exported to Stackdriver.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>This field denotes the logging options for a particular firewall rule. If defined, logging is enabled, and logs will be exported to Cloud Logging.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeFirewallSpecLogConfig? LogConfig { get; set; }

    /// <summary>The network to attach this firewall to.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeFirewallSpecNetworkRef NetworkRef { get; set; }

    /// <summary>Priority for this rule. This is an integer between 0 and 65535, both inclusive. When not specified, the value assumed is 1000. Relative priorities determine precedence of conflicting rules. Lower value of priority implies higher precedence (eg, a rule with priority 0 has higher precedence than a rule with priority 1). DENY rules take precedence over ALLOW rules having equal priority.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>If source ranges are specified, the firewall will apply only to traffic that has source IP address in these ranges. These ranges must be expressed in CIDR format. One or both of sourceRanges and sourceTags may be set. If both properties are set, the firewall will apply to traffic that has source IP address within sourceRanges OR the source IP that belongs to a tag listed in the sourceTags property. The connection does not need to match both properties for the firewall to apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of 'source_ranges', 'source_tags' or 'source_service_accounts' is required.</summary>
    [JsonPropertyName("sourceRanges")]
    public IList<string>? SourceRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceServiceAccounts")]
    public IList<V1beta1ComputeFirewallSpecSourceServiceAccounts>? SourceServiceAccounts { get; set; }

    /// <summary>If source tags are specified, the firewall will apply only to traffic with source IP that belongs to a tag listed in source tags. Source tags cannot be used to control traffic to an instance's external IP address. Because tags are associated with an instance, not an IP address. One or both of sourceRanges and sourceTags may be set. If both properties are set, the firewall will apply to traffic that has source IP address within sourceRanges OR the source IP that belongs to a tag listed in the sourceTags property. The connection does not need to match both properties for the firewall to apply. For INGRESS traffic, one of 'source_ranges', 'source_tags' or 'source_service_accounts' is required.</summary>
    [JsonPropertyName("sourceTags")]
    public IList<string>? SourceTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<V1beta1ComputeFirewallSpecTargetServiceAccounts>? TargetServiceAccounts { get; set; }

    /// <summary>A list of instance tags indicating sets of instances located in the network that may make network connections as specified in allowed[]. If no targetTags are specified, the firewall rule applies to all instances on the specified network.</summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeFirewallStatusConditions
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
public partial class V1beta1ComputeFirewallStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeFirewallStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

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
public partial class V1beta1ComputeFirewall : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeFirewallSpec>, IStatus<V1beta1ComputeFirewallStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeFirewall";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computefirewalls";
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
    public V1beta1ComputeFirewallSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeFirewallStatus? Status { get; set; }
}