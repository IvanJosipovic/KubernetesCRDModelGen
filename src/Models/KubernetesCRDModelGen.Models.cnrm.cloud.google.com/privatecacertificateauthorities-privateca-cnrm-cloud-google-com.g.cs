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
public partial class V1beta1PrivateCACertificateAuthorityList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateCACertificateAuthority>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateAuthorityList";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificateauthorities";
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
    public IList<V1beta1PrivateCACertificateAuthority> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecCaPoolRef
{
    /// <summary>The caPool for the resource  Allowed value: The Google Cloud resource name of a `PrivateCACAPool` resource (format: `projects/{{project}}/locations/{{location}}/caPools/{{name}}`).</summary>
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
/// <summary>Immutable. Required. Contains distinguished name fields such as the common name, location and organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubject
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
/// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSansObjectId
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSans
{
    /// <summary>Immutable. Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSansObjectId ObjectId { get; set; }

    /// <summary>Immutable. Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltName
{
    /// <summary>Immutable. Contains additional subject alternative name values.</summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSans>? CustomSans { get; set; }

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
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfig
{
    /// <summary>Immutable. Required. Contains distinguished name fields such as the common name, location and organization.</summary>
    [JsonPropertyName("subject")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubject Subject { get; set; }

    /// <summary>Immutable. Optional. The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensions
{
    /// <summary>Immutable. Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Immutable. Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensionsObjectId ObjectId { get; set; }

    /// <summary>Immutable. Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigCaOptions
{
    /// <summary>Immutable. Optional. Refers to the "CA" X.509 extension, which is a boolean value. When this value is missing, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Immutable. Optional. Refers to the path length restriction X.509 extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. If this value is missing, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public long? MaxIssuerPathLength { get; set; }

    /// <summary>Immutable. Optional. When true, the "path length constraint" in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageBaseKeyUsage
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
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageExtendedKeyUsage
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
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsage
{
    /// <summary>Immutable. Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Immutable. Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Immutable. Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigPolicyIds
{
    /// <summary>Immutable. Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long> ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509Config
{
    /// <summary>Immutable. Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Immutable. Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>Immutable. Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>Immutable. Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfig
{
    /// <summary>Immutable. Required. Specifies some of the values in a certificate that are related to the subject.</summary>
    [JsonPropertyName("subjectConfig")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfig SubjectConfig { get; set; }

    /// <summary>Immutable. Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
    [JsonPropertyName("x509Config")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509Config X509Config { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecGcsBucketRef
{
    /// <summary>Immutable. The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as `gs://`) or suffixes (such as `.googleapis.com`). For example, to use a bucket named `my-bucket`, you would simply specify `my-bucket`. If not specified, a managed bucket will be created.  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
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
public partial class V1beta1PrivateCACertificateAuthoritySpecKeySpecCloudKmsKeyVersionRef
{
    /// <summary>The resource name for an existing Cloud KMS CryptoKeyVersion in the format `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`. This option enables full flexibility in the key's capabilities and properties.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] KMSCryptoKeyVersion not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. Immutable. Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecKeySpec
{
    /// <summary>Immutable. The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All managed keys will be have their ProtectionLevel as `HSM`. Possible values: RSA_PSS_2048_SHA256, RSA_PSS_3072_SHA256, RSA_PSS_4096_SHA256, RSA_PKCS1_2048_SHA256, RSA_PKCS1_3072_SHA256, RSA_PKCS1_4096_SHA256, EC_P256_SHA256, EC_P384_SHA384</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("cloudKmsKeyVersionRef")]
    public V1beta1PrivateCACertificateAuthoritySpecKeySpecCloudKmsKeyVersionRef? CloudKmsKeyVersionRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecProjectRef
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
public partial class V1beta1PrivateCACertificateAuthoritySpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("caPoolRef")]
    public V1beta1PrivateCACertificateAuthoritySpecCaPoolRef CaPoolRef { get; set; }

    /// <summary>Immutable. Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
    [JsonPropertyName("config")]
    public V1beta1PrivateCACertificateAuthoritySpecConfig Config { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("gcsBucketRef")]
    public V1beta1PrivateCACertificateAuthoritySpecGcsBucketRef? GcsBucketRef { get; set; }

    /// <summary>Immutable. Required. Immutable. Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR.</summary>
    [JsonPropertyName("keySpec")]
    public V1beta1PrivateCACertificateAuthoritySpecKeySpec KeySpec { get; set; }

    /// <summary>Immutable. Required. The desired lifetime of the CA certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate.</summary>
    [JsonPropertyName("lifetime")]
    public string Lifetime { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1PrivateCACertificateAuthoritySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Required. Immutable. The Type of this CertificateAuthority. Possible values: SELF_SIGNED, SUBORDINATE</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. URLs for accessing content published by this CA, such as the CA certificate and CRLs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusAccessUrls
{
    /// <summary>The URL where this CertificateAuthority's CA certificate is published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("caCertificateAccessUrl")]
    public string? CaCertificateAccessUrl { get; set; }

    /// <summary>The URLs where this CertificateAuthority's CRLs are published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("crlAccessUrls")]
    public IList<string>? CrlAccessUrls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsAuthorityKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The hash of the x.509 certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsCertFingerprint
{
    /// <summary>The SHA 256 hash, encoded in hexadecimal, of the DER x509 certificate.</summary>
    [JsonPropertyName("sha256Hash")]
    public string? Sha256Hash { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The public key that corresponds to an issued certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsPublicKey
{
    /// <summary>Required. The format of the public key. Possible values: PEM</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. The padding and encoding must match with the `KeyFormat` value specified for the `format` field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contains distinguished name fields such as the common name, location and organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubject
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
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSansObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSans
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSansObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltName
{
    /// <summary>Contains additional subject alternative name values.</summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSans>? CustomSans { get; set; }

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
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescription
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

    /// <summary>Contains distinguished name fields such as the common name, location and organization.</summary>
    [JsonPropertyName("subject")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubject? Subject { get; set; }

    /// <summary>The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltName? SubjectAltName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionCaOptions
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
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageBaseKeyUsage
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
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageExtendedKeyUsage
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
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509Description
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionPolicyIds>? PolicyIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptions
{
    /// <summary>Describes lists of issuer CA certificate URLs that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaIssuingCertificateUrls")]
    public IList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
    [JsonPropertyName("authorityKeyId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsAuthorityKeyId? AuthorityKeyId { get; set; }

    /// <summary>The hash of the x.509 certificate.</summary>
    [JsonPropertyName("certFingerprint")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsCertFingerprint? CertFingerprint { get; set; }

    /// <summary>Describes a list of locations to obtain CRL information, i.e. the DistributionPoint.fullName described by https://tools.ietf.org/html/rfc5280#section-4.2.1.13</summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }

    /// <summary>The public key that corresponds to an issued certificate.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsPublicKey? PublicKey { get; set; }

    /// <summary>Describes some of the values in a certificate that are related to the subject and lifetime.</summary>
    [JsonPropertyName("subjectDescription")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescription? SubjectDescription { get; set; }

    /// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
    [JsonPropertyName("x509Description")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509Description? X509Description { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConditions
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
/// <summary>Optional. The public key that corresponds to this config. This is, for example, used when issuing Certificates, but not when creating a self-signed CertificateAuthority or CertificateAuthority CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfigPublicKey
{
    /// <summary>Required. The format of the public key. Possible values: PEM</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. The padding and encoding must match with the `KeyFormat` value specified for the `format` field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfigX509Config
{
    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfig
{
    /// <summary>Optional. The public key that corresponds to this config. This is, for example, used when issuing Certificates, but not when creating a self-signed CertificateAuthority or CertificateAuthority CSR.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateAuthorityStatusConfigPublicKey? PublicKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("x509Config")]
    public V1beta1PrivateCACertificateAuthorityStatusConfigX509Config? X509Config { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem certificate for this CA itself.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusSubordinateConfigPemIssuerChain
{
    /// <summary>Required. Expected to be in leaf-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificates")]
    public IList<string>? PemCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. This may be updated, but this CertificateAuthority must continue to validate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusSubordinateConfig
{
    /// <summary>Required. This can refer to a CertificateAuthority in the same project that was used to create a subordinate CertificateAuthority. This field is used for information and usability purposes only. The resource name is in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.</summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Required. Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem certificate for this CA itself.</summary>
    [JsonPropertyName("pemIssuerChain")]
    public V1beta1PrivateCACertificateAuthorityStatusSubordinateConfigPemIssuerChain? PemIssuerChain { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatus
{
    /// <summary>Output only. URLs for accessing content published by this CA, such as the CA certificate and CRLs.</summary>
    [JsonPropertyName("accessUrls")]
    public V1beta1PrivateCACertificateAuthorityStatusAccessUrls? AccessUrls { get; set; }

    /// <summary>Output only. A structured description of this CertificateAuthority's CA certificate and its issuers. Ordered as self-to-root.</summary>
    [JsonPropertyName("caCertificateDescriptions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptions>? CaCertificateDescriptions { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("config")]
    public V1beta1PrivateCACertificateAuthorityStatusConfig? Config { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was soft deleted, if it is in the DELETED state.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority will be permanently purged, if it is in the DELETED state.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. This CertificateAuthority's certificate chain, including the current CertificateAuthority's certificate. Ordered such that the root issuer is the final element (consistent with RFC 5246). For a self-signed CA, this will only list the current CertificateAuthority's certificate.</summary>
    [JsonPropertyName("pemCaCertificates")]
    public IList<string>? PemCaCertificates { get; set; }

    /// <summary>Output only. The State for this CertificateAuthority. Possible values: ENABLED, DISABLED, STAGED, AWAITING_USER_ACTIVATION, DELETED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Optional. If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. This may be updated, but this CertificateAuthority must continue to validate.</summary>
    [JsonPropertyName("subordinateConfig")]
    public V1beta1PrivateCACertificateAuthorityStatusSubordinateConfig? SubordinateConfig { get; set; }

    /// <summary>Output only. The CaPool.Tier of the CaPool that includes this CertificateAuthority. Possible values: ENTERPRISE, DEVOPS</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateAuthority : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateCACertificateAuthoritySpec>, IStatus<V1beta1PrivateCACertificateAuthorityStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateAuthority";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificateauthorities";
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
    public V1beta1PrivateCACertificateAuthoritySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateCACertificateAuthorityStatus? Status { get; set; }
}
#nullable disable
