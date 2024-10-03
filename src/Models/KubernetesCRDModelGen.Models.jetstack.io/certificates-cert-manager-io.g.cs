using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certmanager.io;
/// <summary>CertificateAdditionalOutputFormat defines an additional output format of a Certificate resource. These contain supplementary data formats of the signed certificate chain and paired private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecAdditionalOutputFormats
{
    /// <summary>Type is the name of the format type that should be written to the Certificate's target Secret.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace.  The `name` field of the reference must always be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecIssuerRef
{
    /// <summary>Group of the resource being referred to.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind of the resource being referred to.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the resource being referred to.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the JKS keystore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresJksPasswordSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>JKS configures options for storing a JKS keystore in the `spec.secretName` Secret resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresJks
{
    /// <summary>Alias specifies the alias of the key in the keystore, required by the JKS format. If not provided, the default alias `certificate` will be used.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>Create enables JKS keystore creation for the Certificate. If true, a file named `keystore.jks` will be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef`. The keystore file will be updated immediately. If the issuer provided a CA certificate, a file named `truststore.jks` will also be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef` containing the issuing Certificate Authority</summary>
    [JsonPropertyName("create")]
    public bool Create { get; set; }

    /// <summary>PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the JKS keystore.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1CertificateSpecKeystoresJksPasswordSecretRef PasswordSecretRef { get; set; }
}

/// <summary>PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the PKCS12 keystore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresPkcs12PasswordSecretRef
{
    /// <summary>The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PKCS12 configures options for storing a PKCS12 keystore in the `spec.secretName` Secret resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresPkcs12
{
    /// <summary>Create enables PKCS12 keystore creation for the Certificate. If true, a file named `keystore.p12` will be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef`. The keystore file will be updated immediately. If the issuer provided a CA certificate, a file named `truststore.p12` will also be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef` containing the issuing Certificate Authority</summary>
    [JsonPropertyName("create")]
    public bool Create { get; set; }

    /// <summary>PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the PKCS12 keystore.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1CertificateSpecKeystoresPkcs12PasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Profile specifies the key and certificate encryption algorithms and the HMAC algorithm used to create the PKCS12 keystore. Default value is `LegacyRC2` for backward compatibility.  If provided, allowed values are: `LegacyRC2`: Deprecated. Not supported by default in OpenSSL 3 or Java 20. `LegacyDES`: Less secure algorithm. Use this option for maximal compatibility. `Modern2023`: Secure algorithm. Use this option in case you have to always use secure algorithms (eg. because of company policy). Please note that the security of the algorithm is not that important in reality, because the unencrypted certificate and private key are also stored in the Secret.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }
}

/// <summary>Additional keystore output formats to be stored in the Certificate's Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystores
{
    /// <summary>JKS configures options for storing a JKS keystore in the `spec.secretName` Secret resource.</summary>
    [JsonPropertyName("jks")]
    public V1CertificateSpecKeystoresJks? Jks { get; set; }

    /// <summary>PKCS12 configures options for storing a PKCS12 keystore in the `spec.secretName` Secret resource.</summary>
    [JsonPropertyName("pkcs12")]
    public V1CertificateSpecKeystoresPkcs12? Pkcs12 { get; set; }
}

/// <summary>Excluded contains the constraints which must be disallowed. Any name matching a restriction in the excluded field is invalid regardless of information appearing in the permitted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraintsExcluded
{
    /// <summary>DNSDomains is a list of DNS domains that are permitted or excluded.</summary>
    [JsonPropertyName("dnsDomains")]
    public IList<string>? DnsDomains { get; set; }

    /// <summary>EmailAddresses is a list of Email Addresses that are permitted or excluded.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>IPRanges is a list of IP Ranges that are permitted or excluded. This should be a valid CIDR notation.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>URIDomains is a list of URI domains that are permitted or excluded.</summary>
    [JsonPropertyName("uriDomains")]
    public IList<string>? UriDomains { get; set; }
}

/// <summary>Permitted contains the constraints in which the names must be located.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraintsPermitted
{
    /// <summary>DNSDomains is a list of DNS domains that are permitted or excluded.</summary>
    [JsonPropertyName("dnsDomains")]
    public IList<string>? DnsDomains { get; set; }

    /// <summary>EmailAddresses is a list of Email Addresses that are permitted or excluded.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>IPRanges is a list of IP Ranges that are permitted or excluded. This should be a valid CIDR notation.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>URIDomains is a list of URI domains that are permitted or excluded.</summary>
    [JsonPropertyName("uriDomains")]
    public IList<string>? UriDomains { get; set; }
}

/// <summary>x.509 certificate NameConstraint extension which MUST NOT be used in a non-CA certificate. More Info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.10  This is an Alpha Feature and is only enabled with the `--feature-gates=NameConstraints=true` option set on both the controller and webhook components.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraints
{
    /// <summary>if true then the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Excluded contains the constraints which must be disallowed. Any name matching a restriction in the excluded field is invalid regardless of information appearing in the permitted</summary>
    [JsonPropertyName("excluded")]
    public V1CertificateSpecNameConstraintsExcluded? Excluded { get; set; }

    /// <summary>Permitted contains the constraints in which the names must be located.</summary>
    [JsonPropertyName("permitted")]
    public V1CertificateSpecNameConstraintsPermitted? Permitted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecOtherNames
{
    /// <summary>OID is the object identifier for the otherName SAN. The object identifier must be expressed as a dotted string, for example, "1.2.840.113556.1.4.221".</summary>
    [JsonPropertyName("oid")]
    public string? Oid { get; set; }

    /// <summary>utf8Value is the string value of the otherName SAN. The utf8Value accepts any valid UTF8 string to set as value for the otherName SAN.</summary>
    [JsonPropertyName("utf8Value")]
    public string? Utf8Value { get; set; }
}

/// <summary>Private key options. These include the key algorithm and size, the used encoding and the rotation policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecPrivateKey
{
    /// <summary>Algorithm is the private key algorithm of the corresponding private key for this certificate.  If provided, allowed values are either `RSA`, `ECDSA` or `Ed25519`. If `algorithm` is specified and `size` is not provided, key size of 2048 will be used for `RSA` key algorithm and key size of 256 will be used for `ECDSA` key algorithm. key size is ignored when using the `Ed25519` key algorithm.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The private key cryptography standards (PKCS) encoding for this certificate's private key to be encoded in.  If provided, allowed values are `PKCS1` and `PKCS8` standing for PKCS#1 and PKCS#8, respectively. Defaults to `PKCS1` if not specified.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>RotationPolicy controls how private keys should be regenerated when a re-issuance is being processed.  If set to `Never`, a private key will only be generated if one does not already exist in the target `spec.secretName`. If one does exist but it does not have the correct algorithm or size, a warning will be raised to await user intervention. If set to `Always`, a private key matching the specified requirements will be generated whenever a re-issuance occurs. Default is `Never` for backward compatibility.</summary>
    [JsonPropertyName("rotationPolicy")]
    public string? RotationPolicy { get; set; }

    /// <summary>Size is the key bit size of the corresponding private key for this certificate.  If `algorithm` is set to `RSA`, valid values are `2048`, `4096` or `8192`, and will default to `2048` if not specified. If `algorithm` is set to `ECDSA`, valid values are `256`, `384` or `521`, and will default to `256` if not specified. If `algorithm` is set to `Ed25519`, Size is ignored. No other values are allowed.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary>Defines annotations and labels to be copied to the Certificate's Secret. Labels and annotations on the Secret will be changed as they appear on the SecretTemplate when added or removed. SecretTemplate annotations are added in conjunction with, and cannot overwrite, the base set of annotations cert-manager sets on the Certificate's Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecSecretTemplate
{
    /// <summary>Annotations is a key value map to be copied to the target Kubernetes Secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels is a key value map to be copied to the target Kubernetes Secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Requested set of X509 certificate subject attributes. More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6  The common name attribute is specified separately in the `commonName` field. Cannot be set if the `literalSubject` field is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecSubject
{
    /// <summary>Countries to be used on the Certificate.</summary>
    [JsonPropertyName("countries")]
    public IList<string>? Countries { get; set; }

    /// <summary>Cities to be used on the Certificate.</summary>
    [JsonPropertyName("localities")]
    public IList<string>? Localities { get; set; }

    /// <summary>Organizational Units to be used on the Certificate.</summary>
    [JsonPropertyName("organizationalUnits")]
    public IList<string>? OrganizationalUnits { get; set; }

    /// <summary>Organizations to be used on the Certificate.</summary>
    [JsonPropertyName("organizations")]
    public IList<string>? Organizations { get; set; }

    /// <summary>Postal codes to be used on the Certificate.</summary>
    [JsonPropertyName("postalCodes")]
    public IList<string>? PostalCodes { get; set; }

    /// <summary>State/Provinces to be used on the Certificate.</summary>
    [JsonPropertyName("provinces")]
    public IList<string>? Provinces { get; set; }

    /// <summary>Serial number to be used on the Certificate.</summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>Street addresses to be used on the Certificate.</summary>
    [JsonPropertyName("streetAddresses")]
    public IList<string>? StreetAddresses { get; set; }
}

/// <summary>Specification of the desired state of the Certificate resource. https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpec
{
    /// <summary>Defines extra output formats of the private key and signed certificate chain to be written to this Certificate's target Secret.  This is a Beta Feature enabled by default. It can be disabled with the `--feature-gates=AdditionalCertificateOutputFormats=false` option set on both the controller and webhook components.</summary>
    [JsonPropertyName("additionalOutputFormats")]
    public IList<V1CertificateSpecAdditionalOutputFormats>? AdditionalOutputFormats { get; set; }

    /// <summary>Requested common name X509 certificate subject attribute. More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6 NOTE: TLS clients will ignore this value when any subject alternative name is set (see https://tools.ietf.org/html/rfc6125#section-6.4.4).  Should have a length of 64 characters or fewer to avoid generating invalid CSRs. Cannot be set if the `literalSubject` field is set.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Requested DNS subject alternative names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Requested 'duration' (i.e. lifetime) of the Certificate. Note that the issuer may choose to ignore the requested duration, just like any other requested attribute.  If unset, this defaults to 90 days. Minimum accepted duration is 1 hour. Value must be in units accepted by Go time.ParseDuration https://golang.org/pkg/time/#ParseDuration.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Requested email subject alternative names.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Whether the KeyUsage and ExtKeyUsage extensions should be set in the encoded CSR.  This option defaults to true, and should only be disabled if the target issuer does not support CSRs with these X509 KeyUsage/ ExtKeyUsage extensions.</summary>
    [JsonPropertyName("encodeUsagesInRequest")]
    public bool? EncodeUsagesInRequest { get; set; }

    /// <summary>Requested IP address subject alternative names.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Requested basic constraints isCA value. The isCA value is used to set the `isCA` field on the created CertificateRequest resources. Note that the issuer may choose to ignore the requested isCA value, just like any other requested attribute.  If true, this will automatically add the `cert sign` usage to the list of requested `usages`.</summary>
    [JsonPropertyName("isCA")]
    public bool? IsCA { get; set; }

    /// <summary>Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace.  The `name` field of the reference must always be specified.</summary>
    [JsonPropertyName("issuerRef")]
    public V1CertificateSpecIssuerRef IssuerRef { get; set; }

    /// <summary>Additional keystore output formats to be stored in the Certificate's Secret.</summary>
    [JsonPropertyName("keystores")]
    public V1CertificateSpecKeystores? Keystores { get; set; }

    /// <summary>Requested X.509 certificate subject, represented using the LDAP "String Representation of a Distinguished Name" [1]. Important: the LDAP string format also specifies the order of the attributes in the subject, this is important when issuing certs for LDAP authentication. Example: `CN=foo,DC=corp,DC=example,DC=com` More info [1]: https://datatracker.ietf.org/doc/html/rfc4514 More info: https://github.com/cert-manager/cert-manager/issues/3203 More info: https://github.com/cert-manager/cert-manager/issues/4424  Cannot be set if the `subject` or `commonName` field is set.</summary>
    [JsonPropertyName("literalSubject")]
    public string? LiteralSubject { get; set; }

    /// <summary>x.509 certificate NameConstraint extension which MUST NOT be used in a non-CA certificate. More Info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.10  This is an Alpha Feature and is only enabled with the `--feature-gates=NameConstraints=true` option set on both the controller and webhook components.</summary>
    [JsonPropertyName("nameConstraints")]
    public V1CertificateSpecNameConstraints? NameConstraints { get; set; }

    /// <summary>`otherNames` is an escape hatch for SAN that allows any type. We currently restrict the support to string like otherNames, cf RFC 5280 p 37 Any UTF8 String valued otherName can be passed with by setting the keys oid: x.x.x.x and UTF8Value: somevalue for `otherName`. Most commonly this would be UPN set with oid: 1.3.6.1.4.1.311.20.2.3 You should ensure that any OID passed is valid for the UTF8String type as we do not explicitly validate this.</summary>
    [JsonPropertyName("otherNames")]
    public IList<V1CertificateSpecOtherNames>? OtherNames { get; set; }

    /// <summary>Private key options. These include the key algorithm and size, the used encoding and the rotation policy.</summary>
    [JsonPropertyName("privateKey")]
    public V1CertificateSpecPrivateKey? PrivateKey { get; set; }

    /// <summary>How long before the currently issued certificate's expiry cert-manager should renew the certificate. For example, if a certificate is valid for 60 minutes, and `renewBefore=10m`, cert-manager will begin to attempt to renew the certificate 50 minutes after it was issued (i.e. when there are 10 minutes remaining until the certificate is no longer valid).  NOTE: The actual lifetime of the issued certificate is used to determine the renewal time. If an issuer returns a certificate with a different lifetime than the one requested, cert-manager will use the lifetime of the issued certificate.  If unset, this defaults to 1/3 of the issued certificate's lifetime. Minimum accepted value is 5 minutes. Value must be in units accepted by Go time.ParseDuration https://golang.org/pkg/time/#ParseDuration. Cannot be set if the `renewBeforePercentage` field is set.</summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }

    /// <summary>`renewBeforePercentage` is like `renewBefore`, except it is a relative percentage rather than an absolute duration. For example, if a certificate is valid for 60 minutes, and  `renewBeforePercentage=25`, cert-manager will begin to attempt to renew the certificate 45 minutes after it was issued (i.e. when there are 15 minutes (25%) remaining until the certificate is no longer valid).  NOTE: The actual lifetime of the issued certificate is used to determine the renewal time. If an issuer returns a certificate with a different lifetime than the one requested, cert-manager will use the lifetime of the issued certificate.  Value must be an integer in the range (0,100). The minimum effective `renewBefore` derived from the `renewBeforePercentage` and `duration` fields is 5 minutes. Cannot be set if the `renewBefore` field is set.</summary>
    [JsonPropertyName("renewBeforePercentage")]
    public int? RenewBeforePercentage { get; set; }

    /// <summary>The maximum number of CertificateRequest revisions that are maintained in the Certificate's history. Each revision represents a single `CertificateRequest` created by this Certificate, either when it was created, renewed, or Spec was changed. Revisions will be removed by oldest first if the number of revisions exceeds this number.  If set, revisionHistoryLimit must be a value of `1` or greater. If unset (`nil`), revisions will not be garbage collected. Default value is `nil`.</summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public int? RevisionHistoryLimit { get; set; }

    /// <summary>Name of the Secret resource that will be automatically created and managed by this Certificate resource. It will be populated with a private key and certificate, signed by the denoted issuer. The Secret resource lives in the same namespace as the Certificate resource.</summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }

    /// <summary>Defines annotations and labels to be copied to the Certificate's Secret. Labels and annotations on the Secret will be changed as they appear on the SecretTemplate when added or removed. SecretTemplate annotations are added in conjunction with, and cannot overwrite, the base set of annotations cert-manager sets on the Certificate's Secret.</summary>
    [JsonPropertyName("secretTemplate")]
    public V1CertificateSpecSecretTemplate? SecretTemplate { get; set; }

    /// <summary>Requested set of X509 certificate subject attributes. More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6  The common name attribute is specified separately in the `commonName` field. Cannot be set if the `literalSubject` field is set.</summary>
    [JsonPropertyName("subject")]
    public V1CertificateSpecSubject? Subject { get; set; }

    /// <summary>Requested URI subject alternative names.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }

    /// <summary>Requested key usages and extended key usages. These usages are used to set the `usages` field on the created CertificateRequest resources. If `encodeUsagesInRequest` is unset or set to `true`, the usages will additionally be encoded in the `request` field which contains the CSR blob.  If unset, defaults to `digital signature` and `key encipherment`.</summary>
    [JsonPropertyName("usages")]
    public IList<string>? Usages { get; set; }
}

/// <summary>CertificateCondition contains condition information for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatusConditions
{
    /// <summary>LastTransitionTime is the timestamp corresponding to the last status change of this condition.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message is a human readable description of the details of the last transition, complementing reason.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>If set, this represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the Certificate.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason is a brief machine readable explanation for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of the condition, known values are (`Ready`, `Issuing`).</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status of the Certificate. This is set and managed automatically. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatus
{
    /// <summary>List of status conditions to indicate the status of certificates. Known condition types are `Ready` and `Issuing`.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>The number of continuous failed issuance attempts up till now. This field gets removed (if set) on a successful issuance and gets set to 1 if unset and an issuance has failed. If an issuance has failed, the delay till the next issuance will be calculated using formula time.Hour * 2 ^ (failedIssuanceAttempts - 1).</summary>
    [JsonPropertyName("failedIssuanceAttempts")]
    public int? FailedIssuanceAttempts { get; set; }

    /// <summary>LastFailureTime is set only if the latest issuance for this Certificate failed and contains the time of the failure. If an issuance has failed, the delay till the next issuance will be calculated using formula time.Hour * 2 ^ (failedIssuanceAttempts - 1). If the latest issuance has succeeded this field will be unset.</summary>
    [JsonPropertyName("lastFailureTime")]
    public string? LastFailureTime { get; set; }

    /// <summary>The name of the Secret resource containing the private key to be used for the next certificate iteration. The keymanager controller will automatically set this field if the `Issuing` condition is set to `True`. It will automatically unset this field when the Issuing condition is not set or False.</summary>
    [JsonPropertyName("nextPrivateKeySecretName")]
    public string? NextPrivateKeySecretName { get; set; }

    /// <summary>The expiration time of the certificate stored in the secret named by this resource in `spec.secretName`.</summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>The time after which the certificate stored in the secret named by this resource in `spec.secretName` is valid.</summary>
    [JsonPropertyName("notBefore")]
    public string? NotBefore { get; set; }

    /// <summary>RenewalTime is the time at which the certificate will be next renewed. If not set, no upcoming renewal is scheduled.</summary>
    [JsonPropertyName("renewalTime")]
    public string? RenewalTime { get; set; }

    /// <summary>The current 'revision' of the certificate as issued.  When a CertificateRequest resource is created, it will have the `cert-manager.io/certificate-revision` set to one greater than the current value of this field.  Upon issuance, this field will be set to the value of the annotation on the CertificateRequest resource used to issue the certificate.  Persisting the value on the CertificateRequest resource allows the certificates controller to know whether a request is part of an old issuance or if it is part of the ongoing revision's issuance by checking if the revision value in the annotation is greater than this field.</summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }
}

/// <summary>A Certificate resource should be created to ensure an up to date and signed X.509 certificate is stored in the Kubernetes Secret resource named in `spec.secretName`.  The stored certificate will be renewed before it expires (as configured by `spec.renewBefore`).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1CertificateSpec>, IStatus<V1CertificateStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "cert-manager.io";
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

    /// <summary>Specification of the desired state of the Certificate resource. https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1CertificateSpec? Spec { get; set; }

    /// <summary>Status of the Certificate. This is set and managed automatically. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1CertificateStatus? Status { get; set; }
}