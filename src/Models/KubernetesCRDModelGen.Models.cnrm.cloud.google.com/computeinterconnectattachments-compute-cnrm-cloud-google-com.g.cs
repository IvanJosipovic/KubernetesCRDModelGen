using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Immutable. The addresses that have been reserved for the interconnect attachment. Used only for interconnect attachment that has the encryption option as IPSEC.  The addresses must be RFC 1918 IP address ranges. When creating HA VPN gateway over the interconnect attachment, if the attachment is configured to use an RFC 1918 IP address, then the VPN gateway's IP address will be allocated from the IP address range specified here.  For example, if the HA VPN gateway's interface 0 is paired to this interconnect attachment, then an RFC 1918 IP address for the VPN gateway interface 0 will be allocated from the IP address specified for this interconnect attachment.  If this field is not specified for interconnect attachment that has encryption option as IPSEC, later on when creating HA VPN gateway on this interconnect attachment, the HA VPN gateway's IP address will be allocated from regional external IP address pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInterconnectAttachmentSpecIpsecInternalAddresses
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Cloud Router to be used for dynamic routing. This router must be in the same region as this ComputeInterconnectAttachment. The ComputeInterconnectAttachment will automatically connect the interconnect to the network &amp; region within which the Cloud Router is configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInterconnectAttachmentSpecRouterRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeRouter` resource.</summary>
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
public partial class V1beta1ComputeInterconnectAttachmentSpec
{
    /// <summary>Whether the VLAN attachment is enabled or disabled.  When using PARTNER type this will Pre-Activate the interconnect attachment.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>Provisioned bandwidth capacity for the interconnect attachment. For attachments of type DEDICATED, the user can set the bandwidth. For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth. Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED, Defaults to BPS_10G Possible values: ["BPS_50M", "BPS_100M", "BPS_200M", "BPS_300M", "BPS_400M", "BPS_500M", "BPS_1G", "BPS_2G", "BPS_5G", "BPS_10G", "BPS_20G", "BPS_50G"].</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>Immutable. Up to 16 candidate prefixes that can be used to restrict the allocation of cloudRouterIpAddress and customerRouterIpAddress for this attachment. All prefixes must be within link-local address space (169.254.0.0/16) and must be /29 or shorter (/28, /27, etc). Google will attempt to select an unused /29 from the supplied candidate prefix(es). The request will fail if all possible /29s are in use on Google's edge. If not supplied, Google will randomly select an unused /29 from all of link-local space.</summary>
    [JsonPropertyName("candidateSubnets")]
    public IList<string>? CandidateSubnets { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Desired availability domain for the attachment. Only available for type PARTNER, at creation time. For improved reliability, customers should configure a pair of attachments with one per availability domain. The selected availability domain will be provided to the Partner via the pairing key so that the provisioned circuit will lie in the specified domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.</summary>
    [JsonPropertyName("edgeAvailabilityDomain")]
    public string? EdgeAvailabilityDomain { get; set; }

    /// <summary>Immutable. Indicates the user-supplied encryption option of this interconnect attachment. Can only be specified at attachment creation for PARTNER or DEDICATED attachments.  * NONE - This is the default value, which means that the VLAN attachment carries unencrypted traffic. VMs are able to send traffic to, or receive traffic from, such a VLAN attachment.  * IPSEC - The VLAN attachment carries only encrypted traffic that is encrypted by an IPsec device, such as an HA VPN gateway or third-party IPsec VPN. VMs cannot directly send traffic to, or receive traffic from, such a VLAN attachment. To use HA VPN over Cloud Interconnect, the VLAN attachment must be created with this option. Default value: "NONE" Possible values: ["NONE", "IPSEC"].</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Immutable. URL of the underlying Interconnect object that this attachment's traffic will traverse through. Required if type is DEDICATED, must not be set if type is PARTNER.</summary>
    [JsonPropertyName("interconnect")]
    public string? Interconnect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipsecInternalAddresses")]
    public IList<V1beta1ComputeInterconnectAttachmentSpecIpsecInternalAddresses>? IpsecInternalAddresses { get; set; }

    /// <summary>Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment. Currently, only 1440 and 1500 are allowed. If not specified, the value will default to 1440.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>Region where the regional interconnect attachment resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The Cloud Router to be used for dynamic routing. This router must be in the same region as this ComputeInterconnectAttachment. The ComputeInterconnectAttachment will automatically connect the interconnect to the network &amp; region within which the Cloud Router is configured.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1ComputeInterconnectAttachmentSpecRouterRef RouterRef { get; set; }

    /// <summary>Immutable. The type of InterconnectAttachment you wish to create. Defaults to DEDICATED. Possible values: ["DEDICATED", "PARTNER", "PARTNER_PROVIDER"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Immutable. The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When using PARTNER type this will be managed upstream.</summary>
    [JsonPropertyName("vlanTag8021q")]
    public int? VlanTag8021q { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInterconnectAttachmentStatusConditions
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

/// <summary>Information specific to an InterconnectAttachment. This property is populated if the interconnect that this is attached to is of type DEDICATED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInterconnectAttachmentStatusPrivateInterconnectInfo
{
    /// <summary>802.1q encapsulation tag to be used for traffic between Google and the customer, going to and from this network and region.</summary>
    [JsonPropertyName("tag8021q")]
    public int? Tag8021q { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeInterconnectAttachmentStatus
{
    /// <summary>IPv4 address + prefix length to be configured on Cloud Router Interface for this interconnect attachment.</summary>
    [JsonPropertyName("cloudRouterIpAddress")]
    public string? CloudRouterIpAddress { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeInterconnectAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>IPv4 address + prefix length to be configured on the customer router subinterface for this interconnect attachment.</summary>
    [JsonPropertyName("customerRouterIpAddress")]
    public string? CustomerRouterIpAddress { get; set; }

    /// <summary>Google reference ID, to be used when raising support tickets with Google or otherwise to debug backend connectivity issues.</summary>
    [JsonPropertyName("googleReferenceId")]
    public string? GoogleReferenceId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>[Output only for type PARTNER. Not present for DEDICATED]. The opaque identifier of an PARTNER attachment used to initiate provisioning with a selected partner. Of the form "XXXXX/region/domain".</summary>
    [JsonPropertyName("pairingKey")]
    public string? PairingKey { get; set; }

    /// <summary>[Output only for type PARTNER. Not present for DEDICATED]. Optional BGP ASN for the router that should be supplied by a layer 3 Partner if they configured BGP on behalf of the customer.</summary>
    [JsonPropertyName("partnerAsn")]
    public string? PartnerAsn { get; set; }

    /// <summary>Information specific to an InterconnectAttachment. This property is populated if the interconnect that this is attached to is of type DEDICATED.</summary>
    [JsonPropertyName("privateInterconnectInfo")]
    public V1beta1ComputeInterconnectAttachmentStatusPrivateInterconnectInfo? PrivateInterconnectInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>[Output Only] The current state of this attachment's functionality.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeInterconnectAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeInterconnectAttachmentSpec>, IStatus<V1beta1ComputeInterconnectAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeInterconnectAttachment";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeinterconnectattachments";
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
    public V1beta1ComputeInterconnectAttachmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeInterconnectAttachmentStatus? Status { get; set; }
}