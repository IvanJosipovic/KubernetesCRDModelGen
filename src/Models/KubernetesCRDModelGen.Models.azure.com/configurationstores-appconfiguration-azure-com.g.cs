using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appconfiguration.azure.com;
/// <summary>Storage version of v1api20220501.ConfigurationStore Generator information: - Generated from: /appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/appconfiguration.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501storageConfigurationStoreList : IKubernetesObject<V1ListMeta>, IItems<V1api20220501storageConfigurationStore>
{
    public const string KubeApiVersion = "v1api20220501storage";
    public const string KubeKind = "ConfigurationStoreList";
    public const string KubeGroup = "appconfiguration.azure.com";
    public const string KubePluralName = "configurationstores";
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
    public IList<V1api20220501storageConfigurationStore> Items { get; set; }
}

/// <summary>Storage version of v1api20220501.KeyVaultProperties Settings concerning key vault encryption for a configuration store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>Storage version of v1api20220501.EncryptionProperties The encryption settings for a configuration store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220501.KeyVaultProperties Settings concerning key vault encryption for a configuration store.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20220501storageConfigurationStoreSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20220501.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220501storageConfigurationStoreSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220501.ResourceIdentity An identity that can be associated with a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220501storageConfigurationStoreSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretExpressions
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

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryKeyID
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyKeyID
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryKeyID
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyKeyID
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220501.ConfigurationStoreOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryKey")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryKeyID")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryKeyID? PrimaryKeyID { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryReadOnlyConnectionString")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyConnectionString? PrimaryReadOnlyConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryReadOnlyKey")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyKey? PrimaryReadOnlyKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryReadOnlyKeyID")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsPrimaryReadOnlyKeyID? PrimaryReadOnlyKeyID { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryKeyID")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryKeyID? SecondaryKeyID { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryReadOnlyConnectionString")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyConnectionString? SecondaryReadOnlyConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryReadOnlyKey")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyKey? SecondaryReadOnlyKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryReadOnlyKeyID")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecretsSecondaryReadOnlyKeyID? SecondaryReadOnlyKeyID { get; set; }
}

/// <summary>Storage version of v1api20220501.ConfigurationStoreOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220501storageConfigurationStoreSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220501storageConfigurationStoreSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20220501.ConfigurationStoreOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220501.Sku Describes a configuration store SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220501.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpecSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20220501.ConfigurationStore_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary>Storage version of v1api20220501.EncryptionProperties The encryption settings for a configuration store.</summary>
    [JsonPropertyName("encryption")]
    public V1api20220501storageConfigurationStoreSpecEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20220501.ResourceIdentity An identity that can be associated with a resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220501storageConfigurationStoreSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20220501.ConfigurationStoreOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220501storageConfigurationStoreSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220501storageConfigurationStoreSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20220501.Sku Describes a configuration store SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageConfigurationStoreSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary>Storage version of v1api20220501.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20220501storageConfigurationStoreSpecSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusConditions
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

/// <summary>Storage version of v1api20220501.KeyVaultProperties_STATUS Settings concerning key vault encryption for a configuration store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>Storage version of v1api20220501.EncryptionProperties_STATUS The encryption settings for a configuration store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220501.KeyVaultProperties_STATUS Settings concerning key vault encryption for a configuration store.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20220501storageConfigurationStoreStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>Storage version of v1api20220501.UserIdentity_STATUS A resource identity that is managed by the user of the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20220501.ResourceIdentity_STATUS An identity that can be associated with a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20220501storageConfigurationStoreStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20220501.PrivateEndpointConnectionReference_STATUS A reference to a related private endpoint connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220501.Sku_STATUS Describes a configuration store SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220501.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20220501.ConfigurationStore_STATUS The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageConfigurationStoreStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220501storageConfigurationStoreStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary>Storage version of v1api20220501.EncryptionProperties_STATUS The encryption settings for a configuration store.</summary>
    [JsonPropertyName("encryption")]
    public V1api20220501storageConfigurationStoreStatusEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220501.ResourceIdentity_STATUS An identity that can be associated with a resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220501storageConfigurationStoreStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20220501storageConfigurationStoreStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20220501.Sku_STATUS Describes a configuration store SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageConfigurationStoreStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary>Storage version of v1api20220501.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20220501storageConfigurationStoreStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220501.ConfigurationStore Generator information: - Generated from: /appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2022-05-01/appconfiguration.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501storageConfigurationStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220501storageConfigurationStoreSpec>, IStatus<V1api20220501storageConfigurationStoreStatus>
{
    public const string KubeApiVersion = "v1api20220501storage";
    public const string KubeKind = "ConfigurationStore";
    public const string KubeGroup = "appconfiguration.azure.com";
    public const string KubePluralName = "configurationstores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220501.ConfigurationStore_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220501storageConfigurationStoreSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220501.ConfigurationStore_STATUS The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.</summary>
    [JsonPropertyName("status")]
    public V1api20220501storageConfigurationStoreStatus? Status { get; set; }
}