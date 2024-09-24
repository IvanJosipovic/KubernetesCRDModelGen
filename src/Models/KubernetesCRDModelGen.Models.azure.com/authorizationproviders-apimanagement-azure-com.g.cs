using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpecOauth2GrantTypesAuthorizationCode
{
    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpecOauth2GrantTypesClientCredentials
{
    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2GrantTypes Authorization Provider oauth2 grant types settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpecOauth2GrantTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("authorizationCode")]
    public V1api20220801storageAuthorizationProviderSpecOauth2GrantTypesAuthorizationCode? AuthorizationCode { get; set; }

    /// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientCredentials")]
    public V1api20220801storageAuthorizationProviderSpecOauth2GrantTypesClientCredentials? ClientCredentials { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2Settings OAuth2 settings details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpecOauth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2GrantTypes Authorization Provider oauth2 grant types settings</summary>
    [JsonPropertyName("grantTypes")]
    public V1api20220801storageAuthorizationProviderSpecOauth2GrantTypes? GrantTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a apimanagement.azure.com/Service resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_AuthorizationProvider_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2Settings OAuth2 settings details</summary>
    [JsonPropertyName("oauth2")]
    public V1api20220801storageAuthorizationProviderSpecOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a apimanagement.azure.com/Service resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220801storageAuthorizationProviderSpecOwner Owner { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderStatusConditions
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

/// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2GrantTypes_STATUS Authorization Provider oauth2 grant types settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderStatusOauth2GrantTypes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationCode")]
    public IDictionary<string, string>? AuthorizationCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCredentials")]
    public IDictionary<string, string>? ClientCredentials { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2Settings_STATUS OAuth2 settings details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderStatusOauth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2GrantTypes_STATUS Authorization Provider oauth2 grant types settings</summary>
    [JsonPropertyName("grantTypes")]
    public V1api20220801storageAuthorizationProviderStatusOauth2GrantTypes? GrantTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_AuthorizationProvider_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageAuthorizationProviderStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220801storageAuthorizationProviderStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220801.AuthorizationProviderOAuth2Settings_STATUS OAuth2 settings details</summary>
    [JsonPropertyName("oauth2")]
    public V1api20220801storageAuthorizationProviderStatusOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthorizationProvider Generator information: - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/apimauthorizationproviders.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220801storageAuthorizationProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220801storageAuthorizationProviderSpec>, IStatus<V1api20220801storageAuthorizationProviderStatus>
{
    public const string KubeApiVersion = "v1api20220801storage";
    public const string KubeKind = "AuthorizationProvider";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "authorizationproviders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220801.Service_AuthorizationProvider_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220801storageAuthorizationProviderSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220801.Service_AuthorizationProvider_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220801storageAuthorizationProviderStatus? Status { get; set; }
}