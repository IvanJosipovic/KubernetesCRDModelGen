using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>Storage version of v1api20240302.CopyCompletionError Indicates the error details if the background copy of a resource created via the CopyStart operation fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCopyCompletionError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }
}

/// <summary>ElasticSanResourceReference: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic san volume snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataElasticSanResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataGalleryImageReferenceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.ImageDiskReference The source image used for creating the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataGalleryImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("reference")]
    public V1api20240302storageSnapshotSpecCreationDataGalleryImageReferenceReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataImageReferenceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.ImageDiskReference The source image used for creating the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("reference")]
    public V1api20240302storageSnapshotSpecCreationDataImageReferenceReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationDataSourceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.CreationData Data used when creating a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>ElasticSanResourceReference: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic san volume snapshot.</summary>
    [JsonPropertyName("elasticSanResourceReference")]
    public V1api20240302storageSnapshotSpecCreationDataElasticSanResourceReference? ElasticSanResourceReference { get; set; }

    /// <summary>Storage version of v1api20240302.ImageDiskReference The source image used for creating the disk.</summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20240302storageSnapshotSpecCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>Storage version of v1api20240302.ImageDiskReference The source image used for creating the disk.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20240302storageSnapshotSpecCreationDataImageReference? ImageReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("performancePlus")]
    public bool? PerformancePlus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedBandwidthCopySpeed")]
    public string? ProvisionedBandwidthCopySpeed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityDataUri")]
    public string? SecurityDataUri { get; set; }

    /// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240302storageSnapshotSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecDiskAccessReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.Encryption Encryption at rest settings for disk or snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20240302storageSnapshotSpecEncryptionDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.SourceVault The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240302.KeyVaultAndSecretReference Key Vault Secret Url and vault id of the encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20240302.SourceVault The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.SourceVault The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240302.KeyVaultAndKeyReference Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20240302.SourceVault The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20240302.EncryptionSettingsElement Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240302.KeyVaultAndSecretReference Key Vault Secret Url and vault id of the encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Storage version of v1api20240302.KeyVaultAndKeyReference Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Storage version of v1api20240302.EncryptionSettingsCollection Encryption settings for disk or snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecEncryptionSettingsCollection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20240302storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>Storage version of v1api20240302.ExtendedLocation The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20240302.SnapshotOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240302storageSnapshotSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240302storageSnapshotSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.PurchasePlan Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecPurchasePlan
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>SecureVMDiskEncryptionSetReference: ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecSecurityProfileSecureVMDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.DiskSecurityProfile Contains the security related information for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecureVMDiskEncryptionSetReference: ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key</summary>
    [JsonPropertyName("secureVMDiskEncryptionSetReference")]
    public V1api20240302storageSnapshotSpecSecurityProfileSecureVMDiskEncryptionSetReference? SecureVMDiskEncryptionSetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }
}

/// <summary>Storage version of v1api20240302.SnapshotSku The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240302.SupportedCapabilities List of supported capabilities persisted on the disk resource for VM use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpecSupportedCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("acceleratedNetwork")]
    public bool? AcceleratedNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskControllerTypes")]
    public string? DiskControllerTypes { get; set; }
}

/// <summary>Storage version of v1api20240302.Snapshot_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary>Storage version of v1api20240302.CopyCompletionError Indicates the error details if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("copyCompletionError")]
    public V1api20240302storageSnapshotSpecCopyCompletionError? CopyCompletionError { get; set; }

    /// <summary>Storage version of v1api20240302.CreationData Data used when creating a disk.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240302storageSnapshotSpecCreationData? CreationData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public string? DataAccessAuthMode { get; set; }

    /// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessReference")]
    public V1api20240302storageSnapshotSpecDiskAccessReference? DiskAccessReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskState")]
    public string? DiskState { get; set; }

    /// <summary>Storage version of v1api20240302.Encryption Encryption at rest settings for disk or snapshot</summary>
    [JsonPropertyName("encryption")]
    public V1api20240302storageSnapshotSpecEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20240302.EncryptionSettingsCollection Encryption settings for disk or snapshot</summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20240302storageSnapshotSpecEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>Storage version of v1api20240302.ExtendedLocation The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240302storageSnapshotSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Storage version of v1api20240302.SnapshotOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240302storageSnapshotSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240302storageSnapshotSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20240302.PurchasePlan Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.</summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20240302storageSnapshotSpecPurchasePlan? PurchasePlan { get; set; }

    /// <summary>Storage version of v1api20240302.DiskSecurityProfile Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240302storageSnapshotSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20240302.SnapshotSku The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot</summary>
    [JsonPropertyName("sku")]
    public V1api20240302storageSnapshotSpecSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240302.SupportedCapabilities List of supported capabilities persisted on the disk resource for VM use.</summary>
    [JsonPropertyName("supportedCapabilities")]
    public V1api20240302storageSnapshotSpecSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20240302.CopyCompletionError_STATUS Indicates the error details if the background copy of a resource created via the CopyStart operation fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusCopyCompletionError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }
}

/// <summary>Storage version of v1api20240302.ImageDiskReference_STATUS The source image used for creating the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusCreationDataGalleryImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>Storage version of v1api20240302.ImageDiskReference_STATUS The source image used for creating the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusCreationDataImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>Storage version of v1api20240302.CreationData_STATUS Data used when creating a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticSanResourceId")]
    public string? ElasticSanResourceId { get; set; }

    /// <summary>Storage version of v1api20240302.ImageDiskReference_STATUS The source image used for creating the disk.</summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20240302storageSnapshotStatusCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>Storage version of v1api20240302.ImageDiskReference_STATUS The source image used for creating the disk.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20240302storageSnapshotStatusCreationDataImageReference? ImageReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("performancePlus")]
    public bool? PerformancePlus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedBandwidthCopySpeed")]
    public string? ProvisionedBandwidthCopySpeed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityDataUri")]
    public string? SecurityDataUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceUniqueId")]
    public string? SourceUniqueId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>Storage version of v1api20240302.Encryption_STATUS Encryption at rest settings for disk or snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240302.SourceVault_STATUS The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240302.KeyVaultAndSecretReference_STATUS Key Vault Secret Url and vault id of the encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20240302.SourceVault_STATUS The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20240302.SourceVault_STATUS The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240302.KeyVaultAndKeyReference_STATUS Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20240302.SourceVault_STATUS The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20240302.EncryptionSettingsElement_STATUS Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240302.KeyVaultAndSecretReference_STATUS Key Vault Secret Url and vault id of the encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Storage version of v1api20240302.KeyVaultAndKeyReference_STATUS Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Storage version of v1api20240302.EncryptionSettingsCollection_STATUS Encryption settings for disk or snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusEncryptionSettingsCollection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20240302storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>Storage version of v1api20240302.ExtendedLocation_STATUS The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240302.PurchasePlan_STATUS Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusPurchasePlan
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Storage version of v1api20240302.DiskSecurityProfile_STATUS Contains the security related information for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secureVMDiskEncryptionSetId")]
    public string? SecureVMDiskEncryptionSetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }
}

/// <summary>Storage version of v1api20240302.SnapshotSku_STATUS The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20240302.SupportedCapabilities_STATUS List of supported capabilities persisted on the disk resource for VM use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatusSupportedCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("acceleratedNetwork")]
    public bool? AcceleratedNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskControllerTypes")]
    public string? DiskControllerTypes { get; set; }
}

/// <summary>Storage version of v1api20240302.Snapshot_STATUS Snapshot resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302storageSnapshotStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240302storageSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240302.CopyCompletionError_STATUS Indicates the error details if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("copyCompletionError")]
    public V1api20240302storageSnapshotStatusCopyCompletionError? CopyCompletionError { get; set; }

    /// <summary>Storage version of v1api20240302.CreationData_STATUS Data used when creating a disk.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240302storageSnapshotStatusCreationData? CreationData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public string? DataAccessAuthMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeBytes")]
    public int? DiskSizeBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskState")]
    public string? DiskState { get; set; }

    /// <summary>Storage version of v1api20240302.Encryption_STATUS Encryption at rest settings for disk or snapshot</summary>
    [JsonPropertyName("encryption")]
    public V1api20240302storageSnapshotStatusEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20240302.EncryptionSettingsCollection_STATUS Encryption settings for disk or snapshot</summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20240302storageSnapshotStatusEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>Storage version of v1api20240302.ExtendedLocation_STATUS The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240302storageSnapshotStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incrementalSnapshotFamilyId")]
    public string? IncrementalSnapshotFamilyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20240302.PurchasePlan_STATUS Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.</summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20240302storageSnapshotStatusPurchasePlan? PurchasePlan { get; set; }

    /// <summary>Storage version of v1api20240302.DiskSecurityProfile_STATUS Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240302storageSnapshotStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20240302.SnapshotSku_STATUS The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot</summary>
    [JsonPropertyName("sku")]
    public V1api20240302storageSnapshotStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240302.SupportedCapabilities_STATUS List of supported capabilities persisted on the disk resource for VM use.</summary>
    [JsonPropertyName("supportedCapabilities")]
    public V1api20240302storageSnapshotStatusSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }
}

/// <summary>Storage version of v1api20240302.Snapshot Generator information: - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/snapshot.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240302storageSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240302storageSnapshotSpec>, IStatus<V1api20240302storageSnapshotStatus>
{
    public const string KubeApiVersion = "v1api20240302storage";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "compute.azure.com";
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

    /// <summary>Storage version of v1api20240302.Snapshot_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240302storageSnapshotSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240302.Snapshot_STATUS Snapshot resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240302storageSnapshotStatus? Status { get; set; }
}