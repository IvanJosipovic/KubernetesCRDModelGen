using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opsworks.aws.upbound.io;
public enum V1beta1CustomLayerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderCloudwatchConfigurationLogStreams
{
    /// <summary>Specifies the max number of log events in a batch, up to 10000. The default value is 1000.</summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary>Specifies the maximum size of log events in a batch, in bytes, up to 1048576 bytes. The default value is 32768 bytes.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Specifies the time duration for the batching of log events. The minimum value is 5000 and default value is 5000.</summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary>Specifies how the timestamp is extracted from logs. For more information, see the CloudWatch Logs Agent Reference (https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AgentReference.html).</summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary>Specifies the encoding of the log file so that the file can be read correctly. The default is utf_8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies log files that you want to push to CloudWatch Logs. File can point to a specific file or multiple files (by using wild card characters such as /var/log/system.log*).</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Specifies the range of lines for identifying a file. The valid values are one number, or two dash-delimited numbers, such as 1, 2-5. The default value is 1.</summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary>Specifies where to start to read data (start_of_file or end_of_file). The default is start_of_file.</summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>Specifies the destination log group. A log group is created automatically if it doesn't already exist.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>Specifies the pattern for identifying the start of a log message.</summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary>Specifies the time zone of log event time stamps.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A block the specifies how an opsworks logs look like. See Log Streams.</summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1CustomLayerSpecForProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

public enum V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
public partial class V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderEbsVolume
{
    /// <summary>Encrypt the volume.</summary>
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

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderLoadBasedAutoScalingDownscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderLoadBasedAutoScalingUpscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProviderLoadBasedAutoScaling
{
    /// <summary>The downscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1CustomLayerSpecForProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary>Whether load-based auto scaling is enabled for the layer.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The upscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1CustomLayerSpecForProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

public enum V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecForProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecForProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1CustomLayerSpecForProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecForProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CustomLayerSpecForProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecForProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1CustomLayerSpecForProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecForProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecForProvider
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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See Cloudwatch Configuration.</summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1CustomLayerSpecForProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1CustomLayerSpecForProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See EBS Volume.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1CustomLayerSpecForProviderEbsVolume>? EbsVolume { get; set; }

    /// <summary>Name of an Elastic Load Balancer to attach to this layer</summary>
    [JsonPropertyName("elasticLoadBalancer")]
    public string? ElasticLoadBalancer { get; set; }

    /// <summary>Whether to install OS and package updates on each instance when it boots.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.</summary>
    [JsonPropertyName("instanceShutdownTimeout")]
    public double? InstanceShutdownTimeout { get; set; }

    /// <summary>Load-based auto scaling configuration. See Load Based AutoScaling</summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1CustomLayerSpecForProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1CustomLayerSpecForProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1CustomLayerSpecForProviderStackIdSelector? StackIdSelector { get; set; }

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

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderCloudwatchConfigurationLogStreams
{
    /// <summary>Specifies the max number of log events in a batch, up to 10000. The default value is 1000.</summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary>Specifies the maximum size of log events in a batch, in bytes, up to 1048576 bytes. The default value is 32768 bytes.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Specifies the time duration for the batching of log events. The minimum value is 5000 and default value is 5000.</summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary>Specifies how the timestamp is extracted from logs. For more information, see the CloudWatch Logs Agent Reference (https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AgentReference.html).</summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary>Specifies the encoding of the log file so that the file can be read correctly. The default is utf_8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies log files that you want to push to CloudWatch Logs. File can point to a specific file or multiple files (by using wild card characters such as /var/log/system.log*).</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Specifies the range of lines for identifying a file. The valid values are one number, or two dash-delimited numbers, such as 1, 2-5. The default value is 1.</summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary>Specifies where to start to read data (start_of_file or end_of_file). The default is start_of_file.</summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>Specifies the destination log group. A log group is created automatically if it doesn't already exist.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>Specifies the pattern for identifying the start of a log message.</summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary>Specifies the time zone of log event time stamps.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A block the specifies how an opsworks logs look like. See Log Streams.</summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1CustomLayerSpecInitProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

public enum V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
public partial class V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderEbsVolume
{
    /// <summary>Encrypt the volume.</summary>
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

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderLoadBasedAutoScalingDownscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderLoadBasedAutoScalingUpscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerSpecInitProviderLoadBasedAutoScaling
{
    /// <summary>The downscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1CustomLayerSpecInitProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary>Whether load-based auto scaling is enabled for the layer.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The upscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1CustomLayerSpecInitProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

public enum V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecInitProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecInitProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1CustomLayerSpecInitProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecInitProviderStackIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
public partial class V1beta1CustomLayerSpecInitProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecInitProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1CustomLayerSpecInitProvider
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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See Cloudwatch Configuration.</summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1CustomLayerSpecInitProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1CustomLayerSpecInitProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See EBS Volume.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1CustomLayerSpecInitProviderEbsVolume>? EbsVolume { get; set; }

    /// <summary>Name of an Elastic Load Balancer to attach to this layer</summary>
    [JsonPropertyName("elasticLoadBalancer")]
    public string? ElasticLoadBalancer { get; set; }

    /// <summary>Whether to install OS and package updates on each instance when it boots.</summary>
    [JsonPropertyName("installUpdatesOnBoot")]
    public bool? InstallUpdatesOnBoot { get; set; }

    /// <summary>The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.</summary>
    [JsonPropertyName("instanceShutdownTimeout")]
    public double? InstanceShutdownTimeout { get; set; }

    /// <summary>Load-based auto scaling configuration. See Load Based AutoScaling</summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1CustomLayerSpecInitProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1CustomLayerSpecInitProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1CustomLayerSpecInitProviderStackIdSelector? StackIdSelector { get; set; }

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

public enum V1beta1CustomLayerSpecManagementPoliciesEnum
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

public enum V1beta1CustomLayerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1CustomLayerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1CustomLayerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CustomLayerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CustomLayerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CustomLayerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1CustomLayerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CustomLayerSpec defines the desired state of CustomLayer</summary>
public partial class V1beta1CustomLayerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomLayerSpecDeletionPolicyEnum>))]
    public V1beta1CustomLayerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CustomLayerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CustomLayerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CustomLayerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomLayerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CustomLayerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomLayerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderCloudwatchConfigurationLogStreams
{
    /// <summary>Specifies the max number of log events in a batch, up to 10000. The default value is 1000.</summary>
    [JsonPropertyName("batchCount")]
    public double? BatchCount { get; set; }

    /// <summary>Specifies the maximum size of log events in a batch, in bytes, up to 1048576 bytes. The default value is 32768 bytes.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Specifies the time duration for the batching of log events. The minimum value is 5000 and default value is 5000.</summary>
    [JsonPropertyName("bufferDuration")]
    public double? BufferDuration { get; set; }

    /// <summary>Specifies how the timestamp is extracted from logs. For more information, see the CloudWatch Logs Agent Reference (https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AgentReference.html).</summary>
    [JsonPropertyName("datetimeFormat")]
    public string? DatetimeFormat { get; set; }

    /// <summary>Specifies the encoding of the log file so that the file can be read correctly. The default is utf_8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies log files that you want to push to CloudWatch Logs. File can point to a specific file or multiple files (by using wild card characters such as /var/log/system.log*).</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Specifies the range of lines for identifying a file. The valid values are one number, or two dash-delimited numbers, such as 1, 2-5. The default value is 1.</summary>
    [JsonPropertyName("fileFingerprintLines")]
    public string? FileFingerprintLines { get; set; }

    /// <summary>Specifies where to start to read data (start_of_file or end_of_file). The default is start_of_file.</summary>
    [JsonPropertyName("initialPosition")]
    public string? InitialPosition { get; set; }

    /// <summary>Specifies the destination log group. A log group is created automatically if it doesn't already exist.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>Specifies the pattern for identifying the start of a log message.</summary>
    [JsonPropertyName("multilineStartPattern")]
    public string? MultilineStartPattern { get; set; }

    /// <summary>Specifies the time zone of log event time stamps.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A block the specifies how an opsworks logs look like. See Log Streams.</summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1CustomLayerStatusAtProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderEbsVolume
{
    /// <summary>Encrypt the volume.</summary>
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

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderLoadBasedAutoScalingDownscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderLoadBasedAutoScalingUpscaling
{
    /// <summary>Custom Cloudwatch auto scaling alarms, to be used as thresholds. This parameter takes a list of up to five alarm names, which are case sensitive and must be in the same region as the stack.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>The CPU utilization threshold, as a percent of the available CPU. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("cpuThreshold")]
    public double? CpuThreshold { get; set; }

    /// <summary>The amount of time (in minutes) after a scaling event occurs that AWS OpsWorks Stacks should ignore metrics and suppress additional scaling events.</summary>
    [JsonPropertyName("ignoreMetricsTime")]
    public double? IgnoreMetricsTime { get; set; }

    /// <summary>The number of instances to add or remove when the load exceeds a threshold.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>The load threshold. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }

    /// <summary>The memory utilization threshold, as a percent of the available memory. A value of -1 disables the threshold.</summary>
    [JsonPropertyName("memoryThreshold")]
    public double? MemoryThreshold { get; set; }

    /// <summary>The amount of time, in minutes, that the load must exceed a threshold before more instances are added or removed.</summary>
    [JsonPropertyName("thresholdsWaitTime")]
    public double? ThresholdsWaitTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProviderLoadBasedAutoScaling
{
    /// <summary>The downscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1CustomLayerStatusAtProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary>Whether load-based auto scaling is enabled for the layer.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The upscaling settings, as defined below, used for load-based autoscaling</summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1CustomLayerStatusAtProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary></summary>
public partial class V1beta1CustomLayerStatusAtProvider
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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See Cloudwatch Configuration.</summary>
    [JsonPropertyName("cloudwatchConfiguration")]
    public IList<V1beta1CustomLayerStatusAtProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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

    /// <summary>Will create an EBS volume and connect it to the layer's instances. See EBS Volume.</summary>
    [JsonPropertyName("ebsVolume")]
    public IList<V1beta1CustomLayerStatusAtProviderEbsVolume>? EbsVolume { get; set; }

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

    /// <summary>Load-based auto scaling configuration. See Load Based AutoScaling</summary>
    [JsonPropertyName("loadBasedAutoScaling")]
    public IList<V1beta1CustomLayerStatusAtProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

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

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1CustomLayerStatusConditions
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

/// <summary>CustomLayerStatus defines the observed state of CustomLayer.</summary>
public partial class V1beta1CustomLayerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CustomLayerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomLayerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>CustomLayer is the Schema for the CustomLayers API. Provides an OpsWorks custom layer resource.</summary>
public partial class V1beta1CustomLayer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomLayerSpec>, IStatus<V1beta1CustomLayerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomLayer";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "customlayers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomLayerSpec defines the desired state of CustomLayer</summary>
    [JsonPropertyName("spec")]
    public V1beta1CustomLayerSpec Spec { get; set; }

    /// <summary>CustomLayerStatus defines the observed state of CustomLayer.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomLayerStatus? Status { get; set; }
}