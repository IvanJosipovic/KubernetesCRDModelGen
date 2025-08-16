using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcareapis.azure.upbound.io;
/// <summary>HealthcareDICOMService is the Schema for the HealthcareDICOMServices API. Manages a Healthcare DICOM (Digital Imaging and Communications in Medicine) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareDICOMServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HealthcareDICOMService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareDICOMServiceList";
    public const string KubeGroup = "healthcareapis.azure.upbound.io";
    public const string KubePluralName = "healthcaredicomservices";
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
    public IList<V1beta1HealthcareDICOMService> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecForProvider
{
    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1HealthcareDICOMServiceSpecForProviderCors>? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareDICOMServiceSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public IList<V1beta1HealthcareDICOMServiceSpecForProviderStorage>? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the ID of the Healthcare Workspace where the Healthcare DICOM Service should exist. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta1HealthcareDICOMServiceSpecForProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecInitProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecInitProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecInitProvider
{
    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1HealthcareDICOMServiceSpecInitProviderCors>? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareDICOMServiceSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public IList<V1beta1HealthcareDICOMServiceSpecInitProviderStorage>? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareDICOMServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>HealthcareDICOMServiceSpec defines the desired state of HealthcareDICOMService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HealthcareDICOMServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HealthcareDICOMServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HealthcareDICOMServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HealthcareDICOMServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProviderAuthentication
{
    /// <summary>The intended audience to receive authentication tokens for the service. The default value is https://dicom.azurehealthcareapis.azure.com</summary>
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProviderCors
{
    /// <summary>Whether to allow credentials in CORS. Defaults to false.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>A list of allowed headers for CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of allowed methods for CORS.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of allowed origins for CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>The maximum age in seconds for the CORS configuration (must be between 0 and 99998 inclusive).</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Identity IDs which should be assigned to this Healthcare DICOM service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of identity used for the Healthcare DICOM service. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned. If UserAssigned is set, an identity_ids must be set as well.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProviderPrivateEndpoint
{
    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Healthcare DICOM Service. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProviderStorage
{
    /// <summary>The filesystem name of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("fileSystemName")]
    public string? FileSystemName { get; set; }

    /// <summary>The resource ID of connected storage account. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusAtProvider
{
    /// <summary>The authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1HealthcareDICOMServiceStatusAtProviderAuthentication>? Authentication { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1HealthcareDICOMServiceStatusAtProviderCors>? Cors { get; set; }

    /// <summary>If data partitions are enabled or not. Defaults to false. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("dataPartitionsEnabled")]
    public bool? DataPartitionsEnabled { get; set; }

    /// <summary>The URL of the key to use for encryption as part of the customer-managed key encryption settings. For more details, refer to the Azure Customer-Managed Keys Overview.</summary>
    [JsonPropertyName("encryptionKeyUrl")]
    public string? EncryptionKeyUrl { get; set; }

    /// <summary>The ID of the Healthcare DICOM Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareDICOMServiceStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare DICOM Service should be created. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoint")]
    public IList<V1beta1HealthcareDICOMServiceStatusAtProviderPrivateEndpoint>? PrivateEndpoint { get; set; }

    /// <summary>Whether to enabled public networks when data plane traffic coming from public networks while private endpoint is enabled. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The url of the Healthcare DICOM Services.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public IList<V1beta1HealthcareDICOMServiceStatusAtProviderStorage>? Storage { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare DICOM Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the ID of the Healthcare Workspace where the Healthcare DICOM Service should exist. Changing this forces a new Healthcare DICOM Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatusConditions
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

/// <summary>HealthcareDICOMServiceStatus defines the observed state of HealthcareDICOMService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareDICOMServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HealthcareDICOMServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HealthcareDICOMServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthcareDICOMService is the Schema for the HealthcareDICOMServices API. Manages a Healthcare DICOM (Digital Imaging and Communications in Medicine) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareDICOMService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HealthcareDICOMServiceSpec>, IStatus<V1beta1HealthcareDICOMServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareDICOMService";
    public const string KubeGroup = "healthcareapis.azure.upbound.io";
    public const string KubePluralName = "healthcaredicomservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthcareDICOMServiceSpec defines the desired state of HealthcareDICOMService</summary>
    [JsonPropertyName("spec")]
    public V1beta1HealthcareDICOMServiceSpec Spec { get; set; }

    /// <summary>HealthcareDICOMServiceStatus defines the observed state of HealthcareDICOMService.</summary>
    [JsonPropertyName("status")]
    public V1beta1HealthcareDICOMServiceStatus? Status { get; set; }
}