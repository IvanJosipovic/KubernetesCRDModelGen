using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
#nullable enable
/// <summary>FrontdoorCustomHTTPSConfiguration is the Schema for the FrontdoorCustomHTTPSConfigurations API. Manages the Custom Https Configuration for an Azure Front Door (classic) Frontend Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorCustomHTTPSConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorCustomHTTPSConfigurationList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FrontdoorCustomHTTPSConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
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
#nullable disable

#nullable enable
/// <summary>FrontdoorCustomHTTPSConfigurationSpec defines the desired state of FrontdoorCustomHTTPSConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomHTTPSConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorCustomHTTPSConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable
