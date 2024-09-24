using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Controls for advanced machine-related behavior features.</summary>
public partial class V1beta1ComputeInstanceSpecAdvancedMachineFeatures
{
    /// <summary>Whether to enable nested virtualization or not.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public int? ThreadsPerCore { get; set; }

    /// <summary>The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\'s nominal CPU count and the underlying platform\'s SMT width.</summary>
    [JsonPropertyName("visibleCoreCount")]
    public int? VisibleCoreCount { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRawValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRawValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRawValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link and disk_encryption_key_raw may be set.</summary>
public partial class V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRaw
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRawValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecAttachedDiskKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
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
public partial class V1beta1ComputeInstanceSpecAttachedDiskSourceDiskRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeDisk` resource.</summary>
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
public partial class V1beta1ComputeInstanceSpecAttachedDisk
{
    /// <summary>Name with which the attached disk is accessible under /dev/disk/by-id/.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRaw")]
    public V1beta1ComputeInstanceSpecAttachedDiskDiskEncryptionKeyRaw? DiskEncryptionKeyRaw { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("diskEncryptionKeySha256")]
    public string? DiskEncryptionKeySha256 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeInstanceSpecAttachedDiskKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Read/write mode for the disk. One of "READ_ONLY" or "READ_WRITE".</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ComputeInstanceSpecAttachedDiskSourceDiskRef SourceDiskRef { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRawValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRawValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRawValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link and disk_encryption_key_raw may be set.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRaw
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRawValueFrom? ValueFrom { get; set; }
}

/// <summary>Immutable. The image from which to initialize this disk.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskInitializeParamsSourceImageRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeImage` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Parameters with which a disk was created alongside the instance.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskInitializeParams
{
    /// <summary>Immutable. A set of key/value label pairs assigned to the disk.</summary>
    [JsonPropertyName("labels")]
    public JsonNode? Labels { get; set; }

    /// <summary>Immutable. A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp; PATCH) when empty.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public JsonNode? ResourceManagerTags { get; set; }

    /// <summary>Immutable. The size of the image in gigabytes.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>Immutable. The image from which to initialize this disk.</summary>
    [JsonPropertyName("sourceImageRef")]
    public V1beta1ComputeInstanceSpecBootDiskInitializeParamsSourceImageRef? SourceImageRef { get; set; }

    /// <summary>Immutable. The Google Compute Engine disk type. Such as pd-standard, pd-ssd or pd-balanced.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecBootDiskKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The source disk used to create this disk.</summary>
public partial class V1beta1ComputeInstanceSpecBootDiskSourceDiskRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeDisk` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The boot disk for the instance.</summary>
public partial class V1beta1ComputeInstanceSpecBootDisk
{
    /// <summary>Immutable. Whether the disk will be auto-deleted when the instance is deleted.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Immutable. Name with which attached disk will be accessible under /dev/disk/by-id/.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Immutable. A 256-bit customer-supplied encryption key, encoded in RFC 4648 base64 to encrypt this disk. Only one of kms_key_self_link and disk_encryption_key_raw may be set.</summary>
    [JsonPropertyName("diskEncryptionKeyRaw")]
    public V1beta1ComputeInstanceSpecBootDiskDiskEncryptionKeyRaw? DiskEncryptionKeyRaw { get; set; }

    /// <summary>The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied encryption key that protects this resource.</summary>
    [JsonPropertyName("diskEncryptionKeySha256")]
    public string? DiskEncryptionKeySha256 { get; set; }

    /// <summary>Immutable. Parameters with which a disk was created alongside the instance.</summary>
    [JsonPropertyName("initializeParams")]
    public V1beta1ComputeInstanceSpecBootDiskInitializeParams? InitializeParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeInstanceSpecBootDiskKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Immutable. Read/write mode for the disk. One of "READ_ONLY" or "READ_WRITE".</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. The source disk used to create this disk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ComputeInstanceSpecBootDiskSourceDiskRef? SourceDiskRef { get; set; }
}

/// <summary>Immutable. The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.</summary>
public partial class V1beta1ComputeInstanceSpecConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool EnableConfidentialCompute { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecGuestAccelerator
{
    /// <summary>Immutable. The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>Immutable. The accelerator type resource exposed to this instance. E.g. nvidia-tesla-t4.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecInstanceTemplateRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstanceTemplate` resource.</summary>
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
public partial class V1beta1ComputeInstanceSpecMetadata
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceAccessConfigNatIpRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceAccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("natIpRef")]
    public V1beta1ComputeInstanceSpecNetworkInterfaceAccessConfigNatIpRef? NatIpRef { get; set; }

    /// <summary>The networking tier used for configuring this instance. One of PREMIUM or STANDARD.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The DNS domain name for the public PTR record.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceIpv6AccessConfig
{
    /// <summary>Immutable. The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. To use a static external IP address, it must be unused and in the same region as the instance's zone. If not specified, Google Cloud will automatically assign an external IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary>Immutable. The prefix length of the external IPv6 range.</summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>Immutable. The name of this access configuration. In ipv6AccessConfigs, the recommended name is External IPv6.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string NetworkTier { get; set; }

    /// <summary>The domain name to be used when creating DNSv6 records for the external IPv6 ranges.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceNetworkIpRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: ComputeAddress</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceNetworkRef
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
public partial class V1beta1ComputeInstanceSpecNetworkInterfaceSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
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
public partial class V1beta1ComputeInstanceSpecNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1ComputeInstanceSpecNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1ComputeInstanceSpecNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary>The prefix length of the primary internal IPv6 range.</summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public int? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1ComputeInstanceSpecNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary>One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name of the interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>DEPRECATED. Although this field is still available, there is limited support. We recommend that you use `spec.networkInterface.networkIpRef` instead.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkIpRef")]
    public V1beta1ComputeInstanceSpecNetworkInterfaceNetworkIpRef? NetworkIpRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeInstanceSpecNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Immutable. The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public int? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>The project in which the subnetwork belongs.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeInstanceSpecNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>Immutable. Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.</summary>
public partial class V1beta1ComputeInstanceSpecNetworkPerformanceConfig
{
    /// <summary>Immutable. The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string TotalEgressBandwidthTier { get; set; }
}

/// <summary>Immutable. Stores additional params passed with the request, but not persisted as part of resource payload.</summary>
public partial class V1beta1ComputeInstanceSpecParams
{
    /// <summary>Immutable. A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp; PATCH) when empty.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public JsonNode? ResourceManagerTags { get; set; }
}

/// <summary>Immutable. Specifies the label selector for the reservation to use.</summary>
public partial class V1beta1ComputeInstanceSpecReservationAffinitySpecificReservation
{
    /// <summary>Immutable. Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Immutable. Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string> Values { get; set; }
}

/// <summary>Immutable. Specifies the reservations that this instance can consume from.</summary>
public partial class V1beta1ComputeInstanceSpecReservationAffinity
{
    /// <summary>Immutable. Specifies the label selector for the reservation to use.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ComputeInstanceSpecReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>Immutable. The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecResourcePolicies
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeResourcePolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Specifies the maximum amount of time a Local Ssd Vm should wait while   recovery of the Local Ssd state is attempted. Its value should be in   between 0 and 168 hours with hour granularity and the default value being 1   hour.</summary>
public partial class V1beta1ComputeInstanceSpecSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Immutable. Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Immutable. Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Immutable. The timeout for new network connections to hosts.</summary>
public partial class V1beta1ComputeInstanceSpecSchedulingMaxRunDuration
{
    /// <summary>Immutable. Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Immutable. Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecSchedulingNodeAffinities
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>The scheduling strategy being used by the instance.</summary>
public partial class V1beta1ComputeInstanceSpecScheduling
{
    /// <summary>Specifies if the instance should be restarted if it was terminated by Compute Engine (not a user).</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the action GCE should take when SPOT VM is preempted.</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>Immutable. Specifies the maximum amount of time a Local Ssd Vm should wait while   recovery of the Local Ssd state is attempted. Its value should be in   between 0 and 168 hours with hour granularity and the default value being 1   hour.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public V1beta1ComputeInstanceSpecSchedulingLocalSsdRecoveryTimeout? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>Specifies the frequency of planned maintenance events. The accepted values are: PERIODIC.</summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }

    /// <summary>Immutable. The timeout for new network connections to hosts.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1ComputeInstanceSpecSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCpus")]
    public int? MinNodeCpus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1ComputeInstanceSpecSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Describes maintenance behavior for the instance. One of MIGRATE or TERMINATE,.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Immutable. Whether the instance is preemptible.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Immutable. Whether the instance is spot. If this is set as SPOT.</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecScratchDisk
{
    /// <summary>The disk interface used for attaching this disk. One of SCSI or NVME.</summary>
    [JsonPropertyName("interface")]
    public string Interface { get; set; }

    /// <summary>Immutable. The size of the disk in gigabytes. One of 375 or 3000.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpecServiceAccountServiceAccountRef
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

/// <summary>The service account to attach to the instance.</summary>
public partial class V1beta1ComputeInstanceSpecServiceAccount
{
    /// <summary>A list of service scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string> Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ComputeInstanceSpecServiceAccountServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary>The shielded vm config being used by the instance.</summary>
public partial class V1beta1ComputeInstanceSpecShieldedInstanceConfig
{
    /// <summary>Whether integrity monitoring is enabled for the instance.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Whether secure boot is enabled for the instance.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Whether the instance uses vTPM.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceSpec
{
    /// <summary>Controls for advanced machine-related behavior features.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ComputeInstanceSpecAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>List of disks attached to the instance.</summary>
    [JsonPropertyName("attachedDisk")]
    public IList<V1beta1ComputeInstanceSpecAttachedDisk>? AttachedDisk { get; set; }

    /// <summary>Immutable. The boot disk for the instance.</summary>
    [JsonPropertyName("bootDisk")]
    public V1beta1ComputeInstanceSpecBootDisk? BootDisk { get; set; }

    /// <summary>Whether sending and receiving of packets with non-matching source or destination IPs is allowed.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Immutable. The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1ComputeInstanceSpecConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Whether deletion protection is enabled on this instance.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Immutable. A brief description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Desired status of the instance. Either "RUNNING" or "TERMINATED".</summary>
    [JsonPropertyName("desiredStatus")]
    public string? DesiredStatus { get; set; }

    /// <summary>Whether the instance has virtual displays enabled.</summary>
    [JsonPropertyName("enableDisplay")]
    public bool? EnableDisplay { get; set; }

    /// <summary>Immutable. List of the type and count of accelerator cards attached to the instance.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ComputeInstanceSpecGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Immutable. A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta1ComputeInstanceSpecInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1ComputeInstanceSpecMetadata>? Metadata { get; set; }

    /// <summary>Immutable. Metadata startup scripts made available within the instance.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>The minimum CPU platform specified for the VM instance.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. The networks attached to the instance.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1ComputeInstanceSpecNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Immutable. Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ComputeInstanceSpecNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Immutable. Stores additional params passed with the request, but not persisted as part of resource payload.</summary>
    [JsonPropertyName("params")]
    public V1beta1ComputeInstanceSpecParams? Params { get; set; }

    /// <summary>Immutable. Specifies the reservations that this instance can consume from.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ComputeInstanceSpecReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<V1beta1ComputeInstanceSpecResourcePolicies>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy being used by the instance.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1ComputeInstanceSpecScheduling? Scheduling { get; set; }

    /// <summary>Immutable. The scratch disks attached to the instance.</summary>
    [JsonPropertyName("scratchDisk")]
    public IList<V1beta1ComputeInstanceSpecScratchDisk>? ScratchDisk { get; set; }

    /// <summary>The service account to attach to the instance.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1ComputeInstanceSpecServiceAccount? ServiceAccount { get; set; }

    /// <summary>The shielded vm config being used by the instance.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ComputeInstanceSpecShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>The list of tags attached to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Immutable. The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceStatusConditions
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
public partial class V1beta1ComputeInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>The CPU platform used by this instance.</summary>
    [JsonPropertyName("cpuPlatform")]
    public string? CpuPlatform { get; set; }

    /// <summary> 					Current status of the instance. 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED. 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).</summary>
    [JsonPropertyName("currentStatus")]
    public string? CurrentStatus { get; set; }

    /// <summary>The server-assigned unique identifier of this instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>The unique fingerprint of the labels.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>The unique fingerprint of the metadata.</summary>
    [JsonPropertyName("metadataFingerprint")]
    public string? MetadataFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The unique fingerprint of the tags.</summary>
    [JsonPropertyName("tagsFingerprint")]
    public string? TagsFingerprint { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1ComputeInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeInstanceSpec>, IStatus<V1beta1ComputeInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeInstance";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeinstances";
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
    public V1beta1ComputeInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeInstanceStatus? Status { get; set; }
}