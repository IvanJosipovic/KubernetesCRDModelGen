using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acmpca.aws.upbound.io;
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
public partial class V1beta1CertificateAuthoritySpecForProviderCertificateAuthorityConfigurationSubject
{
    /// <summary>Fully qualified domain name (FQDN) associated with the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Two digit code that specifies the country in which the certificate subject located. Must be less than or equal to 2 characters in length.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>Disambiguating information for the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("distinguishedNameQualifier")]
    public string? DistinguishedNameQualifier { get; set; }

    /// <summary>Typically a qualifier appended to the name of an individual. Examples include Jr. for junior, Sr. for senior, and III for third. Must be less than or equal to 3 characters in length.</summary>
    [JsonPropertyName("generationQualifier")]
    public string? GenerationQualifier { get; set; }

    /// <summary>First name. Must be less than or equal to 16 characters in length.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>Concatenation that typically contains the first letter of the given_name, the first letter of the middle name if one exists, and the first letter of the surname. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("initials")]
    public string? Initials { get; set; }

    /// <summary>Locality (such as a city or town) in which the certificate subject is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Legal name of the organization with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>Subdivision or unit of the organization (such as sales or finance) with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>Typically a shortened version of a longer given_name. For example, Jonathan is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("pseudonym")]
    public string? Pseudonym { get; set; }

    /// <summary>State in which the subject of the certificate is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Family name. In the US and the UK for example, the surname of an individual is ordered last. In Asian cultures the surname is typically ordered first. Must be less than or equal to 40 characters in length.</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>Title such as Mr. or Ms. which is pre-pended to the name to refer formally to the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderCertificateAuthorityConfiguration
{
    /// <summary>Type of the public key algorithm and size, in bits, of the key pair that your key pair creates when it issues a certificate. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Name of the algorithm your private CA uses to sign certificate requests. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }

    /// <summary>Nested argument that contains X.500 distinguished name information. At least one nested attribute must be specified.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthoritySpecForProviderCertificateAuthorityConfigurationSubject>? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderRevocationConfigurationCrlConfiguration
{
    /// <summary>Name inserted into the certificate CRL Distribution Points extension that enables the use of an alias for the CRL distribution point. Use this value if you don't want the name of your S3 bucket to be public. Must be less than or equal to 253 characters in length.</summary>
    [JsonPropertyName("customCname")]
    public string? CustomCname { get; set; }

    /// <summary>Boolean value that specifies whether certificate revocation lists (CRLs) are enabled. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of days until a certificate expires. Must be between 1 and 5000.</summary>
    [JsonPropertyName("expirationInDays")]
    public double? ExpirationInDays { get; set; }

    /// <summary>Name of the S3 bucket that contains the CRL. If you do not provide a value for the custom_cname argument, the name of your S3 bucket is placed into the CRL Distribution Points extension of the issued certificate. You must specify a bucket policy that allows ACM PCA to write the CRL to your bucket. Must be between 3 and 255 characters in length.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Determines whether the CRL will be publicly readable or privately held in the CRL Amazon S3 bucket. Defaults to PUBLIC_READ.</summary>
    [JsonPropertyName("s3ObjectAcl")]
    public string? S3ObjectAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderRevocationConfigurationOcspConfiguration
{
    /// <summary>Boolean value that specifies whether a custom OCSP responder is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>CNAME specifying a customized OCSP domain. Note: The value of the CNAME must not include a protocol prefix such as "http://" or "https://".</summary>
    [JsonPropertyName("ocspCustomCname")]
    public string? OcspCustomCname { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProviderRevocationConfiguration
{
    /// <summary>Nested argument containing configuration of the certificate revocation list (CRL), if any, maintained by the certificate authority. Defined below.</summary>
    [JsonPropertyName("crlConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecForProviderRevocationConfigurationCrlConfiguration>? CrlConfiguration { get; set; }

    /// <summary>Nested argument containing configuration of the custom OCSP responder endpoint. Defined below.</summary>
    [JsonPropertyName("ocspConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecForProviderRevocationConfigurationOcspConfiguration>? OcspConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecForProvider
{
    /// <summary>Nested argument containing algorithms and certificate subject information. Defined below.</summary>
    [JsonPropertyName("certificateAuthorityConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecForProviderCertificateAuthorityConfiguration>? CertificateAuthorityConfiguration { get; set; }

    /// <summary>Whether the certificate authority is enabled or disabled. Defaults to true. Can only be disabled if the CA is in an ACTIVE state.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Cryptographic key management compliance standard used for handling CA keys. Defaults to FIPS_140_2_LEVEL_3_OR_HIGHER. Valid values: FIPS_140_2_LEVEL_3_OR_HIGHER and FIPS_140_2_LEVEL_2_OR_HIGHER. Supported standard for each region can be found in the Storage and security compliance of AWS Private CA private keys Documentation.</summary>
    [JsonPropertyName("keyStorageSecurityStandard")]
    public string? KeyStorageSecurityStandard { get; set; }

    /// <summary>Number of days to make a CA restorable after it has been deleted, must be between 7 to 30 days, with default to 30 days.</summary>
    [JsonPropertyName("permanentDeletionTimeInDays")]
    public double? PermanentDeletionTimeInDays { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Nested argument containing revocation configuration. Defined below.</summary>
    [JsonPropertyName("revocationConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecForProviderRevocationConfiguration>? RevocationConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type of the certificate authority. Defaults to SUBORDINATE. Valid values: ROOT and SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies whether the CA issues general-purpose certificates that typically require a revocation mechanism, or short-lived certificates that may optionally omit revocation because they expire quickly. Short-lived certificate validity is limited to seven days. Defaults to GENERAL_PURPOSE. Valid values: GENERAL_PURPOSE and SHORT_LIVED_CERTIFICATE.</summary>
    [JsonPropertyName("usageMode")]
    public string? UsageMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderCertificateAuthorityConfigurationSubject
{
    /// <summary>Fully qualified domain name (FQDN) associated with the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Two digit code that specifies the country in which the certificate subject located. Must be less than or equal to 2 characters in length.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>Disambiguating information for the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("distinguishedNameQualifier")]
    public string? DistinguishedNameQualifier { get; set; }

    /// <summary>Typically a qualifier appended to the name of an individual. Examples include Jr. for junior, Sr. for senior, and III for third. Must be less than or equal to 3 characters in length.</summary>
    [JsonPropertyName("generationQualifier")]
    public string? GenerationQualifier { get; set; }

    /// <summary>First name. Must be less than or equal to 16 characters in length.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>Concatenation that typically contains the first letter of the given_name, the first letter of the middle name if one exists, and the first letter of the surname. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("initials")]
    public string? Initials { get; set; }

    /// <summary>Locality (such as a city or town) in which the certificate subject is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Legal name of the organization with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>Subdivision or unit of the organization (such as sales or finance) with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>Typically a shortened version of a longer given_name. For example, Jonathan is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("pseudonym")]
    public string? Pseudonym { get; set; }

    /// <summary>State in which the subject of the certificate is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Family name. In the US and the UK for example, the surname of an individual is ordered last. In Asian cultures the surname is typically ordered first. Must be less than or equal to 40 characters in length.</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>Title such as Mr. or Ms. which is pre-pended to the name to refer formally to the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderCertificateAuthorityConfiguration
{
    /// <summary>Type of the public key algorithm and size, in bits, of the key pair that your key pair creates when it issues a certificate. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Name of the algorithm your private CA uses to sign certificate requests. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }

    /// <summary>Nested argument that contains X.500 distinguished name information. At least one nested attribute must be specified.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderCertificateAuthorityConfigurationSubject>? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderRevocationConfigurationCrlConfiguration
{
    /// <summary>Name inserted into the certificate CRL Distribution Points extension that enables the use of an alias for the CRL distribution point. Use this value if you don't want the name of your S3 bucket to be public. Must be less than or equal to 253 characters in length.</summary>
    [JsonPropertyName("customCname")]
    public string? CustomCname { get; set; }

    /// <summary>Boolean value that specifies whether certificate revocation lists (CRLs) are enabled. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of days until a certificate expires. Must be between 1 and 5000.</summary>
    [JsonPropertyName("expirationInDays")]
    public double? ExpirationInDays { get; set; }

    /// <summary>Name of the S3 bucket that contains the CRL. If you do not provide a value for the custom_cname argument, the name of your S3 bucket is placed into the CRL Distribution Points extension of the issued certificate. You must specify a bucket policy that allows ACM PCA to write the CRL to your bucket. Must be between 3 and 255 characters in length.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Determines whether the CRL will be publicly readable or privately held in the CRL Amazon S3 bucket. Defaults to PUBLIC_READ.</summary>
    [JsonPropertyName("s3ObjectAcl")]
    public string? S3ObjectAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderRevocationConfigurationOcspConfiguration
{
    /// <summary>Boolean value that specifies whether a custom OCSP responder is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>CNAME specifying a customized OCSP domain. Note: The value of the CNAME must not include a protocol prefix such as "http://" or "https://".</summary>
    [JsonPropertyName("ocspCustomCname")]
    public string? OcspCustomCname { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProviderRevocationConfiguration
{
    /// <summary>Nested argument containing configuration of the certificate revocation list (CRL), if any, maintained by the certificate authority. Defined below.</summary>
    [JsonPropertyName("crlConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderRevocationConfigurationCrlConfiguration>? CrlConfiguration { get; set; }

    /// <summary>Nested argument containing configuration of the custom OCSP responder endpoint. Defined below.</summary>
    [JsonPropertyName("ocspConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderRevocationConfigurationOcspConfiguration>? OcspConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthoritySpecInitProvider
{
    /// <summary>Nested argument containing algorithms and certificate subject information. Defined below.</summary>
    [JsonPropertyName("certificateAuthorityConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderCertificateAuthorityConfiguration>? CertificateAuthorityConfiguration { get; set; }

    /// <summary>Whether the certificate authority is enabled or disabled. Defaults to true. Can only be disabled if the CA is in an ACTIVE state.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Cryptographic key management compliance standard used for handling CA keys. Defaults to FIPS_140_2_LEVEL_3_OR_HIGHER. Valid values: FIPS_140_2_LEVEL_3_OR_HIGHER and FIPS_140_2_LEVEL_2_OR_HIGHER. Supported standard for each region can be found in the Storage and security compliance of AWS Private CA private keys Documentation.</summary>
    [JsonPropertyName("keyStorageSecurityStandard")]
    public string? KeyStorageSecurityStandard { get; set; }

    /// <summary>Number of days to make a CA restorable after it has been deleted, must be between 7 to 30 days, with default to 30 days.</summary>
    [JsonPropertyName("permanentDeletionTimeInDays")]
    public double? PermanentDeletionTimeInDays { get; set; }

    /// <summary>Nested argument containing revocation configuration. Defined below.</summary>
    [JsonPropertyName("revocationConfiguration")]
    public IList<V1beta1CertificateAuthoritySpecInitProviderRevocationConfiguration>? RevocationConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type of the certificate authority. Defaults to SUBORDINATE. Valid values: ROOT and SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies whether the CA issues general-purpose certificates that typically require a revocation mechanism, or short-lived certificates that may optionally omit revocation because they expire quickly. Short-lived certificate validity is limited to seven days. Defaults to GENERAL_PURPOSE. Valid values: GENERAL_PURPOSE and SHORT_LIVED_CERTIFICATE.</summary>
    [JsonPropertyName("usageMode")]
    public string? UsageMode { get; set; }
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
public partial class V1beta1CertificateAuthorityStatusAtProviderCertificateAuthorityConfigurationSubject
{
    /// <summary>Fully qualified domain name (FQDN) associated with the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Two digit code that specifies the country in which the certificate subject located. Must be less than or equal to 2 characters in length.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>Disambiguating information for the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("distinguishedNameQualifier")]
    public string? DistinguishedNameQualifier { get; set; }

    /// <summary>Typically a qualifier appended to the name of an individual. Examples include Jr. for junior, Sr. for senior, and III for third. Must be less than or equal to 3 characters in length.</summary>
    [JsonPropertyName("generationQualifier")]
    public string? GenerationQualifier { get; set; }

    /// <summary>First name. Must be less than or equal to 16 characters in length.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>Concatenation that typically contains the first letter of the given_name, the first letter of the middle name if one exists, and the first letter of the surname. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("initials")]
    public string? Initials { get; set; }

    /// <summary>Locality (such as a city or town) in which the certificate subject is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Legal name of the organization with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>Subdivision or unit of the organization (such as sales or finance) with which the certificate subject is affiliated. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>Typically a shortened version of a longer given_name. For example, Jonathan is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("pseudonym")]
    public string? Pseudonym { get; set; }

    /// <summary>State in which the subject of the certificate is located. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Family name. In the US and the UK for example, the surname of an individual is ordered last. In Asian cultures the surname is typically ordered first. Must be less than or equal to 40 characters in length.</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>Title such as Mr. or Ms. which is pre-pended to the name to refer formally to the certificate subject. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderCertificateAuthorityConfiguration
{
    /// <summary>Type of the public key algorithm and size, in bits, of the key pair that your key pair creates when it issues a certificate. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Name of the algorithm your private CA uses to sign certificate requests. Valid values can be found in the ACM PCA Documentation.</summary>
    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }

    /// <summary>Nested argument that contains X.500 distinguished name information. At least one nested attribute must be specified.</summary>
    [JsonPropertyName("subject")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderCertificateAuthorityConfigurationSubject>? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderRevocationConfigurationCrlConfiguration
{
    /// <summary>Name inserted into the certificate CRL Distribution Points extension that enables the use of an alias for the CRL distribution point. Use this value if you don't want the name of your S3 bucket to be public. Must be less than or equal to 253 characters in length.</summary>
    [JsonPropertyName("customCname")]
    public string? CustomCname { get; set; }

    /// <summary>Boolean value that specifies whether certificate revocation lists (CRLs) are enabled. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of days until a certificate expires. Must be between 1 and 5000.</summary>
    [JsonPropertyName("expirationInDays")]
    public double? ExpirationInDays { get; set; }

    /// <summary>Name of the S3 bucket that contains the CRL. If you do not provide a value for the custom_cname argument, the name of your S3 bucket is placed into the CRL Distribution Points extension of the issued certificate. You must specify a bucket policy that allows ACM PCA to write the CRL to your bucket. Must be between 3 and 255 characters in length.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Determines whether the CRL will be publicly readable or privately held in the CRL Amazon S3 bucket. Defaults to PUBLIC_READ.</summary>
    [JsonPropertyName("s3ObjectAcl")]
    public string? S3ObjectAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderRevocationConfigurationOcspConfiguration
{
    /// <summary>Boolean value that specifies whether a custom OCSP responder is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>CNAME specifying a customized OCSP domain. Note: The value of the CNAME must not include a protocol prefix such as "http://" or "https://".</summary>
    [JsonPropertyName("ocspCustomCname")]
    public string? OcspCustomCname { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProviderRevocationConfiguration
{
    /// <summary>Nested argument containing configuration of the certificate revocation list (CRL), if any, maintained by the certificate authority. Defined below.</summary>
    [JsonPropertyName("crlConfiguration")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderRevocationConfigurationCrlConfiguration>? CrlConfiguration { get; set; }

    /// <summary>Nested argument containing configuration of the custom OCSP responder endpoint. Defined below.</summary>
    [JsonPropertyName("ocspConfiguration")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderRevocationConfigurationOcspConfiguration>? OcspConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateAuthorityStatusAtProvider
{
    /// <summary>ARN of the certificate authority.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Base64-encoded certificate authority (CA) certificate. Only available after the certificate authority certificate has been imported.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>Nested argument containing algorithms and certificate subject information. Defined below.</summary>
    [JsonPropertyName("certificateAuthorityConfiguration")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderCertificateAuthorityConfiguration>? CertificateAuthorityConfiguration { get; set; }

    /// <summary>Base64-encoded certificate chain that includes any intermediate certificates and chains up to root on-premises certificate that you used to sign your private CA certificate. The chain does not include your private CA certificate. Only available after the certificate authority certificate has been imported.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>The base64 PEM-encoded certificate signing request (CSR) for your private CA certificate.</summary>
    [JsonPropertyName("certificateSigningRequest")]
    public string? CertificateSigningRequest { get; set; }

    /// <summary>Whether the certificate authority is enabled or disabled. Defaults to true. Can only be disabled if the CA is in an ACTIVE state.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the certificate authority.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Cryptographic key management compliance standard used for handling CA keys. Defaults to FIPS_140_2_LEVEL_3_OR_HIGHER. Valid values: FIPS_140_2_LEVEL_3_OR_HIGHER and FIPS_140_2_LEVEL_2_OR_HIGHER. Supported standard for each region can be found in the Storage and security compliance of AWS Private CA private keys Documentation.</summary>
    [JsonPropertyName("keyStorageSecurityStandard")]
    public string? KeyStorageSecurityStandard { get; set; }

    /// <summary>Date and time after which the certificate authority is not valid. Only available after the certificate authority certificate has been imported.</summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>Date and time before which the certificate authority is not valid. Only available after the certificate authority certificate has been imported.</summary>
    [JsonPropertyName("notBefore")]
    public string? NotBefore { get; set; }

    /// <summary>Number of days to make a CA restorable after it has been deleted, must be between 7 to 30 days, with default to 30 days.</summary>
    [JsonPropertyName("permanentDeletionTimeInDays")]
    public double? PermanentDeletionTimeInDays { get; set; }

    /// <summary>Nested argument containing revocation configuration. Defined below.</summary>
    [JsonPropertyName("revocationConfiguration")]
    public IList<V1beta1CertificateAuthorityStatusAtProviderRevocationConfiguration>? RevocationConfiguration { get; set; }

    /// <summary>Serial number of the certificate authority. Only available after the certificate authority certificate has been imported.</summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Type of the certificate authority. Defaults to SUBORDINATE. Valid values: ROOT and SUBORDINATE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies whether the CA issues general-purpose certificates that typically require a revocation mechanism, or short-lived certificates that may optionally omit revocation because they expire quickly. Short-lived certificate validity is limited to seven days. Defaults to GENERAL_PURPOSE. Valid values: GENERAL_PURPOSE and SHORT_LIVED_CERTIFICATE.</summary>
    [JsonPropertyName("usageMode")]
    public string? UsageMode { get; set; }
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

/// <summary>CertificateAuthority is the Schema for the CertificateAuthoritys API. Provides a resource to manage AWS Certificate Manager Private Certificate Authorities</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateAuthority : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateAuthoritySpec>, IStatus<V1beta1CertificateAuthorityStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateAuthority";
    public const string KubeGroup = "acmpca.aws.upbound.io";
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