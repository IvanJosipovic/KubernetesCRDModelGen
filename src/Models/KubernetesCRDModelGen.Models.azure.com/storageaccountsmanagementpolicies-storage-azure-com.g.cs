using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy Generator information: - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20230101storageStorageAccountsManagementPolicy>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsManagementPolicyList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
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
    public IList<V1api20230101storageStorageAccountsManagementPolicy> Items { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicyOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyBaseBlob Management policy action for base blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicySnapShot Management policy action for snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyVersion Management policy action for blob version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyAction Actions are applied to the filtered blobs when the execution condition is met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyBaseBlob Management policy action for base blob.</summary>
    [JsonPropertyName("baseBlob")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicySnapShot Management policy action for snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyVersion Management policy action for blob version.</summary>
    [JsonPropertyName("version")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>Storage version of v1api20230101.TagFilter Blob index tag based filtering for blob objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyFilter Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyDefinition An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinition
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyAction Actions are applied to the filtered blobs when the execution condition is met.</summary>
    [JsonPropertyName("actions")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActions? Actions { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyFilter Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.</summary>
    [JsonPropertyName("filters")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyRule An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyDefinition An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.</summary>
    [JsonPropertyName("definition")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicyRulesDefinition? Definition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicySchema The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpecPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20230101storageStorageAccountsManagementPolicySpecPolicyRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicyOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230101storageStorageAccountsManagementPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageStorageAccountsManagementPolicySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicySchema The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</summary>
    [JsonPropertyName("policy")]
    public V1api20230101storageStorageAccountsManagementPolicySpecPolicy? Policy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusConditions
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

/// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyBaseBlob_STATUS Management policy action for base blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterModification_STATUS Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicySnapShot_STATUS Management policy action for snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyVersion_STATUS Management policy action for blob version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("delete")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>Storage version of v1api20230101.DateAfterCreation_STATUS Object to define snapshot and version action conditions.</summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyAction_STATUS Actions are applied to the filtered blobs when the execution condition is met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyBaseBlob_STATUS Management policy action for base blob.</summary>
    [JsonPropertyName("baseBlob")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicySnapShot_STATUS Management policy action for snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyVersion_STATUS Management policy action for blob version.</summary>
    [JsonPropertyName("version")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>Storage version of v1api20230101.TagFilter_STATUS Blob index tag based filtering for blob objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyFilter_STATUS Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyDefinition_STATUS An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinition
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyAction_STATUS Actions are applied to the filtered blobs when the execution condition is met.</summary>
    [JsonPropertyName("actions")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions? Actions { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyFilter_STATUS Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.</summary>
    [JsonPropertyName("filters")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicyRule_STATUS An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicyDefinition_STATUS An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.</summary>
    [JsonPropertyName("definition")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRulesDefinition? Definition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230101.ManagementPolicySchema_STATUS The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatusPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20230101storageStorageAccountsManagementPolicyStatusPolicyRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsManagementPolicyStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountsManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230101.ManagementPolicySchema_STATUS The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</summary>
    [JsonPropertyName("policy")]
    public V1api20230101storageStorageAccountsManagementPolicyStatusPolicy? Policy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy Generator information: - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountsManagementPolicySpec>, IStatus<V1api20230101storageStorageAccountsManagementPolicyStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsManagementPolicy";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountsManagementPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccountsManagementPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountsManagementPolicyStatus? Status { get; set; }
}