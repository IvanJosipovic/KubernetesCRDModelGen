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
public enum V1beta1NodeJSAppLayerSpecDeletionPolicyEnum
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
public partial class V1beta1NodeJSAppLayerSpecForProviderCloudwatchConfigurationLogStreams
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
public partial class V1beta1NodeJSAppLayerSpecForProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1NodeJSAppLayerSpecForProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProviderEbsVolume
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
public partial class V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScalingDownscaling
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
public partial class V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScalingUpscaling
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
public partial class V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecForProvider
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
    public IList<V1beta1NodeJSAppLayerSpecForProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1NodeJSAppLayerSpecForProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecForProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecForProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of NodeJS to use. Defaults to "0.10.38".</summary>
    [JsonPropertyName("nodejsVersion")]
    public string? NodejsVersion { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1NodeJSAppLayerSpecForProviderStackIdSelector? StackIdSelector { get; set; }

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
public partial class V1beta1NodeJSAppLayerSpecInitProviderCloudwatchConfigurationLogStreams
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1NodeJSAppLayerSpecInitProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProviderEbsVolume
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScalingDownscaling
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScalingUpscaling
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProviderStackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProviderStackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecInitProvider
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
    public IList<V1beta1NodeJSAppLayerSpecInitProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdRefs>? CustomSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate customSecurityGroupIds.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1NodeJSAppLayerSpecInitProviderCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecInitProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1NodeJSAppLayerSpecInitProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of NodeJS to use. Defaults to "0.10.38".</summary>
    [JsonPropertyName("nodejsVersion")]
    public string? NodejsVersion { get; set; }

    /// <summary>ID of the stack the layer will belong to.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>Reference to a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdRef")]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdRef? StackIdRef { get; set; }

    /// <summary>Selector for a Stack in opsworks to populate stackId.</summary>
    [JsonPropertyName("stackIdSelector")]
    public V1beta1NodeJSAppLayerSpecInitProviderStackIdSelector? StackIdSelector { get; set; }

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
public enum V1beta1NodeJSAppLayerSpecManagementPoliciesEnum
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
public enum V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1NodeJSAppLayerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NodeJSAppLayerSpec defines the desired state of NodeJSAppLayer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeJSAppLayerSpecDeletionPolicyEnum>))]
    public V1beta1NodeJSAppLayerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodeJSAppLayerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodeJSAppLayerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NodeJSAppLayerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodeJSAppLayerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NodeJSAppLayerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodeJSAppLayerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerStatusAtProviderCloudwatchConfigurationLogStreams
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
public partial class V1beta1NodeJSAppLayerStatusAtProviderCloudwatchConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logStreams")]
    public IList<V1beta1NodeJSAppLayerStatusAtProviderCloudwatchConfigurationLogStreams>? LogStreams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerStatusAtProviderEbsVolume
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
public partial class V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScalingDownscaling
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
public partial class V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScalingUpscaling
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
public partial class V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScaling
{
    /// <summary></summary>
    [JsonPropertyName("downscaling")]
    public IList<V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScalingDownscaling>? Downscaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upscaling")]
    public IList<V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScalingUpscaling>? Upscaling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerStatusAtProvider
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
    public IList<V1beta1NodeJSAppLayerStatusAtProviderCloudwatchConfiguration>? CloudwatchConfiguration { get; set; }

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
    public IList<V1beta1NodeJSAppLayerStatusAtProviderEbsVolume>? EbsVolume { get; set; }

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
    public IList<V1beta1NodeJSAppLayerStatusAtProviderLoadBasedAutoScaling>? LoadBasedAutoScaling { get; set; }

    /// <summary>A human-readable name for the layer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of NodeJS to use. Defaults to "0.10.38".</summary>
    [JsonPropertyName("nodejsVersion")]
    public string? NodejsVersion { get; set; }

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
public partial class V1beta1NodeJSAppLayerStatusConditions
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

/// <summary>NodeJSAppLayerStatus defines the observed state of NodeJSAppLayer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeJSAppLayerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NodeJSAppLayerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodeJSAppLayerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodeJSAppLayer is the Schema for the NodeJSAppLayers API. Provides an OpsWorks NodeJS application layer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodeJSAppLayer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodeJSAppLayerSpec>, IStatus<V1beta1NodeJSAppLayerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodeJSAppLayer";
    public const string KubeGroup = "opsworks.aws.upbound.io";
    public const string KubePluralName = "nodejsapplayers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodeJSAppLayerSpec defines the desired state of NodeJSAppLayer</summary>
    [JsonPropertyName("spec")]
    public V1beta1NodeJSAppLayerSpec Spec { get; set; }

    /// <summary>NodeJSAppLayerStatus defines the observed state of NodeJSAppLayer.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodeJSAppLayerStatus? Status { get; set; }
}