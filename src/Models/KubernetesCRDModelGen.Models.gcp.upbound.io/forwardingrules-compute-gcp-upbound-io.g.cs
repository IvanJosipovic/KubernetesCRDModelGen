using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1ForwardingRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderIpAddressRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderIpAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderIpAddressSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderServiceDirectoryRegistrations
{
    /// <summary>Service Directory namespace to register the forwarding rule under.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Service Directory service to register the forwarding rule under.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderTargetRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecForProviderTargetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ForwardingRuleSpecForProvider
{
    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The allPorts field has the following limitations:</summary>
    [JsonPropertyName("allPorts")]
    public bool? AllPorts { get; set; }

    /// <summary>This field is used along with the backend_service field for internal load balancing or with the target field for internal TargetInstance. If the field is set to TRUE, clients can access ILB from all regions. Otherwise only allows access from clients in the same region as the internal load balancer.</summary>
    [JsonPropertyName("allowGlobalAccess")]
    public bool? AllowGlobalAccess { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.</summary>
    [JsonPropertyName("allowPscGlobalAccess")]
    public bool? AllowPscGlobalAccess { get; set; }

    /// <summary>Identifies the backend service to which the forwarding rule sends traffic. Required for Internal TCP/UDP Load Balancing and Network Load Balancing; must be omitted for all other load balancer types.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1ForwardingRuleSpecForProviderBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address for which this forwarding rule accepts traffic. When a client sends traffic to this IP address, the forwarding rule directs the traffic to the referenced target or backendService. While creating a forwarding rule, specifying an IPAddress is required under the following circumstances:</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1ForwardingRuleSpecForProviderIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1ForwardingRuleSpecForProviderIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The IP protocol to which this rule applies. For protocol forwarding, valid options are TCP, UDP, ESP, AH, SCTP, ICMP and L3_DEFAULT. The valid IP protocols are different for different load balancing products as described in Load balancing features. A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or backend service with UNSPECIFIED protocol. A forwarding rule with "L3_DEFAULT" IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values are: TCP, UDP, ESP, AH, SCTP, ICMP, L3_DEFAULT.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The IP address version that will be used by this forwarding rule. Valid options are IPV4 and IPV6. If not set, the IPv4 address will be used by default. Possible values are: IPV4, IPV6.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Indicates whether or not this load balancer can be used as a collector for packet mirroring. To prevent mirroring loops, instances behind this load balancer will not have their traffic mirrored even if a PacketMirroring rule applies to them. This can only be set to true for load balancers that have their loadBalancingScheme set to INTERNAL.</summary>
    [JsonPropertyName("isMirroringCollector")]
    public bool? IsMirroringCollector { get; set; }

    /// <summary>Labels to apply to this forwarding rule.  A list of key->value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the forwarding rule type. For more information about forwarding rules, refer to Forwarding rule concepts. Default value is EXTERNAL. Possible values are: EXTERNAL, EXTERNAL_MANAGED, INTERNAL, INTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>This field is not used for external load balancing. For Internal TCP/UDP Load Balancing, this field identifies the network that the load balanced IP should belong to for this Forwarding Rule. If the subnetwork is specified, the network of the subnetwork will be used. If neither subnetwork nor this field is specified, the default network will be used. For Private Service Connect forwarding rules that forward traffic to Google APIs, a network must be provided.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ForwardingRuleSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ForwardingRuleSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>This signifies the networking tier used for configuring this load balancer and can only take the following values: PREMIUM, STANDARD. For regional ForwardingRule, the valid values are PREMIUM and STANDARD. For GlobalForwardingRule, the valid value is PREMIUM. If this field is not specified, it is assumed to be PREMIUM. If IPAddress is specified, this value must be equal to the networkTier of the Address. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.</summary>
    [JsonPropertyName("noAutomateDnsZone")]
    public bool? NoAutomateDnsZone { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The portRange field has the following limitations:</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The ports field has the following limitations:</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>this is used in psc consumer forwardingrule to make provider recreate the forwardingrule when the status is closed</summary>
    [JsonPropertyName("recreateClosedPsc")]
    public bool? RecreateClosedPsc { get; set; }

    /// <summary>A reference to the region where the regional forwarding rule resides. This field is not applicable to global forwarding rules.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Service Directory resources to register this forwarding rule with. Currently, only supports a single Service Directory resource. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectoryRegistrations")]
    public IList<V1beta1ForwardingRuleSpecForProviderServiceDirectoryRegistrations>? ServiceDirectoryRegistrations { get; set; }

    /// <summary>An optional prefix to the service name for this Forwarding Rule. If specified, will be the first label of the fully qualified service name. The label must be 1-63 characters long, and comply with RFC1035. Specifically, the label must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceLabel")]
    public string? ServiceLabel { get; set; }

    /// <summary>If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).</summary>
    [JsonPropertyName("sourceIpRanges")]
    public IList<string>? SourceIpRanges { get; set; }

    /// <summary>This field identifies the subnetwork that the load balanced IP should belong to for this Forwarding Rule, used in internal load balancing and network load balancing with IPv6. If the network specified is in auto subnet mode, this field is optional. However, a subnetwork must be specified if the network is in custom subnet mode or when creating external forwarding rule with IPv6.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1ForwardingRuleSpecForProviderSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>is set to targetGrpcProxy and validateForProxyless is set to true, the IPAddress should be set to 0.0.0.0.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a RegionTargetHTTPProxy in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1ForwardingRuleSpecForProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a RegionTargetHTTPProxy in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1ForwardingRuleSpecForProviderTargetSelector? TargetSelector { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderBackendServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderIpAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderServiceDirectoryRegistrations
{
    /// <summary>Service Directory namespace to register the forwarding rule under.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Service Directory service to register the forwarding rule under.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderTargetRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecInitProviderTargetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ForwardingRuleSpecInitProvider
{
    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The allPorts field has the following limitations:</summary>
    [JsonPropertyName("allPorts")]
    public bool? AllPorts { get; set; }

    /// <summary>This field is used along with the backend_service field for internal load balancing or with the target field for internal TargetInstance. If the field is set to TRUE, clients can access ILB from all regions. Otherwise only allows access from clients in the same region as the internal load balancer.</summary>
    [JsonPropertyName("allowGlobalAccess")]
    public bool? AllowGlobalAccess { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.</summary>
    [JsonPropertyName("allowPscGlobalAccess")]
    public bool? AllowPscGlobalAccess { get; set; }

    /// <summary>Identifies the backend service to which the forwarding rule sends traffic. Required for Internal TCP/UDP Load Balancing and Network Load Balancing; must be omitted for all other load balancer types.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta1ForwardingRuleSpecInitProviderBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address for which this forwarding rule accepts traffic. When a client sends traffic to this IP address, the forwarding rule directs the traffic to the referenced target or backendService. While creating a forwarding rule, specifying an IPAddress is required under the following circumstances:</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1ForwardingRuleSpecInitProviderIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The IP protocol to which this rule applies. For protocol forwarding, valid options are TCP, UDP, ESP, AH, SCTP, ICMP and L3_DEFAULT. The valid IP protocols are different for different load balancing products as described in Load balancing features. A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or backend service with UNSPECIFIED protocol. A forwarding rule with "L3_DEFAULT" IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values are: TCP, UDP, ESP, AH, SCTP, ICMP, L3_DEFAULT.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The IP address version that will be used by this forwarding rule. Valid options are IPV4 and IPV6. If not set, the IPv4 address will be used by default. Possible values are: IPV4, IPV6.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Indicates whether or not this load balancer can be used as a collector for packet mirroring. To prevent mirroring loops, instances behind this load balancer will not have their traffic mirrored even if a PacketMirroring rule applies to them. This can only be set to true for load balancers that have their loadBalancingScheme set to INTERNAL.</summary>
    [JsonPropertyName("isMirroringCollector")]
    public bool? IsMirroringCollector { get; set; }

    /// <summary>Labels to apply to this forwarding rule.  A list of key->value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the forwarding rule type. For more information about forwarding rules, refer to Forwarding rule concepts. Default value is EXTERNAL. Possible values are: EXTERNAL, EXTERNAL_MANAGED, INTERNAL, INTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>This field is not used for external load balancing. For Internal TCP/UDP Load Balancing, this field identifies the network that the load balanced IP should belong to for this Forwarding Rule. If the subnetwork is specified, the network of the subnetwork will be used. If neither subnetwork nor this field is specified, the default network will be used. For Private Service Connect forwarding rules that forward traffic to Google APIs, a network must be provided.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ForwardingRuleSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ForwardingRuleSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>This signifies the networking tier used for configuring this load balancer and can only take the following values: PREMIUM, STANDARD. For regional ForwardingRule, the valid values are PREMIUM and STANDARD. For GlobalForwardingRule, the valid value is PREMIUM. If this field is not specified, it is assumed to be PREMIUM. If IPAddress is specified, this value must be equal to the networkTier of the Address. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.</summary>
    [JsonPropertyName("noAutomateDnsZone")]
    public bool? NoAutomateDnsZone { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The portRange field has the following limitations:</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The ports field has the following limitations:</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>this is used in psc consumer forwardingrule to make provider recreate the forwardingrule when the status is closed</summary>
    [JsonPropertyName("recreateClosedPsc")]
    public bool? RecreateClosedPsc { get; set; }

    /// <summary>Service Directory resources to register this forwarding rule with. Currently, only supports a single Service Directory resource. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectoryRegistrations")]
    public IList<V1beta1ForwardingRuleSpecInitProviderServiceDirectoryRegistrations>? ServiceDirectoryRegistrations { get; set; }

    /// <summary>An optional prefix to the service name for this Forwarding Rule. If specified, will be the first label of the fully qualified service name. The label must be 1-63 characters long, and comply with RFC1035. Specifically, the label must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceLabel")]
    public string? ServiceLabel { get; set; }

    /// <summary>If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).</summary>
    [JsonPropertyName("sourceIpRanges")]
    public IList<string>? SourceIpRanges { get; set; }

    /// <summary>This field identifies the subnetwork that the load balanced IP should belong to for this Forwarding Rule, used in internal load balancing and network load balancing with IPv6. If the network specified is in auto subnet mode, this field is optional. However, a subnetwork must be specified if the network is in custom subnet mode or when creating external forwarding rule with IPv6.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1ForwardingRuleSpecInitProviderSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>is set to targetGrpcProxy and validateForProxyless is set to true, the IPAddress should be set to 0.0.0.0.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a RegionTargetHTTPProxy in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1ForwardingRuleSpecInitProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a RegionTargetHTTPProxy in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1ForwardingRuleSpecInitProviderTargetSelector? TargetSelector { get; set; }
}

public enum V1beta1ForwardingRuleSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ForwardingRuleSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ForwardingRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ForwardingRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ForwardingRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ForwardingRuleSpecDeletionPolicyEnum>))]
    public V1beta1ForwardingRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ForwardingRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ForwardingRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ForwardingRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ForwardingRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ForwardingRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ForwardingRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ForwardingRuleStatusAtProviderServiceDirectoryRegistrations
{
    /// <summary>Service Directory namespace to register the forwarding rule under.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Service Directory service to register the forwarding rule under.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1ForwardingRuleStatusAtProvider
{
    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The allPorts field has the following limitations:</summary>
    [JsonPropertyName("allPorts")]
    public bool? AllPorts { get; set; }

    /// <summary>This field is used along with the backend_service field for internal load balancing or with the target field for internal TargetInstance. If the field is set to TRUE, clients can access ILB from all regions. Otherwise only allows access from clients in the same region as the internal load balancer.</summary>
    [JsonPropertyName("allowGlobalAccess")]
    public bool? AllowGlobalAccess { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.</summary>
    [JsonPropertyName("allowPscGlobalAccess")]
    public bool? AllowPscGlobalAccess { get; set; }

    /// <summary>Identifies the backend service to which the forwarding rule sends traffic. Required for Internal TCP/UDP Load Balancing and Network Load Balancing; must be omitted for all other load balancer types.</summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>[Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.</summary>
    [JsonPropertyName("baseForwardingRule")]
    public string? BaseForwardingRule { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/forwardingRules/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IP address for which this forwarding rule accepts traffic. When a client sends traffic to this IP address, the forwarding rule directs the traffic to the referenced target or backendService. While creating a forwarding rule, specifying an IPAddress is required under the following circumstances:</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The IP protocol to which this rule applies. For protocol forwarding, valid options are TCP, UDP, ESP, AH, SCTP, ICMP and L3_DEFAULT. The valid IP protocols are different for different load balancing products as described in Load balancing features. A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or backend service with UNSPECIFIED protocol. A forwarding rule with "L3_DEFAULT" IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values are: TCP, UDP, ESP, AH, SCTP, ICMP, L3_DEFAULT.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The IP address version that will be used by this forwarding rule. Valid options are IPV4 and IPV6. If not set, the IPv4 address will be used by default. Possible values are: IPV4, IPV6.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Indicates whether or not this load balancer can be used as a collector for packet mirroring. To prevent mirroring loops, instances behind this load balancer will not have their traffic mirrored even if a PacketMirroring rule applies to them. This can only be set to true for load balancers that have their loadBalancingScheme set to INTERNAL.</summary>
    [JsonPropertyName("isMirroringCollector")]
    public bool? IsMirroringCollector { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this forwarding rule.  A list of key->value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specifies the forwarding rule type. For more information about forwarding rules, refer to Forwarding rule concepts. Default value is EXTERNAL. Possible values are: EXTERNAL, EXTERNAL_MANAGED, INTERNAL, INTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>This field is not used for external load balancing. For Internal TCP/UDP Load Balancing, this field identifies the network that the load balanced IP should belong to for this Forwarding Rule. If the subnetwork is specified, the network of the subnetwork will be used. If neither subnetwork nor this field is specified, the default network will be used. For Private Service Connect forwarding rules that forward traffic to Google APIs, a network must be provided.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>This signifies the networking tier used for configuring this load balancer and can only take the following values: PREMIUM, STANDARD. For regional ForwardingRule, the valid values are PREMIUM and STANDARD. For GlobalForwardingRule, the valid value is PREMIUM. If this field is not specified, it is assumed to be PREMIUM. If IPAddress is specified, this value must be equal to the networkTier of the Address. Possible values are: PREMIUM, STANDARD.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.</summary>
    [JsonPropertyName("noAutomateDnsZone")]
    public bool? NoAutomateDnsZone { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The portRange field has the following limitations:</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }

    /// <summary>The ports, portRange, and allPorts fields are mutually exclusive. Only packets addressed to ports in the specified range will be forwarded to the backends configured with this forwarding rule. The ports field has the following limitations:</summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The PSC connection id of the PSC Forwarding Rule.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The PSC connection status of the PSC Forwarding Rule. Possible values: STATUS_UNSPECIFIED, PENDING, ACCEPTED, REJECTED, CLOSED</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    /// <summary>this is used in psc consumer forwardingrule to make provider recreate the forwardingrule when the status is closed</summary>
    [JsonPropertyName("recreateClosedPsc")]
    public bool? RecreateClosedPsc { get; set; }

    /// <summary>A reference to the region where the regional forwarding rule resides. This field is not applicable to global forwarding rules.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Service Directory resources to register this forwarding rule with. Currently, only supports a single Service Directory resource. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectoryRegistrations")]
    public IList<V1beta1ForwardingRuleStatusAtProviderServiceDirectoryRegistrations>? ServiceDirectoryRegistrations { get; set; }

    /// <summary>An optional prefix to the service name for this Forwarding Rule. If specified, will be the first label of the fully qualified service name. The label must be 1-63 characters long, and comply with RFC1035. Specifically, the label must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceLabel")]
    public string? ServiceLabel { get; set; }

    /// <summary>The internal fully qualified service name for this Forwarding Rule. This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).</summary>
    [JsonPropertyName("sourceIpRanges")]
    public IList<string>? SourceIpRanges { get; set; }

    /// <summary>This field identifies the subnetwork that the load balanced IP should belong to for this Forwarding Rule, used in internal load balancing and network load balancing with IPv6. If the network specified is in auto subnet mode, this field is optional. However, a subnetwork must be specified if the network is in custom subnet mode or when creating external forwarding rule with IPv6.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>is set to targetGrpcProxy and validateForProxyless is set to true, the IPAddress should be set to 0.0.0.0.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

public partial class V1beta1ForwardingRuleStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1beta1ForwardingRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ForwardingRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ForwardingRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ForwardingRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ForwardingRuleSpec>, IStatus<V1beta1ForwardingRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ForwardingRule";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "forwardingrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ForwardingRuleSpec defines the desired state of ForwardingRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1ForwardingRuleSpec Spec { get; set; }

    /// <summary>ForwardingRuleStatus defines the observed state of ForwardingRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ForwardingRuleStatus? Status { get; set; }
}