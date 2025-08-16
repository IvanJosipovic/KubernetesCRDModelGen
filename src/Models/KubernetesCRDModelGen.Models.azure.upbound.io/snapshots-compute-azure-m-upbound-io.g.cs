using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.m.upbound.io;
/// <summary>Snapshot is the Schema for the Snapshots API. Manages a Disk Snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Snapshot>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "compute.azure.m.upbound.io";
    public const string KubePluralName = "snapshots";
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
    public IList<V1beta1Snapshot> Items { get; set; }
}

/// <summary>A disk_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1SnapshotSpecForProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta1SnapshotSpecForProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderResourceGroupNameSelector
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
    public V1beta1SnapshotSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate sourceUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecForProviderSourceUriRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate sourceUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProviderSourceUriSelector
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
    public V1beta1SnapshotSpecForProviderSourceUriSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecForProvider
{
    /// <summary>Indicates how the snapshot is to be created. Possible values are Copy or Import.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>Specifies the ID of the Disk Access which should be used for this Snapshot. This is used in conjunction with setting network_access_policy to AllowPrivate.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The size of the Snapshotted Disk in GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta1SnapshotSpecForProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Specifies if the Snapshot is incremental. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("incrementalEnabled")]
    public bool? IncrementalEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Policy for accessing the disk via network. Possible values are AllowAll, AllowPrivate, or DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Policy for controlling export on the disk. Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Snapshot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SnapshotSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SnapshotSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies a reference to an existing snapshot, when create_option is Copy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Specifies the URI to a Managed or Unmanaged Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate sourceUri.</summary>
    [JsonPropertyName("sourceUriRef")]
    public V1beta1SnapshotSpecForProviderSourceUriRef? SourceUriRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate sourceUri.</summary>
    [JsonPropertyName("sourceUriSelector")]
    public V1beta1SnapshotSpecForProviderSourceUriSelector? SourceUriSelector { get; set; }

    /// <summary>Specifies the ID of an storage account. Used with source_uri to allow authorization during import of unmanaged blobs from a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A disk_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1SnapshotSpecInitProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta1SnapshotSpecInitProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate sourceUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotSpecInitProviderSourceUriRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate sourceUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProviderSourceUriSelector
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
    public V1beta1SnapshotSpecInitProviderSourceUriSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecInitProvider
{
    /// <summary>Indicates how the snapshot is to be created. Possible values are Copy or Import.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>Specifies the ID of the Disk Access which should be used for this Snapshot. This is used in conjunction with setting network_access_policy to AllowPrivate.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The size of the Snapshotted Disk in GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta1SnapshotSpecInitProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Specifies if the Snapshot is incremental. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("incrementalEnabled")]
    public bool? IncrementalEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Policy for accessing the disk via network. Possible values are AllowAll, AllowPrivate, or DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Policy for controlling export on the disk. Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies a reference to an existing snapshot, when create_option is Copy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Specifies the URI to a Managed or Unmanaged Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate sourceUri.</summary>
    [JsonPropertyName("sourceUriRef")]
    public V1beta1SnapshotSpecInitProviderSourceUriRef? SourceUriRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate sourceUri.</summary>
    [JsonPropertyName("sourceUriSelector")]
    public V1beta1SnapshotSpecInitProviderSourceUriSelector? SourceUriSelector { get; set; }

    /// <summary>Specifies the ID of an storage account. Used with source_uri to allow authorization during import of unmanaged blobs from a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpecProviderConfigRef
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
public partial class V1beta1SnapshotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SnapshotSpec defines the desired state of Snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SnapshotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SnapshotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SnapshotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SnapshotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A disk_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined below.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1SnapshotStatusAtProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta1SnapshotStatusAtProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusAtProvider
{
    /// <summary>Indicates how the snapshot is to be created. Possible values are Copy or Import.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>Specifies the ID of the Disk Access which should be used for this Snapshot. This is used in conjunction with setting network_access_policy to AllowPrivate.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The size of the Snapshotted Disk in GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta1SnapshotStatusAtProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>The Snapshot ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies if the Snapshot is incremental. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("incrementalEnabled")]
    public bool? IncrementalEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Policy for accessing the disk via network. Possible values are AllowAll, AllowPrivate, or DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Policy for controlling export on the disk. Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Snapshot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies a reference to an existing snapshot, when create_option is Copy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Specifies the URI to a Managed or Unmanaged Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>Specifies the ID of an storage account. Used with source_uri to allow authorization during import of unmanaged blobs from a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether Trusted Launch is enabled for the Snapshot.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatusConditions
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

/// <summary>SnapshotStatus defines the observed state of Snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SnapshotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Snapshot is the Schema for the Snapshots API. Manages a Disk Snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SnapshotSpec>, IStatus<V1beta1SnapshotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "compute.azure.m.upbound.io";
    public const string KubePluralName = "snapshots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SnapshotSpec defines the desired state of Snapshot</summary>
    [JsonPropertyName("spec")]
    public V1beta1SnapshotSpec Spec { get; set; }

    /// <summary>SnapshotStatus defines the observed state of Snapshot.</summary>
    [JsonPropertyName("status")]
    public V1beta1SnapshotStatus? Status { get; set; }
}