using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containeraws.gcp.m.upbound.io;
/// <summary>NodePool is the Schema for the NodePools API. An Anthos node pool running on AWS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NodePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePoolList";
    public const string KubeGroup = "containeraws.gcp.m.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1NodePool> Items { get; set; }
}

/// <summary>Autoscaler configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the NodePool. Must be &gt;= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the NodePool. Must be &gt;= 1 and &lt;= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in containeraws to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in containeraws to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigAutoscalingMetricsCollection
{
    /// <summary>The frequency at which EC2 Auto Scaling sends aggregated data to AWS CloudWatch. The only valid value is "1Minute".</summary>
    [JsonPropertyName("granularity")]
    public string? Granularity { get; set; }

    /// <summary>The metrics to enable. For a list of valid metrics, see https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_EnableMetricsCollection.html. If you specify granularity and don't specify any metrics, all metrics are enabled.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigConfigEncryption
{
    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigProxyConfig
{
    /// <summary>The ARN of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>The version string of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigRootVolume
{
    /// <summary>Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }

    /// <summary>Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Optional. The SSH configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigSshConfig
{
    /// <summary>The name of the EC2 key pair used to login into cluster machines.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfigTaints
{
    /// <summary>The taint effect. Possible values: EFFECT_UNSPECIFIED, NO_SCHEDULE, PREFER_NO_SCHEDULE, NO_EXECUTE</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for the taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The configuration of the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderConfig
{
    /// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
    [JsonPropertyName("autoscalingMetricsCollection")]
    public V1beta1NodePoolSpecForProviderConfigAutoscalingMetricsCollection? AutoscalingMetricsCollection { get; set; }

    /// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
    [JsonPropertyName("configEncryption")]
    public V1beta1NodePoolSpecForProviderConfigConfigEncryption? ConfigEncryption { get; set; }

    /// <summary>The name of the AWS IAM role assigned to nodes in the pool.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Optional. The AWS instance type. When unspecified, it defaults to m5.large.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1NodePoolSpecForProviderConfigProxyConfig? ProxyConfig { get; set; }

    /// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta1NodePoolSpecForProviderConfigRootVolume? RootVolume { get; set; }

    /// <summary>Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Optional. The SSH configuration.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta1NodePoolSpecForProviderConfigSshConfig? SshConfig { get; set; }

    /// <summary>Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The initial taints assigned to nodes of this node pool.</summary>
    [JsonPropertyName("taints")]
    public IList<V1beta1NodePoolSpecForProviderConfigTaints>? Taints { get; set; }
}

/// <summary>The kubelet configuration for the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderKubeletConfig
{
    /// <summary>Whether or not to enable CPU CFS quota. Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>Optional. The CPU CFS quota period to use for the node. Defaults to "100ms".</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CpuManagerPolicy to use for the node. Defaults to "none".</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary>The Management configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

/// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

/// <summary>Optional. Settings for surge update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpdateSettingsSurgeSettings
{
    /// <summary>Optional. The maximum number of nodes that can be created beyond the current size of the node pool during the update process.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>Optional. The maximum number of nodes that can be simultaneously unavailable during the update process. A node is considered unavailable if its status is not Ready.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }
}

/// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpdateSettings
{
    /// <summary>Optional. Settings for surge update.</summary>
    [JsonPropertyName("surgeSettings")]
    public V1beta1NodePoolSpecForProviderUpdateSettingsSurgeSettings? SurgeSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolSpecForProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The awsCluster for the resource</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in containeraws to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in containeraws to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>The configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public V1beta1NodePoolSpecForProviderConfig? Config { get; set; }

    /// <summary>The kubelet configuration for the node pool.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolSpecForProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public V1beta1NodePoolSpecForProviderManagement? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public V1beta1NodePoolSpecForProviderMaxPodsConstraint? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The subnet where the node pool node run.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
    [JsonPropertyName("updateSettings")]
    public V1beta1NodePoolSpecForProviderUpdateSettings? UpdateSettings { get; set; }

    /// <summary>The Kubernetes version to run on this node pool (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Autoscaler configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the NodePool. Must be &gt;= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the NodePool. Must be &gt;= 1 and &lt;= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigAutoscalingMetricsCollection
{
    /// <summary>The frequency at which EC2 Auto Scaling sends aggregated data to AWS CloudWatch. The only valid value is "1Minute".</summary>
    [JsonPropertyName("granularity")]
    public string? Granularity { get; set; }

    /// <summary>The metrics to enable. For a list of valid metrics, see https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_EnableMetricsCollection.html. If you specify granularity and don't specify any metrics, all metrics are enabled.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigConfigEncryption
{
    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigProxyConfig
{
    /// <summary>The ARN of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>The version string of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigRootVolume
{
    /// <summary>Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }

    /// <summary>Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Optional. The SSH configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigSshConfig
{
    /// <summary>The name of the EC2 key pair used to login into cluster machines.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfigTaints
{
    /// <summary>The taint effect. Possible values: EFFECT_UNSPECIFIED, NO_SCHEDULE, PREFER_NO_SCHEDULE, NO_EXECUTE</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for the taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The configuration of the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderConfig
{
    /// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
    [JsonPropertyName("autoscalingMetricsCollection")]
    public V1beta1NodePoolSpecInitProviderConfigAutoscalingMetricsCollection? AutoscalingMetricsCollection { get; set; }

    /// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
    [JsonPropertyName("configEncryption")]
    public V1beta1NodePoolSpecInitProviderConfigConfigEncryption? ConfigEncryption { get; set; }

    /// <summary>The name of the AWS IAM role assigned to nodes in the pool.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Optional. The AWS instance type. When unspecified, it defaults to m5.large.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1NodePoolSpecInitProviderConfigProxyConfig? ProxyConfig { get; set; }

    /// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta1NodePoolSpecInitProviderConfigRootVolume? RootVolume { get; set; }

    /// <summary>Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Optional. The SSH configuration.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta1NodePoolSpecInitProviderConfigSshConfig? SshConfig { get; set; }

    /// <summary>Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The initial taints assigned to nodes of this node pool.</summary>
    [JsonPropertyName("taints")]
    public IList<V1beta1NodePoolSpecInitProviderConfigTaints>? Taints { get; set; }
}

/// <summary>The kubelet configuration for the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderKubeletConfig
{
    /// <summary>Whether or not to enable CPU CFS quota. Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>Optional. The CPU CFS quota period to use for the node. Defaults to "100ms".</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CpuManagerPolicy to use for the node. Defaults to "none".</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary>The Management configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

/// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

/// <summary>Optional. Settings for surge update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpdateSettingsSurgeSettings
{
    /// <summary>Optional. The maximum number of nodes that can be created beyond the current size of the node pool during the update process.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>Optional. The maximum number of nodes that can be simultaneously unavailable during the update process. A node is considered unavailable if its status is not Ready.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }
}

/// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpdateSettings
{
    /// <summary>Optional. Settings for surge update.</summary>
    [JsonPropertyName("surgeSettings")]
    public V1beta1NodePoolSpecInitProviderUpdateSettingsSurgeSettings? SurgeSettings { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolSpecInitProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public V1beta1NodePoolSpecInitProviderConfig? Config { get; set; }

    /// <summary>The kubelet configuration for the node pool.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolSpecInitProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public V1beta1NodePoolSpecInitProviderManagement? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public V1beta1NodePoolSpecInitProviderMaxPodsConstraint? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The subnet where the node pool node run.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
    [JsonPropertyName("updateSettings")]
    public V1beta1NodePoolSpecInitProviderUpdateSettings? UpdateSettings { get; set; }

    /// <summary>The Kubernetes version to run on this node pool (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NodePoolSpec defines the desired state of NodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodePoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodePoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Autoscaler configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the NodePool. Must be &gt;= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the NodePool. Must be &gt;= 1 and &lt;= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigAutoscalingMetricsCollection
{
    /// <summary>The frequency at which EC2 Auto Scaling sends aggregated data to AWS CloudWatch. The only valid value is "1Minute".</summary>
    [JsonPropertyName("granularity")]
    public string? Granularity { get; set; }

    /// <summary>The metrics to enable. For a list of valid metrics, see https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_EnableMetricsCollection.html. If you specify granularity and don't specify any metrics, all metrics are enabled.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigConfigEncryption
{
    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigProxyConfig
{
    /// <summary>The ARN of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>The version string of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigRootVolume
{
    /// <summary>Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }

    /// <summary>Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Optional. The SSH configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigSshConfig
{
    /// <summary>The name of the EC2 key pair used to login into cluster machines.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfigTaints
{
    /// <summary>The taint effect. Possible values: EFFECT_UNSPECIFIED, NO_SCHEDULE, PREFER_NO_SCHEDULE, NO_EXECUTE</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for the taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The configuration of the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderConfig
{
    /// <summary>Optional. Configuration related to CloudWatch metrics collection on the Auto Scaling group of the node pool. When unspecified, metrics collection is disabled.</summary>
    [JsonPropertyName("autoscalingMetricsCollection")]
    public V1beta1NodePoolStatusAtProviderConfigAutoscalingMetricsCollection? AutoscalingMetricsCollection { get; set; }

    /// <summary>The ARN of the AWS KMS key used to encrypt node pool configuration.</summary>
    [JsonPropertyName("configEncryption")]
    public V1beta1NodePoolStatusAtProviderConfigConfigEncryption? ConfigEncryption { get; set; }

    /// <summary>The name of the AWS IAM role assigned to nodes in the pool.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Optional. The AWS instance type. When unspecified, it defaults to m5.large.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1NodePoolStatusAtProviderConfigProxyConfig? ProxyConfig { get; set; }

    /// <summary>Optional. Template for the root volume provisioned for node pool nodes. Volumes will be provisioned in the availability zone assigned to the node pool subnet. When unspecified, it defaults to 32 GiB with the GP2 volume type.</summary>
    [JsonPropertyName("rootVolume")]
    public V1beta1NodePoolStatusAtProviderConfigRootVolume? RootVolume { get; set; }

    /// <summary>Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Optional. The SSH configuration.</summary>
    [JsonPropertyName("sshConfig")]
    public V1beta1NodePoolStatusAtProviderConfigSshConfig? SshConfig { get; set; }

    /// <summary>Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The initial taints assigned to nodes of this node pool.</summary>
    [JsonPropertyName("taints")]
    public IList<V1beta1NodePoolStatusAtProviderConfigTaints>? Taints { get; set; }
}

/// <summary>The kubelet configuration for the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderKubeletConfig
{
    /// <summary>Whether or not to enable CPU CFS quota. Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>Optional. The CPU CFS quota period to use for the node. Defaults to "100ms".</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CpuManagerPolicy to use for the node. Defaults to "none".</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary>The Management configuration for this node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

/// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

/// <summary>Optional. Settings for surge update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpdateSettingsSurgeSettings
{
    /// <summary>Optional. The maximum number of nodes that can be created beyond the current size of the node pool during the update process.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>Optional. The maximum number of nodes that can be simultaneously unavailable during the update process. A node is considered unavailable if its status is not Ready.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }
}

/// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpdateSettings
{
    /// <summary>Optional. Settings for surge update.</summary>
    [JsonPropertyName("surgeSettings")]
    public V1beta1NodePoolStatusAtProviderUpdateSettingsSurgeSettings? SurgeSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolStatusAtProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The awsCluster for the resource</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public V1beta1NodePoolStatusAtProviderConfig? Config { get; set; }

    /// <summary>Output only. The time at which this node pool was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/awsClusters/{{cluster}}/awsNodePools/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The kubelet configuration for the node pool.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolStatusAtProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public V1beta1NodePoolStatusAtProviderManagement? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public V1beta1NodePoolStatusAtProviderMaxPodsConstraint? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. If set, there are currently changes in flight to the node pool.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The lifecycle state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The subnet where the node pool node run.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Output only. A globally unique identifier for the node pool.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Optional. Update settings control the speed and disruption of the node pool update.</summary>
    [JsonPropertyName("updateSettings")]
    public V1beta1NodePoolStatusAtProviderUpdateSettings? UpdateSettings { get; set; }

    /// <summary>Output only. The time at which this node pool was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The Kubernetes version to run on this node pool (e.g. 1.19.10-gke.1000). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusConditions
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

/// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodePool is the Schema for the NodePools API. An Anthos node pool running on AWS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodePoolSpec>, IStatus<V1beta1NodePoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "containeraws.gcp.m.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodePoolSpec defines the desired state of NodePool</summary>
    [JsonPropertyName("spec")]
    public V1beta1NodePoolSpec Spec { get; set; }

    /// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodePoolStatus? Status { get; set; }
}