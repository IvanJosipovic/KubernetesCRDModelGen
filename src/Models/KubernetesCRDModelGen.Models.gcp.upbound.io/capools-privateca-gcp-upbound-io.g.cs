using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>The algorithm used. Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service will not enforce an explicit upper bound on RSA modulus sizes.</summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service-level min RSA modulus size will continue to apply.</summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>Represents an allowed Elliptic Curve key type. Structure is documented below.</summary>
    [JsonPropertyName("ellipticCurve")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesEllipticCurve>? EllipticCurve { get; set; }

    /// <summary>Describes an RSA key that may be used in a Certificate issued from a CaPool. Structure is documented below.</summary>
    [JsonPropertyName("rsa")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesRsa>? Rsa { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
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
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesNameConstraints
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
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValues
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Location of the CaPool. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicyIdentityConstraints
{
    /// <summary>If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>If this is set, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/cel-guide Structure is documented below.</summary>
    [JsonPropertyName("celExpression")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyIdentityConstraintsCelExpression>? CelExpression { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderIssuancePolicy
{
    /// <summary>IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyAllowedIssuanceModes>? AllowedIssuanceModes { get; set; }

    /// <summary>If any AllowedKeyType is specified, then the certificate request's public key must match one of the key types listed here. Otherwise, any key may be used. Structure is documented below.</summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate issuance request will fail. Structure is documented below.</summary>
    [JsonPropertyName("baselineValues")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyBaselineValues>? BaselineValues { get; set; }

    /// <summary>Describes constraints on identities that may appear in Certificates issued through this CaPool. If this is omitted, then this CaPool will not add restrictions on a certificate's identity. Structure is documented below.</summary>
    [JsonPropertyName("identityConstraints")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicyIdentityConstraints>? IdentityConstraints { get; set; }

    /// <summary>The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority expires before a Certificate's requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProviderPublishingOptions
{
    /// <summary>Specifies the encoding format of each CertificateAuthority's CA certificate and CRLs. If this is omitted, CA certificates and CRLs will be published in PEM. Possible values are: PEM, DER.</summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CA certificate and includes its URL in the "Authority Information Access" X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding X.509 extension will not be written in issued certificates.</summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CRL and includes its URL in the "CRL Distribution Points" X.509 extension in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.</summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecForProvider
{
    /// <summary>The IssuancePolicy to control how Certificates will be issued from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("issuancePolicy")]
    public IList<V1beta1CAPoolSpecForProviderIssuancePolicy>? IssuancePolicy { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Location of the CaPool. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("publishingOptions")]
    public IList<V1beta1CAPoolSpecForProviderPublishingOptions>? PublishingOptions { get; set; }

    /// <summary>The Tier of this CaPool. Possible values are: ENTERPRISE, DEVOPS.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>The algorithm used. Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service will not enforce an explicit upper bound on RSA modulus sizes.</summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service-level min RSA modulus size will continue to apply.</summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>Represents an allowed Elliptic Curve key type. Structure is documented below.</summary>
    [JsonPropertyName("ellipticCurve")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesEllipticCurve>? EllipticCurve { get; set; }

    /// <summary>Describes an RSA key that may be used in a Certificate issued from a CaPool. Structure is documented below.</summary>
    [JsonPropertyName("rsa")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesRsa>? Rsa { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
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
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesNameConstraints
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
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValues
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicyIdentityConstraints
{
    /// <summary>If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>If this is set, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/cel-guide Structure is documented below.</summary>
    [JsonPropertyName("celExpression")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyIdentityConstraintsCelExpression>? CelExpression { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderIssuancePolicy
{
    /// <summary>IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedIssuanceModes>? AllowedIssuanceModes { get; set; }

    /// <summary>If any AllowedKeyType is specified, then the certificate request's public key must match one of the key types listed here. Otherwise, any key may be used. Structure is documented below.</summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate issuance request will fail. Structure is documented below.</summary>
    [JsonPropertyName("baselineValues")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyBaselineValues>? BaselineValues { get; set; }

    /// <summary>Describes constraints on identities that may appear in Certificates issued through this CaPool. If this is omitted, then this CaPool will not add restrictions on a certificate's identity. Structure is documented below.</summary>
    [JsonPropertyName("identityConstraints")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicyIdentityConstraints>? IdentityConstraints { get; set; }

    /// <summary>The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority expires before a Certificate's requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProviderPublishingOptions
{
    /// <summary>Specifies the encoding format of each CertificateAuthority's CA certificate and CRLs. If this is omitted, CA certificates and CRLs will be published in PEM. Possible values are: PEM, DER.</summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CA certificate and includes its URL in the "Authority Information Access" X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding X.509 extension will not be written in issued certificates.</summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CRL and includes its URL in the "CRL Distribution Points" X.509 extension in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.</summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecInitProvider
{
    /// <summary>The IssuancePolicy to control how Certificates will be issued from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("issuancePolicy")]
    public IList<V1beta1CAPoolSpecInitProviderIssuancePolicy>? IssuancePolicy { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("publishingOptions")]
    public IList<V1beta1CAPoolSpecInitProviderPublishingOptions>? PublishingOptions { get; set; }

    /// <summary>The Tier of this CaPool. Possible values are: ENTERPRISE, DEVOPS.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CAPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CAPoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CAPoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CAPoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CAPoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CAPoolSpec defines the desired state of CAPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CAPoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CAPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CAPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CAPoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CAPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>The algorithm used. Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service will not enforce an explicit upper bound on RSA modulus sizes.</summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the service-level min RSA modulus size will continue to apply.</summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>Represents an allowed Elliptic Curve key type. Structure is documented below.</summary>
    [JsonPropertyName("ellipticCurve")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesEllipticCurve>? EllipticCurve { get; set; }

    /// <summary>Describes an RSA key that may be used in a Certificate issued from a CaPool. Structure is documented below.</summary>
    [JsonPropertyName("rsa")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesRsa>? Rsa { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the "CA" in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Refers to the "path length constraint" in Basic Constraints extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>When true, the "CA" in Basic Constraints extension will be set to false. If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>When true, the "path length constraint" in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
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
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>Describes high-level ways in which a key may be used. Structure is documented below.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages. Structure is documented below.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesNameConstraints
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
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValues
{
    /// <summary>Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs. Structure is documented below.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the "Authority Information Access" extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Describes values that are relevant in a CA certificate. Structure is documented below.</summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesCaOptions>? CaOptions { get; set; }

    /// <summary>Indicates the intended use for keys that correspond to a certificate. Structure is documented below.</summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsage>? KeyUsage { get; set; }

    /// <summary>Describes the X.509 name constraints extension. Structure is documented below.</summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesNameConstraints>? NameConstraints { get; set; }

    /// <summary>Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4. Structure is documented below.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Location of the CaPool. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicyIdentityConstraints
{
    /// <summary>If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>If this is set, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/cel-guide Structure is documented below.</summary>
    [JsonPropertyName("celExpression")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyIdentityConstraintsCelExpression>? CelExpression { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderIssuancePolicy
{
    /// <summary>IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedIssuanceModes>? AllowedIssuanceModes { get; set; }

    /// <summary>If any AllowedKeyType is specified, then the certificate request's public key must match one of the key types listed here. Otherwise, any key may be used. Structure is documented below.</summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate issuance request will fail. Structure is documented below.</summary>
    [JsonPropertyName("baselineValues")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyBaselineValues>? BaselineValues { get; set; }

    /// <summary>Describes constraints on identities that may appear in Certificates issued through this CaPool. If this is omitted, then this CaPool will not add restrictions on a certificate's identity. Structure is documented below.</summary>
    [JsonPropertyName("identityConstraints")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicyIdentityConstraints>? IdentityConstraints { get; set; }

    /// <summary>The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority expires before a Certificate's requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProviderPublishingOptions
{
    /// <summary>Specifies the encoding format of each CertificateAuthority's CA certificate and CRLs. If this is omitted, CA certificates and CRLs will be published in PEM. Possible values are: PEM, DER.</summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CA certificate and includes its URL in the "Authority Information Access" X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding X.509 extension will not be written in issued certificates.</summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>When true, publishes each CertificateAuthority's CRL and includes its URL in the "CRL Distribution Points" X.509 extension in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.</summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusAtProvider
{
    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/caPools/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IssuancePolicy to control how Certificates will be issued from this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("issuancePolicy")]
    public IList<V1beta1CAPoolStatusAtProviderIssuancePolicy>? IssuancePolicy { get; set; }

    /// <summary>Labels with user-defined metadata. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Location of the CaPool. A full list of valid locations can be found by running gcloud privateca locations list.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool. Structure is documented below.</summary>
    [JsonPropertyName("publishingOptions")]
    public IList<V1beta1CAPoolStatusAtProviderPublishingOptions>? PublishingOptions { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The Tier of this CaPool. Possible values are: ENTERPRISE, DEVOPS.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatusConditions
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

/// <summary>CAPoolStatus defines the observed state of CAPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CAPoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CAPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CAPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CAPool is the Schema for the CAPools API. A CaPool represents a group of CertificateAuthorities that form a trust anchor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CAPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CAPoolSpec>, IStatus<V1beta1CAPoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CAPool";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "capools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CAPoolSpec defines the desired state of CAPool</summary>
    [JsonPropertyName("spec")]
    public V1beta1CAPoolSpec Spec { get; set; }

    /// <summary>CAPoolStatus defines the observed state of CAPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1CAPoolStatus? Status { get; set; }
}