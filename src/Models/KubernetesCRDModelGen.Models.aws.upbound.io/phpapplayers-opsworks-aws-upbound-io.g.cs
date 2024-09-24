using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opsworks.aws.upbound.io;
public enum V1beta1PHPAppLayerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1PHPAppLayerSpecForProviderCloudwatchConfigurationLogStreams
{
    /// <summary></summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1PHPAppLayerSpecForProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

public enum V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderEbsVolume
{
    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>For PIOPS volumes, the IOPS per disk.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The path to mount the EBS volume on the layer's instances.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The number of disks to use for the EBS volume.</summary>
    [JsonPropertyName("numberOfDisks")]
    public double? NumberOfDisks { get; set; }

    /// <summary>The RAID level to use for the volume.</summary>
    [JsonPropertyName("raidLevel")]
    public string? RaidLevel { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The type of volume to create. This may be standard (the default), io1 or gp2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScalingDownscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScalingUpscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

public enum V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecForProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecForProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecForProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecForProviderStackIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PHPAppLayerSpecForProvider
{
    /// <summary>Whether to automatically assign an elastic IP address to the layer's instances.</summary>
    [JsonPropertyName("autoAssignElasticIps")]
    public bool? AutoAssignElasticIps { get; set; }

    /// <summary>For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.</summary>
    [JsonPropertyName("autoAssignPublicIps")]
    public bool? AutoAssignPublicIps { get; set; }

    /// <summary>Whether to enable auto-healing for the layer.</summary>
    [JsonPropertyName("autoHealing")]
    public bool? AutoHealing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1PHPAppLayerSpecForProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customConfigureRecipes")]
    public IList<string>? CustomConfigureRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDeployRecipes")]
    public IList<string>? CustomDeployRecipes { get; set; }

    /// <summary>The ARN of an IAM profile that will be used for the layer's instances.</summary>
    [JsonPropertyName("customInstanceProfileArn")]
    public string? CustomInstanceProfileArn { get; set; }

    /// <summary>Custom JSON attributes to apply to the layer.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdRefs")]
    public IList<V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1PHPAppLayerSpecForProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

    /// <summary>Ids for a set of security groups to apply to the layer's instances.</summary>
    [JsonPropertyName("customSecurityGroupIds")]
    public IList<string>? CustomSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customSetupRecipes")]
    public IList<string>? CustomSetupRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customShutdownRecipes")]
    public IList<string>? CustomShutdownRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customUndeployRecipes")]
    public IList<string>? CustomUndeployRecipes { get; set; }

    /// <summary>Whether to enable Elastic Load Balancing connection draining.</summary>
    [JsonPropertyName("drainElbOnShutdown")]
    public bool? DrainElbOnShutdown { get; set; }

    /// <summary>ebs_volume blocks, as described below, will each create an EBS volume and connect it to the layer's instances.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1PHPAppLayerSpecForProviderEbsVolume>? EbsVolume { get; set; }

    /// <summary>Name of an Elastic Load Balancer to attach to this layer</summary>
    [JsonPropertyName("elasticLoadBalancer")]
    public string? ElasticLoadBalancer { get; set; }

    /// <summary>Whether to install OS and package updates on each instance when it boots.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.</summary>
    [JsonPropertyName("instanceShutdownTimeout")]
    public double? InstanceShutdownTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1PHPAppLayerSpecForProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1PHPAppLayerSpecForProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1PHPAppLayerSpecForProviderStackIdSelector? StackIdSelector { get; set; }

    /// <summary>Names of a set of system packages to install on the layer's instances.</summary>
    [JsonPropertyName("systemPackages")]
    public IList<string>? SystemPackages { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to use EBS-optimized instances.</summary>
    [JsonPropertyName("useEbsOptimizedInstances")]
    public bool? UseEbsOptimizedInstances { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderCloudwatchConfigurationLogStreams
{
    /// <summary></summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1PHPAppLayerSpecInitProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

public enum V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderEbsVolume
{
    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>For PIOPS volumes, the IOPS per disk.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The path to mount the EBS volume on the layer's instances.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The number of disks to use for the EBS volume.</summary>
    [JsonPropertyName("numberOfDisks")]
    public double? NumberOfDisks { get; set; }

    /// <summary>The RAID level to use for the volume.</summary>
    [JsonPropertyName("raidLevel")]
    public string? RaidLevel { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The type of volume to create. This may be standard (the default), io1 or gp2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScalingDownscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScalingUpscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

public enum V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecInitProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecInitProviderStackIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PHPAppLayerSpecInitProvider
{
    /// <summary>Whether to automatically assign an elastic IP address to the layer's instances.</summary>
    [JsonPropertyName("autoAssignElasticIps")]
    public bool? AutoAssignElasticIps { get; set; }

    /// <summary>For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.</summary>
    [JsonPropertyName("autoAssignPublicIps")]
    public bool? AutoAssignPublicIps { get; set; }

    /// <summary>Whether to enable auto-healing for the layer.</summary>
    [JsonPropertyName("autoHealing")]
    public bool? AutoHealing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1PHPAppLayerSpecInitProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customConfigureRecipes")]
    public IList<string>? CustomConfigureRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDeployRecipes")]
    public IList<string>? CustomDeployRecipes { get; set; }

    /// <summary>The ARN of an IAM profile that will be used for the layer's instances.</summary>
    [JsonPropertyName("customInstanceProfileArn")]
    public string? CustomInstanceProfileArn { get; set; }

    /// <summary>Custom JSON attributes to apply to the layer.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdRefs")]
    public IList<V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1PHPAppLayerSpecInitProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

    /// <summary>Ids for a set of security groups to apply to the layer's instances.</summary>
    [JsonPropertyName("customSecurityGroupIds")]
    public IList<string>? CustomSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customSetupRecipes")]
    public IList<string>? CustomSetupRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customShutdownRecipes")]
    public IList<string>? CustomShutdownRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customUndeployRecipes")]
    public IList<string>? CustomUndeployRecipes { get; set; }

    /// <summary>Whether to enable Elastic Load Balancing connection draining.</summary>
    [JsonPropertyName("drainElbOnShutdown")]
    public bool? DrainElbOnShutdown { get; set; }

    /// <summary>ebs_volume blocks, as described below, will each create an EBS volume and connect it to the layer's instances.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1PHPAppLayerSpecInitProviderEbsVolume>? EbsVolume { get; set; }

    /// <summary>Name of an Elastic Load Balancer to attach to this layer</summary>
    [JsonPropertyName("elasticLoadBalancer")]
    public string? ElasticLoadBalancer { get; set; }

    /// <summary>Whether to install OS and package updates on each instance when it boots.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.</summary>
    [JsonPropertyName("instanceShutdownTimeout")]
    public double? InstanceShutdownTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1PHPAppLayerSpecInitProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1PHPAppLayerSpecInitProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1PHPAppLayerSpecInitProviderStackIdSelector? StackIdSelector { get; set; }

    /// <summary>Names of a set of system packages to install on the layer's instances.</summary>
    [JsonPropertyName("systemPackages")]
    public IList<string>? SystemPackages { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to use EBS-optimized instances.</summary>
    [JsonPropertyName("useEbsOptimizedInstances")]
    public bool? UseEbsOptimizedInstances { get; set; }
}

public enum V1beta1PHPAppLayerSpecManagementPoliciesEnum
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

public enum V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PHPAppLayerSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PHPAppLayerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PHPAppLayerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PHPAppLayerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PHPAppLayerSpecDeletionPolicyEnum>))]
    public V1beta1PHPAppLayerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PHPAppLayerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PHPAppLayerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PHPAppLayerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PHPAppLayerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PHPAppLayerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PHPAppLayerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderCloudwatchConfigurationLogStreams
{
    /// <summary></summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1PHPAppLayerStatusAtProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderEbsVolume
{
    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>For PIOPS volumes, the IOPS per disk.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The path to mount the EBS volume on the layer's instances.</summary>
    [JsonPropertyName("mountPoint")]
    public string? MountPoint { get; set; }

    /// <summary>The number of disks to use for the EBS volume.</summary>
    [JsonPropertyName("numberOfDisks")]
    public double? NumberOfDisks { get; set; }

    /// <summary>The RAID level to use for the volume.</summary>
    [JsonPropertyName("raidLevel")]
    public string? RaidLevel { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>The type of volume to create. This may be standard (the default), io1 or gp2.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScalingDownscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScalingUpscaling
{
    /// <summary></summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

public partial class V1beta1PHPAppLayerStatusAtProvider
{
    /// <summary>The Amazon Resource Name(ARN) of the layer.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether to automatically assign an elastic IP address to the layer's instances.</summary>
    [JsonPropertyName("autoAssignElasticIps")]
    public bool? AutoAssignElasticIps { get; set; }

    /// <summary>For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.</summary>
    [JsonPropertyName("autoAssignPublicIps")]
    public bool? AutoAssignPublicIps { get; set; }

    /// <summary>Whether to enable auto-healing for the layer.</summary>
    [JsonPropertyName("autoHealing")]
    public bool? AutoHealing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1PHPAppLayerStatusAtProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customConfigureRecipes")]
    public IList<string>? CustomConfigureRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDeployRecipes")]
    public IList<string>? CustomDeployRecipes { get; set; }

    /// <summary>The ARN of an IAM profile that will be used for the layer's instances.</summary>
    [JsonPropertyName("customInstanceProfileArn")]
    public string? CustomInstanceProfileArn { get; set; }

    /// <summary>Custom JSON attributes to apply to the layer.</summary>
    [JsonPropertyName("customJson")]
    public string? CustomJson { get; set; }

    /// <summary>Ids for a set of security groups to apply to the layer's instances.</summary>
    [JsonPropertyName("customSecurityGroupIds")]
    public IList<string>? CustomSecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customSetupRecipes")]
    public IList<string>? CustomSetupRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customShutdownRecipes")]
    public IList<string>? CustomShutdownRecipes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customUndeployRecipes")]
    public IList<string>? CustomUndeployRecipes { get; set; }

    /// <summary>Whether to enable Elastic Load Balancing connection draining.</summary>
    [JsonPropertyName("drainElbOnShutdown")]
    public bool? DrainElbOnShutdown { get; set; }

    /// <summary>ebs_volume blocks, as described below, will each create an EBS volume and connect it to the layer's instances.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1PHPAppLayerStatusAtProviderEbsVolume>? EbsVolume { get; set; }

    /// <summary>Name of an Elastic Load Balancer to attach to this layer</summary>
    [JsonPropertyName("elasticLoadBalancer")]
    public string? ElasticLoadBalancer { get; set; }

    /// <summary>The id of the layer.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to install OS and package updates on each instance when it boots.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.</summary>
    [JsonPropertyName("instanceShutdownTimeout")]
    public double? InstanceShutdownTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1PHPAppLayerStatusAtProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Names of a set of system packages to install on the layer's instances.</summary>
    [JsonPropertyName("systemPackages")]
    public IList<string>? SystemPackages { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Whether to use EBS-optimized instances.</summary>
    [JsonPropertyName("useEbsOptimizedInstances")]
    public bool? UseEbsOptimizedInstances { get; set; }
}

public partial class V1beta1PHPAppLayerStatusConditions
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

public partial class V1beta1PHPAppLayerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PHPAppLayerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PHPAppLayerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PHPAppLayer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PHPAppLayerSpec>, IStatus<V1beta1PHPAppLayerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PHPAppLayer";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "phpapplayers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PHPAppLayerSpec defines the desired state of PHPAppLayer</summary>
    [JsonPropertyName("spec")]
    public V1beta1PHPAppLayerSpec Spec { get; set; }

    /// <summary>PHPAppLayerStatus defines the observed state of PHPAppLayer.</summary>
    [JsonPropertyName("status")]
    public V1beta1PHPAppLayerStatus? Status { get; set; }
}