using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderKeyVaultConnectionString
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server connection string.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string in which to authenticate with Azure SQL Database. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_connection_string block as defined below. Use this argument to store Azure SQL Database connection string in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("keyVaultConnectionString")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderKeyVaultConnectionString>? KeyVaultConnectionString { get; set; }

    /// <summary>A key_vault_password block as defined below. Use this argument to store SQL Server password in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseSpecForProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure SQL Database. Required if service_principal_key is set.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the Azure SQL Database. Required if service_principal_id is set.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure SQL Database.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure SQL Database. Incompatible with service_principal_id and service_principal_key</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecInitProviderKeyVaultConnectionString
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server connection string.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecInitProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string in which to authenticate with Azure SQL Database. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>The description for the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_connection_string block as defined below. Use this argument to store Azure SQL Database connection string in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("keyVaultConnectionString")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseSpecInitProviderKeyVaultConnectionString>? KeyVaultConnectionString { get; set; }

    /// <summary>A key_vault_password block as defined below. Use this argument to store SQL Server password in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseSpecInitProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure SQL Database. Required if service_principal_key is set.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the Azure SQL Database. Required if service_principal_id is set.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure SQL Database.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure SQL Database. Incompatible with service_principal_id and service_principal_key</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinkedServiceAzureSQLDatabaseSpec defines the desired state of LinkedServiceAzureSQLDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinkedServiceAzureSQLDatabaseSpecDeletionPolicyEnum>))]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseStatusAtProviderKeyVaultConnectionString
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server connection string.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseStatusAtProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores SQL Server password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string in which to authenticate with Azure SQL Database. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Data Factory Azure SQL Database Linked Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_connection_string block as defined below. Use this argument to store Azure SQL Database connection string in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. Exactly one of either connection_string or key_vault_connection_string is required.</summary>
    [JsonPropertyName("keyVaultConnectionString")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseStatusAtProviderKeyVaultConnectionString>? KeyVaultConnectionString { get; set; }

    /// <summary>A key_vault_password block as defined below. Use this argument to store SQL Server password in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseStatusAtProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service Azure SQL Database.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure SQL Database. Required if service_principal_key is set.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the Azure SQL Database. Required if service_principal_id is set.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure SQL Database.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure SQL Database. Incompatible with service_principal_id and service_principal_key</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseStatusConditions
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

/// <summary>LinkedServiceAzureSQLDatabaseStatus defines the observed state of LinkedServiceAzureSQLDatabase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureSQLDatabaseStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinkedServiceAzureSQLDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinkedServiceAzureSQLDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinkedServiceAzureSQLDatabase is the Schema for the LinkedServiceAzureSQLDatabases API. Manages a Linked Service (connection) between Azure SQL Database and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceAzureSQLDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinkedServiceAzureSQLDatabaseSpec>, IStatus<V1beta1LinkedServiceAzureSQLDatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceAzureSQLDatabase";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "linkedserviceazuresqldatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinkedServiceAzureSQLDatabaseSpec defines the desired state of LinkedServiceAzureSQLDatabase</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinkedServiceAzureSQLDatabaseSpec Spec { get; set; }

    /// <summary>LinkedServiceAzureSQLDatabaseStatus defines the observed state of LinkedServiceAzureSQLDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinkedServiceAzureSQLDatabaseStatus? Status { get; set; }
}