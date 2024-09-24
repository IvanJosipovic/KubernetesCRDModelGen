using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>Storage version of v1api20230101.CorsRule Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecCorsCorsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRules Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("corsRules")]
    public IList<V1api20230101storageStorageAccountsFileServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.Multichannel Multichannel setting. Applies to Premium FileStorage only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.SmbSetting Setting for SMB protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecProtocolSettingsSmb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>Storage version of v1api20230101.Multichannel Multichannel setting. Applies to Premium FileStorage only.</summary>
    [JsonPropertyName("multichannel")]
    public V1api20230101storageStorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>Storage version of v1api20230101.ProtocolSettings Protocol settings for file service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecProtocolSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.SmbSetting Setting for SMB protocol</summary>
    [JsonPropertyName("smb")]
    public V1api20230101storageStorageAccountsFileServiceSpecProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpecShareDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccounts_FileService_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.CorsRules Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("cors")]
    public V1api20230101storageStorageAccountsFileServiceSpecCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageStorageAccountsFileServiceSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230101.ProtocolSettings Protocol settings for file service</summary>
    [JsonPropertyName("protocolSettings")]
    public V1api20230101storageStorageAccountsFileServiceSpecProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsFileServiceSpecShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusConditions
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

/// <summary>Storage version of v1api20230101.CorsRule_STATUS Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusCorsCorsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRules_STATUS Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("corsRules")]
    public IList<V1api20230101storageStorageAccountsFileServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>Storage version of v1api20230101.Multichannel_STATUS Multichannel setting. Applies to Premium FileStorage only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.SmbSetting_STATUS Setting for SMB protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusProtocolSettingsSmb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>Storage version of v1api20230101.Multichannel_STATUS Multichannel setting. Applies to Premium FileStorage only.</summary>
    [JsonPropertyName("multichannel")]
    public V1api20230101storageStorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>Storage version of v1api20230101.ProtocolSettings_STATUS Protocol settings for file service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusProtocolSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.SmbSetting_STATUS Setting for SMB protocol</summary>
    [JsonPropertyName("smb")]
    public V1api20230101storageStorageAccountsFileServiceStatusProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusShareDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.Sku_STATUS The SKU of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatusSku
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

/// <summary>Storage version of v1api20230101.StorageAccounts_FileService_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsFileServiceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountsFileServiceStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20230101.CorsRules_STATUS Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("cors")]
    public V1api20230101storageStorageAccountsFileServiceStatusCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230101.ProtocolSettings_STATUS Protocol settings for file service</summary>
    [JsonPropertyName("protocolSettings")]
    public V1api20230101storageStorageAccountsFileServiceStatusProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsFileServiceStatusShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }

    /// <summary>Storage version of v1api20230101.Sku_STATUS The SKU of the storage account.</summary>
    [JsonPropertyName("sku")]
    public V1api20230101storageStorageAccountsFileServiceStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccountsFileService Generator information: - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/file.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsFileService : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountsFileServiceSpec>, IStatus<V1api20230101storageStorageAccountsFileServiceStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsFileService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_FileService_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountsFileServiceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_FileService_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountsFileServiceStatus? Status { get; set; }
}