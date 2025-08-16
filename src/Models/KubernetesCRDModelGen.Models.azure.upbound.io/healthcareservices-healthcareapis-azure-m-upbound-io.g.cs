using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcareapis.azure.m.upbound.io;
/// <summary>HealthcareService is the Schema for the HealthcareServices API. Manages a Healthcare Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HealthcareService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareServiceList";
    public const string KubeGroup = "healthcareapis.azure.m.upbound.io";
    public const string KubePluralName = "healthcareservices";
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
    public IList<V1beta1HealthcareService> Items { get; set; }
}

/// <summary>An authentication_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProviderAuthenticationConfiguration
{
    /// <summary>The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>(Boolean) Enables the 'SMART on FHIR' option for mobile and web implementations.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProviderCorsConfiguration
{
    /// <summary>(Boolean) If credentials are allowed via CORS.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProviderIdentity
{
    /// <summary>The type of managed identity to assign. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1HealthcareServiceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareServiceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1HealthcareServiceSpecForProviderResourceGroupNameSelector
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
    public V1beta1HealthcareServiceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecForProvider
{
    /// <summary>A set of Azure object IDs that are allowed to access the Service.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication_configuration block as defined below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1HealthcareServiceSpecForProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A cors_configuration block as defined below.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1HealthcareServiceSpecForProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption of the backing database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosdbKeyVaultKeyVersionlessId")]
    public string? CosmosdbKeyVaultKeyVersionlessId { get; set; }

    /// <summary>The provisioned throughput for the backing database. Range of 400-100000. Defaults to 1000.</summary>
    [JsonPropertyName("cosmosdbThroughput")]
    public double? CosmosdbThroughput { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareServiceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The type of the service. Values at time of publication are: fhir, fhir-Stu3 and fhir-R4. Default value is fhir.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the supported Azure Region where the Service should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is enabled or disabled for this service instance. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which to create the Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HealthcareServiceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HealthcareServiceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An authentication_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecInitProviderAuthenticationConfiguration
{
    /// <summary>The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>(Boolean) Enables the 'SMART on FHIR' option for mobile and web implementations.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecInitProviderCorsConfiguration
{
    /// <summary>(Boolean) If credentials are allowed via CORS.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecInitProviderIdentity
{
    /// <summary>The type of managed identity to assign. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecInitProvider
{
    /// <summary>A set of Azure object IDs that are allowed to access the Service.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication_configuration block as defined below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1HealthcareServiceSpecInitProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A cors_configuration block as defined below.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1HealthcareServiceSpecInitProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption of the backing database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosdbKeyVaultKeyVersionlessId")]
    public string? CosmosdbKeyVaultKeyVersionlessId { get; set; }

    /// <summary>The provisioned throughput for the backing database. Range of 400-100000. Defaults to 1000.</summary>
    [JsonPropertyName("cosmosdbThroughput")]
    public double? CosmosdbThroughput { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareServiceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The type of the service. Values at time of publication are: fhir, fhir-Stu3 and fhir-R4. Default value is fhir.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the supported Azure Region where the Service should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is enabled or disabled for this service instance. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpecProviderConfigRef
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
public partial class V1beta1HealthcareServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>HealthcareServiceSpec defines the desired state of HealthcareService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HealthcareServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HealthcareServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HealthcareServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HealthcareServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An authentication_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatusAtProviderAuthenticationConfiguration
{
    /// <summary>The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>(Boolean) Enables the 'SMART on FHIR' option for mobile and web implementations.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatusAtProviderCorsConfiguration
{
    /// <summary>(Boolean) If credentials are allowed via CORS.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatusAtProviderIdentity
{
    /// <summary>The ID of the Healthcare Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Healthcare Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of managed identity to assign. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatusAtProvider
{
    /// <summary>A set of Azure object IDs that are allowed to access the Service.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication_configuration block as defined below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1HealthcareServiceStatusAtProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A cors_configuration block as defined below.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1HealthcareServiceStatusAtProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption of the backing database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cosmosdbKeyVaultKeyVersionlessId")]
    public string? CosmosdbKeyVaultKeyVersionlessId { get; set; }

    /// <summary>The provisioned throughput for the backing database. Range of 400-100000. Defaults to 1000.</summary>
    [JsonPropertyName("cosmosdbThroughput")]
    public double? CosmosdbThroughput { get; set; }

    /// <summary>The ID of the Healthcare Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareServiceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The type of the service. Values at time of publication are: fhir, fhir-Stu3 and fhir-R4. Default value is fhir.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the supported Azure Region where the Service should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is enabled or disabled for this service instance. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which to create the Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatusConditions
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

/// <summary>HealthcareServiceStatus defines the observed state of HealthcareService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HealthcareServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HealthcareServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthcareService is the Schema for the HealthcareServices API. Manages a Healthcare Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HealthcareServiceSpec>, IStatus<V1beta1HealthcareServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareService";
    public const string KubeGroup = "healthcareapis.azure.m.upbound.io";
    public const string KubePluralName = "healthcareservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthcareServiceSpec defines the desired state of HealthcareService</summary>
    [JsonPropertyName("spec")]
    public V1beta1HealthcareServiceSpec Spec { get; set; }

    /// <summary>HealthcareServiceStatus defines the observed state of HealthcareService.</summary>
    [JsonPropertyName("status")]
    public V1beta1HealthcareServiceStatus? Status { get; set; }
}