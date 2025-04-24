using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>A ComputeBackendService to receive the matched traffic. This is used only for internal load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecBackendServiceRef
{
    /// <summary>The ComputeBackendService selflink in the form "projects/{{project}}/global/backendServices/{{name}}" or "projects/{{project}}/regions/{{region}}/backendServices/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeBackendService` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecIpAddressAddressRef
{
    /// <summary>The ComputeAddress selflink in the form "projects/{{project}}/regions/{{region}}/addresses/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The IP address that this forwarding rule is serving on behalf of.  Addresses are restricted based on the forwarding rule's load balancing scheme (EXTERNAL or INTERNAL) and scope (global or regional).  When the load balancing scheme is EXTERNAL, for global forwarding rules, the address must be a global IP, and for regional forwarding rules, the address must live in the same region as the forwarding rule. If this field is empty, an ephemeral IPv4 address from the same scope (global or regional) will be assigned. A regional forwarding rule supports IPv4 only. A global forwarding rule supports either IPv4 or IPv6.  When the load balancing scheme is INTERNAL, this can only be an RFC 1918 IP address belonging to the network/subnet configured for the forwarding rule. By default, if this field is empty, an ephemeral internal IP address will be automatically allocated from the IP range of the subnet or network configured for this forwarding rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecIpAddress
{
    /// <summary></summary>
    [JsonPropertyName("addressRef")]
    public V1beta1ComputeForwardingRuleSpecIpAddressAddressRef? AddressRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecMetadataFiltersFilterLabels
{
    /// <summary>Immutable. Name of the metadata label. The length must be between 1 and 1024 characters, inclusive.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Immutable. The value that the label must match. The value has a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecMetadataFilters
{
    /// <summary>Immutable. The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria  This list must not be empty and can have at the most 64 entries.</summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta1ComputeForwardingRuleSpecMetadataFiltersFilterLabels> FilterLabels { get; set; }

    /// <summary>Immutable. Specifies how individual filterLabel matches within the list of filterLabels contribute towards the overall metadataFilter match.  MATCH_ANY - At least one of the filterLabels must have a matching label in the provided metadata. MATCH_ALL - All filterLabels must have matching labels in the provided metadata. Possible values: ["MATCH_ANY", "MATCH_ALL"].</summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string FilterMatchCriteria { get; set; }
}

/// <summary>This field is not used for external load balancing. For internal load balancing, this field identifies the network that the load balanced IP should belong to for this forwarding rule. If this field is not specified, the default network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecServiceDirectoryRegistrations
{
    /// <summary>Immutable. Service Directory namespace to register the forwarding rule under.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Immutable. Service Directory service to register the forwarding rule under.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>Immutable. The subnetwork that the load balanced IP should belong to for this forwarding rule. This field is only used for internal load balancing.  If the network specified is in auto subnet mode, this field is optional. However, if the network is in custom subnet mode, a subnetwork must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetServiceAttachmentRef
{
    /// <summary>The ComputeServiceAttachment selflink in the form "projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetGRPCProxyRef
{
    /// <summary>The ComputeTargetGrpcProxy selflink in the form "projects/{{project}}/global/targetGrpcProxies/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetGrpcProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetGrpcProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetHTTPProxyRef
{
    /// <summary>The ComputeTargetHTTPProxy selflink in the form "projects/{{project}}/global/targetHttpProxies/{{name}}" or "projects/{{project}}/regions/{{region}}/targetHttpProxies/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetHTTPProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetHTTPProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetHTTPSProxyRef
{
    /// <summary>The ComputeTargetHTTPSProxy selflink in the form "projects/{{project}}/global/targetHttpProxies/{{name}}" or "projects/{{project}}/regions/{{region}}/targetHttpProxies/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetHTTPSProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetHTTPSProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetSSLProxyRef
{
    /// <summary>The ComputeTargetSSLProxy selflink in the form "projects/{{project}}/global/targetSslProxies/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetSSLProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetSSLProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetTCPProxyRef
{
    /// <summary>The ComputeTargetTCPProxy selflink in the form "projects/{{project}}/global/targetTcpProxies/{{name}}" or "projects/{{project}}/regions/{{region}}/targetTcpProxies/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetTCPProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetTCPProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetVPNGatewayRef
{
    /// <summary>The ComputeTargetVPNGateway selflink in the form "projects/{{project}}/regions/{{region}}/targetVpnGateways/{{name}}" when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetVPNGateway` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetVPNGateway` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The target resource to receive the matched traffic. The forwarded traffic must be of a type appropriate to the target object. For INTERNAL_SELF_MANAGED load balancing, only HTTP and HTTPS targets are valid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTarget
{
    /// <summary></summary>
    [JsonPropertyName("googleAPIsBundle")]
    public string? GoogleAPIsBundle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAttachmentRef")]
    public V1beta1ComputeForwardingRuleSpecTargetServiceAttachmentRef? ServiceAttachmentRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetGRPCProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetGRPCProxyRef? TargetGRPCProxyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetHTTPProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetHTTPProxyRef? TargetHTTPProxyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetHTTPSProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetHTTPSProxyRef? TargetHTTPSProxyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetSSLProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetSSLProxyRef? TargetSSLProxyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetTCPProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetTCPProxyRef? TargetTCPProxyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetVPNGatewayRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetVPNGatewayRef? TargetVPNGatewayRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpec
{
    /// <summary>Immutable. This field can only be used: * If 'IPProtocol' is one of TCP, UDP, or SCTP. * By internal TCP/UDP load balancers, backend service-based network load balancers, and internal and external protocol forwarding.  This option should be set to TRUE when the Forwarding Rule IPProtocol is set to L3_DEFAULT.  Set this field to true to allow packets addressed to any port or packets lacking destination port information (for example, UDP fragments after the first fragment) to be forwarded to the backends configured with this forwarding rule.  The 'ports', 'port_range', and 'allPorts' fields are mutually exclusive.</summary>
    [JsonPropertyName("allPorts")]
    public bool? AllPorts { get; set; }

    /// <summary>This field is used along with the 'backend_service' field for internal load balancing or with the 'target' field for internal TargetInstance.  If the field is set to 'TRUE', clients can access ILB from all regions.  Otherwise only allows access from clients in the same region as the internal load balancer.</summary>
    [JsonPropertyName("allowGlobalAccess")]
    public bool? AllowGlobalAccess { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.</summary>
    [JsonPropertyName("allowPscGlobalAccess")]
    public bool? AllowPscGlobalAccess { get; set; }

    /// <summary>A ComputeBackendService to receive the matched traffic. This is used only for internal load balancing.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeForwardingRuleSpecBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP address that this forwarding rule is serving on behalf of.  Addresses are restricted based on the forwarding rule's load balancing scheme (EXTERNAL or INTERNAL) and scope (global or regional).  When the load balancing scheme is EXTERNAL, for global forwarding rules, the address must be a global IP, and for regional forwarding rules, the address must live in the same region as the forwarding rule. If this field is empty, an ephemeral IPv4 address from the same scope (global or regional) will be assigned. A regional forwarding rule supports IPv4 only. A global forwarding rule supports either IPv4 or IPv6.  When the load balancing scheme is INTERNAL, this can only be an RFC 1918 IP address belonging to the network/subnet configured for the forwarding rule. By default, if this field is empty, an ephemeral internal IP address will be automatically allocated from the IP range of the subnet or network configured for this forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1ComputeForwardingRuleSpecIpAddress? IpAddress { get; set; }

    /// <summary>Immutable. The IP protocol to which this rule applies.  For protocol forwarding, valid options are 'TCP', 'UDP', 'ESP', 'AH', 'SCTP', 'ICMP' and 'L3_DEFAULT'.  The valid IP protocols are different for different load balancing products as described in [Load balancing features](https://cloud.google.com/load-balancing/docs/features#protocols_from_the_load_balancer_to_the_backends).  A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or backend service with UNSPECIFIED protocol. A forwarding rule with "L3_DEFAULT" IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values: ["TCP", "UDP", "ESP", "AH", "SCTP", "ICMP", "L3_DEFAULT"].</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>Immutable. The IP address version that will be used by this forwarding rule. Valid options are IPV4 and IPV6.  If not set, the IPv4 address will be used by default. Possible values: ["IPV4", "IPV6"].</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Immutable. Indicates whether or not this load balancer can be used as a collector for packet mirroring. To prevent mirroring loops, instances behind this load balancer will not have their traffic mirrored even if a 'PacketMirroring' rule applies to them.  This can only be set to true for load balancers that have their 'loadBalancingScheme' set to 'INTERNAL'.</summary>
    [JsonPropertyName("isMirroringCollector")]
    public bool? IsMirroringCollector { get; set; }

    /// <summary>Immutable. Specifies the forwarding rule type.  Must set to empty for private service connect forwarding rule. For more information about forwarding rules, refer to [Forwarding rule concepts](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts). Default value: "EXTERNAL" Possible values: ["EXTERNAL", "EXTERNAL_MANAGED", "INTERNAL", "INTERNAL_MANAGED", ""].</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>Location represents the geographical location of the ComputeForwardingRule. Specify a region name or "global" for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Opaque filter criteria used by Loadbalancer to restrict routing configuration to a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS clients present node metadata. If a match takes place, the relevant routing configuration is made available to those proxies.  For each metadataFilter in this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the filterLabels must match the corresponding label provided in the metadata. If its filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match with corresponding labels in the provided metadata.  metadataFilters specified here can be overridden by those specified in the UrlMap that this ForwardingRule references.  metadataFilters only applies to Loadbalancers that have their loadBalancingScheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1ComputeForwardingRuleSpecMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>This field is not used for external load balancing. For internal load balancing, this field identifies the network that the load balanced IP should belong to for this forwarding rule. If this field is not specified, the default network will be used.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeForwardingRuleSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. This signifies the networking tier used for configuring this load balancer and can only take the following values: 'PREMIUM', 'STANDARD'.  For regional ForwardingRule, the valid values are 'PREMIUM' and 'STANDARD'. For GlobalForwardingRule, the valid value is 'PREMIUM'.  If this field is not specified, it is assumed to be 'PREMIUM'. If 'IPAddress' is specified, this value must be equal to the networkTier of the Address. Possible values: ["PREMIUM", "STANDARD"].</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>Immutable. This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.</summary>
    [JsonPropertyName("noAutomateDnsZone")]
    public bool? NoAutomateDnsZone { get; set; }

    /// <summary>Immutable. This field can only be used:  * If 'IPProtocol' is one of TCP, UDP, or SCTP. * By backend service-based network load balancers, target pool-based network load balancers, internal proxy load balancers, external proxy load balancers, Traffic Director, external protocol forwarding, and Classic VPN. Some products have restrictions on what ports can be used. See [port specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#port_specifications) for details.  Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule.  The 'ports' and 'port_range' fields are mutually exclusive.  For external forwarding rules, two or more forwarding rules cannot use the same '[IPAddress, IPProtocol]' pair, and cannot have overlapping 'portRange's.  For internal forwarding rules within the same VPC network, two or more forwarding rules cannot use the same '[IPAddress, IPProtocol]' pair, and cannot have overlapping 'portRange's.</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }

    /// <summary>Immutable. This field can only be used:  * If 'IPProtocol' is one of TCP, UDP, or SCTP. * By internal TCP/UDP load balancers, backend service-based network load balancers, internal protocol forwarding and when protocol is not L3_DEFAULT.  You can specify a list of up to five ports by number, separated by commas. The ports can be contiguous or discontiguous. Only packets addressed to these ports will be forwarded to the backends configured with this forwarding rule.  For external forwarding rules, two or more forwarding rules cannot use the same '[IPAddress, IPProtocol]' pair, and cannot share any values defined in 'ports'.  For internal forwarding rules within the same VPC network, two or more forwarding rules cannot use the same '[IPAddress, IPProtocol]' pair, and cannot share any values defined in 'ports'.  The 'ports' and 'port_range' fields are mutually exclusive.</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Service Directory resources to register this forwarding rule with.  Currently, only supports a single Service Directory resource.</summary>
    [JsonPropertyName("serviceDirectoryRegistrations")]
    public IList<V1beta1ComputeForwardingRuleSpecServiceDirectoryRegistrations>? ServiceDirectoryRegistrations { get; set; }

    /// <summary>Immutable. An optional prefix to the service name for this Forwarding Rule. If specified, will be the first label of the fully qualified service name.  The label must be 1-63 characters long, and comply with RFC1035. Specifically, the label must be 1-63 characters long and match the regular expression '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.  This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceLabel")]
    public string? ServiceLabel { get; set; }

    /// <summary>Immutable. If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).</summary>
    [JsonPropertyName("sourceIpRanges")]
    public IList<string>? SourceIpRanges { get; set; }

    /// <summary>Immutable. The subnetwork that the load balanced IP should belong to for this forwarding rule. This field is only used for internal load balancing.  If the network specified is in auto subnet mode, this field is optional. However, if the network is in custom subnet mode, a subnetwork must be specified.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeForwardingRuleSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>The target resource to receive the matched traffic. The forwarded traffic must be of a type appropriate to the target object. For INTERNAL_SELF_MANAGED load balancing, only HTTP and HTTPS targets are valid.</summary>
    [JsonPropertyName("target")]
    public V1beta1ComputeForwardingRuleSpecTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleStatusConditions
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
public partial class V1beta1ComputeForwardingRuleStatus
{
    /// <summary>[Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.</summary>
    [JsonPropertyName("baseForwardingRule")]
    public string? BaseForwardingRule { get; set; }

    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeForwardingRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A unique Config Connector specifier for the resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The PSC connection id of the PSC Forwarding Rule.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The PSC connection status of the PSC Forwarding Rule. Possible values: 'STATUS_UNSPECIFIED', 'PENDING', 'ACCEPTED', 'REJECTED', 'CLOSED'.</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The internal fully qualified service name for this Forwarding Rule.  This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>ComputeForwardingRule is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeForwardingRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeForwardingRuleSpec>, IStatus<V1beta1ComputeForwardingRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeForwardingRule";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeforwardingrules";
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
    public V1beta1ComputeForwardingRuleSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeForwardingRuleStatus? Status { get; set; }
}

/// <summary>ComputeForwardingRule is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeForwardingRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeForwardingRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeForwardingRuleList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeforwardingrules";
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
    public IList<V1beta1ComputeForwardingRule> Items { get; set; }
}