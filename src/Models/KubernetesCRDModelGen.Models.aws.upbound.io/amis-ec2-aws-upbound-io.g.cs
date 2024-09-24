using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1AMISpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum>))]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum>))]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EBSSnapshot in ec2 to populate snapshotId.</summary>
public partial class V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum>))]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum>))]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EBSSnapshot in ec2 to populate snapshotId.</summary>
public partial class V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMISpecForProviderEbsBlockDevice
{
    /// <summary>Boolean controlling whether the EBS volumes created to support each created instance will be deleted once that instance is terminated.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Boolean controlling whether the created EBS volumes will be encrypted. Can't be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Number of I/O operations per second the created volumes will support.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN of the Outpost on which the snapshot is stored.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>ID of an EBS snapshot that will be used to initialize the created EBS volumes. If set, the volume_size attribute must be at least as large as the referenced snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Reference to a EBSSnapshot in ec2 to populate snapshotId.</summary>
    [JsonPropertyName("snapshotIdRef")]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdRef? SnapshotIdRef { get; set; }

    /// <summary>Selector for a EBSSnapshot in ec2 to populate snapshotId.</summary>
    [JsonPropertyName("snapshotIdSelector")]
    public V1beta1AMISpecForProviderEbsBlockDeviceSnapshotIdSelector? SnapshotIdSelector { get; set; }

    /// <summary>Throughput that the EBS volume supports, in MiB/s. Only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of created volumes in GiB. If snapshot_id is set and volume_size is omitted then the volume will have the same size as the selected snapshot.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volume to create. Can be standard, gp2, gp3, io1, io2, sc1 or st1 (Default: standard).</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMISpecForProviderEphemeralBlockDevice
{
    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Name for the ephemeral device, of the form "ephemeralN" where N is a volume number starting from zero.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMISpecForProvider
{
    /// <summary>Machine architecture for created instances. Defaults to "x86_64".</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Boot mode of the AMI. For more information, see Boot modes in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("bootMode")]
    public string? BootMode { get; set; }

    /// <summary>Date and time to deprecate the AMI. If you specified a value for seconds, Amazon EC2 rounds the seconds to the nearest minute. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("deprecationTime")]
    public string? DeprecationTime { get; set; }

    /// <summary>Longer, human-readable description for the AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Nested block describing an EBS block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1AMISpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether enhanced networking with ENA is enabled. Defaults to false.</summary>
    [JsonPropertyName("enaSupport")]
    public bool? EnaSupport { get; set; }

    /// <summary>Nested block describing an ephemeral block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1AMISpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Path to an S3 object containing an image manifest, e.g., created by the ec2-upload-bundle command in the EC2 command line tools.</summary>
    [JsonPropertyName("imageLocation")]
    public string? ImageLocation { get; set; }

    /// <summary>If EC2 instances started from this image should require the use of the Instance Metadata Service V2 (IMDSv2), set this argument to v2.0. For more information, see Configure instance metadata options for new instances.</summary>
    [JsonPropertyName("imdsSupport")]
    public string? ImdsSupport { get; set; }

    /// <summary>ID of the kernel image (AKI) that will be used as the paravirtual kernel in created instances.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>Region-unique name for the AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of an initrd image (ARI) that will be used when booting the created instances.</summary>
    [JsonPropertyName("ramdiskId")]
    public string? RamdiskId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Name of the root device (for example, /dev/sda1, or /dev/xvda).</summary>
    [JsonPropertyName("rootDeviceName")]
    public string? RootDeviceName { get; set; }

    /// <summary>When set to "simple" (the default), enables enhanced networking for created instances. No other value is supported at this time.</summary>
    [JsonPropertyName("sriovNetSupport")]
    public string? SriovNetSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If the image is configured for NitroTPM support, the value is v2.0. For more information, see NitroTPM in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("tpmSupport")]
    public string? TpmSupport { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Can be either "paravirtual" (the default) or "hvm". The choice of virtualization type changes the set of further arguments that are required, as described below.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

public enum V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum>))]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum>))]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EBSSnapshot in ec2 to populate snapshotId.</summary>
public partial class V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum>))]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum>))]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EBSSnapshot in ec2 to populate snapshotId.</summary>
public partial class V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMISpecInitProviderEbsBlockDevice
{
    /// <summary>Boolean controlling whether the EBS volumes created to support each created instance will be deleted once that instance is terminated.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Boolean controlling whether the created EBS volumes will be encrypted. Can't be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Number of I/O operations per second the created volumes will support.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN of the Outpost on which the snapshot is stored.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>ID of an EBS snapshot that will be used to initialize the created EBS volumes. If set, the volume_size attribute must be at least as large as the referenced snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Reference to a EBSSnapshot in ec2 to populate snapshotId.</summary>
    [JsonPropertyName("snapshotIdRef")]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdRef? SnapshotIdRef { get; set; }

    /// <summary>Selector for a EBSSnapshot in ec2 to populate snapshotId.</summary>
    [JsonPropertyName("snapshotIdSelector")]
    public V1beta1AMISpecInitProviderEbsBlockDeviceSnapshotIdSelector? SnapshotIdSelector { get; set; }

    /// <summary>Throughput that the EBS volume supports, in MiB/s. Only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of created volumes in GiB. If snapshot_id is set and volume_size is omitted then the volume will have the same size as the selected snapshot.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volume to create. Can be standard, gp2, gp3, io1, io2, sc1 or st1 (Default: standard).</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMISpecInitProviderEphemeralBlockDevice
{
    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Name for the ephemeral device, of the form "ephemeralN" where N is a volume number starting from zero.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AMISpecInitProvider
{
    /// <summary>Machine architecture for created instances. Defaults to "x86_64".</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Boot mode of the AMI. For more information, see Boot modes in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("bootMode")]
    public string? BootMode { get; set; }

    /// <summary>Date and time to deprecate the AMI. If you specified a value for seconds, Amazon EC2 rounds the seconds to the nearest minute. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("deprecationTime")]
    public string? DeprecationTime { get; set; }

    /// <summary>Longer, human-readable description for the AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Nested block describing an EBS block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1AMISpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether enhanced networking with ENA is enabled. Defaults to false.</summary>
    [JsonPropertyName("enaSupport")]
    public bool? EnaSupport { get; set; }

    /// <summary>Nested block describing an ephemeral block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1AMISpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Path to an S3 object containing an image manifest, e.g., created by the ec2-upload-bundle command in the EC2 command line tools.</summary>
    [JsonPropertyName("imageLocation")]
    public string? ImageLocation { get; set; }

    /// <summary>If EC2 instances started from this image should require the use of the Instance Metadata Service V2 (IMDSv2), set this argument to v2.0. For more information, see Configure instance metadata options for new instances.</summary>
    [JsonPropertyName("imdsSupport")]
    public string? ImdsSupport { get; set; }

    /// <summary>ID of the kernel image (AKI) that will be used as the paravirtual kernel in created instances.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>Region-unique name for the AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of an initrd image (ARI) that will be used when booting the created instances.</summary>
    [JsonPropertyName("ramdiskId")]
    public string? RamdiskId { get; set; }

    /// <summary>Name of the root device (for example, /dev/sda1, or /dev/xvda).</summary>
    [JsonPropertyName("rootDeviceName")]
    public string? RootDeviceName { get; set; }

    /// <summary>When set to "simple" (the default), enables enhanced networking for created instances. No other value is supported at this time.</summary>
    [JsonPropertyName("sriovNetSupport")]
    public string? SriovNetSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If the image is configured for NitroTPM support, the value is v2.0. For more information, see NitroTPM in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("tpmSupport")]
    public string? TpmSupport { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Can be either "paravirtual" (the default) or "hvm". The choice of virtualization type changes the set of further arguments that are required, as described below.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

public enum V1beta1AMISpecManagementPoliciesEnum
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

public enum V1beta1AMISpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AMISpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AMISpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AMISpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AMISpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AMISpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AMISpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AMISpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AMISpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AMISpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AMISpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AMISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AMISpec defines the desired state of AMI</summary>
public partial class V1beta1AMISpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AMISpecDeletionPolicyEnum>))]
    public V1beta1AMISpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AMISpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AMISpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AMISpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AMISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AMISpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AMISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMIStatusAtProviderEbsBlockDevice
{
    /// <summary>Boolean controlling whether the EBS volumes created to support each created instance will be deleted once that instance is terminated.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Boolean controlling whether the created EBS volumes will be encrypted. Can't be used with snapshot_id.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Number of I/O operations per second the created volumes will support.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN of the Outpost on which the snapshot is stored.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>ID of an EBS snapshot that will be used to initialize the created EBS volumes. If set, the volume_size attribute must be at least as large as the referenced snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Throughput that the EBS volume supports, in MiB/s. Only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of created volumes in GiB. If snapshot_id is set and volume_size is omitted then the volume will have the same size as the selected snapshot.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volume to create. Can be standard, gp2, gp3, io1, io2, sc1 or st1 (Default: standard).</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMIStatusAtProviderEphemeralBlockDevice
{
    /// <summary>Path at which the device is exposed to created instances.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Name for the ephemeral device, of the form "ephemeralN" where N is a volume number starting from zero.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1AMIStatusAtProvider
{
    /// <summary>Machine architecture for created instances. Defaults to "x86_64".</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>ARN of the AMI.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Boot mode of the AMI. For more information, see Boot modes in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("bootMode")]
    public string? BootMode { get; set; }

    /// <summary>Date and time to deprecate the AMI. If you specified a value for seconds, Amazon EC2 rounds the seconds to the nearest minute. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("deprecationTime")]
    public string? DeprecationTime { get; set; }

    /// <summary>Longer, human-readable description for the AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Nested block describing an EBS block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1AMIStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether enhanced networking with ENA is enabled. Defaults to false.</summary>
    [JsonPropertyName("enaSupport")]
    public bool? EnaSupport { get; set; }

    /// <summary>Nested block describing an ephemeral block device that should be attached to created instances. The structure of this block is described below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1AMIStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Hypervisor type of the image.</summary>
    [JsonPropertyName("hypervisor")]
    public string? Hypervisor { get; set; }

    /// <summary>ID of the created AMI.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Path to an S3 object containing an image manifest, e.g., created by the ec2-upload-bundle command in the EC2 command line tools.</summary>
    [JsonPropertyName("imageLocation")]
    public string? ImageLocation { get; set; }

    /// <summary>AWS account alias (for example, amazon, self) or the AWS account ID of the AMI owner.</summary>
    [JsonPropertyName("imageOwnerAlias")]
    public string? ImageOwnerAlias { get; set; }

    /// <summary>Type of image.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>If EC2 instances started from this image should require the use of the Instance Metadata Service V2 (IMDSv2), set this argument to v2.0. For more information, see Configure instance metadata options for new instances.</summary>
    [JsonPropertyName("imdsSupport")]
    public string? ImdsSupport { get; set; }

    /// <summary>ID of the kernel image (AKI) that will be used as the paravirtual kernel in created instances.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manageEbsSnapshots")]
    public bool? ManageEbsSnapshots { get; set; }

    /// <summary>Region-unique name for the AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>AWS account ID of the image owner.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>This value is set to windows for Windows AMIs; otherwise, it is blank.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Platform details associated with the billing code of the AMI.</summary>
    [JsonPropertyName("platformDetails")]
    public string? PlatformDetails { get; set; }

    /// <summary>Whether the image has public launch permissions.</summary>
    [JsonPropertyName("public")]
    public bool? Public { get; set; }

    /// <summary>ID of an initrd image (ARI) that will be used when booting the created instances.</summary>
    [JsonPropertyName("ramdiskId")]
    public string? RamdiskId { get; set; }

    /// <summary>Name of the root device (for example, /dev/sda1, or /dev/xvda).</summary>
    [JsonPropertyName("rootDeviceName")]
    public string? RootDeviceName { get; set; }

    /// <summary>Snapshot ID for the root volume (for EBS-backed AMIs)</summary>
    [JsonPropertyName("rootSnapshotId")]
    public string? RootSnapshotId { get; set; }

    /// <summary>When set to "simple" (the default), enables enhanced networking for created instances. No other value is supported at this time.</summary>
    [JsonPropertyName("sriovNetSupport")]
    public string? SriovNetSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>If the image is configured for NitroTPM support, the value is v2.0. For more information, see NitroTPM in the Amazon Elastic Compute Cloud User Guide.</summary>
    [JsonPropertyName("tpmSupport")]
    public string? TpmSupport { get; set; }

    /// <summary>Operation of the Amazon EC2 instance and the billing code that is associated with the AMI.</summary>
    [JsonPropertyName("usageOperation")]
    public string? UsageOperation { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Can be either "paravirtual" (the default) or "hvm". The choice of virtualization type changes the set of further arguments that are required, as described below.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AMIStatusConditions
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

/// <summary>AMIStatus defines the observed state of AMI.</summary>
public partial class V1beta1AMIStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AMIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AMIStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AMI is the Schema for the AMIs API. Creates and manages a custom Amazon Machine Image (AMI).</summary>
public partial class V1beta1AMI : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AMISpec>, IStatus<V1beta1AMIStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AMI";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "amis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AMISpec defines the desired state of AMI</summary>
    [JsonPropertyName("spec")]
    public V1beta1AMISpec Spec { get; set; }

    /// <summary>AMIStatus defines the observed state of AMI.</summary>
    [JsonPropertyName("status")]
    public V1beta1AMIStatus? Status { get; set; }
}