using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
public enum V1beta1ClusterInstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProvider
{
    /// <summary>Specifies whether any database modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the DB instance during the maintenance window. Default true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>EC2 Availability Zone that the DB instance is created in. See docs about the details.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>Identifier of the aws_rds_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in rds to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }

    /// <summary>defined tags from the DB instance to snapshots of the DB instance. Default false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>Instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Name of the DB parameter group to associate with this instance.</summary>
    [JsonPropertyName("dbParameterGroupName")]
    public string? DbParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate dbParameterGroupName.</summary>
    [JsonPropertyName("dbParameterGroupNameRef")]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameRef? DbParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate dbParameterGroupName.</summary>
    [JsonPropertyName("dbParameterGroupNameSelector")]
    public V1beta1ClusterInstanceSpecForProviderDbParameterGroupNameSelector? DbParameterGroupNameSelector { get; set; }

    /// <summary>DB subnet group to associate with this DB instance. NOTE: This must match the db_subnet_group_name of the attached aws_rds_cluster.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta1ClusterInstanceSpecForProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>Name of the database engine to be used for the RDS cluster instance. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres.(Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Database engine version. Please note that to upgrade the engine_version of the instance, it must be done on the aws_rds_cluster engine_version. Trying to upgrade in aws_cluster_instance will not update the engine_version.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Instance class to use. For details on CPU and memory, see Scaling Aurora DB Instances. Aurora uses db.* instance classes/types. Please see AWS Documentation for currently available instance classes and complete details.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB instance. To disable collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta1ClusterInstanceSpecForProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Specifies whether Performance Insights is enabled or not.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate performanceInsightsKmsKeyId.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyIdRef")]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdRef? PerformanceInsightsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate performanceInsightsKmsKeyId.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyIdSelector")]
    public V1beta1ClusterInstanceSpecForProviderPerformanceInsightsKmsKeyIdSelector? PerformanceInsightsKmsKeyIdSelector { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to '7'.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00". NOTE: If preferred_backup_window is set at the cluster level, this argument must be omitted.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoted to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default false. See the documentation on Creating DB Instances for more details on controlling this property.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProvider
{
    /// <summary>Specifies whether any database modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the DB instance during the maintenance window. Default true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>EC2 Availability Zone that the DB instance is created in. See docs about the details.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>Identifier of the aws_rds_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in rds to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }

    /// <summary>defined tags from the DB instance to snapshots of the DB instance. Default false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>Instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Name of the DB parameter group to associate with this instance.</summary>
    [JsonPropertyName("dbParameterGroupName")]
    public string? DbParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate dbParameterGroupName.</summary>
    [JsonPropertyName("dbParameterGroupNameRef")]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameRef? DbParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate dbParameterGroupName.</summary>
    [JsonPropertyName("dbParameterGroupNameSelector")]
    public V1beta1ClusterInstanceSpecInitProviderDbParameterGroupNameSelector? DbParameterGroupNameSelector { get; set; }

    /// <summary>DB subnet group to associate with this DB instance. NOTE: This must match the db_subnet_group_name of the attached aws_rds_cluster.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta1ClusterInstanceSpecInitProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>Name of the database engine to be used for the RDS cluster instance. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres.(Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Database engine version. Please note that to upgrade the engine_version of the instance, it must be done on the aws_rds_cluster engine_version. Trying to upgrade in aws_cluster_instance will not update the engine_version.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Instance class to use. For details on CPU and memory, see Scaling Aurora DB Instances. Aurora uses db.* instance classes/types. Please see AWS Documentation for currently available instance classes and complete details.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB instance. To disable collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta1ClusterInstanceSpecInitProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Specifies whether Performance Insights is enabled or not.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate performanceInsightsKmsKeyId.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyIdRef")]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdRef? PerformanceInsightsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate performanceInsightsKmsKeyId.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyIdSelector")]
    public V1beta1ClusterInstanceSpecInitProviderPerformanceInsightsKmsKeyIdSelector? PerformanceInsightsKmsKeyIdSelector { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to '7'.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00". NOTE: If preferred_backup_window is set at the cluster level, this argument must be omitted.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoted to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default false. See the documentation on Creating DB Instances for more details on controlling this property.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ClusterInstanceSpecManagementPoliciesEnum
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

public enum V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterInstanceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ClusterInstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ClusterInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ClusterInstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecDeletionPolicyEnum>))]
    public V1beta1ClusterInstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterInstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClusterInstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClusterInstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ClusterInstanceStatusAtProvider
{
    /// <summary>Specifies whether any database modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Amazon Resource Name (ARN) of cluster instance</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the DB instance during the maintenance window. Default true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>EC2 Availability Zone that the DB instance is created in. See docs about the details.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>Identifier of the aws_rds_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>defined tags from the DB instance to snapshots of the DB instance. Default false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>Instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Name of the DB parameter group to associate with this instance.</summary>
    [JsonPropertyName("dbParameterGroupName")]
    public string? DbParameterGroupName { get; set; }

    /// <summary>DB subnet group to associate with this DB instance. NOTE: This must match the db_subnet_group_name of the attached aws_rds_cluster.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Region-unique, immutable identifier for the DB instance.</summary>
    [JsonPropertyName("dbiResourceId")]
    public string? DbiResourceId { get; set; }

    /// <summary>DNS address for this instance. May not be writable</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Name of the database engine to be used for the RDS cluster instance. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres.(Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Database engine version. Please note that to upgrade the engine_version of the instance, it must be done on the aws_rds_cluster engine_version. Trying to upgrade in aws_cluster_instance will not update the engine_version.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Database engine version</summary>
    [JsonPropertyName("engineVersionActual")]
    public string? EngineVersionActual { get; set; }

    /// <summary>Instance identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Instance class to use. For details on CPU and memory, see Scaling Aurora DB Instances. Aurora uses db.* instance classes/types. Please see AWS Documentation for currently available instance classes and complete details.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>ARN for the KMS encryption key if one is set to the cluster.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB instance. To disable collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Network type of the DB instance.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Specifies whether Performance Insights is enabled or not.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to '7'.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Database port</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00". NOTE: If preferred_backup_window is set at the cluster level, this argument must be omitted.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoted to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default false. See the documentation on Creating DB Instances for more details on controlling this property.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>– Boolean indicating if this instance is writable. False indicates this instance is a read replica.</summary>
    [JsonPropertyName("writer")]
    public bool? Writer { get; set; }
}

public partial class V1beta1ClusterInstanceStatusConditions
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

public partial class V1beta1ClusterInstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterInstanceSpec>, IStatus<V1beta1ClusterInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterInstance";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "clusterinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterInstanceSpec defines the desired state of ClusterInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterInstanceSpec Spec { get; set; }

    /// <summary>ClusterInstanceStatus defines the observed state of ClusterInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterInstanceStatus? Status { get; set; }
}