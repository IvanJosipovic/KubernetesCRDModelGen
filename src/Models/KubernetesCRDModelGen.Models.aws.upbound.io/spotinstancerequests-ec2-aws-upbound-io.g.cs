using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1SpotInstanceRequestSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecification
{
    /// <summary></summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderCpuOptions
{
    /// <summary></summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderCreditSpecification
{
    /// <summary></summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderEnclaveOptions
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderEphemeralBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderMaintenanceOptions
{
    /// <summary></summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderMetadataOptions
{
    /// <summary></summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderNetworkInterface
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderPrivateDnsNameOptions
{
    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The required duration for the Spot instances, in minutes. This value must be a multiple of 60 (60, 120, 180, 240, 300, or 360). The duration period starts as soon as your Spot instance receives its instance ID. At the end of the duration period, Amazon EC2 marks the Spot instance for termination and provides a Spot instance termination notice, which gives the instance a two-minute warning before it terminates. Note that you can't specify an Availability Zone group or a launch group if you specify a duration.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A launch group is a group of spot instances that launch together and terminate together. If left empty instances are launched and terminated individually.</summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>If set to one-time, after the instance is terminated, the spot request will be closed.</summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecification
{
    /// <summary></summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderCpuOptions
{
    /// <summary></summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderCreditSpecification
{
    /// <summary></summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderEnclaveOptions
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderEphemeralBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderMaintenanceOptions
{
    /// <summary></summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderMetadataOptions
{
    /// <summary></summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderNetworkInterface
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions
{
    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SpotInstanceRequestSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The required duration for the Spot instances, in minutes. This value must be a multiple of 60 (60, 120, 180, 240, 300, or 360). The duration period starts as soon as your Spot instance receives its instance ID. At the end of the duration period, Amazon EC2 marks the Spot instance for termination and provides a Spot instance termination notice, which gives the instance a two-minute warning before it terminates. Note that you can't specify an Availability Zone group or a launch group if you specify a duration.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A launch group is a group of spot instances that launch together and terminate together. If left empty instances are launched and terminated individually.</summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>If set to one-time, after the instance is terminated, the spot request will be closed.</summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecManagementPoliciesEnum
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

public enum V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SpotInstanceRequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1SpotInstanceRequestSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SpotInstanceRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
public partial class V1beta1SpotInstanceRequestSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecDeletionPolicyEnum>))]
    public V1beta1SpotInstanceRequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpotInstanceRequestSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpotInstanceRequestSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpotInstanceRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpotInstanceRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpotInstanceRequestSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpotInstanceRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecification
{
    /// <summary></summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderCpuOptions
{
    /// <summary></summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderCreditSpecification
{
    /// <summary></summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderEnclaveOptions
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderEphemeralBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderMaintenanceOptions
{
    /// <summary></summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderMetadataOptions
{
    /// <summary></summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderNetworkInterface
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions
{
    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProviderRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpotInstanceRequestStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The required duration for the Spot instances, in minutes. This value must be a multiple of 60 (60, 120, 180, 240, 300, or 360). The duration period starts as soon as your Spot instance receives its instance ID. At the end of the duration period, Amazon EC2 marks the Spot instance for termination and provides a Spot instance termination notice, which gives the instance a two-minute warning before it terminates. Note that you can't specify an Availability Zone group or a launch group if you specify a duration.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceState")]
    public string? InstanceState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A launch group is a group of spot instances that launch together and terminate together. If left empty instances are launched and terminated individually.</summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordData")]
    public string? PasswordData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("primaryNetworkInterfaceId")]
    public string? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>The private DNS name assigned to the instance. Can only be used inside the Amazon EC2, and only available if you've enabled DNS hostnames for your VPC</summary>
    [JsonPropertyName("privateDns")]
    public string? PrivateDns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>The public DNS name assigned to the instance. For EC2-VPC, this is only available if you've enabled DNS hostnames for your VPC</summary>
    [JsonPropertyName("publicDns")]
    public string? PublicDns { get; set; }

    /// <summary>The public IP address assigned to the instance, if applicable.</summary>
    [JsonPropertyName("publicIp")]
    public string? PublicIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>The current bid status of the Spot Instance Request.</summary>
    [JsonPropertyName("spotBidStatus")]
    public string? SpotBidStatus { get; set; }

    /// <summary>The Instance ID (if any) that is currently fulfilling the Spot Instance request.</summary>
    [JsonPropertyName("spotInstanceId")]
    public string? SpotInstanceId { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The current request state of the Spot Instance Request.</summary>
    [JsonPropertyName("spotRequestState")]
    public string? SpotRequestState { get; set; }

    /// <summary>If set to one-time, after the instance is terminated, the spot request will be closed.</summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1SpotInstanceRequestStatusConditions
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

/// <summary>SpotInstanceRequestStatus defines the observed state of SpotInstanceRequest.</summary>
public partial class V1beta1SpotInstanceRequestStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpotInstanceRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpotInstanceRequestStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SpotInstanceRequest is the Schema for the SpotInstanceRequests API. Provides a Spot Instance Request resource.</summary>
public partial class V1beta1SpotInstanceRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpotInstanceRequestSpec>, IStatus<V1beta1SpotInstanceRequestStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpotInstanceRequest";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotinstancerequests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpotInstanceRequestSpec Spec { get; set; }

    /// <summary>SpotInstanceRequestStatus defines the observed state of SpotInstanceRequest.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpotInstanceRequestStatus? Status { get; set; }
}