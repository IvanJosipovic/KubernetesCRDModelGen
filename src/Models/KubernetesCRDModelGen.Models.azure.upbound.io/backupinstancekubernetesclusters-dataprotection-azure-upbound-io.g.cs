using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.upbound.io;
public enum V1beta1BackupInstanceKubernetesClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupDatasourceParameters
{
    /// <summary>Whether to include cluster scope resources during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterScopedResourcesEnabled")]
    public bool? ClusterScopedResourcesEnabled { get; set; }

    /// <summary>Specifies the namespaces to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>Specifies the namespaces to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary>Specifies the resources with such label selectors to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary>Whether to take volume snapshots during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumeSnapshotEnabled")]
    public bool? VolumeSnapshotEnabled { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecForProvider
{
    /// <summary>A backup_datasource_parameters block as defined below.</summary>
    [JsonPropertyName("backupDatasourceParameters")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupDatasourceParameters? BackupDatasourceParameters { get; set; }

    /// <summary>The ID of the Backup Policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupPolicyId")]
    public string? BackupPolicyId { get; set; }

    /// <summary>Reference to a BackupPolicyKubernetesCluster in dataprotection to populate backupPolicyId.</summary>
    [JsonPropertyName("backupPolicyIdRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdRef? BackupPolicyIdRef { get; set; }

    /// <summary>Selector for a BackupPolicyKubernetesCluster in dataprotection to populate backupPolicyId.</summary>
    [JsonPropertyName("backupPolicyIdSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderBackupPolicyIdSelector? BackupPolicyIdSelector { get; set; }

    /// <summary>The ID of the Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdRef? KubernetesClusterIdRef { get; set; }

    /// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderKubernetesClusterIdSelector? KubernetesClusterIdSelector { get; set; }

    /// <summary>The location of the Backup Instance Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where snapshots are stored. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotResourceGroupName")]
    public string? SnapshotResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate snapshotResourceGroupName.</summary>
    [JsonPropertyName("snapshotResourceGroupNameRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameRef? SnapshotResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate snapshotResourceGroupName.</summary>
    [JsonPropertyName("snapshotResourceGroupNameSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderSnapshotResourceGroupNameSelector? SnapshotResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Backup Vault within which the Backup Instance Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }

    /// <summary>Reference to a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdRef? VaultIdRef { get; set; }

    /// <summary>Selector for a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProviderVaultIdSelector? VaultIdSelector { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupDatasourceParameters
{
    /// <summary>Whether to include cluster scope resources during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterScopedResourcesEnabled")]
    public bool? ClusterScopedResourcesEnabled { get; set; }

    /// <summary>Specifies the namespaces to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>Specifies the namespaces to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary>Specifies the resources with such label selectors to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary>Whether to take volume snapshots during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumeSnapshotEnabled")]
    public bool? VolumeSnapshotEnabled { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecInitProvider
{
    /// <summary>A backup_datasource_parameters block as defined below.</summary>
    [JsonPropertyName("backupDatasourceParameters")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupDatasourceParameters? BackupDatasourceParameters { get; set; }

    /// <summary>The ID of the Backup Policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupPolicyId")]
    public string? BackupPolicyId { get; set; }

    /// <summary>Reference to a BackupPolicyKubernetesCluster in dataprotection to populate backupPolicyId.</summary>
    [JsonPropertyName("backupPolicyIdRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdRef? BackupPolicyIdRef { get; set; }

    /// <summary>Selector for a BackupPolicyKubernetesCluster in dataprotection to populate backupPolicyId.</summary>
    [JsonPropertyName("backupPolicyIdSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderBackupPolicyIdSelector? BackupPolicyIdSelector { get; set; }

    /// <summary>The ID of the Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdRef? KubernetesClusterIdRef { get; set; }

    /// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderKubernetesClusterIdSelector? KubernetesClusterIdSelector { get; set; }

    /// <summary>The location of the Backup Instance Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where snapshots are stored. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotResourceGroupName")]
    public string? SnapshotResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate snapshotResourceGroupName.</summary>
    [JsonPropertyName("snapshotResourceGroupNameRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameRef? SnapshotResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate snapshotResourceGroupName.</summary>
    [JsonPropertyName("snapshotResourceGroupNameSelector")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProviderSnapshotResourceGroupNameSelector? SnapshotResourceGroupNameSelector { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecManagementPoliciesEnum
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

public enum V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupInstanceKubernetesClusterSpecDeletionPolicyEnum>))]
    public V1beta1BackupInstanceKubernetesClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupInstanceKubernetesClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupInstanceKubernetesClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BackupInstanceKubernetesClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BackupInstanceKubernetesClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupInstanceKubernetesClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterStatusAtProviderBackupDatasourceParameters
{
    /// <summary>Whether to include cluster scope resources during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterScopedResourcesEnabled")]
    public bool? ClusterScopedResourcesEnabled { get; set; }

    /// <summary>Specifies the namespaces to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be excluded during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>Specifies the namespaces to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary>Specifies the resource types to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary>Specifies the resources with such label selectors to be included during backup. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary>Whether to take volume snapshots during backup. Default to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumeSnapshotEnabled")]
    public bool? VolumeSnapshotEnabled { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterStatusAtProvider
{
    /// <summary>A backup_datasource_parameters block as defined below.</summary>
    [JsonPropertyName("backupDatasourceParameters")]
    public V1beta1BackupInstanceKubernetesClusterStatusAtProviderBackupDatasourceParameters? BackupDatasourceParameters { get; set; }

    /// <summary>The ID of the Backup Policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupPolicyId")]
    public string? BackupPolicyId { get; set; }

    /// <summary>The ID of the Backup Instance Kubernetes Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>The location of the Backup Instance Kubernetes Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where snapshots are stored. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotResourceGroupName")]
    public string? SnapshotResourceGroupName { get; set; }

    /// <summary>The ID of the Backup Vault within which the Backup Instance Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

public partial class V1beta1BackupInstanceKubernetesClusterStatusConditions
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

public partial class V1beta1BackupInstanceKubernetesClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupInstanceKubernetesClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupInstanceKubernetesClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupInstanceKubernetesCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupInstanceKubernetesClusterSpec>, IStatus<V1beta1BackupInstanceKubernetesClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupInstanceKubernetesCluster";
    public const string KubeGroup = "dataprotection.azure.upbound.io";
    public const string KubePluralName = "backupinstancekubernetesclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupInstanceKubernetesClusterSpec defines the desired state of BackupInstanceKubernetesCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupInstanceKubernetesClusterSpec Spec { get; set; }

    /// <summary>BackupInstanceKubernetesClusterStatus defines the observed state of BackupInstanceKubernetesCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupInstanceKubernetesClusterStatus? Status { get; set; }
}