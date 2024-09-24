using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.neptune.aws.upbound.io;
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

public enum V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterInstanceSpecForProvider
{
    /// <summary>Specifies whether any instance modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The EC2 Availability Zone that the neptune instance is created in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The identifier of the aws_neptune_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in neptune to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in neptune to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1ClusterInstanceSpecForProviderClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }

    /// <summary>The name of the database engine to be used for the neptune instance. Defaults to neptune. Valid Values: neptune.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The neptune engine version. Currently configuring this argumnet has no effect.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The instance class to use.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>The name of the neptune parameter group to associate with this instance.</summary>
    [JsonPropertyName("neptuneParameterGroupName")]
    public string? NeptuneParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in neptune to populate neptuneParameterGroupName.</summary>
    [JsonPropertyName("neptuneParameterGroupNameRef")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameRef? NeptuneParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in neptune to populate neptuneParameterGroupName.</summary>
    [JsonPropertyName("neptuneParameterGroupNameSelector")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneParameterGroupNameSelector? NeptuneParameterGroupNameSelector { get; set; }

    /// <summary>A subnet group to associate with this neptune instance. NOTE: This must match the neptune_subnet_group_name of the attached aws_neptune_cluster.</summary>
    [JsonPropertyName("neptuneSubnetGroupName")]
    public string? NeptuneSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in neptune to populate neptuneSubnetGroupName.</summary>
    [JsonPropertyName("neptuneSubnetGroupNameRef")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameRef? NeptuneSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in neptune to populate neptuneSubnetGroupName.</summary>
    [JsonPropertyName("neptuneSubnetGroupNameSelector")]
    public V1beta1ClusterInstanceSpecForProviderNeptuneSubnetGroupNameSelector? NeptuneSubnetGroupNameSelector { get; set; }

    /// <summary>The port on which the DB accepts connections. Defaults to 8182.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB instance is deleted.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

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

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterInstanceSpecInitProvider
{
    /// <summary>Specifies whether any instance modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The EC2 Availability Zone that the neptune instance is created in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The identifier of the aws_neptune_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in neptune to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in neptune to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1ClusterInstanceSpecInitProviderClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }

    /// <summary>The name of the database engine to be used for the neptune instance. Defaults to neptune. Valid Values: neptune.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The neptune engine version. Currently configuring this argumnet has no effect.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The instance class to use.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>The name of the neptune parameter group to associate with this instance.</summary>
    [JsonPropertyName("neptuneParameterGroupName")]
    public string? NeptuneParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in neptune to populate neptuneParameterGroupName.</summary>
    [JsonPropertyName("neptuneParameterGroupNameRef")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameRef? NeptuneParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in neptune to populate neptuneParameterGroupName.</summary>
    [JsonPropertyName("neptuneParameterGroupNameSelector")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneParameterGroupNameSelector? NeptuneParameterGroupNameSelector { get; set; }

    /// <summary>A subnet group to associate with this neptune instance. NOTE: This must match the neptune_subnet_group_name of the attached aws_neptune_cluster.</summary>
    [JsonPropertyName("neptuneSubnetGroupName")]
    public string? NeptuneSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in neptune to populate neptuneSubnetGroupName.</summary>
    [JsonPropertyName("neptuneSubnetGroupNameRef")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameRef? NeptuneSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in neptune to populate neptuneSubnetGroupName.</summary>
    [JsonPropertyName("neptuneSubnetGroupNameSelector")]
    public V1beta1ClusterInstanceSpecInitProviderNeptuneSubnetGroupNameSelector? NeptuneSubnetGroupNameSelector { get; set; }

    /// <summary>The port on which the DB accepts connections. Defaults to 8182.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB instance is deleted.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

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
    /// <summary>The hostname of the instance. See also endpoint and port.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Specifies whether any instance modifications are applied immediately, or during the next maintenance window. Default isfalse.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Amazon Resource Name (ARN) of neptune instance</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is true.</summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The EC2 Availability Zone that the neptune instance is created in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The identifier of the aws_neptune_cluster in which to launch this instance.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>The region-unique, immutable identifier for the neptune instance.</summary>
    [JsonPropertyName("dbiResourceId")]
    public string? DbiResourceId { get; set; }

    /// <summary>The connection endpoint in address:port format.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The name of the database engine to be used for the neptune instance. Defaults to neptune. Valid Values: neptune.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The neptune engine version. Currently configuring this argumnet has no effect.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The Instance identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The instance class to use.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>The ARN for the KMS encryption key if one is set to the neptune cluster.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The name of the neptune parameter group to associate with this instance.</summary>
    [JsonPropertyName("neptuneParameterGroupName")]
    public string? NeptuneParameterGroupName { get; set; }

    /// <summary>A subnet group to associate with this neptune instance. NOTE: This must match the neptune_subnet_group_name of the attached aws_neptune_cluster.</summary>
    [JsonPropertyName("neptuneSubnetGroupName")]
    public string? NeptuneSubnetGroupName { get; set; }

    /// <summary>The port on which the DB accepts connections. Defaults to 8182.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The window to perform maintenance in. Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.</summary>
    [JsonPropertyName("promotionTier")]
    public double? PromotionTier { get; set; }

    /// <summary>Bool to control if instance is publicly accessible. Default is false.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB instance is deleted.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether the neptune cluster is encrypted.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>Storage type associated with the cluster standard/iopt1.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
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
    public const string KubeGroup = "neptune.aws.upbound.io";
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