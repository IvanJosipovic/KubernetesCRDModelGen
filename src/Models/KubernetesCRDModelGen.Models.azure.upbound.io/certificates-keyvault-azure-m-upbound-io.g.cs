using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyvault.azure.m.upbound.io;
/// <summary>Certificate is the Schema for the Certificates API. Manages a Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Certificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "keyvault.azure.m.upbound.io";
    public const string KubePluralName = "certificates";
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
    public IList<V1beta1Certificate> Items { get; set; }
}

/// <summary>The base64-encoded certificate contents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificateContentsSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The password associated with the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificate
{
    /// <summary>The base64-encoded certificate contents.</summary>
    [JsonPropertyName("contentsSecretRef")]
    public V1beta1CertificateSpecForProviderCertificateContentsSecretRef? ContentsSecretRef { get; set; }

    /// <summary>The password associated with the certificate.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1CertificateSpecForProviderCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>A issuer_parameters block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyIssuerParameters
{
    /// <summary>The name of the Certificate Issuer. Possible values include Self (for self-signed certificate), or Unknown (for a certificate issuing authority like Let's Encrypt and Azure direct supported ones).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A key_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyKeyProperties
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>Is this certificate exportable?</summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>The size of the key used in the certificate. Possible values include 2048, 3072, and 4096 for RSA keys, or 256, 384, and 521 for EC keys. This property is required when using RSA keys.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the type of key. Possible values are EC, EC-HSM, RSA, RSA-HSM and oct.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Is the key reusable?</summary>
    [JsonPropertyName("reuseKey")]
    public bool? ReuseKey { get; set; }
}

/// <summary>A action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyLifetimeActionAction
{
    /// <summary>The Type of action to be performed when the lifetime trigger is triggerec. Possible values include AutoRenew and EmailContacts.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyLifetimeActionTrigger
{
    /// <summary>The number of days before the Certificate expires that the action associated with this Trigger should run. Conflicts with lifetime_percentage.</summary>
    [JsonPropertyName("daysBeforeExpiry")]
    public double? DaysBeforeExpiry { get; set; }

    /// <summary>The percentage at which during the Certificates Lifetime the action associated with this Trigger should run. Conflicts with days_before_expiry.</summary>
    [JsonPropertyName("lifetimePercentage")]
    public double? LifetimePercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyLifetimeAction
{
    /// <summary>A action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1CertificateSpecForProviderCertificatePolicyLifetimeActionAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1CertificateSpecForProviderCertificatePolicyLifetimeActionTrigger? Trigger { get; set; }
}

/// <summary>A secret_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicySecretProperties
{
    /// <summary>The Content-Type of the Certificate, such as application/x-pkcs12 for a PFX or application/x-pem-file for a PEM.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
}

/// <summary>A subject_alternative_names block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
{
    /// <summary>A list of alternative DNS names (FQDNs) identified by the Certificate.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>A list of email addresses identified by this Certificate.</summary>
    [JsonPropertyName("emails")]
    public IList<string>? Emails { get; set; }

    /// <summary>A list of User Principal Names identified by the Certificate.</summary>
    [JsonPropertyName("upns")]
    public IList<string>? Upns { get; set; }
}

/// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicyX509CertificateProperties
{
    /// <summary>A list of Extended/Enhanced Key Usages.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<string>? ExtendedKeyUsage { get; set; }

    /// <summary>A list of uses associated with this Key. Possible values include cRLSign, dataEncipherment, decipherOnly, digitalSignature, encipherOnly, keyAgreement, keyCertSign, keyEncipherment and nonRepudiation and are case-sensitive.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>The Certificate's Subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>A subject_alternative_names block as defined below.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta1CertificateSpecForProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>The Certificates Validity Period in Months.</summary>
    [JsonPropertyName("validityInMonths")]
    public double? ValidityInMonths { get; set; }
}

/// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificatePolicy
{
    /// <summary>A issuer_parameters block as defined below.</summary>
    [JsonPropertyName("issuerParameters")]
    public V1beta1CertificateSpecForProviderCertificatePolicyIssuerParameters? IssuerParameters { get; set; }

    /// <summary>A key_properties block as defined below.</summary>
    [JsonPropertyName("keyProperties")]
    public V1beta1CertificateSpecForProviderCertificatePolicyKeyProperties? KeyProperties { get; set; }

    /// <summary>A lifetime_action block as defined below.</summary>
    [JsonPropertyName("lifetimeAction")]
    public IList<V1beta1CertificateSpecForProviderCertificatePolicyLifetimeAction>? LifetimeAction { get; set; }

    /// <summary>A secret_properties block as defined below.</summary>
    [JsonPropertyName("secretProperties")]
    public V1beta1CertificateSpecForProviderCertificatePolicySecretProperties? SecretProperties { get; set; }

    /// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
    [JsonPropertyName("x509CertificateProperties")]
    public V1beta1CertificateSpecForProviderCertificatePolicyX509CertificateProperties? X509CertificateProperties { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderKeyVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderKeyVaultIdSelector
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
    public V1beta1CertificateSpecForProviderKeyVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProvider
{
    /// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta1CertificateSpecForProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificatePolicy")]
    public V1beta1CertificateSpecForProviderCertificatePolicy? CertificatePolicy { get; set; }

    /// <summary>The ID of the Key Vault where the Certificate should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CertificateSpecForProviderKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CertificateSpecForProviderKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>The base64-encoded certificate contents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificateContentsSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The password associated with the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificate
{
    /// <summary>The base64-encoded certificate contents.</summary>
    [JsonPropertyName("contentsSecretRef")]
    public V1beta1CertificateSpecInitProviderCertificateContentsSecretRef ContentsSecretRef { get; set; }

    /// <summary>The password associated with the certificate.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1CertificateSpecInitProviderCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>A issuer_parameters block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyIssuerParameters
{
    /// <summary>The name of the Certificate Issuer. Possible values include Self (for self-signed certificate), or Unknown (for a certificate issuing authority like Let's Encrypt and Azure direct supported ones).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A key_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyKeyProperties
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>Is this certificate exportable?</summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>The size of the key used in the certificate. Possible values include 2048, 3072, and 4096 for RSA keys, or 256, 384, and 521 for EC keys. This property is required when using RSA keys.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the type of key. Possible values are EC, EC-HSM, RSA, RSA-HSM and oct.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Is the key reusable?</summary>
    [JsonPropertyName("reuseKey")]
    public bool? ReuseKey { get; set; }
}

/// <summary>A action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeActionAction
{
    /// <summary>The Type of action to be performed when the lifetime trigger is triggerec. Possible values include AutoRenew and EmailContacts.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeActionTrigger
{
    /// <summary>The number of days before the Certificate expires that the action associated with this Trigger should run. Conflicts with lifetime_percentage.</summary>
    [JsonPropertyName("daysBeforeExpiry")]
    public double? DaysBeforeExpiry { get; set; }

    /// <summary>The percentage at which during the Certificates Lifetime the action associated with this Trigger should run. Conflicts with days_before_expiry.</summary>
    [JsonPropertyName("lifetimePercentage")]
    public double? LifetimePercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeAction
{
    /// <summary>A action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeActionAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeActionTrigger? Trigger { get; set; }
}

/// <summary>A secret_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicySecretProperties
{
    /// <summary>The Content-Type of the Certificate, such as application/x-pkcs12 for a PFX or application/x-pem-file for a PEM.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
}

/// <summary>A subject_alternative_names block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
{
    /// <summary>A list of alternative DNS names (FQDNs) identified by the Certificate.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>A list of email addresses identified by this Certificate.</summary>
    [JsonPropertyName("emails")]
    public IList<string>? Emails { get; set; }

    /// <summary>A list of User Principal Names identified by the Certificate.</summary>
    [JsonPropertyName("upns")]
    public IList<string>? Upns { get; set; }
}

/// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicyX509CertificateProperties
{
    /// <summary>A list of Extended/Enhanced Key Usages.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<string>? ExtendedKeyUsage { get; set; }

    /// <summary>A list of uses associated with this Key. Possible values include cRLSign, dataEncipherment, decipherOnly, digitalSignature, encipherOnly, keyAgreement, keyCertSign, keyEncipherment and nonRepudiation and are case-sensitive.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>The Certificate's Subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>A subject_alternative_names block as defined below.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>The Certificates Validity Period in Months.</summary>
    [JsonPropertyName("validityInMonths")]
    public double? ValidityInMonths { get; set; }
}

/// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificatePolicy
{
    /// <summary>A issuer_parameters block as defined below.</summary>
    [JsonPropertyName("issuerParameters")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyIssuerParameters? IssuerParameters { get; set; }

    /// <summary>A key_properties block as defined below.</summary>
    [JsonPropertyName("keyProperties")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyKeyProperties? KeyProperties { get; set; }

    /// <summary>A lifetime_action block as defined below.</summary>
    [JsonPropertyName("lifetimeAction")]
    public IList<V1beta1CertificateSpecInitProviderCertificatePolicyLifetimeAction>? LifetimeAction { get; set; }

    /// <summary>A secret_properties block as defined below.</summary>
    [JsonPropertyName("secretProperties")]
    public V1beta1CertificateSpecInitProviderCertificatePolicySecretProperties? SecretProperties { get; set; }

    /// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
    [JsonPropertyName("x509CertificateProperties")]
    public V1beta1CertificateSpecInitProviderCertificatePolicyX509CertificateProperties? X509CertificateProperties { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderKeyVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderKeyVaultIdSelector
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
    public V1beta1CertificateSpecInitProviderKeyVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProvider
{
    /// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta1CertificateSpecInitProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificatePolicy")]
    public V1beta1CertificateSpecInitProviderCertificatePolicy? CertificatePolicy { get; set; }

    /// <summary>The ID of the Key Vault where the Certificate should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1CertificateSpecInitProviderKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1CertificateSpecInitProviderKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecProviderConfigRef
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
public partial class V1beta1CertificateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>CertificateSpec defines the desired state of Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CertificateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CertificateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CertificateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CertificateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The base64-encoded certificate contents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificateContentsSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The password associated with the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificate
{
    /// <summary>The base64-encoded certificate contents.</summary>
    [JsonPropertyName("contentsSecretRef")]
    public V1beta1CertificateStatusAtProviderCertificateContentsSecretRef? ContentsSecretRef { get; set; }

    /// <summary>The password associated with the certificate.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1CertificateStatusAtProviderCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificateAttribute
{
    /// <summary>The create time of the Key Vault Certificate.</summary>
    [JsonPropertyName("created")]
    public string? Created { get; set; }

    /// <summary>whether the Key Vault Certificate is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The expires time of the Key Vault Certificate.</summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>The not before valid time of the Key Vault Certificate.</summary>
    [JsonPropertyName("notBefore")]
    public string? NotBefore { get; set; }

    /// <summary>The deletion recovery level of the Key Vault Certificate.</summary>
    [JsonPropertyName("recoveryLevel")]
    public string? RecoveryLevel { get; set; }

    /// <summary>The recent update time of the Key Vault Certificate.</summary>
    [JsonPropertyName("updated")]
    public string? Updated { get; set; }
}

/// <summary>A issuer_parameters block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyIssuerParameters
{
    /// <summary>The name of the Certificate Issuer. Possible values include Self (for self-signed certificate), or Unknown (for a certificate issuing authority like Let's Encrypt and Azure direct supported ones).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A key_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyKeyProperties
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>Is this certificate exportable?</summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>The size of the key used in the certificate. Possible values include 2048, 3072, and 4096 for RSA keys, or 256, 384, and 521 for EC keys. This property is required when using RSA keys.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the type of key. Possible values are EC, EC-HSM, RSA, RSA-HSM and oct.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Is the key reusable?</summary>
    [JsonPropertyName("reuseKey")]
    public bool? ReuseKey { get; set; }
}

/// <summary>A action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeActionAction
{
    /// <summary>The Type of action to be performed when the lifetime trigger is triggerec. Possible values include AutoRenew and EmailContacts.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeActionTrigger
{
    /// <summary>The number of days before the Certificate expires that the action associated with this Trigger should run. Conflicts with lifetime_percentage.</summary>
    [JsonPropertyName("daysBeforeExpiry")]
    public double? DaysBeforeExpiry { get; set; }

    /// <summary>The percentage at which during the Certificates Lifetime the action associated with this Trigger should run. Conflicts with days_before_expiry.</summary>
    [JsonPropertyName("lifetimePercentage")]
    public double? LifetimePercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeAction
{
    /// <summary>A action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeActionAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeActionTrigger? Trigger { get; set; }
}

/// <summary>A secret_properties block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicySecretProperties
{
    /// <summary>The Content-Type of the Certificate, such as application/x-pkcs12 for a PFX or application/x-pem-file for a PEM.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
}

/// <summary>A subject_alternative_names block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
{
    /// <summary>A list of alternative DNS names (FQDNs) identified by the Certificate.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>A list of email addresses identified by this Certificate.</summary>
    [JsonPropertyName("emails")]
    public IList<string>? Emails { get; set; }

    /// <summary>A list of User Principal Names identified by the Certificate.</summary>
    [JsonPropertyName("upns")]
    public IList<string>? Upns { get; set; }
}

/// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicyX509CertificateProperties
{
    /// <summary>A list of Extended/Enhanced Key Usages.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<string>? ExtendedKeyUsage { get; set; }

    /// <summary>A list of uses associated with this Key. Possible values include cRLSign, dataEncipherment, decipherOnly, digitalSignature, encipherOnly, keyAgreement, keyCertSign, keyEncipherment and nonRepudiation and are case-sensitive.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>The Certificate's Subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>A subject_alternative_names block as defined below.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>The Certificates Validity Period in Months.</summary>
    [JsonPropertyName("validityInMonths")]
    public double? ValidityInMonths { get; set; }
}

/// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderCertificatePolicy
{
    /// <summary>A issuer_parameters block as defined below.</summary>
    [JsonPropertyName("issuerParameters")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyIssuerParameters? IssuerParameters { get; set; }

    /// <summary>A key_properties block as defined below.</summary>
    [JsonPropertyName("keyProperties")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyKeyProperties? KeyProperties { get; set; }

    /// <summary>A lifetime_action block as defined below.</summary>
    [JsonPropertyName("lifetimeAction")]
    public IList<V1beta1CertificateStatusAtProviderCertificatePolicyLifetimeAction>? LifetimeAction { get; set; }

    /// <summary>A secret_properties block as defined below.</summary>
    [JsonPropertyName("secretProperties")]
    public V1beta1CertificateStatusAtProviderCertificatePolicySecretProperties? SecretProperties { get; set; }

    /// <summary>A x509_certificate_properties block as defined below. Required when certificate block is not specified.</summary>
    [JsonPropertyName("x509CertificateProperties")]
    public V1beta1CertificateStatusAtProviderCertificatePolicyX509CertificateProperties? X509CertificateProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProvider
{
    /// <summary>A certificate block as defined below, used to Import an existing certificate. Changing this will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta1CertificateStatusAtProviderCertificate? Certificate { get; set; }

    /// <summary>A certificate_attribute block as defined below.</summary>
    [JsonPropertyName("certificateAttribute")]
    public IList<V1beta1CertificateStatusAtProviderCertificateAttribute>? CertificateAttribute { get; set; }

    /// <summary>The raw Key Vault Certificate data represented as a hexadecimal string.</summary>
    [JsonPropertyName("certificateData")]
    public string? CertificateData { get; set; }

    /// <summary>The Base64 encoded Key Vault Certificate data.</summary>
    [JsonPropertyName("certificateDataBase64")]
    public string? CertificateDataBase64 { get; set; }

    /// <summary>A certificate_policy block as defined below. Changing this (except the lifetime_action field) will create a new version of the Key Vault Certificate.</summary>
    [JsonPropertyName("certificatePolicy")]
    public V1beta1CertificateStatusAtProviderCertificatePolicy? CertificatePolicy { get; set; }

    /// <summary>The Key Vault Certificate ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Key Vault where the Certificate should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The (Versioned) ID for this Key Vault Certificate. This property points to a specific version of a Key Vault Certificate, as such using this won't auto-rotate values if used in other Azure Services.</summary>
    [JsonPropertyName("resourceManagerId")]
    public string? ResourceManagerId { get; set; }

    /// <summary>The Versionless ID of the Key Vault Certificate. This property allows other Azure Services (that support it) to auto-rotate their value when the Key Vault Certificate is updated.</summary>
    [JsonPropertyName("resourceManagerVersionlessId")]
    public string? ResourceManagerVersionlessId { get; set; }

    /// <summary>The ID of the associated Key Vault Secret.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The X509 Thumbprint of the Key Vault Certificate represented as a hexadecimal string.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The current version of the Key Vault Certificate.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Base ID of the Key Vault Certificate.</summary>
    [JsonPropertyName("versionlessId")]
    public string? VersionlessId { get; set; }

    /// <summary>The Base ID of the Key Vault Secret.</summary>
    [JsonPropertyName("versionlessSecretId")]
    public string? VersionlessSecretId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusConditions
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

/// <summary>CertificateStatus defines the observed state of Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CertificateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Certificate is the Schema for the Certificates API. Manages a Key Vault Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateSpec>, IStatus<V1beta1CertificateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "keyvault.azure.m.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateSpec defines the desired state of Certificate</summary>
    [JsonPropertyName("spec")]
    public V1beta1CertificateSpec Spec { get; set; }

    /// <summary>CertificateStatus defines the observed state of Certificate.</summary>
    [JsonPropertyName("status")]
    public V1beta1CertificateStatus? Status { get; set; }
}