using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementSpecForProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The password for the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderCertificateCertificatePasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderCertificateEncodedCertificateSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderCertificate
{
    /// <summary>The password for the certificate.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1ManagementSpecForProviderCertificateCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
    [JsonPropertyName("encodedCertificateSecretRef")]
    public V1beta1ManagementSpecForProviderCertificateEncodedCertificateSecretRef? EncodedCertificateSecretRef { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderDelegationValidationKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }

    /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
    [JsonPropertyName("validationKeySecretRef")]
    public V1beta1ManagementSpecForProviderDelegationValidationKeySecretRef? ValidationKeySecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderProtocols
{
    /// <summary></summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1ManagementSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1ManagementSpecForProviderResourceGroupNameSelector
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
    public V1beta1ManagementSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta1ManagementSpecForProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecForProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta1ManagementSpecForProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagementSpecForProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta1ManagementSpecForProviderDelegation? Delegation { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta1ManagementSpecForProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ManagementSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ManagementSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagementSpecForProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ManagementSpecForProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta1ManagementSpecForProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, Standard and Premium. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta1ManagementSpecForProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementSpecForProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The password for the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderCertificateCertificatePasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderCertificateEncodedCertificateSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderCertificate
{
    /// <summary>The password for the certificate.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1ManagementSpecInitProviderCertificateCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
    [JsonPropertyName("encodedCertificateSecretRef")]
    public V1beta1ManagementSpecInitProviderCertificateEncodedCertificateSecretRef EncodedCertificateSecretRef { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderDelegationValidationKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }

    /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
    [JsonPropertyName("validationKeySecretRef")]
    public V1beta1ManagementSpecInitProviderDelegationValidationKeySecretRef? ValidationKeySecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderProtocols
{
    /// <summary></summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta1ManagementSpecInitProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecInitProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta1ManagementSpecInitProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagementSpecInitProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta1ManagementSpecInitProviderDelegation? Delegation { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta1ManagementSpecInitProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagementSpecInitProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ManagementSpecInitProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta1ManagementSpecInitProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, Standard and Premium. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta1ManagementSpecInitProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementSpecInitProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpecProviderConfigRef
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
public partial class V1beta1ManagementSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ManagementSpec defines the desired state of Management</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagementSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagementSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagementSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagementSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The URL of the Regional Gateway for the API Management Service in the specified region.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Private IP addresses of the API Management Service. Available only when the API Manager instance is using Virtual Network mode.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard and Premium SKU.</summary>
    [JsonPropertyName("publicIpAddresses")]
    public IList<string>? PublicIpAddresses { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementStatusAtProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderCertificate
{
    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfigurationDeveloperPortal
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfigurationManagement
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfigurationPortal
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfigurationProxy
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn't specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfigurationScm
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A hostname_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderHostnameConfiguration
{
    /// <summary>One or more developer_portal blocks as documented below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1ManagementStatusAtProviderHostnameConfigurationDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more management blocks as documented below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1ManagementStatusAtProviderHostnameConfigurationManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as documented below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1ManagementStatusAtProviderHostnameConfigurationPortal>? Portal { get; set; }

    /// <summary>One or more proxy blocks as documented below.</summary>
    [JsonPropertyName("proxy")]
    public IList<V1beta1ManagementStatusAtProviderHostnameConfigurationProxy>? Proxy { get; set; }

    /// <summary>One or more scm blocks as documented below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1ManagementStatusAtProviderHostnameConfigurationScm>? Scm { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderProtocols
{
    /// <summary></summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta1ManagementStatusAtProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The identifier for the tenant access information contract.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusAtProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta1ManagementStatusAtProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagementStatusAtProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta1ManagementStatusAtProviderDelegation? Delegation { get; set; }

    /// <summary>The URL for the Developer Portal associated with this API Management service.</summary>
    [JsonPropertyName("developerPortalUrl")]
    public string? DeveloperPortalUrl { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The Region URL for the Gateway of the API Management Service.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>The URL of the Gateway for the API Management Service.</summary>
    [JsonPropertyName("gatewayUrl")]
    public string? GatewayUrl { get; set; }

    /// <summary>A hostname_configuration block as defined below.</summary>
    [JsonPropertyName("hostnameConfiguration")]
    public V1beta1ManagementStatusAtProviderHostnameConfiguration? HostnameConfiguration { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The URL for the Management API associated with this API Management service.</summary>
    [JsonPropertyName("managementApiUrl")]
    public string? ManagementApiUrl { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>The URL for the Publisher Portal associated with this API Management service.</summary>
    [JsonPropertyName("portalUrl")]
    public string? PortalUrl { get; set; }

    /// <summary>The Private IP addresses of the API Management Service.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta1ManagementStatusAtProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>The Public IP addresses of the API Management Service.</summary>
    [JsonPropertyName("publicIpAddresses")]
    public IList<string>? PublicIpAddresses { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The URL for the SCM (Source Code Management) Endpoint associated with this API Management service.</summary>
    [JsonPropertyName("scmUrl")]
    public string? ScmUrl { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagementStatusAtProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1ManagementStatusAtProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta1ManagementStatusAtProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, Standard and Premium. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta1ManagementStatusAtProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ManagementStatusAtProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatusConditions
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

/// <summary>ManagementStatus defines the observed state of Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagementStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagementStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Management is the Schema for the Managements API. Manages an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Management : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagementSpec>, IStatus<V1beta1ManagementStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Management";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "managements";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementSpec defines the desired state of Management</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagementSpec Spec { get; set; }

    /// <summary>ManagementStatus defines the observed state of Management.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagementStatus? Status { get; set; }
}

/// <summary>Management is the Schema for the Managements API. Manages an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagementList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Management>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagementList";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "managements";
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
    public IList<V1beta1Management> Items { get; set; }
}