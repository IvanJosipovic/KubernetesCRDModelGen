using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Immutable. Controls for advanced machine-related behavior features.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecAdvancedMachineFeatures
{
    /// <summary>Immutable. Whether to enable nested virtualization or not.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Immutable. The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public int? ThreadsPerCore { get; set; }

    /// <summary>Immutable. The number of physical cores to expose to an instance. Multiply by the number of threads per core to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is inferred from the instance\'s nominal CPU count and the underlying platform\'s SMT width.</summary>
    [JsonPropertyName("visibleCoreCount")]
    public int? VisibleCoreCount { get; set; }
}

/// <summary>Immutable. The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecConfidentialInstanceConfig
{
    /// <summary>Immutable. Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool EnableConfidentialCompute { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskDiskEncryptionKeyKmsKeyRef
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

/// <summary>Immutable. Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskDiskEncryptionKey
{
    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskDiskEncryptionKeyKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskResourcePolicies
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

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceDiskRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeDisk` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKeyKmsKeySelfLinkRef
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

/// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKeyKmsKeyServiceAccountRef
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

/// <summary>Immutable. The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.  Instance templates do not store customer-supplied encryption keys, so you cannot create disks for instances in a managed instance group if the source images are encrypted with your own keys.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLinkRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKeyKmsKeySelfLinkRef KmsKeySelfLinkRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceImageRef
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

/// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKeyKmsKeySelfLinkRef
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

/// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKeyKmsKeyServiceAccountRef
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

/// <summary>Immutable. The customer-supplied encryption key of the source snapshot.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeySelfLinkRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKeyKmsKeySelfLinkRef KmsKeySelfLinkRef { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccountRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKeyKmsKeyServiceAccountRef? KmsKeyServiceAccountRef { get; set; }
}

/// <summary>The source snapshot to create this disk. When creating a new instance, one of initializeParams.sourceSnapshot, initializeParams.sourceImage, or disks.source is required except for local SSD.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSnapshot` resource.</summary>
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
public partial class V1beta1ComputeInstanceTemplateSpecDisk
{
    /// <summary>Immutable. Whether or not the disk should be auto-deleted. This defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Immutable. Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>Immutable. A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Immutable. Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1ComputeInstanceTemplateSpecDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Immutable. Name of the disk. When not provided, this defaults to the name of the instance.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>Immutable. The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be one of 375 or 3000 GB, with a default of 375 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>Immutable. The Google Compute Engine disk type. Such as "pd-ssd", "local-ssd", "pd-balanced" or "pd-standard".</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Immutable. Specifies the disk interface to use for attaching this disk.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Immutable. A set of key/value label pairs to assign to disks,.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. Values must be between 10,000 and 120,000. For more details, see the [Extreme persistent disk documentation](https://cloud.google.com/compute/docs/disks/extreme-persistent-disk).</summary>
    [JsonPropertyName("provisionedIops")]
    public int? ProvisionedIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<V1beta1ComputeInstanceTemplateSpecDiskResourcePolicies>? ResourcePolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Immutable. The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.  Instance templates do not store customer-supplied encryption keys, so you cannot create disks for instances in a managed instance group if the source images are encrypted with your own keys.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceImageRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceImageRef? SourceImageRef { get; set; }

    /// <summary>Immutable. The customer-supplied encryption key of the source snapshot.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The source snapshot to create this disk. When creating a new instance, one of initializeParams.sourceSnapshot, initializeParams.sourceImage, or disks.source is required except for local SSD.</summary>
    [JsonPropertyName("sourceSnapshotRef")]
    public V1beta1ComputeInstanceTemplateSpecDiskSourceSnapshotRef? SourceSnapshotRef { get; set; }

    /// <summary>Immutable. The type of Google Compute Engine disk, can be either "SCRATCH" or "PERSISTENT".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecGuestAccelerator
{
    /// <summary>Immutable. The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>Immutable. The accelerator type resource to expose to this instance. E.g. nvidia-tesla-t4.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecMetadata
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAccessConfigNatIpRef
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
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("natIpRef")]
    public V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAccessConfigNatIpRef? NatIpRef { get; set; }

    /// <summary>Immutable. The networking tier used for configuring this instance template. This field can take the following values: PREMIUM, STANDARD, FIXED_STANDARD. If this field is not specified, it is assumed to be PREMIUM.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The DNS domain name for the public PTR record.The DNS domain name for the public PTR record.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAliasIpRange
{
    /// <summary>Immutable. The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. At the time of writing only a netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API error.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string IpCidrRange { get; set; }

    /// <summary>Immutable. The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The first IPv6 address of the external IPv6 range associated with this instance, prefix length is stored in externalIpv6PrefixLength in ipv6AccessConfig. The field is output only, an IPv6 address from a subnetwork associated with the instance will be allocated dynamically.</summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary>The prefix length of the external IPv6 range.</summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>The name of this access configuration.</summary>
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
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceNetworkRef
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
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterfaceSubnetworkRef
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
public partial class V1beta1ComputeInstanceTemplateSpecNetworkInterface
{
    /// <summary></summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>Immutable. An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1ComputeInstanceTemplateSpecNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary>The prefix length of the primary internal IPv6 range.</summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public int? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1ComputeInstanceTemplateSpecNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary>One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the Internet. This field is always inherited from its subnetwork.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>An IPv6 internal network address for this network interface. If not specified, Google Cloud will automatically assign an internal IPv6 address from the instance's subnetwork.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name of the network_interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Immutable. The URL of the network attachment that this interface should connect to in the following format: projects/{projectNumber}/regions/{region_name}/networkAttachments/{network_attachment_name}.</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    /// <summary>Immutable. The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeInstanceTemplateSpecNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The type of vNIC to be used on this interface. Possible values:GVNIC, VIRTIO_NET.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Immutable. The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public int? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>Immutable. The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeInstanceTemplateSpecNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>Immutable. Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecNetworkPerformanceConfig
{
    /// <summary>Immutable. The egress bandwidth tier to enable. Possible values:TIER_1, DEFAULT.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string TotalEgressBandwidthTier { get; set; }
}

/// <summary>Immutable. Specifies the label selector for the reservation to use.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecReservationAffinitySpecificReservation
{
    /// <summary>Immutable. Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Immutable. Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string> Values { get; set; }
}

/// <summary>Immutable. Specifies the reservations that this instance can consume from.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecReservationAffinity
{
    /// <summary>Immutable. Specifies the label selector for the reservation to use.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ComputeInstanceTemplateSpecReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>Immutable. The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecResourcePolicies
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

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Immutable. Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Immutable. Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Immutable. The timeout for new network connections to hosts.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecSchedulingMaxRunDuration
{
    /// <summary>Immutable. Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Immutable. Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecSchedulingNodeAffinities
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>Immutable. The scheduling strategy to use.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecScheduling
{
    /// <summary>Immutable. Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Immutable. Specifies the action GCE should take when SPOT VM is preempted.</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>Specifies the maximum amount of time a Local Ssd Vm should wait while   recovery of the Local Ssd state is attempted. Its value should be in   between 0 and 168 hours with hour granularity and the default value being 1   hour.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta1ComputeInstanceTemplateSpecSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>Specifies the frequency of planned maintenance events. The accepted values are: PERIODIC.</summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }

    /// <summary>Immutable. The timeout for new network connections to hosts.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1ComputeInstanceTemplateSpecSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary>Minimum number of cpus for the instance.</summary>
    [JsonPropertyName("minNodeCpus")]
    public int? MinNodeCpus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1ComputeInstanceTemplateSpecSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Immutable. Defines the maintenance behavior for this instance.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Immutable. Allows instance to be preempted. This defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Immutable. Whether the instance is spot. If this is set as SPOT.</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpecServiceAccountServiceAccountRef
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

/// <summary>Immutable. Service account to attach to the instance.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecServiceAccount
{
    /// <summary>Immutable. A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope.</summary>
    [JsonPropertyName("scopes")]
    public IList<string> Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ComputeInstanceTemplateSpecServiceAccountServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary>Immutable. Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.</summary>
public partial class V1beta1ComputeInstanceTemplateSpecShieldedInstanceConfig
{
    /// <summary>Immutable. Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Immutable. Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Immutable. Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateSpec
{
    /// <summary>Immutable. Controls for advanced machine-related behavior features.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ComputeInstanceTemplateSpecAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>Immutable. Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Immutable. The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1ComputeInstanceTemplateSpecConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Immutable. A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1ComputeInstanceTemplateSpecDisk> Disk { get; set; }

    /// <summary>Immutable. Enable Virtual Displays on this instance. Note: allow_stopping_for_update must be set to true in order to update this field.</summary>
    [JsonPropertyName("enableDisplay")]
    public bool? EnableDisplay { get; set; }

    /// <summary>Immutable. List of the type and count of accelerator cards attached to the instance.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ComputeInstanceTemplateSpecGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Immutable. A description of the instance.</summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Immutable. The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.</summary>
    [JsonPropertyName("machineType")]
    public string MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1ComputeInstanceTemplateSpecMetadata>? Metadata { get; set; }

    /// <summary>Immutable. An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Immutable. Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Creates a unique name beginning with the specified prefix. Conflicts with name.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Immutable. Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1ComputeInstanceTemplateSpecNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Immutable. Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ComputeInstanceTemplateSpecNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Immutable. An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Immutable. Specifies the reservations that this instance can consume from.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ComputeInstanceTemplateSpecReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<V1beta1ComputeInstanceTemplateSpecResourcePolicies>? ResourcePolicies { get; set; }

    /// <summary>Immutable. The scheduling strategy to use.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1ComputeInstanceTemplateSpecScheduling? Scheduling { get; set; }

    /// <summary>Immutable. Service account to attach to the instance.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1ComputeInstanceTemplateSpecServiceAccount? ServiceAccount { get; set; }

    /// <summary>Immutable. Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ComputeInstanceTemplateSpecShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Immutable. Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplateStatusConditions
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
public partial class V1beta1ComputeInstanceTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeInstanceTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>The unique fingerprint of the metadata.</summary>
    [JsonPropertyName("metadataFingerprint")]
    public string? MetadataFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A special URI of the created resource that uniquely identifies this instance template.</summary>
    [JsonPropertyName("selfLinkUnique")]
    public string? SelfLinkUnique { get; set; }

    /// <summary>The unique fingerprint of the tags.</summary>
    [JsonPropertyName("tagsFingerprint")]
    public string? TagsFingerprint { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1ComputeInstanceTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeInstanceTemplateSpec>, IStatus<V1beta1ComputeInstanceTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeInstanceTemplate";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeinstancetemplates";
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
    public V1beta1ComputeInstanceTemplateSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeInstanceTemplateStatus? Status { get; set; }
}