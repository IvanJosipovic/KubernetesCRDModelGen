using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1LaunchTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbs
{
    /// <summary>Whether the volume should be destroyed on instance termination. See Preserving Amazon EBS Volumes on Instance Termination for more information.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Enables EBS encryption on the volume. Cannot be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1/io2/gp3".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ARN of the AWS Key Management Service (AWS KMS) customer master key (CMK) to use when creating the encrypted volume. encrypted must be set to true when this is set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The volume type. Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappingsEbs>? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name (e.g., "ephemeral0").</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be open or none. (Default none).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1LaunchTemplateSpecForProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>The number of threads per CPU core. To disable Intel Hyper-Threading Technology for the instance, specify a value of 1. Otherwise, specify the default value of 2.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderCreditSpecification
{
    /// <summary>The credit option for CPU usage. Can be standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderElasticGpuSpecifications
{
    /// <summary>The Elastic GPU Type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderElasticInferenceAccelerator
{
    /// <summary>Accelerator type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnRef? ArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileArnSelector? ArnSelector { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameRef? NameRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1LaunchTemplateSpecForProviderIamInstanceProfileNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>The behavior when a Spot Instance is interrupted. Can be hibernate, stop, or terminate. (Default: terminate).</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you're willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be "enabled" or "disabled". (Default: "enabled").</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be "optional" or "required". (Default: "optional").</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The name of the placement group for the instance.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
public partial class V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecForProvider
{
    /// <summary>Specify volumes to attach to the instance besides the volumes specified by the AMI. See Block Devices below for details.</summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta1LaunchTemplateSpecForProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1LaunchTemplateSpecForProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>Customize the credit specification of the instance. See Credit Specification below for more details.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1LaunchTemplateSpecForProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>The elastic GPU to attach to the instance. See Elastic GPU below for more details.</summary>
    [JsonPropertyName("elasticGpuSpecifications")]
    public IList<V1beta1LaunchTemplateSpecForProviderElasticGpuSpecifications>? ElasticGpuSpecifications { get; set; }

    /// <summary>Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.</summary>
    [JsonPropertyName("elasticInferenceAccelerator")]
    public IList<V1beta1LaunchTemplateSpecForProviderElasticInferenceAccelerator>? ElasticInferenceAccelerator { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderHibernationOptions>? HibernationOptions { get; set; }

    /// <summary>The IAM Instance Profile to launch the instance with. See Instance Profile below for more details.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public IList<V1beta1LaunchTemplateSpecForProviderIamInstanceProfile>? IamInstanceProfile { get; set; }

    /// <summary>The AMI from which to launch the instance.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>Shutdown behavior for the instance. Can be stop or terminate. (Default: stop).</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>The market (purchasing) option for the instance. See Market Options below for details.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1LaunchTemplateSpecForProviderInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta1LaunchTemplateSpecForProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public IList<V1beta1LaunchTemplateSpecForProviderMonitoring>? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1LaunchTemplateSpecForProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1LaunchTemplateSpecForProviderPlacement>? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1LaunchTemplateSpecForProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameRefs")]
    public IList<V1beta1LaunchTemplateSpecForProviderSecurityGroupNameRefs>? SecurityGroupNameRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameSelector")]
    public V1beta1LaunchTemplateSpecForProviderSecurityGroupNameSelector? SecurityGroupNameSelector { get; set; }

    /// <summary>A list of security group names to associate with. If you are creating Instances in a VPC, use vpc_security_group_ids instead.</summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta1LaunchTemplateSpecForProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1LaunchTemplateSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbs
{
    /// <summary>Whether the volume should be destroyed on instance termination. See Preserving Amazon EBS Volumes on Instance Termination for more information.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Enables EBS encryption on the volume. Cannot be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1/io2/gp3".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ARN of the AWS Key Management Service (AWS KMS) customer master key (CMK) to use when creating the encrypted volume. encrypted must be set to true when this is set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The volume type. Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappingsEbs>? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name (e.g., "ephemeral0").</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be open or none. (Default none).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1LaunchTemplateSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>The number of threads per CPU core. To disable Intel Hyper-Threading Technology for the instance, specify a value of 1. Otherwise, specify the default value of 2.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderCreditSpecification
{
    /// <summary>The credit option for CPU usage. Can be standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderElasticGpuSpecifications
{
    /// <summary>The Elastic GPU Type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderElasticInferenceAccelerator
{
    /// <summary>Accelerator type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnRef? ArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileArnSelector? ArnSelector { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameRef? NameRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1LaunchTemplateSpecInitProviderIamInstanceProfileNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>The behavior when a Spot Instance is interrupted. Can be hibernate, stop, or terminate. (Default: terminate).</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you're willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be "enabled" or "disabled". (Default: "enabled").</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be "optional" or "required". (Default: "optional").</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The name of the placement group for the instance.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateSpecInitProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
public partial class V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1LaunchTemplateSpecInitProvider
{
    /// <summary>Specify volumes to attach to the instance besides the volumes specified by the AMI. See Block Devices below for details.</summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta1LaunchTemplateSpecInitProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1LaunchTemplateSpecInitProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>Customize the credit specification of the instance. See Credit Specification below for more details.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1LaunchTemplateSpecInitProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>The elastic GPU to attach to the instance. See Elastic GPU below for more details.</summary>
    [JsonPropertyName("elasticGpuSpecifications")]
    public IList<V1beta1LaunchTemplateSpecInitProviderElasticGpuSpecifications>? ElasticGpuSpecifications { get; set; }

    /// <summary>Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.</summary>
    [JsonPropertyName("elasticInferenceAccelerator")]
    public IList<V1beta1LaunchTemplateSpecInitProviderElasticInferenceAccelerator>? ElasticInferenceAccelerator { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderHibernationOptions>? HibernationOptions { get; set; }

    /// <summary>The IAM Instance Profile to launch the instance with. See Instance Profile below for more details.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public IList<V1beta1LaunchTemplateSpecInitProviderIamInstanceProfile>? IamInstanceProfile { get; set; }

    /// <summary>The AMI from which to launch the instance.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>Shutdown behavior for the instance. Can be stop or terminate. (Default: stop).</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>The market (purchasing) option for the instance. See Market Options below for details.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1LaunchTemplateSpecInitProviderInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta1LaunchTemplateSpecInitProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public IList<V1beta1LaunchTemplateSpecInitProviderMonitoring>? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1LaunchTemplateSpecInitProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1LaunchTemplateSpecInitProviderPlacement>? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1LaunchTemplateSpecInitProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameRefs")]
    public IList<V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameRefs>? SecurityGroupNameRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameSelector")]
    public V1beta1LaunchTemplateSpecInitProviderSecurityGroupNameSelector? SecurityGroupNameSelector { get; set; }

    /// <summary>A list of security group names to associate with. If you are creating Instances in a VPC, use vpc_security_group_ids instead.</summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta1LaunchTemplateSpecInitProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

public enum V1beta1LaunchTemplateSpecManagementPoliciesEnum
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

public enum V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1LaunchTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1LaunchTemplateSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LaunchTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1LaunchTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LaunchTemplateSpec defines the desired state of LaunchTemplate</summary>
public partial class V1beta1LaunchTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LaunchTemplateSpecDeletionPolicyEnum>))]
    public V1beta1LaunchTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LaunchTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LaunchTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LaunchTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LaunchTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LaunchTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LaunchTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderBlockDeviceMappingsEbs
{
    /// <summary>Whether the volume should be destroyed on instance termination. See Preserving Amazon EBS Volumes on Instance Termination for more information.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Enables EBS encryption on the volume. Cannot be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1/io2/gp3".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ARN of the AWS Key Management Service (AWS KMS) customer master key (CMK) to use when creating the encrypted volume. encrypted must be set to true when this is set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The volume type. Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1LaunchTemplateStatusAtProviderBlockDeviceMappingsEbs>? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name (e.g., "ephemeral0").</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be open or none. (Default none).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1LaunchTemplateStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>The number of threads per CPU core. To disable Intel Hyper-Threading Technology for the instance, specify a value of 1. Otherwise, specify the default value of 2.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderCreditSpecification
{
    /// <summary>The credit option for CPU usage. Can be standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderElasticGpuSpecifications
{
    /// <summary>The Elastic GPU Type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderElasticInferenceAccelerator
{
    /// <summary>Accelerator type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>The behavior when a Spot Instance is interrupted. Can be hibernate, stop, or terminate. (Default: terminate).</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you're willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be "enabled" or "disabled". (Default: "enabled").</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be "optional" or "required". (Default: "optional").</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be "enabled" or "disabled".</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The name of the placement group for the instance.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1LaunchTemplateStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the launch template.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specify volumes to attach to the instance besides the volumes specified by the AMI. See Block Devices below for details.</summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta1LaunchTemplateStatusAtProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1LaunchTemplateStatusAtProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>Customize the credit specification of the instance. See Credit Specification below for more details.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1LaunchTemplateStatusAtProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>The elastic GPU to attach to the instance. See Elastic GPU below for more details.</summary>
    [JsonPropertyName("elasticGpuSpecifications")]
    public IList<V1beta1LaunchTemplateStatusAtProviderElasticGpuSpecifications>? ElasticGpuSpecifications { get; set; }

    /// <summary>Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.</summary>
    [JsonPropertyName("elasticInferenceAccelerator")]
    public IList<V1beta1LaunchTemplateStatusAtProviderElasticInferenceAccelerator>? ElasticInferenceAccelerator { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderHibernationOptions>? HibernationOptions { get; set; }

    /// <summary>The IAM Instance Profile to launch the instance with. See Instance Profile below for more details.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public IList<V1beta1LaunchTemplateStatusAtProviderIamInstanceProfile>? IamInstanceProfile { get; set; }

    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The AMI from which to launch the instance.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>Shutdown behavior for the instance. Can be stop or terminate. (Default: stop).</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>The market (purchasing) option for the instance. See Market Options below for details.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1LaunchTemplateStatusAtProviderInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The latest version of the launch template.</summary>
    [JsonPropertyName("latestVersion")]
    public double? LatestVersion { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta1LaunchTemplateStatusAtProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public IList<V1beta1LaunchTemplateStatusAtProviderMonitoring>? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1LaunchTemplateStatusAtProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1LaunchTemplateStatusAtProviderPlacement>? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1LaunchTemplateStatusAtProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>A list of security group names to associate with. If you are creating Instances in a VPC, use vpc_security_group_ids instead.</summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta1LaunchTemplateStatusAtProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1LaunchTemplateStatusConditions
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

/// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate.</summary>
public partial class V1beta1LaunchTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LaunchTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LaunchTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>LaunchTemplate is the Schema for the LaunchTemplates API. Provides an EC2 launch template resource. Can be used to create instances or auto scaling groups.</summary>
public partial class V1beta1LaunchTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LaunchTemplateSpec>, IStatus<V1beta1LaunchTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LaunchTemplate";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "launchtemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LaunchTemplateSpec defines the desired state of LaunchTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1LaunchTemplateSpec Spec { get; set; }

    /// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1LaunchTemplateStatus? Status { get; set; }
}