using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef? AzureKeyVaultCertificateVaultIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdSelector")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector? AzureKeyVaultCertificateVaultIdSelector { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public IList<V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfiguration>? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef? AzureKeyVaultCertificateVaultIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdSelector")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector? AzureKeyVaultCertificateVaultIdSelector { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public IList<V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfiguration>? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecManagementPoliciesEnum
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
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FrontdoorCustomHTTPSConfigurationSpec defines the desired state of FrontdoorCustomHTTPSConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FrontdoorCustomHTTPSConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationStatusAtProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>Minimum client TLS version supported.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningSubstate")]
    public string? ProvisioningSubstate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationStatusAtProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public IList<V1beta1FrontdoorCustomHTTPSConfigurationStatusAtProviderCustomHttpsConfiguration>? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }

    /// <summary>The ID of the Azure Front Door Custom HTTPS Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationStatusConditions
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

/// <summary>FrontdoorCustomHTTPSConfigurationStatus defines the observed state of FrontdoorCustomHTTPSConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorCustomHTTPSConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorCustomHTTPSConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorCustomHTTPSConfiguration is the Schema for the FrontdoorCustomHTTPSConfigurations API. Manages the Custom Https Configuration for an Azure Front Door (classic) Frontend Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorCustomHTTPSConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorCustomHTTPSConfigurationSpec>, IStatus<V1beta1FrontdoorCustomHTTPSConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorCustomHTTPSConfiguration";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorcustomhttpsconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorCustomHTTPSConfigurationSpec defines the desired state of FrontdoorCustomHTTPSConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpec Spec { get; set; }

    /// <summary>FrontdoorCustomHTTPSConfigurationStatus defines the observed state of FrontdoorCustomHTTPSConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorCustomHTTPSConfigurationStatus? Status { get; set; }
}