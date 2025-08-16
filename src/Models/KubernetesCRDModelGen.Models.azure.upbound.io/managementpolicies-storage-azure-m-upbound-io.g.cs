using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.m.upbound.io;
/// <summary>ManagementPolicy is the Schema for the ManagementPolicys API. Manages an Azure Storage Account Management Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagementPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagementPolicyList";
    public const string KubeGroup = "storage.azure.m.upbound.io";
    public const string KubePluralName = "managementpolicies";
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
    public IList<V1beta1ManagementPolicy> Items { get; set; }
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it's accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta1ManagementPolicySpecForProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1ManagementPolicySpecForProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta1ManagementPolicySpecForProviderRuleActionsVersion? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta1ManagementPolicySpecForProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta1ManagementPolicySpecForProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta1ManagementPolicySpecForProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementPolicySpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProviderStorageAccountIdSelector
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
    public V1beta1ManagementPolicySpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecForProvider
{
    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ManagementPolicySpecForProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1ManagementPolicySpecForProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1ManagementPolicySpecForProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it's accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta1ManagementPolicySpecInitProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1ManagementPolicySpecInitProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta1ManagementPolicySpecInitProviderRuleActionsVersion? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta1ManagementPolicySpecInitProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta1ManagementPolicySpecInitProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta1ManagementPolicySpecInitProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementPolicySpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProviderStorageAccountIdSelector
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
    public V1beta1ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecInitProvider
{
    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ManagementPolicySpecInitProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1ManagementPolicySpecInitProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1ManagementPolicySpecInitProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpecProviderConfigRef
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
public partial class V1beta1ManagementPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ManagementPolicySpec defines the desired state of ManagementPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagementPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagementPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagementPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagementPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it's accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta1ManagementPolicyStatusAtProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1ManagementPolicyStatusAtProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta1ManagementPolicyStatusAtProviderRuleActionsVersion? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta1ManagementPolicyStatusAtProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta1ManagementPolicyStatusAtProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta1ManagementPolicyStatusAtProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusAtProvider
{
    /// <summary>The ID of the Storage Account Management Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1ManagementPolicyStatusAtProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatusConditions
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

/// <summary>ManagementPolicyStatus defines the observed state of ManagementPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagementPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagementPolicy is the Schema for the ManagementPolicys API. Manages an Azure Storage Account Management Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagementPolicySpec>, IStatus<V1beta1ManagementPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagementPolicy";
    public const string KubeGroup = "storage.azure.m.upbound.io";
    public const string KubePluralName = "managementpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementPolicySpec defines the desired state of ManagementPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagementPolicySpec Spec { get; set; }

    /// <summary>ManagementPolicyStatus defines the observed state of ManagementPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagementPolicyStatus? Status { get; set; }
}