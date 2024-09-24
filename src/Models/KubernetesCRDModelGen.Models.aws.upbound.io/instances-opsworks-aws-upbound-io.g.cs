using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opsworks.aws.upbound.io;
public enum V1beta1InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1InstanceSpecForProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecForProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

public enum V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecForProviderLayerIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderLayerIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1InstanceSpecForProviderLayerIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderLayerIdsRefsPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecForProviderLayerIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderLayerIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of CustomLayer in opsworks to populate layerIds.</summary>
public partial class V1beta1InstanceSpecForProviderLayerIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderLayerIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecForProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

public enum V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1InstanceSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
public partial class V1beta1InstanceSpecForProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecForProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1InstanceSpecForProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecForProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1InstanceSpecForProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderStackIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1InstanceSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1InstanceSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>OpsWorks agent to install. Default is INHERIT.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>AMI to use for the instance.  If an AMI is specified, os must be Custom.</summary>
    [JsonPropertyName("amiId")]
    public string? AmiId { get; set; }

    /// <summary>Machine architecture for created instances.  Valid values are x86_64 or i386. The default is x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Creates load-based or time-based instances.  Valid values are load, timer.</summary>
    [JsonPropertyName("autoScalingType")]
    public string? AutoScalingType { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Time that the instance was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Whether to delete EBS volume on deletion. Default is true.</summary>
    [JsonPropertyName("deleteEbs")]
    public bool? DeleteEbs { get; set; }

    /// <summary>Whether to delete the Elastic IP on deletion.</summary>
    [JsonPropertyName("deleteEip")]
    public bool? DeleteEip { get; set; }

    /// <summary>Configuration block for additional EBS block devices to attach to the instance. See Block Devices below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>ECS cluster's ARN for container instances.</summary>
    [JsonPropertyName("ecsClusterArn")]
    public string? EcsClusterArn { get; set; }

    /// <summary>Instance Elastic IP address.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>Configuration block for ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Instance's host name.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>For registered instances, infrastructure class: ec2 or on-premises.</summary>
    [JsonPropertyName("infrastructureClass")]
    public string? InfrastructureClass { get; set; }

    /// <summary>Controls where to install OS and package updates when the instance boots.  Default is true.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>ARN of the instance's IAM profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>List of the layers the instance will belong to.</summary>
    [JsonPropertyName("layerIds")]
    public IList<string>? LayerIds { get; set; }

    /// <summary>References to CustomLayer in opsworks to populate layerIds.</summary>
    [JsonPropertyName("layerIdsRefs")]
    public IList<V1beta1InstanceSpecForProviderLayerIdsRefs>? LayerIdsRefs { get; set; }

    /// <summary>Selector for a list of CustomLayer in opsworks to populate layerIds.</summary>
    [JsonPropertyName("layerIdsSelector")]
    public V1beta1InstanceSpecForProviderLayerIdsSelector? LayerIdsSelector { get; set; }

    /// <summary>Name of operating system that will be installed.</summary>
    [JsonPropertyName("os")]
    public string? Os { get; set; }

    /// <summary>Configuration block for the root block device of the instance. See Block Devices below.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>Name of the type of root device instances will have by default. Valid values are ebs or instance-store.</summary>
    [JsonPropertyName("rootDeviceType")]
    public string? RootDeviceType { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1InstanceSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1InstanceSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Associated security groups.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("sshKeyName")]
    public string? SshKeyName { get; set; }

    /// <summary>Identifier of the stack the instance will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1InstanceSpecForProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1InstanceSpecForProviderStackIdSelector? StackIdSelector { get; set; }

    /// <summary>Desired state of the instance. Valid values are running or stopped.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Instance status. Will be one of booting, connection_lost, online, pending, rebooting, requested, running_setup, setup_failed, shutting_down, start_failed, stop_failed, stopped, stopping, terminated, or terminating.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Subnet ID to attach to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1InstanceSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1InstanceSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Instance tenancy to use. Valid values are default, dedicated or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Valid values are paravirtual or hvm.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecInitProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecInitProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

public enum V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecInitProviderLayerIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderLayerIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1InstanceSpecInitProviderLayerIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderLayerIdsRefsPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of CustomLayer in opsworks to populate layerIds.</summary>
public partial class V1beta1InstanceSpecInitProviderLayerIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderLayerIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceSpecInitProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

public enum V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1InstanceSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
public partial class V1beta1InstanceSpecInitProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecInitProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1InstanceSpecInitProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecInitProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1InstanceSpecInitProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderStackIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1InstanceSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
public partial class V1beta1InstanceSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>OpsWorks agent to install. Default is INHERIT.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>AMI to use for the instance.  If an AMI is specified, os must be Custom.</summary>
    [JsonPropertyName("amiId")]
    public string? AmiId { get; set; }

    /// <summary>Machine architecture for created instances.  Valid values are x86_64 or i386. The default is x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Creates load-based or time-based instances.  Valid values are load, timer.</summary>
    [JsonPropertyName("autoScalingType")]
    public string? AutoScalingType { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Time that the instance was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Whether to delete EBS volume on deletion. Default is true.</summary>
    [JsonPropertyName("deleteEbs")]
    public bool? DeleteEbs { get; set; }

    /// <summary>Whether to delete the Elastic IP on deletion.</summary>
    [JsonPropertyName("deleteEip")]
    public bool? DeleteEip { get; set; }

    /// <summary>Configuration block for additional EBS block devices to attach to the instance. See Block Devices below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>ECS cluster's ARN for container instances.</summary>
    [JsonPropertyName("ecsClusterArn")]
    public string? EcsClusterArn { get; set; }

    /// <summary>Instance Elastic IP address.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>Configuration block for ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Instance's host name.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>For registered instances, infrastructure class: ec2 or on-premises.</summary>
    [JsonPropertyName("infrastructureClass")]
    public string? InfrastructureClass { get; set; }

    /// <summary>Controls where to install OS and package updates when the instance boots.  Default is true.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>ARN of the instance's IAM profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>List of the layers the instance will belong to.</summary>
    [JsonPropertyName("layerIds")]
    public IList<string>? LayerIds { get; set; }

    /// <summary>References to CustomLayer in opsworks to populate layerIds.</summary>
    [JsonPropertyName("layerIdsRefs")]
    public IList<V1beta1InstanceSpecInitProviderLayerIdsRefs>? LayerIdsRefs { get; set; }

    /// <summary>Selector for a list of CustomLayer in opsworks to populate layerIds.</summary>
    [JsonPropertyName("layerIdsSelector")]
    public V1beta1InstanceSpecInitProviderLayerIdsSelector? LayerIdsSelector { get; set; }

    /// <summary>Name of operating system that will be installed.</summary>
    [JsonPropertyName("os")]
    public string? Os { get; set; }

    /// <summary>Configuration block for the root block device of the instance. See Block Devices below.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>Name of the type of root device instances will have by default. Valid values are ebs or instance-store.</summary>
    [JsonPropertyName("rootDeviceType")]
    public string? RootDeviceType { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1InstanceSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1InstanceSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Associated security groups.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("sshKeyName")]
    public string? SshKeyName { get; set; }

    /// <summary>Identifier of the stack the instance will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1InstanceSpecInitProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1InstanceSpecInitProviderStackIdSelector? StackIdSelector { get; set; }

    /// <summary>Desired state of the instance. Valid values are running or stopped.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Instance status. Will be one of booting, connection_lost, online, pending, rebooting, requested, running_setup, setup_failed, shutting_down, start_failed, stop_failed, stopped, stopping, terminated, or terminating.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Subnet ID to attach to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1InstanceSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1InstanceSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Instance tenancy to use. Valid values are default, dedicated or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Valid values are paravirtual or hvm.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

public enum V1beta1InstanceSpecManagementPoliciesEnum
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

public enum V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1InstanceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1InstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecDeletionPolicyEnum>))]
    public V1beta1InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceStatusAtProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceStatusAtProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceStatusAtProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Default is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values are standard, gp2, or io1. Default is standard.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>OpsWorks agent to install. Default is INHERIT.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>AMI to use for the instance.  If an AMI is specified, os must be Custom.</summary>
    [JsonPropertyName("amiId")]
    public string? AmiId { get; set; }

    /// <summary>Machine architecture for created instances.  Valid values are x86_64 or i386. The default is x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Creates load-based or time-based instances.  Valid values are load, timer.</summary>
    [JsonPropertyName("autoScalingType")]
    public string? AutoScalingType { get; set; }

    /// <summary>Name of the availability zone where instances will be created by default.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Time that the instance was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Whether to delete EBS volume on deletion. Default is true.</summary>
    [JsonPropertyName("deleteEbs")]
    public bool? DeleteEbs { get; set; }

    /// <summary>Whether to delete the Elastic IP on deletion.</summary>
    [JsonPropertyName("deleteEip")]
    public bool? DeleteEip { get; set; }

    /// <summary>Configuration block for additional EBS block devices to attach to the instance. See Block Devices below.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>Whether the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>EC2 instance ID.</summary>
    [JsonPropertyName("ec2InstanceId")]
    public string? Ec2InstanceId { get; set; }

    /// <summary>ECS cluster's ARN for container instances.</summary>
    [JsonPropertyName("ecsClusterArn")]
    public string? EcsClusterArn { get; set; }

    /// <summary>Instance Elastic IP address.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>Configuration block for ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Instance's host name.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>ID of the OpsWorks instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>For registered instances, infrastructure class: ec2 or on-premises.</summary>
    [JsonPropertyName("infrastructureClass")]
    public string? InfrastructureClass { get; set; }

    /// <summary>Controls where to install OS and package updates when the instance boots.  Default is true.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>ARN of the instance's IAM profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>ID of the last service error.</summary>
    [JsonPropertyName("lastServiceErrorId")]
    public string? LastServiceErrorId { get; set; }

    /// <summary>List of the layers the instance will belong to.</summary>
    [JsonPropertyName("layerIds")]
    public IList<string>? LayerIds { get; set; }

    /// <summary>Name of operating system that will be installed.</summary>
    [JsonPropertyName("os")]
    public string? Os { get; set; }

    /// <summary>Instance's platform.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Private DNS name assigned to the instance. Can only be used inside the Amazon EC2, and only available if you've enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("privateDns")]
    public string? PrivateDns { get; set; }

    /// <summary>Private IP address assigned to the instance.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Public DNS name assigned to the instance. For EC2-VPC, this is only available if you've enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("publicDns")]
    public string? PublicDns { get; set; }

    /// <summary>Public IP address assigned to the instance, if applicable.</summary>
    [JsonPropertyName("publicIp")]
    public string? PublicIp { get; set; }

    /// <summary>For registered instances, who performed the registration.</summary>
    [JsonPropertyName("registeredBy")]
    public string? RegisteredBy { get; set; }

    /// <summary>Instance's reported AWS OpsWorks Stacks agent version.</summary>
    [JsonPropertyName("reportedAgentVersion")]
    public string? ReportedAgentVersion { get; set; }

    /// <summary>For registered instances, the reported operating system family.</summary>
    [JsonPropertyName("reportedOsFamily")]
    public string? ReportedOsFamily { get; set; }

    /// <summary>For registered instances, the reported operating system name.</summary>
    [JsonPropertyName("reportedOsName")]
    public string? ReportedOsName { get; set; }

    /// <summary>For registered instances, the reported operating system version.</summary>
    [JsonPropertyName("reportedOsVersion")]
    public string? ReportedOsVersion { get; set; }

    /// <summary>Configuration block for the root block device of the instance. See Block Devices below.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>Name of the type of root device instances will have by default. Valid values are ebs or instance-store.</summary>
    [JsonPropertyName("rootDeviceType")]
    public string? RootDeviceType { get; set; }

    /// <summary>Root device volume ID.</summary>
    [JsonPropertyName("rootDeviceVolumeId")]
    public string? RootDeviceVolumeId { get; set; }

    /// <summary>Associated security groups.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>SSH key's Deep Security Agent (DSA) fingerprint.</summary>
    [JsonPropertyName("sshHostDsaKeyFingerprint")]
    public string? SshHostDsaKeyFingerprint { get; set; }

    /// <summary>SSH key's RSA fingerprint.</summary>
    [JsonPropertyName("sshHostRsaKeyFingerprint")]
    public string? SshHostRsaKeyFingerprint { get; set; }

    /// <summary>Name of the SSH keypair that instances will have by default.</summary>
    [JsonPropertyName("sshKeyName")]
    public string? SshKeyName { get; set; }

    /// <summary>Identifier of the stack the instance will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Desired state of the instance. Valid values are running or stopped.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Instance status. Will be one of booting, connection_lost, online, pending, rebooting, requested, running_setup, setup_failed, shutting_down, start_failed, stop_failed, stopped, stopping, terminated, or terminating.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Subnet ID to attach to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Instance tenancy to use. Valid values are default, dedicated or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Keyword to choose what virtualization mode created instances will use. Valid values are paravirtual or hvm.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Instance is the Schema for the Instances API. Provides an OpsWorks instance resource.</summary>
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}