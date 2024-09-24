using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
public enum V1beta1CustomDomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderApiManagementIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderApiManagementIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderDeveloperPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderGatewayCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderGatewayCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderGateway
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderGatewayCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderGatewayCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn't specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderManagementCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderManagementCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderManagement
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderManagementCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderManagementCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderPortalCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderPortalCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderScmCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderScmCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecForProviderScm
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderScmCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderScmCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecForProvider
{
    /// <summary>The ID of the API Management service for which to configure Custom Domains. Changing this forces a new API Management Custom Domain resource to be created.</summary>
    [JsonPropertyName("apiManagementId")]
    public string? ApiManagementId { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementId.</summary>
    [JsonPropertyName("apiManagementIdRef")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRef? ApiManagementIdRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementId.</summary>
    [JsonPropertyName("apiManagementIdSelector")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelector? ApiManagementIdSelector { get; set; }

    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainSpecForProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainSpecForProviderGateway>? Gateway { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainSpecForProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainSpecForProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainSpecForProviderScm>? Scm { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderGateway
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn't specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderManagementCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderManagementCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderManagement
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderManagementCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderManagementCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderPortalCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderPortalCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderScmCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderScmCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProviderScm
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderScmCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderScmCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

public partial class V1beta1CustomDomainSpecInitProvider
{
    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainSpecInitProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainSpecInitProviderGateway>? Gateway { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainSpecInitProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainSpecInitProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainSpecInitProviderScm>? Scm { get; set; }
}

public enum V1beta1CustomDomainSpecManagementPoliciesEnum
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

public enum V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1CustomDomainSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1CustomDomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CustomDomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CustomDomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1CustomDomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1CustomDomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecDeletionPolicyEnum>))]
    public V1beta1CustomDomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CustomDomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CustomDomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CustomDomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomDomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CustomDomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomDomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProviderDeveloperPortal
{
    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProviderGateway
{
    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn't specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProviderManagement
{
    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProviderPortal
{
    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProviderScm
{
    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be should be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1CustomDomainStatusAtProvider
{
    /// <summary>The ID of the API Management service for which to configure Custom Domains. Changing this forces a new API Management Custom Domain resource to be created.</summary>
    [JsonPropertyName("apiManagementId")]
    public string? ApiManagementId { get; set; }

    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainStatusAtProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainStatusAtProviderGateway>? Gateway { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainStatusAtProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainStatusAtProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainStatusAtProviderScm>? Scm { get; set; }
}

public partial class V1beta1CustomDomainStatusConditions
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

public partial class V1beta1CustomDomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CustomDomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomDomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomDomainSpec>, IStatus<V1beta1CustomDomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomDomain";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "customdomains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomDomainSpec defines the desired state of CustomDomain</summary>
    [JsonPropertyName("spec")]
    public V1beta1CustomDomainSpec Spec { get; set; }

    /// <summary>CustomDomainStatus defines the observed state of CustomDomain.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomDomainStatus? Status { get; set; }
}