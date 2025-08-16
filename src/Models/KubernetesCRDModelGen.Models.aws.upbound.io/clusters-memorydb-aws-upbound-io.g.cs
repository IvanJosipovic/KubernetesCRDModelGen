using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorydb.aws.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. Provides a MemoryDB Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "memorydb.aws.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in memorydb to populate subnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in memorydb to populate subnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>The name of the Access Control List to associate with the cluster.</summary>
    [JsonPropertyName("aclName")]
    public string? AclName { get; set; }

    /// <summary>When set to true, the cluster will automatically receive minor engine version upgrades after launch. Defaults to true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>Enables data tiering. This option is not supported by all instance types. For more information, see Data tiering.</summary>
    [JsonPropertyName("dataTiering")]
    public bool? DataTiering { get; set; }

    /// <summary>Description for the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The engine that will run on your nodes. Supported values are redis and valkey.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Version number of the engine to be used for the cluster. Downgrades are not supported.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Name of the final cluster snapshot to be created when this resource is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotName")]
    public string? FinalSnapshotName { get; set; }

    /// <summary>ARN of the KMS key used to encrypt the cluster at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1ClusterSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1ClusterSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Specifies the weekly time range during which maintenance on the cluster is performed. Specify as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance window is a 60 minute period. Example: sun:23:00-mon:01:30.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The multi region cluster identifier specified on aws_memorydb_multi_region_cluster.</summary>
    [JsonPropertyName("multiRegionClusterName")]
    public string? MultiRegionClusterName { get; set; }

    /// <summary>The compute and memory capacity of the nodes in the cluster. See AWS documentation on supported node types as well as vertical scaling.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of replicas to apply to each shard, up to a maximum of 5. Defaults to 1 (i.e. 2 nodes per shard).</summary>
    [JsonPropertyName("numReplicasPerShard")]
    public double? NumReplicasPerShard { get; set; }

    /// <summary>The number of shards in the cluster. Defaults to 1.</summary>
    [JsonPropertyName("numShards")]
    public double? NumShards { get; set; }

    /// <summary>The name of the parameter group associated with the cluster.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections. Defaults to 6379.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1ClusterSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1ClusterSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Set of VPC Security Group ID-s to associate with this cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of ARN-s that uniquely identify RDB snapshot files stored in S3. The snapshot files will be used to populate the new cluster. Object names in the ARN-s cannot contain any commas.</summary>
    [JsonPropertyName("snapshotArns")]
    public IList<string>? SnapshotArns { get; set; }

    /// <summary>The name of a snapshot from which to restore data into the new cluster.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>The number of days for which MemoryDB retains automatic snapshots before deleting them. When set to 0, automatic backups are disabled. Defaults to 0.</summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public double? SnapshotRetentionLimit { get; set; }

    /// <summary>The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot of your shard. Example: 05:00-09:00.</summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>ARN of the SNS topic to which cluster notifications are sent.</summary>
    [JsonPropertyName("snsTopicArn")]
    public string? SnsTopicArn { get; set; }

    /// <summary>The name of the subnet group to be used for the cluster. Defaults to a subnet group consisting of default VPC subnets.</summary>
    [JsonPropertyName("subnetGroupName")]
    public string? SubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in memorydb to populate subnetGroupName.</summary>
    [JsonPropertyName("subnetGroupNameRef")]
    public V1beta1ClusterSpecForProviderSubnetGroupNameRef? SubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in memorydb to populate subnetGroupName.</summary>
    [JsonPropertyName("subnetGroupNameSelector")]
    public V1beta1ClusterSpecForProviderSubnetGroupNameSelector? SubnetGroupNameSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A flag to enable in-transit encryption on the cluster. When set to false, the acl_name must be open-access. Defaults to true.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in memorydb to populate subnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in memorydb to populate subnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>The name of the Access Control List to associate with the cluster.</summary>
    [JsonPropertyName("aclName")]
    public string? AclName { get; set; }

    /// <summary>When set to true, the cluster will automatically receive minor engine version upgrades after launch. Defaults to true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>Enables data tiering. This option is not supported by all instance types. For more information, see Data tiering.</summary>
    [JsonPropertyName("dataTiering")]
    public bool? DataTiering { get; set; }

    /// <summary>Description for the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The engine that will run on your nodes. Supported values are redis and valkey.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Version number of the engine to be used for the cluster. Downgrades are not supported.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Name of the final cluster snapshot to be created when this resource is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotName")]
    public string? FinalSnapshotName { get; set; }

    /// <summary>ARN of the KMS key used to encrypt the cluster at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1ClusterSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1ClusterSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Specifies the weekly time range during which maintenance on the cluster is performed. Specify as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance window is a 60 minute period. Example: sun:23:00-mon:01:30.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The multi region cluster identifier specified on aws_memorydb_multi_region_cluster.</summary>
    [JsonPropertyName("multiRegionClusterName")]
    public string? MultiRegionClusterName { get; set; }

    /// <summary>The compute and memory capacity of the nodes in the cluster. See AWS documentation on supported node types as well as vertical scaling.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of replicas to apply to each shard, up to a maximum of 5. Defaults to 1 (i.e. 2 nodes per shard).</summary>
    [JsonPropertyName("numReplicasPerShard")]
    public double? NumReplicasPerShard { get; set; }

    /// <summary>The number of shards in the cluster. Defaults to 1.</summary>
    [JsonPropertyName("numShards")]
    public double? NumShards { get; set; }

    /// <summary>The name of the parameter group associated with the cluster.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections. Defaults to 6379.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1ClusterSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1ClusterSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Set of VPC Security Group ID-s to associate with this cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of ARN-s that uniquely identify RDB snapshot files stored in S3. The snapshot files will be used to populate the new cluster. Object names in the ARN-s cannot contain any commas.</summary>
    [JsonPropertyName("snapshotArns")]
    public IList<string>? SnapshotArns { get; set; }

    /// <summary>The name of a snapshot from which to restore data into the new cluster.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>The number of days for which MemoryDB retains automatic snapshots before deleting them. When set to 0, automatic backups are disabled. Defaults to 0.</summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public double? SnapshotRetentionLimit { get; set; }

    /// <summary>The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot of your shard. Example: 05:00-09:00.</summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>ARN of the SNS topic to which cluster notifications are sent.</summary>
    [JsonPropertyName("snsTopicArn")]
    public string? SnsTopicArn { get; set; }

    /// <summary>The name of the subnet group to be used for the cluster. Defaults to a subnet group consisting of default VPC subnets.</summary>
    [JsonPropertyName("subnetGroupName")]
    public string? SubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in memorydb to populate subnetGroupName.</summary>
    [JsonPropertyName("subnetGroupNameRef")]
    public V1beta1ClusterSpecInitProviderSubnetGroupNameRef? SubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in memorydb to populate subnetGroupName.</summary>
    [JsonPropertyName("subnetGroupNameSelector")]
    public V1beta1ClusterSpecInitProviderSubnetGroupNameSelector? SubnetGroupNameSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A flag to enable in-transit encryption on the cluster. When set to false, the acl_name must be open-access. Defaults to true.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterEndpoint
{
    /// <summary>DNS hostname of the cluster configuration endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections. Defaults to 6379.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderShardsNodesEndpoint
{
    /// <summary>DNS hostname of the cluster configuration endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections. Defaults to 6379.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderShardsNodes
{
    /// <summary>The Availability Zone in which the node resides.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The date and time when the node was created. Example: 2022-01-01T21:00:00Z.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1ClusterStatusAtProviderShardsNodesEndpoint>? Endpoint { get; set; }

    /// <summary>Name of the cluster. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderShards
{
    /// <summary>Name of the cluster. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of nodes in this shard.</summary>
    [JsonPropertyName("nodes")]
    public IList<V1beta1ClusterStatusAtProviderShardsNodes>? Nodes { get; set; }

    /// <summary>Number of individual nodes in this shard.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>Keyspace for this shard. Example: 0-16383.</summary>
    [JsonPropertyName("slots")]
    public string? Slots { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>The name of the Access Control List to associate with the cluster.</summary>
    [JsonPropertyName("aclName")]
    public string? AclName { get; set; }

    /// <summary>The ARN of the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>When set to true, the cluster will automatically receive minor engine version upgrades after launch. Defaults to true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterEndpoint")]
    public IList<V1beta1ClusterStatusAtProviderClusterEndpoint>? ClusterEndpoint { get; set; }

    /// <summary>Enables data tiering. This option is not supported by all instance types. For more information, see Data tiering.</summary>
    [JsonPropertyName("dataTiering")]
    public bool? DataTiering { get; set; }

    /// <summary>Description for the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The engine that will run on your nodes. Supported values are redis and valkey.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Patch version number of the engine used by the cluster.</summary>
    [JsonPropertyName("enginePatchVersion")]
    public string? EnginePatchVersion { get; set; }

    /// <summary>Version number of the engine to be used for the cluster. Downgrades are not supported.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Name of the final cluster snapshot to be created when this resource is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotName")]
    public string? FinalSnapshotName { get; set; }

    /// <summary>Same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the KMS key used to encrypt the cluster at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Specifies the weekly time range during which maintenance on the cluster is performed. Specify as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance window is a 60 minute period. Example: sun:23:00-mon:01:30.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The multi region cluster identifier specified on aws_memorydb_multi_region_cluster.</summary>
    [JsonPropertyName("multiRegionClusterName")]
    public string? MultiRegionClusterName { get; set; }

    /// <summary>The compute and memory capacity of the nodes in the cluster. See AWS documentation on supported node types as well as vertical scaling.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of replicas to apply to each shard, up to a maximum of 5. Defaults to 1 (i.e. 2 nodes per shard).</summary>
    [JsonPropertyName("numReplicasPerShard")]
    public double? NumReplicasPerShard { get; set; }

    /// <summary>The number of shards in the cluster. Defaults to 1.</summary>
    [JsonPropertyName("numShards")]
    public double? NumShards { get; set; }

    /// <summary>The name of the parameter group associated with the cluster.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections. Defaults to 6379.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Set of VPC Security Group ID-s to associate with this cluster.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of shards in this cluster.</summary>
    [JsonPropertyName("shards")]
    public IList<V1beta1ClusterStatusAtProviderShards>? Shards { get; set; }

    /// <summary>List of ARN-s that uniquely identify RDB snapshot files stored in S3. The snapshot files will be used to populate the new cluster. Object names in the ARN-s cannot contain any commas.</summary>
    [JsonPropertyName("snapshotArns")]
    public IList<string>? SnapshotArns { get; set; }

    /// <summary>The name of a snapshot from which to restore data into the new cluster.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>The number of days for which MemoryDB retains automatic snapshots before deleting them. When set to 0, automatic backups are disabled. Defaults to 0.</summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public double? SnapshotRetentionLimit { get; set; }

    /// <summary>The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot of your shard. Example: 05:00-09:00.</summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>ARN of the SNS topic to which cluster notifications are sent.</summary>
    [JsonPropertyName("snsTopicArn")]
    public string? SnsTopicArn { get; set; }

    /// <summary>The name of the subnet group to be used for the cluster. Defaults to a subnet group consisting of default VPC subnets.</summary>
    [JsonPropertyName("subnetGroupName")]
    public string? SubnetGroupName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A flag to enable in-transit encryption on the cluster. When set to false, the acl_name must be open-access. Defaults to true.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Provides a MemoryDB Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "memorydb.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}