using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcareapis.azure.m.upbound.io;
/// <summary>HealthcareFHIRService is the Schema for the HealthcareFHIRServices API. Manages a Healthcare FHIR (Fast Healthcare Interoperability Resources) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareFHIRServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HealthcareFHIRService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareFHIRServiceList";
    public const string KubeGroup = "healthcareapis.azure.m.upbound.io";
    public const string KubePluralName = "healthcarefhirservices";
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
    public IList<V1beta1HealthcareFHIRService> Items { get; set; }
}

/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderAuthentication
{
    /// <summary>The intended audience to receive authentication tokens for the service.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>Whether smart proxy is enabled.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderCors
{
    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>If credentials are allowed via CORS.</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderIdentity
{
    /// <summary>A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are UserAssigned and SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderOciArtifact
{
    /// <summary>A digest of an image within Azure container registry used for export operations of the service instance to narrow the artifacts down.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>An image within Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>An Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("loginServer")]
    public string? LoginServer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameSelector
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
    public V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdRefPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdSelectorPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdSelector
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
    public V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecForProvider
{
    /// <summary>A list of the access policies of the service instance.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1HealthcareFHIRServiceSpecForProviderAuthentication? Authentication { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A list of azure container registry settings used for convert data operation of the service instance.</summary>
    [JsonPropertyName("containerRegistryLoginServerUrl")]
    public IList<string>? ContainerRegistryLoginServerUrl { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1HealthcareFHIRServiceSpecForProviderCors? Cors { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareFHIRServiceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the kind of the Healthcare FHIR Service. Possible values are: fhir-Stu3 and fhir-R4. Defaults to fhir-R4. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare FHIR Service should be created. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of oci_artifact objects as defined below to describe OCI artifacts for export.</summary>
    [JsonPropertyName("ociArtifact")]
    public IList<V1beta1HealthcareFHIRServiceSpecForProviderOciArtifact>? OciArtifact { get; set; }

    /// <summary>Specifies the name of the Resource Group in which to create the Healthcare FHIR Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HealthcareFHIRServiceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare FHIR Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the id of the Healthcare Workspace where the Healthcare FHIR Service should exist. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta1HealthcareFHIRServiceSpecForProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderAuthentication
{
    /// <summary>The intended audience to receive authentication tokens for the service.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>Whether smart proxy is enabled.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderCors
{
    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>If credentials are allowed via CORS.</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderIdentity
{
    /// <summary>A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are UserAssigned and SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderOciArtifact
{
    /// <summary>A digest of an image within Azure container registry used for export operations of the service instance to narrow the artifacts down.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>An image within Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>An Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("loginServer")]
    public string? LoginServer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameRefPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameSelector
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
    public V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecInitProvider
{
    /// <summary>A list of the access policies of the service instance.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderAuthentication? Authentication { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A list of azure container registry settings used for convert data operation of the service instance.</summary>
    [JsonPropertyName("containerRegistryLoginServerUrl")]
    public IList<string>? ContainerRegistryLoginServerUrl { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderCors? Cors { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the kind of the Healthcare FHIR Service. Possible values are: fhir-Stu3 and fhir-R4. Defaults to fhir-R4. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare FHIR Service should be created. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of oci_artifact objects as defined below to describe OCI artifacts for export.</summary>
    [JsonPropertyName("ociArtifact")]
    public IList<V1beta1HealthcareFHIRServiceSpecInitProviderOciArtifact>? OciArtifact { get; set; }

    /// <summary>Specifies the name of the Resource Group in which to create the Healthcare FHIR Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HealthcareFHIRServiceSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare FHIR Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpecProviderConfigRef
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
public partial class V1beta1HealthcareFHIRServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>HealthcareFHIRServiceSpec defines the desired state of HealthcareFHIRService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HealthcareFHIRServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HealthcareFHIRServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HealthcareFHIRServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HealthcareFHIRServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusAtProviderAuthentication
{
    /// <summary>The intended audience to receive authentication tokens for the service.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Azure Active Directory (tenant) that serves as the authentication authority to access the service. Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>Whether smart proxy is enabled.</summary>
    [JsonPropertyName("smartProxyEnabled")]
    public bool? SmartProxyEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusAtProviderCors
{
    /// <summary>A set of headers to be allowed via CORS.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>The methods to be allowed via CORS. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PATCH and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A set of origins to be allowed via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>If credentials are allowed via CORS.</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>The max age to be allowed via CORS.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusAtProviderIdentity
{
    /// <summary>A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Healthcare FHIR Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Healthcare FHIR Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are UserAssigned and SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusAtProviderOciArtifact
{
    /// <summary>A digest of an image within Azure container registry used for export operations of the service instance to narrow the artifacts down.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>An image within Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>An Azure container registry used for export operations of the service instance.</summary>
    [JsonPropertyName("loginServer")]
    public string? LoginServer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusAtProvider
{
    /// <summary>A list of the access policies of the service instance.</summary>
    [JsonPropertyName("accessPolicyObjectIds")]
    public IList<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1HealthcareFHIRServiceStatusAtProviderAuthentication? Authentication { get; set; }

    /// <summary>Specifies the name of the storage account which the operation configuration information is exported to.</summary>
    [JsonPropertyName("configurationExportStorageAccountName")]
    public string? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>A list of azure container registry settings used for convert data operation of the service instance.</summary>
    [JsonPropertyName("containerRegistryLoginServerUrl")]
    public IList<string>? ContainerRegistryLoginServerUrl { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1HealthcareFHIRServiceStatusAtProviderCors? Cors { get; set; }

    /// <summary>The ID of the Healthcare FHIR Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1HealthcareFHIRServiceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the kind of the Healthcare FHIR Service. Possible values are: fhir-Stu3 and fhir-R4. Defaults to fhir-R4. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare FHIR Service should be created. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of oci_artifact objects as defined below to describe OCI artifacts for export.</summary>
    [JsonPropertyName("ociArtifact")]
    public IList<V1beta1HealthcareFHIRServiceStatusAtProviderOciArtifact>? OciArtifact { get; set; }

    /// <summary>Whether public networks access is enabled.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies the name of the Resource Group in which to create the Healthcare FHIR Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare FHIR Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the id of the Healthcare Workspace where the Healthcare FHIR Service should exist. Changing this forces a new Healthcare FHIR Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatusConditions
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

/// <summary>HealthcareFHIRServiceStatus defines the observed state of HealthcareFHIRService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HealthcareFHIRServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HealthcareFHIRServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HealthcareFHIRServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HealthcareFHIRService is the Schema for the HealthcareFHIRServices API. Manages a Healthcare FHIR (Fast Healthcare Interoperability Resources) Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HealthcareFHIRService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HealthcareFHIRServiceSpec>, IStatus<V1beta1HealthcareFHIRServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareFHIRService";
    public const string KubeGroup = "healthcareapis.azure.m.upbound.io";
    public const string KubePluralName = "healthcarefhirservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthcareFHIRServiceSpec defines the desired state of HealthcareFHIRService</summary>
    [JsonPropertyName("spec")]
    public V1beta1HealthcareFHIRServiceSpec Spec { get; set; }

    /// <summary>HealthcareFHIRServiceStatus defines the observed state of HealthcareFHIRService.</summary>
    [JsonPropertyName("status")]
    public V1beta1HealthcareFHIRServiceStatus? Status { get; set; }
}