using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkebackup.cnrm.cloud.google.com;
/// <summary>GKEBackupRestore is the Schema for the GKEBackupRestore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupRestoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GKEBackupRestore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupRestoreList";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackuprestores";
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
    public IList<V1alpha1GKEBackupRestore> Items { get; set; }
}

/// <summary>Required. Immutable. A reference to the [Backup][google.cloud.gkebackup.v1.Backup] used as the source from which this Restore will restore. Note that this Backup must be a sub-resource of the RestorePlan's [backup_plan][google.cloud.gkebackup.v1.RestorePlan.backup_plan].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecBackupRef
{
    /// <summary>A reference to an externally managed GKEBackupBackup resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/backups/{{backupID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a GKEBackupBackup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a GKEBackupBackup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Selects resources using their Kubernetes GroupKinds. If specified, only resources of provided GroupKind will be selected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecFilterExclusionFiltersGroupKind
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecFilterExclusionFilters
{
    /// <summary>Optional. Selects resources using their Kubernetes GroupKinds. If specified, only resources of provided GroupKind will be selected.</summary>
    [JsonPropertyName("groupKind")]
    public V1alpha1GKEBackupRestoreSpecFilterExclusionFiltersGroupKind? GroupKind { get; set; }

    /// <summary>Optional. Selects resources using Kubernetes [labels](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/). If specified, a resource will be selected if and only if the resource has all of the provided labels and all the label values match.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Optional. Selects resources using their resource names. If specified, only resources with the provided name will be selected.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Selects resources using their namespaces. This only applies to namespace scoped resources and cannot be used for selecting cluster scoped resources. If specified, only resources in the provided namespace will be selected. If not specified, the filter will apply to both cluster scoped and namespace scoped resources (e.g. name or label). The [Namespace](https://pkg.go.dev/k8s.io/api/core/v1#Namespace) resource itself will be restored if and only if any resources within the namespace are restored.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Selects resources using their Kubernetes GroupKinds. If specified, only resources of provided GroupKind will be selected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecFilterInclusionFiltersGroupKind
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecFilterInclusionFilters
{
    /// <summary>Optional. Selects resources using their Kubernetes GroupKinds. If specified, only resources of provided GroupKind will be selected.</summary>
    [JsonPropertyName("groupKind")]
    public V1alpha1GKEBackupRestoreSpecFilterInclusionFiltersGroupKind? GroupKind { get; set; }

    /// <summary>Optional. Selects resources using Kubernetes [labels](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/). If specified, a resource will be selected if and only if the resource has all of the provided labels and all the label values match.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Optional. Selects resources using their resource names. If specified, only resources with the provided name will be selected.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Selects resources using their namespaces. This only applies to namespace scoped resources and cannot be used for selecting cluster scoped resources. If specified, only resources in the provided namespace will be selected. If not specified, the filter will apply to both cluster scoped and namespace scoped resources (e.g. name or label). The [Namespace](https://pkg.go.dev/k8s.io/api/core/v1#Namespace) resource itself will be restored if and only if any resources within the namespace are restored.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Immutable. Filters resources for `Restore`. If not specified, the scope of the restore will remain the same as defined in the `RestorePlan`. If this is specified, and no resources are matched by the `inclusion_filters` or everything is excluded by the `exclusion_filters`, nothing will be restored. This filter can only be specified if the value of [namespaced_resource_restore_mode][google.cloud.gkebackup.v1.RestoreConfig.namespaced_resource_restore_mode] is set to `MERGE_SKIP_ON_CONFLICT`, `MERGE_REPLACE_VOLUME_ON_CONFLICT` or `MERGE_REPLACE_ON_CONFLICT`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecFilter
{
    /// <summary>Optional. Excludes resources from restoration. If specified, a resource will not be restored if it matches any `ResourceSelector` of the `exclusion_filters`.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<V1alpha1GKEBackupRestoreSpecFilterExclusionFilters>? ExclusionFilters { get; set; }

    /// <summary>Optional. Selects resources for restoration. If specified, only resources which match `inclusion_filters` will be selected for restoration. A resource will be selected if it matches any `ResourceSelector` of the `inclusion_filters`.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<V1alpha1GKEBackupRestoreSpecFilterInclusionFilters>? InclusionFilters { get; set; }
}

/// <summary>Required. The RestorePlan from which this Restore is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecRestorePlanRef
{
    /// <summary>A reference to an externally managed GKEBackupRestorePlan resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/restorePlans/{{restoreplanID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a GKEBackupRestorePlan resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a GKEBackupRestorePlan resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverridesSelectedPVCsNamespacedNames
{
    /// <summary>Optional. The name of the Kubernetes resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The Namespace of the Kubernetes resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of PVCs to apply the policy override to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverridesSelectedPVCs
{
    /// <summary>Optional. A list of namespaced Kubernetes resources.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverridesSelectedPVCsNamespacedNames>? NamespacedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverrides
{
    /// <summary>Required. The VolumeDataRestorePolicy to apply when restoring volumes in scope.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>A list of PVCs to apply the policy override to.</summary>
    [JsonPropertyName("selectedPVCs")]
    public V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverridesSelectedPVCs? SelectedPVCs { get; set; }
}

/// <summary>GKEBackupRestoreSpec defines the desired state of GKEBackupRestore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreSpec
{
    /// <summary>Required. Immutable. A reference to the [Backup][google.cloud.gkebackup.v1.Backup] used as the source from which this Restore will restore. Note that this Backup must be a sub-resource of the RestorePlan's [backup_plan][google.cloud.gkebackup.v1.RestorePlan.backup_plan].</summary>
    [JsonPropertyName("backupRef")]
    public V1alpha1GKEBackupRestoreSpecBackupRef? BackupRef { get; set; }

    /// <summary>User specified descriptive string for this Restore.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Immutable. Filters resources for `Restore`. If not specified, the scope of the restore will remain the same as defined in the `RestorePlan`. If this is specified, and no resources are matched by the `inclusion_filters` or everything is excluded by the `exclusion_filters`, nothing will be restored. This filter can only be specified if the value of [namespaced_resource_restore_mode][google.cloud.gkebackup.v1.RestoreConfig.namespaced_resource_restore_mode] is set to `MERGE_SKIP_ON_CONFLICT`, `MERGE_REPLACE_VOLUME_ON_CONFLICT` or `MERGE_REPLACE_ON_CONFLICT`.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1GKEBackupRestoreSpecFilter? Filter { get; set; }

    /// <summary>A set of custom labels supplied by user.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The GKEBackupRestore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The RestorePlan from which this Restore is created.</summary>
    [JsonPropertyName("restorePlanRef")]
    public V1alpha1GKEBackupRestoreSpecRestorePlanRef RestorePlanRef { get; set; }

    /// <summary>Optional. Immutable. Overrides the volume data restore policies selected in the Restore Config for override-scoped resources.</summary>
    [JsonPropertyName("volumeDataRestorePolicyOverrides")]
    public IList<V1alpha1GKEBackupRestoreSpecVolumeDataRestorePolicyOverrides>? VolumeDataRestorePolicyOverrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScopeExcludedGroupKinds
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScopeSelectedGroupKinds
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary>Optional. Identifies the cluster-scoped resources to restore from the Backup. Not specifying it means NO cluster resource will be restored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScope
{
    /// <summary>Optional. If True, all valid cluster-scoped resources will be restored. Mutually exclusive to any other field in the message.</summary>
    [JsonPropertyName("allGroupKinds")]
    public bool? AllGroupKinds { get; set; }

    /// <summary>Optional. A list of cluster-scoped resource group kinds to NOT restore from the backup. If specified, all valid cluster-scoped resources will be restored except for those specified in the list. Mutually exclusive to any other field in the message.</summary>
    [JsonPropertyName("excludedGroupKinds")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScopeExcludedGroupKinds>? ExcludedGroupKinds { get; set; }

    /// <summary>Optional. If True, no cluster-scoped resources will be restored. This has the same restore scope as if the message is not defined. Mutually exclusive to any other field in the message.</summary>
    [JsonPropertyName("noGroupKinds")]
    public bool? NoGroupKinds { get; set; }

    /// <summary>Optional. A list of cluster-scoped resource group kinds to restore from the backup. If specified, only the selected resources will be restored. Mutually exclusive to any other field in the message.</summary>
    [JsonPropertyName("selectedGroupKinds")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScopeSelectedGroupKinds>? SelectedGroupKinds { get; set; }
}

/// <summary>A list of selected namespaces excluded from restoration. All namespaces except those in this list will be restored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigExcludedNamespaces
{
    /// <summary>Optional. A list of Kubernetes Namespaces</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>Required. The requiring group kind requires that the other group kind be restored first.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependenciesRequiring
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary>Required. The satisfying group kind must be restored first in order to satisfy the dependency.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependenciesSatisfying
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependencies
{
    /// <summary>Required. The requiring group kind requires that the other group kind be restored first.</summary>
    [JsonPropertyName("requiring")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependenciesRequiring Requiring { get; set; }

    /// <summary>Required. The satisfying group kind must be restored first in order to satisfy the dependency.</summary>
    [JsonPropertyName("satisfying")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependenciesSatisfying Satisfying { get; set; }
}

/// <summary>Optional. RestoreOrder contains custom ordering to use on a Restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrder
{
    /// <summary>Optional. Contains a list of group kind dependency pairs provided by the customer, that is used by Backup for GKE to generate a group kind restore order.</summary>
    [JsonPropertyName("groupKindDependencies")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrderGroupKindDependencies>? GroupKindDependencies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedApplicationsNamespacedNames
{
    /// <summary>Optional. The name of the Kubernetes resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The Namespace of the Kubernetes resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of selected ProtectedApplications to restore. The listed ProtectedApplications and all the resources to which they refer will be restored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedApplications
{
    /// <summary>Optional. A list of namespaced Kubernetes resources.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}

/// <summary>A list of selected Namespaces to restore from the Backup. The listed Namespaces and all resources contained in them will be restored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedNamespaces
{
    /// <summary>Optional. A list of Kubernetes Namespaces</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSubstitutionRulesTargetGroupKinds
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSubstitutionRules
{
    /// <summary>Optional. This is the new value to set for any fields that pass the filtering and selection criteria. To remove a value from a Kubernetes resource, either leave this field unspecified, or set it to the empty string ("").</summary>
    [JsonPropertyName("newValue")]
    public string? NewValue { get; set; }

    /// <summary>Optional. (Filtering parameter) This is a [regular expression] (https://en.wikipedia.org/wiki/Regular_expression) that is compared against the fields matched by the target_json_path expression (and must also have passed the previous filters). Substitution will not be performed against fields whose value does not match this expression. If this field is NOT specified, then ALL fields matched by the target_json_path expression will undergo substitution. Note that an empty (e.g., "", rather than unspecified) value for this field will only match empty fields.</summary>
    [JsonPropertyName("originalValuePattern")]
    public string? OriginalValuePattern { get; set; }

    /// <summary>Optional. (Filtering parameter) Any resource subject to substitution must belong to one of the listed "types". If this field is not provided, no type filtering will be performed (all resources of all types matching previous filtering parameters will be candidates for substitution).</summary>
    [JsonPropertyName("targetGroupKinds")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSubstitutionRulesTargetGroupKinds>? TargetGroupKinds { get; set; }

    /// <summary>Required. This is a [JSONPath] (https://kubernetes.io/docs/reference/kubectl/jsonpath/) expression that matches specific fields of candidate resources and it operates as both a filtering parameter (resources that are not matched with this expression will not be candidates for substitution) as well as a field identifier (identifies exactly which fields out of the candidate resources will be modified).</summary>
    [JsonPropertyName("targetJSONPath")]
    public string TargetJSONPath { get; set; }

    /// <summary>Optional. (Filtering parameter) Any resource subject to substitution must be contained within one of the listed Kubernetes Namespace in the Backup. If this field is not provided, no namespace filtering will be performed (all resources in all Namespaces, including all cluster-scoped resources, will be candidates for substitution). To mix cluster-scoped and namespaced resources in the same rule, use an empty string ("") as one of the target namespaces.</summary>
    [JsonPropertyName("targetNamespaces")]
    public IList<string>? TargetNamespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesFieldActions
{
    /// <summary>Optional. A string containing a JSON Pointer value that references the location in the target document to move the value from.</summary>
    [JsonPropertyName("fromPath")]
    public string? FromPath { get; set; }

    /// <summary>Required. op specifies the operation to perform.</summary>
    [JsonPropertyName("op")]
    public string Op { get; set; }

    /// <summary>Optional. A string containing a JSON-Pointer value that references a location within the target document where the operation is performed.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. A string that specifies the desired value in string format to use for transformation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesResourceFilterGroupKinds
{
    /// <summary>Optional. API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use empty string for core API group</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Optional. Kind of a Kubernetes resource, must be in UpperCamelCase (PascalCase) and singular form. E.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
    [JsonPropertyName("resourceKind")]
    public string? ResourceKind { get; set; }
}

/// <summary>Optional. This field is used to specify a set of fields that should be used to determine which resources in backup should be acted upon by the supplied transformation rule actions, and this will ensure that only specific resources are affected by transformation rule actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesResourceFilter
{
    /// <summary>Optional. (Filtering parameter) Any resource subject to transformation must belong to one of the listed "types". If this field is not provided, no type filtering will be performed (all resources of all types matching previous filtering parameters will be candidates for transformation).</summary>
    [JsonPropertyName("groupKinds")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesResourceFilterGroupKinds>? GroupKinds { get; set; }

    /// <summary>Optional. This is a [JSONPath] (https://github.com/json-path/JsonPath/blob/master/README.md) expression that matches specific fields of candidate resources and it operates as a filtering parameter (resources that are not matched with this expression will not be candidates for transformation).</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    /// <summary>Optional. (Filtering parameter) Any resource subject to transformation must be contained within one of the listed Kubernetes Namespace in the Backup. If this field is not provided, no namespace filtering will be performed (all resources in all Namespaces, including all cluster-scoped resources, will be candidates for transformation).</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRules
{
    /// <summary>Optional. The description is a user specified string description of the transformation rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. A list of transformation rule actions to take against candidate resources. Actions are executed in order defined - this order matters, as they could potentially interfere with each other and the first operation could affect the outcome of the second operation.</summary>
    [JsonPropertyName("fieldActions")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesFieldActions> FieldActions { get; set; }

    /// <summary>Optional. This field is used to specify a set of fields that should be used to determine which resources in backup should be acted upon by the supplied transformation rule actions, and this will ensure that only specific resources are affected by transformation rule actions.</summary>
    [JsonPropertyName("resourceFilter")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRulesResourceFilter? ResourceFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigVolumeDataRestorePolicyBindings
{
    /// <summary>Required. The VolumeDataRestorePolicy to apply when restoring volumes in scope.</summary>
    [JsonPropertyName("policy")]
    public string Policy { get; set; }

    /// <summary>The volume type, as determined by the PVC's bound PV, to apply the policy to.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Output only. Configuration of the Restore.  Inherited from parent RestorePlan's [restore_config][google.cloud.gkebackup.v1.RestorePlan.restore_config].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfig
{
    /// <summary>Restore all namespaced resources in the Backup if set to "True". Specifying this field to "False" is an error.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>Optional. Defines the behavior for handling the situation where cluster-scoped resources being restored already exist in the target cluster. This MUST be set to a value other than CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED if [cluster_resource_restore_scope][google.cloud.gkebackup.v1.RestoreConfig.cluster_resource_restore_scope] is not empty.</summary>
    [JsonPropertyName("clusterResourceConflictPolicy")]
    public string? ClusterResourceConflictPolicy { get; set; }

    /// <summary>Optional. Identifies the cluster-scoped resources to restore from the Backup. Not specifying it means NO cluster resource will be restored.</summary>
    [JsonPropertyName("clusterResourceRestoreScope")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigClusterResourceRestoreScope? ClusterResourceRestoreScope { get; set; }

    /// <summary>A list of selected namespaces excluded from restoration. All namespaces except those in this list will be restored.</summary>
    [JsonPropertyName("excludedNamespaces")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigExcludedNamespaces? ExcludedNamespaces { get; set; }

    /// <summary>Optional. Defines the behavior for handling the situation where sets of namespaced resources being restored already exist in the target cluster. This MUST be set to a value other than NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED.</summary>
    [JsonPropertyName("namespacedResourceRestoreMode")]
    public string? NamespacedResourceRestoreMode { get; set; }

    /// <summary>Do not restore any namespaced resources if set to "True". Specifying this field to "False" is not allowed.</summary>
    [JsonPropertyName("noNamespaces")]
    public bool? NoNamespaces { get; set; }

    /// <summary>Optional. RestoreOrder contains custom ordering to use on a Restore.</summary>
    [JsonPropertyName("restoreOrder")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigRestoreOrder? RestoreOrder { get; set; }

    /// <summary>A list of selected ProtectedApplications to restore. The listed ProtectedApplications and all the resources to which they refer will be restored.</summary>
    [JsonPropertyName("selectedApplications")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedApplications? SelectedApplications { get; set; }

    /// <summary>A list of selected Namespaces to restore from the Backup. The listed Namespaces and all resources contained in them will be restored.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSelectedNamespaces? SelectedNamespaces { get; set; }

    /// <summary>Optional. A list of transformation rules to be applied against Kubernetes resources as they are selected for restoration from a Backup. Rules are executed in order defined - this order matters, as changes made by a rule may impact the filtering logic of subsequent rules. An empty list means no substitution will occur.</summary>
    [JsonPropertyName("substitutionRules")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigSubstitutionRules>? SubstitutionRules { get; set; }

    /// <summary>Optional. A list of transformation rules to be applied against Kubernetes resources as they are selected for restoration from a Backup. Rules are executed in order defined - this order matters, as changes made by a rule may impact the filtering logic of subsequent rules. An empty list means no transformation will occur.</summary>
    [JsonPropertyName("transformationRules")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigTransformationRules>? TransformationRules { get; set; }

    /// <summary>Optional. Specifies the mechanism to be used to restore volume data. Default: VOLUME_DATA_RESTORE_POLICY_UNSPECIFIED (will be treated as NO_VOLUME_DATA_RESTORATION).</summary>
    [JsonPropertyName("volumeDataRestorePolicy")]
    public string? VolumeDataRestorePolicy { get; set; }

    /// <summary>Optional. A table that binds volumes by their scope to a restore policy. Bindings must have a unique scope. Any volumes not scoped in the bindings are subject to the policy defined in volume_data_restore_policy.</summary>
    [JsonPropertyName("volumeDataRestorePolicyBindings")]
    public IList<V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfigVolumeDataRestorePolicyBindings>? VolumeDataRestorePolicyBindings { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatusObservedState
{
    /// <summary>Output only. The target cluster into which this Restore will restore data.  Valid formats:     - `projects/*/locations/*/clusters/*`    - `projects/*/zones/*/clusters/*`   Inherited from parent RestorePlan's  [cluster][google.cloud.gkebackup.v1.RestorePlan.cluster] value.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Output only. Timestamp of when the restore operation completed.</summary>
    [JsonPropertyName("completeTime")]
    public string? CompleteTime { get; set; }

    /// <summary>Output only. The timestamp when this Restore resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a restore from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform restore updates in order to avoid race conditions: An `etag` is returned in the response to `GetRestore`, and systems are expected to put that etag in the request to `UpdateRestore` or `DeleteRestore` to ensure that their change will be applied to the same version of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Number of resources excluded during the restore execution.</summary>
    [JsonPropertyName("resourcesExcludedCount")]
    public int? ResourcesExcludedCount { get; set; }

    /// <summary>Output only. Number of resources that failed to be restored during the restore execution.</summary>
    [JsonPropertyName("resourcesFailedCount")]
    public int? ResourcesFailedCount { get; set; }

    /// <summary>Output only. Number of resources restored during the restore execution.</summary>
    [JsonPropertyName("resourcesRestoredCount")]
    public int? ResourcesRestoredCount { get; set; }

    /// <summary>Output only. Configuration of the Restore.  Inherited from parent RestorePlan's [restore_config][google.cloud.gkebackup.v1.RestorePlan.restore_config].</summary>
    [JsonPropertyName("restoreConfig")]
    public V1alpha1GKEBackupRestoreStatusObservedStateRestoreConfig? RestoreConfig { get; set; }

    /// <summary>Output only. The current state of the Restore.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Human-readable description of why the Restore is in its current state.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>Output only. Server generated global unique identifier of [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp when this Restore resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. Number of volumes restored during the restore execution.</summary>
    [JsonPropertyName("volumesRestoredCount")]
    public int? VolumesRestoredCount { get; set; }
}

/// <summary>GKEBackupRestoreStatus defines the config connector machine state of GKEBackupRestore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupRestoreStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEBackupRestoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GKEBackupRestore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GKEBackupRestoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>GKEBackupRestore is the Schema for the GKEBackupRestore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupRestore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GKEBackupRestoreSpec>, IStatus<V1alpha1GKEBackupRestoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupRestore";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackuprestores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GKEBackupRestoreSpec defines the desired state of GKEBackupRestore</summary>
    [JsonPropertyName("spec")]
    public V1alpha1GKEBackupRestoreSpec Spec { get; set; }

    /// <summary>GKEBackupRestoreStatus defines the config connector machine state of GKEBackupRestore</summary>
    [JsonPropertyName("status")]
    public V1alpha1GKEBackupRestoreStatus? Status { get; set; }
}