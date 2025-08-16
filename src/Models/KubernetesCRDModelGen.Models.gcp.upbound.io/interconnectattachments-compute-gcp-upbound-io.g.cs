using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>InterconnectAttachment is the Schema for the InterconnectAttachments API. Represents an InterconnectAttachment (VLAN attachment) resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InterconnectAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InterconnectAttachment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InterconnectAttachmentList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "interconnectattachments";
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
    public IList<V1beta1InterconnectAttachment> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate ipsecInternalAddresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecForProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecForProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecForProvider
{
    /// <summary>Whether the VLAN attachment is enabled or disabled.  When using PARTNER type this will Pre-Activate the interconnect attachment</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>Provisioned bandwidth capacity for the interconnect attachment. For attachments of type DEDICATED, the user can set the bandwidth. For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth. Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED, Defaults to BPS_10G Possible values are: BPS_50M, BPS_100M, BPS_200M, BPS_300M, BPS_400M, BPS_500M, BPS_1G, BPS_2G, BPS_5G, BPS_10G, BPS_20G, BPS_50G, BPS_100G.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>Up to 16 candidate prefixes that can be used to restrict the allocation of cloudRouterIpAddress and customerRouterIpAddress for this attachment. All prefixes must be within link-local address space (169.254.0.0/16) and must be /29 or shorter (/28, /27, etc). Google will attempt to select an unused /29 from the supplied candidate prefix(es). The request will fail if all possible /29s are in use on Google's edge. If not supplied, Google will randomly select an unused /29 from all of link-local space.</summary>
    [JsonPropertyName("candidateSubnets")]
    public IList<string>? CandidateSubnets { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired availability domain for the attachment. Only available for type PARTNER, at creation time. For improved reliability, customers should configure a pair of attachments with one per availability domain. The selected availability domain will be provided to the Partner via the pairing key so that the provisioned circuit will lie in the specified domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.</summary>
    [JsonPropertyName("edgeAvailabilityDomain")]
    public string? EdgeAvailabilityDomain { get; set; }

    /// <summary>Indicates the user-supplied encryption option of this interconnect attachment. Can only be specified at attachment creation for PARTNER or DEDICATED attachments.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>URL of the underlying Interconnect object that this attachment's traffic will traverse through. Required if type is DEDICATED, must not be set if type is PARTNER.</summary>
    [JsonPropertyName("interconnect")]
    public string? Interconnect { get; set; }

    /// <summary>URL of addresses that have been reserved for the interconnect attachment, Used only for interconnect attachment that has the encryption option as IPSEC. The addresses must be RFC 1918 IP address ranges. When creating HA VPN gateway over the interconnect attachment, if the attachment is configured to use an RFC 1918 IP address, then the VPN gateway's IP address will be allocated from the IP address range specified here. For example, if the HA VPN gateway's interface 0 is paired to this interconnect attachment, then an RFC 1918 IP address for the VPN gateway interface 0 will be allocated from the IP address specified for this interconnect attachment. If this field is not specified for interconnect attachment that has encryption option as IPSEC, later on when creating HA VPN gateway on this interconnect attachment, the HA VPN gateway's IP address will be allocated from regional external IP address pool.</summary>
    [JsonPropertyName("ipsecInternalAddresses")]
    public IList<string>? IpsecInternalAddresses { get; set; }

    /// <summary>References to Address in compute to populate ipsecInternalAddresses.</summary>
    [JsonPropertyName("ipsecInternalAddressesRefs")]
    public IList<V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesRefs>? IpsecInternalAddressesRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate ipsecInternalAddresses.</summary>
    [JsonPropertyName("ipsecInternalAddressesSelector")]
    public V1beta1InterconnectAttachmentSpecForProviderIpsecInternalAddressesSelector? IpsecInternalAddressesSelector { get; set; }

    /// <summary>Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment. Valid values are 1440, 1460, 1500, and 8896. If not specified, the value will default to 1440.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the regional interconnect attachment resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>URL of the cloud router to be used for dynamic routing. This router must be in the same region as this InterconnectAttachment. The InterconnectAttachment will automatically connect the Interconnect to the network &amp; region within which the Cloud Router is configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1InterconnectAttachmentSpecForProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1InterconnectAttachmentSpecForProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>The stack type for this interconnect attachment to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used. This field can be both set at interconnect attachments creation and update interconnect attachment operations. Possible values are: IPV4_IPV6, IPV4_ONLY.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>Length of the IPv4 subnet mask. Allowed values: 29 (default), 30. The default value is 29, except for Cross-Cloud Interconnect connections that use an InterconnectRemoteLocation with a constraints.subnetLengthRange.min equal to 30. For example, connections that use an Azure remote location fall into this category. In these cases, the default value is 30, and requesting 29 returns an error. Where both 29 and 30 are allowed, 29 is preferred, because it gives Google Cloud Support more debugging visibility.</summary>
    [JsonPropertyName("subnetLength")]
    public double? SubnetLength { get; set; }

    /// <summary>The type of InterconnectAttachment you wish to create. Defaults to DEDICATED. Possible values are: DEDICATED, PARTNER, PARTNER_PROVIDER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When using PARTNER type this will be managed upstream.</summary>
    [JsonPropertyName("vlanTag8021Q")]
    public double? VlanTag8021Q { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate ipsecInternalAddresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecInitProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecInitProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecInitProvider
{
    /// <summary>Whether the VLAN attachment is enabled or disabled.  When using PARTNER type this will Pre-Activate the interconnect attachment</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>Provisioned bandwidth capacity for the interconnect attachment. For attachments of type DEDICATED, the user can set the bandwidth. For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth. Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED, Defaults to BPS_10G Possible values are: BPS_50M, BPS_100M, BPS_200M, BPS_300M, BPS_400M, BPS_500M, BPS_1G, BPS_2G, BPS_5G, BPS_10G, BPS_20G, BPS_50G, BPS_100G.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>Up to 16 candidate prefixes that can be used to restrict the allocation of cloudRouterIpAddress and customerRouterIpAddress for this attachment. All prefixes must be within link-local address space (169.254.0.0/16) and must be /29 or shorter (/28, /27, etc). Google will attempt to select an unused /29 from the supplied candidate prefix(es). The request will fail if all possible /29s are in use on Google's edge. If not supplied, Google will randomly select an unused /29 from all of link-local space.</summary>
    [JsonPropertyName("candidateSubnets")]
    public IList<string>? CandidateSubnets { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired availability domain for the attachment. Only available for type PARTNER, at creation time. For improved reliability, customers should configure a pair of attachments with one per availability domain. The selected availability domain will be provided to the Partner via the pairing key so that the provisioned circuit will lie in the specified domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.</summary>
    [JsonPropertyName("edgeAvailabilityDomain")]
    public string? EdgeAvailabilityDomain { get; set; }

    /// <summary>Indicates the user-supplied encryption option of this interconnect attachment. Can only be specified at attachment creation for PARTNER or DEDICATED attachments.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>URL of the underlying Interconnect object that this attachment's traffic will traverse through. Required if type is DEDICATED, must not be set if type is PARTNER.</summary>
    [JsonPropertyName("interconnect")]
    public string? Interconnect { get; set; }

    /// <summary>URL of addresses that have been reserved for the interconnect attachment, Used only for interconnect attachment that has the encryption option as IPSEC. The addresses must be RFC 1918 IP address ranges. When creating HA VPN gateway over the interconnect attachment, if the attachment is configured to use an RFC 1918 IP address, then the VPN gateway's IP address will be allocated from the IP address range specified here. For example, if the HA VPN gateway's interface 0 is paired to this interconnect attachment, then an RFC 1918 IP address for the VPN gateway interface 0 will be allocated from the IP address specified for this interconnect attachment. If this field is not specified for interconnect attachment that has encryption option as IPSEC, later on when creating HA VPN gateway on this interconnect attachment, the HA VPN gateway's IP address will be allocated from regional external IP address pool.</summary>
    [JsonPropertyName("ipsecInternalAddresses")]
    public IList<string>? IpsecInternalAddresses { get; set; }

    /// <summary>References to Address in compute to populate ipsecInternalAddresses.</summary>
    [JsonPropertyName("ipsecInternalAddressesRefs")]
    public IList<V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesRefs>? IpsecInternalAddressesRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate ipsecInternalAddresses.</summary>
    [JsonPropertyName("ipsecInternalAddressesSelector")]
    public V1beta1InterconnectAttachmentSpecInitProviderIpsecInternalAddressesSelector? IpsecInternalAddressesSelector { get; set; }

    /// <summary>Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment. Valid values are 1440, 1460, 1500, and 8896. If not specified, the value will default to 1440.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the cloud router to be used for dynamic routing. This router must be in the same region as this InterconnectAttachment. The InterconnectAttachment will automatically connect the Interconnect to the network &amp; region within which the Cloud Router is configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1InterconnectAttachmentSpecInitProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1InterconnectAttachmentSpecInitProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>The stack type for this interconnect attachment to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used. This field can be both set at interconnect attachments creation and update interconnect attachment operations. Possible values are: IPV4_IPV6, IPV4_ONLY.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>Length of the IPv4 subnet mask. Allowed values: 29 (default), 30. The default value is 29, except for Cross-Cloud Interconnect connections that use an InterconnectRemoteLocation with a constraints.subnetLengthRange.min equal to 30. For example, connections that use an Azure remote location fall into this category. In these cases, the default value is 30, and requesting 29 returns an error. Where both 29 and 30 are allowed, 29 is preferred, because it gives Google Cloud Support more debugging visibility.</summary>
    [JsonPropertyName("subnetLength")]
    public double? SubnetLength { get; set; }

    /// <summary>The type of InterconnectAttachment you wish to create. Defaults to DEDICATED. Possible values are: DEDICATED, PARTNER, PARTNER_PROVIDER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When using PARTNER type this will be managed upstream.</summary>
    [JsonPropertyName("vlanTag8021Q")]
    public double? VlanTag8021Q { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InterconnectAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InterconnectAttachmentSpec defines the desired state of InterconnectAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InterconnectAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InterconnectAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InterconnectAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InterconnectAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentStatusAtProviderPrivateInterconnectInfo
{
    /// <summary>(Output) 802.1q encapsulation tag to be used for traffic between Google and the customer, going to and from this network and region.</summary>
    [JsonPropertyName("tag8021q")]
    public double? Tag8021q { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentStatusAtProvider
{
    /// <summary>Whether the VLAN attachment is enabled or disabled.  When using PARTNER type this will Pre-Activate the interconnect attachment</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>URL of the AttachmentGroup that includes this Attachment.</summary>
    [JsonPropertyName("attachmentGroup")]
    public string? AttachmentGroup { get; set; }

    /// <summary>Provisioned bandwidth capacity for the interconnect attachment. For attachments of type DEDICATED, the user can set the bandwidth. For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth. Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED, Defaults to BPS_10G Possible values are: BPS_50M, BPS_100M, BPS_200M, BPS_300M, BPS_400M, BPS_500M, BPS_1G, BPS_2G, BPS_5G, BPS_10G, BPS_20G, BPS_50G, BPS_100G.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>Up to 16 candidate prefixes that can be used to restrict the allocation of cloudRouterIpAddress and customerRouterIpAddress for this attachment. All prefixes must be within link-local address space (169.254.0.0/16) and must be /29 or shorter (/28, /27, etc). Google will attempt to select an unused /29 from the supplied candidate prefix(es). The request will fail if all possible /29s are in use on Google's edge. If not supplied, Google will randomly select an unused /29 from all of link-local space.</summary>
    [JsonPropertyName("candidateSubnets")]
    public IList<string>? CandidateSubnets { get; set; }

    /// <summary>IPv4 address + prefix length to be configured on Cloud Router Interface for this interconnect attachment.</summary>
    [JsonPropertyName("cloudRouterIpAddress")]
    public string? CloudRouterIpAddress { get; set; }

    /// <summary>IPv6 address + prefix length to be configured on Cloud Router Interface for this interconnect attachment.</summary>
    [JsonPropertyName("cloudRouterIpv6Address")]
    public string? CloudRouterIpv6Address { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>IPv4 address + prefix length to be configured on the customer router subinterface for this interconnect attachment.</summary>
    [JsonPropertyName("customerRouterIpAddress")]
    public string? CustomerRouterIpAddress { get; set; }

    /// <summary>IPv6 address + prefix length to be configured on the customer router subinterface for this interconnect attachment.</summary>
    [JsonPropertyName("customerRouterIpv6Address")]
    public string? CustomerRouterIpv6Address { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired availability domain for the attachment. Only available for type PARTNER, at creation time. For improved reliability, customers should configure a pair of attachments with one per availability domain. The selected availability domain will be provided to the Partner via the pairing key so that the provisioned circuit will lie in the specified domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.</summary>
    [JsonPropertyName("edgeAvailabilityDomain")]
    public string? EdgeAvailabilityDomain { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Indicates the user-supplied encryption option of this interconnect attachment. Can only be specified at attachment creation for PARTNER or DEDICATED attachments.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Google reference ID, to be used when raising support tickets with Google or otherwise to debug backend connectivity issues.</summary>
    [JsonPropertyName("googleReferenceId")]
    public string? GoogleReferenceId { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/interconnectAttachments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>URL of the underlying Interconnect object that this attachment's traffic will traverse through. Required if type is DEDICATED, must not be set if type is PARTNER.</summary>
    [JsonPropertyName("interconnect")]
    public string? Interconnect { get; set; }

    /// <summary>URL of addresses that have been reserved for the interconnect attachment, Used only for interconnect attachment that has the encryption option as IPSEC. The addresses must be RFC 1918 IP address ranges. When creating HA VPN gateway over the interconnect attachment, if the attachment is configured to use an RFC 1918 IP address, then the VPN gateway's IP address will be allocated from the IP address range specified here. For example, if the HA VPN gateway's interface 0 is paired to this interconnect attachment, then an RFC 1918 IP address for the VPN gateway interface 0 will be allocated from the IP address specified for this interconnect attachment. If this field is not specified for interconnect attachment that has encryption option as IPSEC, later on when creating HA VPN gateway on this interconnect attachment, the HA VPN gateway's IP address will be allocated from regional external IP address pool.</summary>
    [JsonPropertyName("ipsecInternalAddresses")]
    public IList<string>? IpsecInternalAddresses { get; set; }

    /// <summary>A fingerprint for the labels being applied to this Interconnect, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment. Valid values are 1440, 1460, 1500, and 8896. If not specified, the value will default to 1440.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>[Output only for type PARTNER. Not present for DEDICATED]. The opaque identifier of an PARTNER attachment used to initiate provisioning with a selected partner. Of the form "XXXXX/region/domain"</summary>
    [JsonPropertyName("pairingKey")]
    public string? PairingKey { get; set; }

    /// <summary>[Output only for type PARTNER. Not present for DEDICATED]. Optional BGP ASN for the router that should be supplied by a layer 3 Partner if they configured BGP on behalf of the customer.</summary>
    [JsonPropertyName("partnerAsn")]
    public string? PartnerAsn { get; set; }

    /// <summary>Information specific to an InterconnectAttachment. This property is populated if the interconnect that this is attached to is of type DEDICATED. Structure is documented below.</summary>
    [JsonPropertyName("privateInterconnectInfo")]
    public IList<V1beta1InterconnectAttachmentStatusAtProviderPrivateInterconnectInfo>? PrivateInterconnectInfo { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the regional interconnect attachment resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URL of the cloud router to be used for dynamic routing. This router must be in the same region as this InterconnectAttachment. The InterconnectAttachment will automatically connect the Interconnect to the network &amp; region within which the Cloud Router is configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The stack type for this interconnect attachment to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used. This field can be both set at interconnect attachments creation and update interconnect attachment operations. Possible values are: IPV4_IPV6, IPV4_ONLY.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>[Output Only] The current state of this attachment's functionality.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Length of the IPv4 subnet mask. Allowed values: 29 (default), 30. The default value is 29, except for Cross-Cloud Interconnect connections that use an InterconnectRemoteLocation with a constraints.subnetLengthRange.min equal to 30. For example, connections that use an Azure remote location fall into this category. In these cases, the default value is 30, and requesting 29 returns an error. Where both 29 and 30 are allowed, 29 is preferred, because it gives Google Cloud Support more debugging visibility.</summary>
    [JsonPropertyName("subnetLength")]
    public double? SubnetLength { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The type of InterconnectAttachment you wish to create. Defaults to DEDICATED. Possible values are: DEDICATED, PARTNER, PARTNER_PROVIDER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When using PARTNER type this will be managed upstream.</summary>
    [JsonPropertyName("vlanTag8021Q")]
    public double? VlanTag8021Q { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentStatusConditions
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

/// <summary>InterconnectAttachmentStatus defines the observed state of InterconnectAttachment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InterconnectAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InterconnectAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InterconnectAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InterconnectAttachment is the Schema for the InterconnectAttachments API. Represents an InterconnectAttachment (VLAN attachment) resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InterconnectAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InterconnectAttachmentSpec>, IStatus<V1beta1InterconnectAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InterconnectAttachment";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "interconnectattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InterconnectAttachmentSpec defines the desired state of InterconnectAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1InterconnectAttachmentSpec Spec { get; set; }

    /// <summary>InterconnectAttachmentStatus defines the observed state of InterconnectAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1InterconnectAttachmentStatus? Status { get; set; }
}