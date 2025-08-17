using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateCACertificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateList";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificates";
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
    public IList<V1beta1PrivateCACertificate> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecCaPoolRef
{
    /// <summary>The ca_pool for the resource  Allowed value: The Google Cloud resource name of a `PrivateCACAPool` resource (format: `projects/{{project}}/locations/{{location}}/caPools/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecCertificateAuthorityRef
{
    /// <summary>The certificate authority for the resource  Allowed value: The Google Cloud resource name of a `PrivateCACertificateAuthority` resource (format: `projects/{{project}}/locations/{{location}}/caPools/{{ca_pool}}/certificateAuthorities/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecCertificateTemplateRef
{
    /// <summary>Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary permission to use this template. If this is omitted, no template will be used. This template must be in the same location as the Certificate.  Allowed value: The `selfLink` field of a `PrivateCACertificateTemplate` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. The public key that corresponds to this config. This is, for example, used when issuing Certificates, but not when creating a self-signed CertificateAuthority or CertificateAuthority CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigPublicKey
{
    /// <summary>Immutable. Required. The format of the public key. Possible values: KEY_FORMAT_UNSPECIFIED, PEM</summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>Immutable. Required. A public key. The padding and encoding must match with the `KeyFormat` value specified for the `format` field.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Contains distinguished name fields such as the common name, location and organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigSubjectConfigSubject
{
    /// <summary>Immutable. The "common name" of the subject.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Immutable. The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>Immutable. The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Immutable. The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>Immutable. The organizational_unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>Immutable. The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>Immutable. The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>Immutable. The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigSubjectConfigSubjectAltName
{
    /// <summary>Immutable. Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Immutable. Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Immutable. Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Immutable. Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Specifies some of the values in a certificate that are related to the subject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigSubjectConfig
{
    /// <summary>Immutable. Required. Contains distinguished name fields such as the common name, location and organization.</summary>
    [JsonPropertyName("subject")]
    public V1beta1PrivateCACertificateSpecConfigSubjectConfigSubject Subject { get; set; }

    /// <summary>Immutable. Optional. The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateSpecConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigAdditionalExtensions
{
    /// <summary>Immutable. Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateSpecConfigX509ConfigAdditionalExtensionsObjectId ObjectId { get; set; }

    /// <summary>Immutable. Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigCaOptions
{
    /// <summary>Immutable. Optional. When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Immutable. Optional. Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public long? MaxIssuerPathLength { get; set; }

    /// <summary>Immutable. Optional. When true, the "CA" in Basic Constraints extension will be set to false. If both `is_ca` and `non_ca` are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>Immutable. Optional. When true, the "path length constraint" in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageBaseKeyUsage
{
    /// <summary>Immutable. The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>Immutable. The key may be used for cryptographic commitments. Note that this may also be referred to as "non-repudiation".</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>Immutable. The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>Immutable. The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>Immutable. The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>Immutable. The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>Immutable. The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>Immutable. The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>Immutable. The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageExtendedKeyUsage
{
    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as "TLS WWW client authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as "Signing of downloadable executable code client authentication".</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as "Email protection".</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as "Signing OCSP responses".</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as "TLS WWW server authentication", though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Immutable. Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as "Binding the hash of an object to a time".</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsage
{
    /// <summary>Immutable. Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Immutable. Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Immutable. Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509ConfigPolicyIds
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfigX509Config
{
    /// <summary>Immutable. Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateSpecConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Immutable. Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Immutable. Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateSpecConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>Immutable. Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateSpecConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>Immutable. Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateSpecConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Immutable. A description of the certificate and key that does not require X.509 or ASN.1.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecConfig
{
    /// <summary>Immutable. Optional. The public key that corresponds to this config. This is, for example, used when issuing Certificates, but not when creating a self-signed CertificateAuthority or CertificateAuthority CSR.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateSpecConfigPublicKey? PublicKey { get; set; }

    /// <summary>Immutable. Required. Specifies some of the values in a certificate that are related to the subject.</summary>
    [JsonPropertyName("subjectConfig")]
    public V1beta1PrivateCACertificateSpecConfigSubjectConfig SubjectConfig { get; set; }

    /// <summary>Immutable. Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
    [JsonPropertyName("x509Config")]
    public V1beta1PrivateCACertificateSpecConfigX509Config X509Config { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("caPoolRef")]
    public V1beta1PrivateCACertificateSpecCaPoolRef CaPoolRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1beta1PrivateCACertificateSpecCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("certificateTemplateRef")]
    public V1beta1PrivateCACertificateSpecCertificateTemplateRef? CertificateTemplateRef { get; set; }

    /// <summary>Immutable. Immutable. A description of the certificate and key that does not require X.509 or ASN.1.</summary>
    [JsonPropertyName("config")]
    public V1beta1PrivateCACertificateSpecConfig? Config { get; set; }

    /// <summary>Immutable. Required. Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.</summary>
    [JsonPropertyName("lifetime")]
    public string Lifetime { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Immutable. A pem-encoded X.509 certificate signing request (CSR).</summary>
    [JsonPropertyName("pemCsr")]
    public string? PemCsr { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1PrivateCACertificateSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the `DEFAULT` subject mode will be used. Possible values: SUBJECT_REQUEST_MODE_UNSPECIFIED, DEFAULT, REFLECTED_SPIFFE</summary>
    [JsonPropertyName("subjectMode")]
    public string? SubjectMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionAuthorityKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The hash of the x.509 certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionCertFingerprint
{
    /// <summary>The SHA 256 hash, encoded in hexadecimal, of the DER x509 certificate.</summary>
    [JsonPropertyName("sha256Hash")]
    public string? Sha256Hash { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The public key that corresponds to an issued certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionPublicKey
{
    /// <summary>Required. The format of the public key. Possible values: KEY_FORMAT_UNSPECIFIED, PEM</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. The padding and encoding must match with the `KeyFormat` value specified for the `format` field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contains distinguished name fields such as the common name, location and / organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubject
{
    /// <summary>The "common name" of the subject.</summary>
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

    /// <summary>The organizational_unit of the subject.</summary>
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
#nullable disable

#nullable enable
/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSansObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSans
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSansObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltName
{
    /// <summary>Contains additional subject alternative name values.</summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSans>? CustomSans { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Describes some of the values in a certificate that are related to the subject and lifetime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescription
{
    /// <summary>The serial number encoded in lowercase hexadecimal.</summary>
    [JsonPropertyName("hexSerialNumber")]
    public string? HexSerialNumber { get; set; }

    /// <summary>For convenience, the actual lifetime of an issued certificate.</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>The time after which the certificate is expired. Per RFC 5280, the validity period for a certificate is the period of time from not_before_time through not_after_time, inclusive. Corresponds to 'not_before_time' + 'lifetime' - 1 second.</summary>
    [JsonPropertyName("notAfterTime")]
    public string? NotAfterTime { get; set; }

    /// <summary>The time at which the certificate becomes valid.</summary>
    [JsonPropertyName("notBeforeTime")]
    public string? NotBeforeTime { get; set; }

    /// <summary>Contains distinguished name fields such as the common name, location and / organization.</summary>
    [JsonPropertyName("subject")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubject? Subject { get; set; }

    /// <summary>The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescriptionSubjectAltName? SubjectAltName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionCaOptions
{
    /// <summary>Optional. Refers to the "CA" X.509 extension, which is a boolean value. When this value is missing, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Optional. Refers to the path length restriction X.509 extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. If this value is missing, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public long? MaxIssuerPathLength { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageBaseKeyUsage
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
#nullable disable

#nullable enable
/// <summary>Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageExtendedKeyUsage
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescriptionX509Description
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateStatusCertificateDescriptionX509DescriptionPolicyIds>? PolicyIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. A structured description of the issued X.509 certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusCertificateDescription
{
    /// <summary>Describes lists of issuer CA certificate URLs that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaIssuingCertificateUrls")]
    public IList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
    [JsonPropertyName("authorityKeyId")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionAuthorityKeyId? AuthorityKeyId { get; set; }

    /// <summary>The hash of the x.509 certificate.</summary>
    [JsonPropertyName("certFingerprint")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionCertFingerprint? CertFingerprint { get; set; }

    /// <summary>Describes a list of locations to obtain CRL information, i.e. the DistributionPoint.fullName described by https://tools.ietf.org/html/rfc5280#section-4.2.1.13</summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }

    /// <summary>The public key that corresponds to an issued certificate.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionPublicKey? PublicKey { get; set; }

    /// <summary>Describes some of the values in a certificate that are related to the subject and lifetime.</summary>
    [JsonPropertyName("subjectDescription")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectDescription? SubjectDescription { get; set; }

    /// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
    [JsonPropertyName("x509Description")]
    public V1beta1PrivateCACertificateStatusCertificateDescriptionX509Description? X509Description { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatusRevocationDetails
{
    /// <summary>Indicates why a Certificate was revoked. Possible values: REVOCATION_REASON_UNSPECIFIED, KEY_COMPROMISE, CERTIFICATE_AUTHORITY_COMPROMISE, AFFILIATION_CHANGED, SUPERSEDED, CESSATION_OF_OPERATION, CERTIFICATE_HOLD, PRIVILEGE_WITHDRAWN, ATTRIBUTE_AUTHORITY_COMPROMISE</summary>
    [JsonPropertyName("revocationState")]
    public string? RevocationState { get; set; }

    /// <summary>The time at which this Certificate was revoked.</summary>
    [JsonPropertyName("revocationTime")]
    public string? RevocationTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateStatus
{
    /// <summary>Output only. A structured description of the issued X.509 certificate.</summary>
    [JsonPropertyName("certificateDescription")]
    public V1beta1PrivateCACertificateStatusCertificateDescription? CertificateDescription { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateCACertificateStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time at which this Certificate was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The resource name of the issuing CertificateAuthority in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.</summary>
    [JsonPropertyName("issuerCertificateAuthority")]
    public string? IssuerCertificateAuthority { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The pem-encoded, signed X.509 certificate.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>Output only. The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificateChain")]
    public IList<string>? PemCertificateChain { get; set; }

    /// <summary>Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.</summary>
    [JsonPropertyName("revocationDetails")]
    public V1beta1PrivateCACertificateStatusRevocationDetails? RevocationDetails { get; set; }

    /// <summary>Output only. The time at which this Certificate was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateCACertificateSpec>, IStatus<V1beta1PrivateCACertificateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificate";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateCACertificateSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateCACertificateStatus? Status { get; set; }
}
#nullable disable
