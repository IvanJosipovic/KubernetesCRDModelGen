using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redshift.aws.upbound.io;
#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Provides a Redshift Cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "redshift.aws.upbound.io";
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDefaultIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate defaultIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDefaultIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderDefaultIamRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDefaultIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate defaultIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDefaultIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderDefaultIamRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIamRoleRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIamRoleRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderIamRoleRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIamRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Role in iam to populate iamRoles.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIamRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderIamRoleSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password_wo. One of master_password, master_password_wo or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password. One of master_password_wo, master_password or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterPasswordWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true.</summary>
    [JsonPropertyName("allowVersionUpgrade")]
    public bool? AllowVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>The value represents how the cluster is configured to use AQUA (Advanced Query Accelerator) after the cluster is restored. No longer supported by the AWS API. Always returns auto.</summary>
    [JsonPropertyName("aquaConfigurationStatus")]
    public string? AquaConfigurationStatus { get; set; }

    /// <summary>The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.</summary>
    [JsonPropertyName("automatedSnapshotRetentionPeriod")]
    public double? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency. Can only be changed if availability_zone_relocation_enabled is true.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>If true, the cluster can be relocated to another availabity zone, either automatically by AWS or when requested. Default is false. Available for use on clusters from the RA3 instance family.</summary>
    [JsonPropertyName("availabilityZoneRelocationEnabled")]
    public bool? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>The name of the parameter group to be associated with this cluster.</summary>
    [JsonPropertyName("clusterParameterGroupName")]
    public string? ClusterParameterGroupName { get; set; }

    /// <summary>The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).</summary>
    [JsonPropertyName("clusterSubnetGroupName")]
    public string? ClusterSubnetGroupName { get; set; }

    /// <summary>The cluster type to use. Either single-node or multi-node.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The version of the Amazon Redshift engine software that you want to deploy on the cluster. The version selected runs on all the nodes in the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>The name of the first database to be created when the cluster is created. If you do not provide a name, Amazon Redshift will create a default database called dev.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster when the cluster was created.</summary>
    [JsonPropertyName("defaultIamRoleArn")]
    public string? DefaultIamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate defaultIamRoleArn.</summary>
    [JsonPropertyName("defaultIamRoleArnRef")]
    public V1beta1ClusterSpecForProviderDefaultIamRoleArnRef? DefaultIamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate defaultIamRoleArn.</summary>
    [JsonPropertyName("defaultIamRoleArnSelector")]
    public V1beta1ClusterSpecForProviderDefaultIamRoleArnSelector? DefaultIamRoleArnSelector { get; set; }

    /// <summary>The Elastic IP (EIP) address for the cluster.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>If true , the data in the cluster is encrypted at rest. Default is true.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>If true , enhanced VPC routing is enabled.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, skip_final_snapshot must be false.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>References to Role in iam to populate iamRoles.</summary>
    [JsonPropertyName("iamRoleRefs")]
    public IList<V1beta1ClusterSpecForProviderIamRoleRefs>? IamRoleRefs { get; set; }

    /// <summary>Selector for a list of Role in iam to populate iamRoles.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta1ClusterSpecForProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.</summary>
    [JsonPropertyName("iamRoles")]
    public IList<string>? IamRoles { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ClusterSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of the maintenance track for the restored cluster. When you take a snapshot, the snapshot inherits the MaintenanceTrack value from the cluster. The snapshot might be on a different track than the cluster that was the source for the snapshot. For example, suppose that you take a snapshot of  a cluster that is on the current track and then change the cluster to be on the trailing track. In this case, the snapshot and the source cluster are on different tracks. Default value is current.</summary>
    [JsonPropertyName("maintenanceTrackName")]
    public string? MaintenanceTrackName { get; set; }

    /// <summary>Whether to use AWS SecretsManager to manage the cluster admin credentials. Conflicts with master_password and master_password_wo. One of master_password or manage_master_password is required unless snapshot_identifier is provided.</summary>
    [JsonPropertyName("manageMasterPassword")]
    public bool? ManageMasterPassword { get; set; }

    /// <summary>The default number of days to retain a manual snapshot. If the value is -1, the snapshot is retained indefinitely. This setting doesn't change the retention period of existing snapshots. Valid values are between -1 and 3653. Default value is -1.</summary>
    [JsonPropertyName("manualSnapshotRetentionPeriod")]
    public double? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>ID of the KMS key used to encrypt the cluster admin credentials secret.</summary>
    [JsonPropertyName("masterPasswordSecretKmsKeyId")]
    public string? MasterPasswordSecretKmsKeyId { get; set; }

    /// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password_wo. One of master_password, master_password_wo or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta1ClusterSpecForProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password. One of master_password_wo, master_password or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
    [JsonPropertyName("masterPasswordWoSecretRef")]
    public V1beta1ClusterSpecForProviderMasterPasswordWoSecretRef? MasterPasswordWoSecretRef { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Specifies if the Redshift cluster is multi-AZ.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>The node type to be provisioned for the cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.</summary>
    [JsonPropertyName("ownerAccount")]
    public string? OwnerAccount { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections. Valid values are between 1115 and 65535. The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The weekly time range (in UTC) during which automated cluster maintenance can occur. Format: ddd:hh24:mi-ddd:hh24:mi</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>If true, the cluster can be accessed from a public network. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>The ARN of the snapshot from which to create the new cluster. Conflicts with snapshot_identifier.</summary>
    [JsonPropertyName("snapshotArn")]
    public string? SnapshotArn { get; set; }

    /// <summary>The name of the cluster the source snapshot was created from.</summary>
    [JsonPropertyName("snapshotClusterIdentifier")]
    public string? SnapshotClusterIdentifier { get; set; }

    /// <summary>The name of the snapshot from which to create the new cluster.  Conflicts with snapshot_arn.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDefaultIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate defaultIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDefaultIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderDefaultIamRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDefaultIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate defaultIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDefaultIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderDefaultIamRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIamRoleRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIamRoleRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderIamRoleRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIamRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Role in iam to populate iamRoles.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIamRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderIamRoleSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password_wo. One of master_password, master_password_wo or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password. One of master_password_wo, master_password or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterPasswordWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true.</summary>
    [JsonPropertyName("allowVersionUpgrade")]
    public bool? AllowVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>The value represents how the cluster is configured to use AQUA (Advanced Query Accelerator) after the cluster is restored. No longer supported by the AWS API. Always returns auto.</summary>
    [JsonPropertyName("aquaConfigurationStatus")]
    public string? AquaConfigurationStatus { get; set; }

    /// <summary>The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.</summary>
    [JsonPropertyName("automatedSnapshotRetentionPeriod")]
    public double? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency. Can only be changed if availability_zone_relocation_enabled is true.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>If true, the cluster can be relocated to another availabity zone, either automatically by AWS or when requested. Default is false. Available for use on clusters from the RA3 instance family.</summary>
    [JsonPropertyName("availabilityZoneRelocationEnabled")]
    public bool? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>The name of the parameter group to be associated with this cluster.</summary>
    [JsonPropertyName("clusterParameterGroupName")]
    public string? ClusterParameterGroupName { get; set; }

    /// <summary>The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).</summary>
    [JsonPropertyName("clusterSubnetGroupName")]
    public string? ClusterSubnetGroupName { get; set; }

    /// <summary>The cluster type to use. Either single-node or multi-node.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The version of the Amazon Redshift engine software that you want to deploy on the cluster. The version selected runs on all the nodes in the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>The name of the first database to be created when the cluster is created. If you do not provide a name, Amazon Redshift will create a default database called dev.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster when the cluster was created.</summary>
    [JsonPropertyName("defaultIamRoleArn")]
    public string? DefaultIamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate defaultIamRoleArn.</summary>
    [JsonPropertyName("defaultIamRoleArnRef")]
    public V1beta1ClusterSpecInitProviderDefaultIamRoleArnRef? DefaultIamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate defaultIamRoleArn.</summary>
    [JsonPropertyName("defaultIamRoleArnSelector")]
    public V1beta1ClusterSpecInitProviderDefaultIamRoleArnSelector? DefaultIamRoleArnSelector { get; set; }

    /// <summary>The Elastic IP (EIP) address for the cluster.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>If true , the data in the cluster is encrypted at rest. Default is true.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>If true , enhanced VPC routing is enabled.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, skip_final_snapshot must be false.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>References to Role in iam to populate iamRoles.</summary>
    [JsonPropertyName("iamRoleRefs")]
    public IList<V1beta1ClusterSpecInitProviderIamRoleRefs>? IamRoleRefs { get; set; }

    /// <summary>Selector for a list of Role in iam to populate iamRoles.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta1ClusterSpecInitProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.</summary>
    [JsonPropertyName("iamRoles")]
    public IList<string>? IamRoles { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of the maintenance track for the restored cluster. When you take a snapshot, the snapshot inherits the MaintenanceTrack value from the cluster. The snapshot might be on a different track than the cluster that was the source for the snapshot. For example, suppose that you take a snapshot of  a cluster that is on the current track and then change the cluster to be on the trailing track. In this case, the snapshot and the source cluster are on different tracks. Default value is current.</summary>
    [JsonPropertyName("maintenanceTrackName")]
    public string? MaintenanceTrackName { get; set; }

    /// <summary>Whether to use AWS SecretsManager to manage the cluster admin credentials. Conflicts with master_password and master_password_wo. One of master_password or manage_master_password is required unless snapshot_identifier is provided.</summary>
    [JsonPropertyName("manageMasterPassword")]
    public bool? ManageMasterPassword { get; set; }

    /// <summary>The default number of days to retain a manual snapshot. If the value is -1, the snapshot is retained indefinitely. This setting doesn't change the retention period of existing snapshots. Valid values are between -1 and 3653. Default value is -1.</summary>
    [JsonPropertyName("manualSnapshotRetentionPeriod")]
    public double? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>ID of the KMS key used to encrypt the cluster admin credentials secret.</summary>
    [JsonPropertyName("masterPasswordSecretKmsKeyId")]
    public string? MasterPasswordSecretKmsKeyId { get; set; }

    /// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password_wo. One of master_password, master_password_wo or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta1ClusterSpecInitProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Password for the master DB user. Conflicts with manage_master_password and master_password. One of master_password_wo, master_password or manage_master_password is required unless snapshot_identifier is provided. Note that this may show up in logs. Password must contain at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.</summary>
    [JsonPropertyName("masterPasswordWoSecretRef")]
    public V1beta1ClusterSpecInitProviderMasterPasswordWoSecretRef? MasterPasswordWoSecretRef { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Specifies if the Redshift cluster is multi-AZ.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>The node type to be provisioned for the cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.</summary>
    [JsonPropertyName("ownerAccount")]
    public string? OwnerAccount { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections. Valid values are between 1115 and 65535. The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The weekly time range (in UTC) during which automated cluster maintenance can occur. Format: ddd:hh24:mi-ddd:hh24:mi</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>If true, the cluster can be accessed from a public network. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>The ARN of the snapshot from which to create the new cluster. Conflicts with snapshot_identifier.</summary>
    [JsonPropertyName("snapshotArn")]
    public string? SnapshotArn { get; set; }

    /// <summary>The name of the cluster the source snapshot was created from.</summary>
    [JsonPropertyName("snapshotClusterIdentifier")]
    public string? SnapshotClusterIdentifier { get; set; }

    /// <summary>The name of the snapshot from which to create the new cluster.  Conflicts with snapshot_arn.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterNodes
{
    /// <summary>Whether the node is a leader node or a compute node</summary>
    [JsonPropertyName("nodeRole")]
    public string? NodeRole { get; set; }

    /// <summary>The private IP address of a node within a cluster</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The public IP address of a node within a cluster</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true.</summary>
    [JsonPropertyName("allowVersionUpgrade")]
    public bool? AllowVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>The value represents how the cluster is configured to use AQUA (Advanced Query Accelerator) after the cluster is restored. No longer supported by the AWS API. Always returns auto.</summary>
    [JsonPropertyName("aquaConfigurationStatus")]
    public string? AquaConfigurationStatus { get; set; }

    /// <summary>Amazon Resource Name (ARN) of cluster</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.</summary>
    [JsonPropertyName("automatedSnapshotRetentionPeriod")]
    public double? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency. Can only be changed if availability_zone_relocation_enabled is true.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>If true, the cluster can be relocated to another availabity zone, either automatically by AWS or when requested. Default is false. Available for use on clusters from the RA3 instance family.</summary>
    [JsonPropertyName("availabilityZoneRelocationEnabled")]
    public bool? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>The namespace Amazon Resource Name (ARN) of the cluster</summary>
    [JsonPropertyName("clusterNamespaceArn")]
    public string? ClusterNamespaceArn { get; set; }

    /// <summary>The nodes in the cluster. Cluster node blocks are documented below</summary>
    [JsonPropertyName("clusterNodes")]
    public IList<V1beta1ClusterStatusAtProviderClusterNodes>? ClusterNodes { get; set; }

    /// <summary>The name of the parameter group to be associated with this cluster.</summary>
    [JsonPropertyName("clusterParameterGroupName")]
    public string? ClusterParameterGroupName { get; set; }

    /// <summary>The public key for the cluster</summary>
    [JsonPropertyName("clusterPublicKey")]
    public string? ClusterPublicKey { get; set; }

    /// <summary>The specific revision number of the database in the cluster</summary>
    [JsonPropertyName("clusterRevisionNumber")]
    public string? ClusterRevisionNumber { get; set; }

    /// <summary>The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).</summary>
    [JsonPropertyName("clusterSubnetGroupName")]
    public string? ClusterSubnetGroupName { get; set; }

    /// <summary>The cluster type to use. Either single-node or multi-node.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The version of the Amazon Redshift engine software that you want to deploy on the cluster. The version selected runs on all the nodes in the cluster.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>The name of the first database to be created when the cluster is created. If you do not provide a name, Amazon Redshift will create a default database called dev.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster when the cluster was created.</summary>
    [JsonPropertyName("defaultIamRoleArn")]
    public string? DefaultIamRoleArn { get; set; }

    /// <summary>The DNS name of the cluster</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The Elastic IP (EIP) address for the cluster.</summary>
    [JsonPropertyName("elasticIp")]
    public string? ElasticIp { get; set; }

    /// <summary>If true , the data in the cluster is encrypted at rest. Default is true.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>The connection endpoint</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>If true , enhanced VPC routing is enabled.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, skip_final_snapshot must be false.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.</summary>
    [JsonPropertyName("iamRoles")]
    public IList<string>? IamRoles { get; set; }

    /// <summary>The Redshift Cluster ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The name of the maintenance track for the restored cluster. When you take a snapshot, the snapshot inherits the MaintenanceTrack value from the cluster. The snapshot might be on a different track than the cluster that was the source for the snapshot. For example, suppose that you take a snapshot of  a cluster that is on the current track and then change the cluster to be on the trailing track. In this case, the snapshot and the source cluster are on different tracks. Default value is current.</summary>
    [JsonPropertyName("maintenanceTrackName")]
    public string? MaintenanceTrackName { get; set; }

    /// <summary>Whether to use AWS SecretsManager to manage the cluster admin credentials. Conflicts with master_password and master_password_wo. One of master_password or manage_master_password is required unless snapshot_identifier is provided.</summary>
    [JsonPropertyName("manageMasterPassword")]
    public bool? ManageMasterPassword { get; set; }

    /// <summary>The default number of days to retain a manual snapshot. If the value is -1, the snapshot is retained indefinitely. This setting doesn't change the retention period of existing snapshots. Valid values are between -1 and 3653. Default value is -1.</summary>
    [JsonPropertyName("manualSnapshotRetentionPeriod")]
    public double? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>ARN of the cluster admin credentials secret</summary>
    [JsonPropertyName("masterPasswordSecretArn")]
    public string? MasterPasswordSecretArn { get; set; }

    /// <summary>ID of the KMS key used to encrypt the cluster admin credentials secret.</summary>
    [JsonPropertyName("masterPasswordSecretKmsKeyId")]
    public string? MasterPasswordSecretKmsKeyId { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Specifies if the Redshift cluster is multi-AZ.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>The node type to be provisioned for the cluster.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }

    /// <summary>The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.</summary>
    [JsonPropertyName("ownerAccount")]
    public string? OwnerAccount { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections. Valid values are between 1115 and 65535. The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The weekly time range (in UTC) during which automated cluster maintenance can occur. Format: ddd:hh24:mi-ddd:hh24:mi</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>If true, the cluster can be accessed from a public network. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>The ARN of the snapshot from which to create the new cluster. Conflicts with snapshot_identifier.</summary>
    [JsonPropertyName("snapshotArn")]
    public string? SnapshotArn { get; set; }

    /// <summary>The name of the cluster the source snapshot was created from.</summary>
    [JsonPropertyName("snapshotClusterIdentifier")]
    public string? SnapshotClusterIdentifier { get; set; }

    /// <summary>The name of the snapshot from which to create the new cluster.  Conflicts with snapshot_arn.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Provides a Redshift Cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "redshift.aws.upbound.io";
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
#nullable disable
