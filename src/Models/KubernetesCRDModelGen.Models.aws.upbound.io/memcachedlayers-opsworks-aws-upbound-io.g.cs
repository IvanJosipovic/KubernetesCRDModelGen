using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opsworks.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCloudwatchConfigurationLogStreams
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1MemcachedLayerSpecForProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderEbsVolume
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScalingDownscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScalingUpscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecForProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecForProviderStackIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecForProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecForProvider
{
    /// <summary>Amount of memory to allocate for the cache on each instance, in megabytes. Defaults to 512MB.</summary>
    [JsonPropertyName("allocatedMemory")]
    public double? AllocatedMemory { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecForProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1MemcachedLayerSpecForProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecForProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecForProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1MemcachedLayerSpecForProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1MemcachedLayerSpecForProviderStackIdSelector? StackIdSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCloudwatchConfigurationLogStreams
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1MemcachedLayerSpecInitProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderEbsVolume
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScalingDownscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScalingUpscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecInitProviderStackIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecInitProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecInitProvider
{
    /// <summary>Amount of memory to allocate for the cache on each instance, in megabytes. Defaults to 512MB.</summary>
    [JsonPropertyName("allocatedMemory")]
    public double? AllocatedMemory { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecInitProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1MemcachedLayerSpecInitProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecInitProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1MemcachedLayerSpecInitProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1MemcachedLayerSpecInitProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1MemcachedLayerSpecInitProviderStackIdSelector? StackIdSelector { get; set; }

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

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MemcachedLayerSpec defines the desired state of MemcachedLayer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemcachedLayerSpecDeletionPolicyEnum>))]
    public V1beta1MemcachedLayerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MemcachedLayerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MemcachedLayerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MemcachedLayerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MemcachedLayerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MemcachedLayerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MemcachedLayerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderCloudwatchConfigurationLogStreams
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1MemcachedLayerStatusAtProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderEbsVolume
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScalingDownscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScalingUpscaling
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusAtProvider
{
    /// <summary>Amount of memory to allocate for the cache on each instance, in megabytes. Defaults to 512MB.</summary>
    [JsonPropertyName("allocatedMemory")]
    public double? AllocatedMemory { get; set; }

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
    public IList<V1beta1MemcachedLayerStatusAtProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1MemcachedLayerStatusAtProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1MemcachedLayerStatusAtProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

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

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatusConditions
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

/// <summary>MemcachedLayerStatus defines the observed state of MemcachedLayer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcachedLayerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MemcachedLayerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MemcachedLayerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MemcachedLayer is the Schema for the MemcachedLayers API. Provides an OpsWorks memcached layer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MemcachedLayer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MemcachedLayerSpec>, IStatus<V1beta1MemcachedLayerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MemcachedLayer";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "memcachedlayers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MemcachedLayerSpec defines the desired state of MemcachedLayer</summary>
    [JsonPropertyName("spec")]
    public V1beta1MemcachedLayerSpec Spec { get; set; }

    /// <summary>MemcachedLayerStatus defines the observed state of MemcachedLayer.</summary>
    [JsonPropertyName("status")]
    public V1beta1MemcachedLayerStatus? Status { get; set; }
}