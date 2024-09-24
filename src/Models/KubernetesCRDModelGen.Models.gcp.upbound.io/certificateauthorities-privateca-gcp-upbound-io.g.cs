using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfig
{
    /// <summary>Contains distinguished name fields such as the location and organization. Structure is documented below.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfigSubject>? Subject { get; set; }

    /// <summary>The subject alternative name fields. Structure is documented below.</summary>
    [JsonPropertyName("subjectAltName")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfigSubjectAltName>? SubjectAltName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexidecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. Setting the value to 0 requires setting zero_max_issuer_path_length = true.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. If both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as "non-repudiation".</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as "TLS WWW client authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as "Signing of downloadable executable code client authentication".</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as "Email protection".</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as "Signing OCSP responses".</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as "TLS WWW server authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as "Binding the hash of an object to a time".</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Contains excluded DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>Contains the excluded email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>Contains the excluded IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>Contains the excluded URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>Contains permitted DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>Contains the permitted email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>Contains the permitted IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>Contains the permitted URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfigX509Config
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderConfig
{
    /// <summary>Specifies some of the values in a certificate that are related to the subject. Structure is documented below.</summary>
    [JsonPropertyName("subjectConfig")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigSubjectConfig>? SubjectConfig { get; set; }

    /// <summary>When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2.. Structure is documented below.</summary>
    [JsonPropertyName("subjectKeyId")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigSubjectKeyId>? SubjectKeyId { get; set; }

    /// <summary>Describes how some of the technical X.509 fields in a certificate should be populated. Structure is documented below.</summary>
    [JsonPropertyName("x509Config")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfigX509Config>? X509Config { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderKeySpec
{
    /// <summary>The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All managed keys will be have their ProtectionLevel as HSM. Possible values are: SIGN_HASH_ALGORITHM_UNSPECIFIED, RSA_PSS_2048_SHA256, RSA_PSS_3072_SHA256, RSA_PSS_4096_SHA256, RSA_PKCS1_2048_SHA256, RSA_PKCS1_3072_SHA256, RSA_PKCS1_4096_SHA256, EC_P256_SHA256, EC_P384_SHA384.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The resource name for an existing Cloud KMS CryptoKeyVersion in the format projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*.</summary>
    [JsonPropertyName("cloudKmsKeyVersion")]
    public string? CloudKmsKeyVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecForProviderPoolRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CAPool in privateca to populate pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecForProviderPoolRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CAPool in privateca to populate pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderPoolSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecForProviderPoolSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfigPemIssuerChain
{
    /// <summary>Expected to be in leaf-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificates")]
    public IList<string>? PemCertificates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderSubordinateConfig
{
    /// <summary>This can refer to a CertificateAuthority that was used to create a subordinate CertificateAuthority. This field is used for information and usability purposes only. The resource name is in the format projects/*/locations/*/caPools/*/certificateAuthorities/*.</summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthoritySelector")]
    public V1beta1CertificateAuthoritySpecForProviderSubordinateConfigCertificateAuthoritySelector? CertificateAuthoritySelector { get; set; }

    /// <summary>Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem certificate for this CA itself. Structure is documented below.</summary>
    [JsonPropertyName("pemIssuerChain")]
    public IList<V1beta1CertificateAuthoritySpecForProviderSubordinateConfigPemIssuerChain>? PemIssuerChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProvider
{
    /// <summary>The config used to create a self-signed X.509 certificate or CSR. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1CertificateAuthoritySpecForProviderConfig>? Config { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Desired state of the CertificateAuthority. Set this field to STAGED to create a STAGED root CA.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as gs://) or suffixes (such as .googleapis.com). For example, to use a bucket named my-bucket, you would simply specify my-bucket. If not specified, a managed bucket will be created.</summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs. Use with care. Defaults to false.</summary>
    [JsonPropertyName("ignoreActiveCertificatesOnDeletion")]
    public bool? IgnoreActiveCertificatesOnDeletion { get; set; }

    /// <summary>Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR. Structure is documented below.</summary>
    [JsonPropertyName("keySpec")]
    public IList<V1beta1CertificateAuthoritySpecForProviderKeySpec>? KeySpec { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The desired lifetime of the CA certificate. Used to create the "notBeforeTime" and "notAfterTime" fields inside an X.509 certificate. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>Location of the CertificateAuthority. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The signed CA certificate issued from the subordinated CA's CSR. This is needed when activating the subordiante CA with a third party issuer.</summary>
    [JsonPropertyName("pemCaCertificate")]
    public string? PemCaCertificate { get; set; }

    /// <summary>The name of the CaPool this Certificate Authority belongs to.</summary>
    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    /// <summary>Reference to a CAPool in privateca to populate pool.</summary>
    [JsonPropertyName("poolRef")]
    public V1beta1CertificateAuthoritySpecForProviderPoolRef? PoolRef { get; set; }

    /// <summary>Selector for a CAPool in privateca to populate pool.</summary>
    [JsonPropertyName("poolSelector")]
    public V1beta1CertificateAuthoritySpecForProviderPoolSelector? PoolSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If this flag is set, the Certificate Authority will be deleted as soon as possible without a 30-day grace period where undeletion would have been allowed. If you proceed, there will be no way to recover this CA. Use with care. Defaults to false.</summary>
    [JsonPropertyName("skipGracePeriod")]
    public bool? SkipGracePeriod { get; set; }

    /// <summary>If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. Structure is documented below.</summary>
    [JsonPropertyName("subordinateConfig")]
    public IList<V1beta1CertificateAuthoritySpecForProviderSubordinateConfig>? SubordinateConfig { get; set; }

    /// <summary>The Type of this CertificateAuthority. ~&gt; Note: For SUBORDINATE Certificate Authorities, they need to be activated before they can issue certificates. Default value is SELF_SIGNED. Possible values are: SELF_SIGNED, SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfig
{
    /// <summary>Contains distinguished name fields such as the location and organization. Structure is documented below.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfigSubject>? Subject { get; set; }

    /// <summary>The subject alternative name fields. Structure is documented below.</summary>
    [JsonPropertyName("subjectAltName")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfigSubjectAltName>? SubjectAltName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexidecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. Setting the value to 0 requires setting zero_max_issuer_path_length = true.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. If both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as "non-repudiation".</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as "TLS WWW client authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as "Signing of downloadable executable code client authentication".</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as "Email protection".</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as "Signing OCSP responses".</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as "TLS WWW server authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as "Binding the hash of an object to a time".</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Contains excluded DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>Contains the excluded email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>Contains the excluded IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>Contains the excluded URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>Contains permitted DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>Contains the permitted email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>Contains the permitted IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>Contains the permitted URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfigX509Config
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderConfig
{
    /// <summary>Specifies some of the values in a certificate that are related to the subject. Structure is documented below.</summary>
    [JsonPropertyName("subjectConfig")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigSubjectConfig>? SubjectConfig { get; set; }

    /// <summary>When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2.. Structure is documented below.</summary>
    [JsonPropertyName("subjectKeyId")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigSubjectKeyId>? SubjectKeyId { get; set; }

    /// <summary>Describes how some of the technical X.509 fields in a certificate should be populated. Structure is documented below.</summary>
    [JsonPropertyName("x509Config")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfigX509Config>? X509Config { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderKeySpec
{
    /// <summary>The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All managed keys will be have their ProtectionLevel as HSM. Possible values are: SIGN_HASH_ALGORITHM_UNSPECIFIED, RSA_PSS_2048_SHA256, RSA_PSS_3072_SHA256, RSA_PSS_4096_SHA256, RSA_PKCS1_2048_SHA256, RSA_PKCS1_3072_SHA256, RSA_PKCS1_4096_SHA256, EC_P256_SHA256, EC_P384_SHA384.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The resource name for an existing Cloud KMS CryptoKeyVersion in the format projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*.</summary>
    [JsonPropertyName("cloudKmsKeyVersion")]
    public string? CloudKmsKeyVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigPemIssuerChain
{
    /// <summary>Expected to be in leaf-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificates")]
    public IList<string>? PemCertificates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderSubordinateConfig
{
    /// <summary>This can refer to a CertificateAuthority that was used to create a subordinate CertificateAuthority. This field is used for information and usability purposes only. The resource name is in the format projects/*/locations/*/caPools/*/certificateAuthorities/*.</summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthoritySelector")]
    public V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigCertificateAuthoritySelector? CertificateAuthoritySelector { get; set; }

    /// <summary>Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem certificate for this CA itself. Structure is documented below.</summary>
    [JsonPropertyName("pemIssuerChain")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfigPemIssuerChain>? PemIssuerChain { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProvider
{
    /// <summary>The config used to create a self-signed X.509 certificate or CSR. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderConfig>? Config { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Desired state of the CertificateAuthority. Set this field to STAGED to create a STAGED root CA.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as gs://) or suffixes (such as .googleapis.com). For example, to use a bucket named my-bucket, you would simply specify my-bucket. If not specified, a managed bucket will be created.</summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs. Use with care. Defaults to false.</summary>
    [JsonPropertyName("ignoreActiveCertificatesOnDeletion")]
    public bool? IgnoreActiveCertificatesOnDeletion { get; set; }

    /// <summary>Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR. Structure is documented below.</summary>
    [JsonPropertyName("keySpec")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderKeySpec>? KeySpec { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The desired lifetime of the CA certificate. Used to create the "notBeforeTime" and "notAfterTime" fields inside an X.509 certificate. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>The signed CA certificate issued from the subordinated CA's CSR. This is needed when activating the subordiante CA with a third party issuer.</summary>
    [JsonPropertyName("pemCaCertificate")]
    public string? PemCaCertificate { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If this flag is set, the Certificate Authority will be deleted as soon as possible without a 30-day grace period where undeletion would have been allowed. If you proceed, there will be no way to recover this CA. Use with care. Defaults to false.</summary>
    [JsonPropertyName("skipGracePeriod")]
    public bool? SkipGracePeriod { get; set; }

    /// <summary>If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. Structure is documented below.</summary>
    [JsonPropertyName("subordinateConfig")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderSubordinateConfig>? SubordinateConfig { get; set; }

    /// <summary>The Type of this CertificateAuthority. ~&gt; Note: For SUBORDINATE Certificate Authorities, they need to be activated before they can issue certificates. Default value is SELF_SIGNED. Possible values are: SELF_SIGNED, SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecManagementPoliciesEnum
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
public enum V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CertificateAuthoritySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CertificateAuthoritySpec defines the desired state of CertificateAuthority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateAuthoritySpecDeletionPolicyEnum>))]
    public V1beta1CertificateAuthoritySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CertificateAuthoritySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CertificateAuthoritySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CertificateAuthoritySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CertificateAuthoritySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CertificateAuthoritySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CertificateAuthoritySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderAccessUrls
{
    /// <summary>(Output) The URL where this CertificateAuthority's CA certificate is published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("caCertificateAccessUrl")]
    public string? CaCertificateAccessUrl { get; set; }

    /// <summary>(Output) The URL where this CertificateAuthority's CRLs are published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("crlAccessUrls")]
    public IList<string>? CrlAccessUrls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfig
{
    /// <summary>Contains distinguished name fields such as the location and organization. Structure is documented below.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfigSubject>? Subject { get; set; }

    /// <summary>The subject alternative name fields. Structure is documented below.</summary>
    [JsonPropertyName("subjectAltName")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfigSubjectAltName>? SubjectAltName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexidecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. Setting the value to 0 requires setting zero_max_issuer_path_length = true.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. If both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as "non-repudiation".</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as "TLS WWW client authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as "Signing of downloadable executable code client authentication".</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as "Email protection".</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as "Signing OCSP responses".</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as "TLS WWW server authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as "Binding the hash of an object to a time".</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Contains excluded DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>Contains the excluded email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>Contains the excluded IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>Contains the excluded URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>Contains permitted DNS names. Any DNS name that can be constructed by simply adding zero or more labels to the left-hand side of the name satisfies the name constraint. For example, example.com, www.example.com, www.sub.example.com would satisfy example.com while example1.com does not.</summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>Contains the permitted email addresses. The value can be a particular email address, a hostname to indicate all email addresses on that host or a domain with a leading period (e.g. .example.com) to indicate all email addresses in that domain.</summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>Contains the permitted IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.</summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>Contains the permitted URIs that apply to the host part of the name. The value can be a hostname or a domain with a leading period (like .example.com)</summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfigX509Config
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderConfig
{
    /// <summary>Specifies some of the values in a certificate that are related to the subject. Structure is documented below.</summary>
    [JsonPropertyName("subjectConfig")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigSubjectConfig>? SubjectConfig { get; set; }

    /// <summary>When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2.. Structure is documented below.</summary>
    [JsonPropertyName("subjectKeyId")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigSubjectKeyId>? SubjectKeyId { get; set; }

    /// <summary>Describes how some of the technical X.509 fields in a certificate should be populated. Structure is documented below.</summary>
    [JsonPropertyName("x509Config")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfigX509Config>? X509Config { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderKeySpec
{
    /// <summary>The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All managed keys will be have their ProtectionLevel as HSM. Possible values are: SIGN_HASH_ALGORITHM_UNSPECIFIED, RSA_PSS_2048_SHA256, RSA_PSS_3072_SHA256, RSA_PSS_4096_SHA256, RSA_PKCS1_2048_SHA256, RSA_PKCS1_3072_SHA256, RSA_PKCS1_4096_SHA256, EC_P256_SHA256, EC_P384_SHA384.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The resource name for an existing Cloud KMS CryptoKeyVersion in the format projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*.</summary>
    [JsonPropertyName("cloudKmsKeyVersion")]
    public string? CloudKmsKeyVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderSubordinateConfigPemIssuerChain
{
    /// <summary>Expected to be in leaf-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificates")]
    public IList<string>? PemCertificates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderSubordinateConfig
{
    /// <summary>This can refer to a CertificateAuthority that was used to create a subordinate CertificateAuthority. This field is used for information and usability purposes only. The resource name is in the format projects/*/locations/*/caPools/*/certificateAuthorities/*.</summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem certificate for this CA itself. Structure is documented below.</summary>
    [JsonPropertyName("pemIssuerChain")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderSubordinateConfigPemIssuerChain>? PemIssuerChain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProvider
{
    /// <summary>URLs for accessing content published by this CA, such as the CA certificate and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("accessUrls")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderAccessUrls>? AccessUrls { get; set; }

    /// <summary>The config used to create a self-signed X.509 certificate or CSR. Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderConfig>? Config { get; set; }

    /// <summary>The time at which this CertificateAuthority was created. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Desired state of the CertificateAuthority. Set this field to STAGED to create a STAGED root CA.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as gs://) or suffixes (such as .googleapis.com). For example, to use a bucket named my-bucket, you would simply specify my-bucket. If not specified, a managed bucket will be created.</summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/caPools/{{pool}}/certificateAuthorities/{{certificate_authority_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs. Use with care. Defaults to false.</summary>
    [JsonPropertyName("ignoreActiveCertificatesOnDeletion")]
    public bool? IgnoreActiveCertificatesOnDeletion { get; set; }

    /// <summary>Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR. Structure is documented below.</summary>
    [JsonPropertyName("keySpec")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderKeySpec>? KeySpec { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The desired lifetime of the CA certificate. Used to create the "notBeforeTime" and "notAfterTime" fields inside an X.509 certificate. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>Location of the CertificateAuthority. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The resource name for this CertificateAuthority in the format projects//locations//certificateAuthorities/*.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The signed CA certificate issued from the subordinated CA's CSR. This is needed when activating the subordiante CA with a third party issuer.</summary>
    [JsonPropertyName("pemCaCertificate")]
    public string? PemCaCertificate { get; set; }

    /// <summary>This CertificateAuthority's certificate chain, including the current CertificateAuthority's certificate. Ordered such that the root issuer is the final element (consistent with RFC 5246). For a self-signed CA, this will only list the current CertificateAuthority's certificate.</summary>
    [JsonPropertyName("pemCaCertificates")]
    public IList<string>? PemCaCertificates { get; set; }

    /// <summary>The name of the CaPool this Certificate Authority belongs to.</summary>
    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If this flag is set, the Certificate Authority will be deleted as soon as possible without a 30-day grace period where undeletion would have been allowed. If you proceed, there will be no way to recover this CA. Use with care. Defaults to false.</summary>
    [JsonPropertyName("skipGracePeriod")]
    public bool? SkipGracePeriod { get; set; }

    /// <summary>The State for this CertificateAuthority.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. Structure is documented below.</summary>
    [JsonPropertyName("subordinateConfig")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderSubordinateConfig>? SubordinateConfig { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The Type of this CertificateAuthority. ~&gt; Note: For SUBORDINATE Certificate Authorities, they need to be activated before they can issue certificates. Default value is SELF_SIGNED. Possible values are: SELF_SIGNED, SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The time at which this CertificateAuthority was updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusConditions
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

/// <summary>CertificateAuthorityStatus defines the observed state of CertificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CertificateAuthorityStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateAuthorityStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CertificateAuthority is the Schema for the CertificateAuthoritys API. A CertificateAuthority represents an individual Certificate Authority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateAuthority : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateAuthoritySpec>, IStatus<V1beta1CertificateAuthorityStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateAuthority";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "certificateauthorities";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateAuthoritySpec defines the desired state of CertificateAuthority</summary>
    [JsonPropertyName("spec")]
    public V1beta1CertificateAuthoritySpec Spec { get; set; }

    /// <summary>CertificateAuthorityStatus defines the observed state of CertificateAuthority.</summary>
    [JsonPropertyName("status")]
    public V1beta1CertificateAuthorityStatus? Status { get; set; }
}