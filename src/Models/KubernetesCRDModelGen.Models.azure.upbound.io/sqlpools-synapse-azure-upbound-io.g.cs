using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.upbound.io;
/// <summary>SQLPool is the Schema for the SQLPools API. Manages a Synapse SQL Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPoolList";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sqlpools";
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
    public IList<V1beta1SQLPool> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProviderRestore
{
    /// <summary>Specifies the Snapshot time to restore formatted as an RFC3339 date string. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to restore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecForProvider
{
    /// <summary>The name of the collation to use with this pool, only applicable when create_mode is set to Default. Azure default is SQL_LATIN1_GENERAL_CP1_CI_AS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies how to create the SQL Pool. Valid values are: Default, Recovery or PointInTimeRestore. Must be Default to create a new database. Defaults to Default. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>Is transparent data encryption enabled?</summary>
    [JsonPropertyName("dataEncrypted")]
    public bool? DataEncrypted { get; set; }

    /// <summary>Is geo-backup policy enabled? Defaults to true.</summary>
    [JsonPropertyName("geoBackupPolicyEnabled")]
    public bool? GeoBackupPolicyEnabled { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to back up, only applicable when create_mode is set to Recovery. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("recoveryDatabaseId")]
    public string? RecoveryDatabaseId { get; set; }

    /// <summary>A restore block as defined below. Only applicable when create_mode is set to PointInTimeRestore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1SQLPoolSpecForProviderRestore>? Restore { get; set; }

    /// <summary>Specifies the SKU Name for this Synapse SQL Pool. Possible values are DW100c, DW200c, DW300c, DW400c, DW500c, DW1000c, DW1500c, DW2000c, DW2500c, DW3000c, DW5000c, DW6000c, DW7500c, DW10000c, DW15000c or DW30000c.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The storage account type that will be used to store backups for this Synapse SQL Pool. Possible values are LRS or GRS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>The ID of Synapse Workspace within which this SQL Pool should be created. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdRef")]
    public V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdRef? SynapseWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdSelector")]
    public V1beta1SQLPoolSpecForProviderSynapseWorkspaceIdSelector? SynapseWorkspaceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse SQL Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecInitProviderRestore
{
    /// <summary>Specifies the Snapshot time to restore formatted as an RFC3339 date string. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to restore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecInitProvider
{
    /// <summary>The name of the collation to use with this pool, only applicable when create_mode is set to Default. Azure default is SQL_LATIN1_GENERAL_CP1_CI_AS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies how to create the SQL Pool. Valid values are: Default, Recovery or PointInTimeRestore. Must be Default to create a new database. Defaults to Default. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>Is transparent data encryption enabled?</summary>
    [JsonPropertyName("dataEncrypted")]
    public bool? DataEncrypted { get; set; }

    /// <summary>Is geo-backup policy enabled? Defaults to true.</summary>
    [JsonPropertyName("geoBackupPolicyEnabled")]
    public bool? GeoBackupPolicyEnabled { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to back up, only applicable when create_mode is set to Recovery. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("recoveryDatabaseId")]
    public string? RecoveryDatabaseId { get; set; }

    /// <summary>A restore block as defined below. Only applicable when create_mode is set to PointInTimeRestore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1SQLPoolSpecInitProviderRestore>? Restore { get; set; }

    /// <summary>Specifies the SKU Name for this Synapse SQL Pool. Possible values are DW100c, DW200c, DW300c, DW400c, DW500c, DW1000c, DW1500c, DW2000c, DW2500c, DW3000c, DW5000c, DW6000c, DW7500c, DW10000c, DW15000c or DW30000c.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The storage account type that will be used to store backups for this Synapse SQL Pool. Possible values are LRS or GRS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse SQL Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecProviderConfigRefPolicy
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
public partial class V1beta1SQLPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SQLPoolSpec defines the desired state of SQLPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SQLPoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SQLPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolStatusAtProviderRestore
{
    /// <summary>Specifies the Snapshot time to restore formatted as an RFC3339 date string. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to restore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolStatusAtProvider
{
    /// <summary>The name of the collation to use with this pool, only applicable when create_mode is set to Default. Azure default is SQL_LATIN1_GENERAL_CP1_CI_AS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies how to create the SQL Pool. Valid values are: Default, Recovery or PointInTimeRestore. Must be Default to create a new database. Defaults to Default. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>Is transparent data encryption enabled?</summary>
    [JsonPropertyName("dataEncrypted")]
    public bool? DataEncrypted { get; set; }

    /// <summary>Is geo-backup policy enabled? Defaults to true.</summary>
    [JsonPropertyName("geoBackupPolicyEnabled")]
    public bool? GeoBackupPolicyEnabled { get; set; }

    /// <summary>The ID of the Synapse SQL Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Synapse SQL Pool or SQL Database which is to back up, only applicable when create_mode is set to Recovery. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("recoveryDatabaseId")]
    public string? RecoveryDatabaseId { get; set; }

    /// <summary>A restore block as defined below. Only applicable when create_mode is set to PointInTimeRestore. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1SQLPoolStatusAtProviderRestore>? Restore { get; set; }

    /// <summary>Specifies the SKU Name for this Synapse SQL Pool. Possible values are DW100c, DW200c, DW300c, DW400c, DW500c, DW1000c, DW1500c, DW2000c, DW2500c, DW3000c, DW5000c, DW6000c, DW7500c, DW10000c, DW15000c or DW30000c.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The storage account type that will be used to store backups for this Synapse SQL Pool. Possible values are LRS or GRS. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>The ID of Synapse Workspace within which this SQL Pool should be created. Changing this forces a new Synapse SQL Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse SQL Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolStatusConditions
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

/// <summary>SQLPoolStatus defines the observed state of SQLPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SQLPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLPool is the Schema for the SQLPools API. Manages a Synapse SQL Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLPoolSpec>, IStatus<V1beta1SQLPoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPool";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sqlpools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLPoolSpec defines the desired state of SQLPool</summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLPoolSpec Spec { get; set; }

    /// <summary>SQLPoolStatus defines the observed state of SQLPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLPoolStatus? Status { get; set; }
}