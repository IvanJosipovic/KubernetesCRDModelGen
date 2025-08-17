using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acm.aws.upbound.io;
#nullable enable
/// <summary>Certificate is the Schema for the Certificates API. Requests and manages a certificate from Amazon Certificate Manager (ACM).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Certificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "acm.aws.upbound.io";
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificateAuthorityArnRefPolicy
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
/// <summary>Reference to a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificateAuthorityArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderCertificateAuthorityArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificateAuthorityArnSelectorPolicy
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
/// <summary>Selector for a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderCertificateAuthorityArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderCertificateAuthorityArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderOptions
{
    /// <summary>Whether certificate details should be added to a certificate transparency log. Valid values are ENABLED or DISABLED. See https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency for more details.</summary>
    [JsonPropertyName("certificateTransparencyLoggingPreference")]
    public string? CertificateTransparencyLoggingPreference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Certificate's PEM-formatted private key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderPrivateKeySecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderValidationOption
{
    /// <summary>Fully qualified domain name (FQDN) in the certificate.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Domain name that you want ACM to use to send you validation emails. This domain name is the suffix of the email addresses that you want ACM to use. This must be the same as the domain_name value or a superdomain of the domain_name value. For example, if you request a certificate for "testing.example.com", you can specify "example.com" for this value.</summary>
    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProvider
{
    /// <summary>ARN of an ACM PCA</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Reference to a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
    [JsonPropertyName("certificateAuthorityArnRef")]
    public V1beta1CertificateSpecForProviderCertificateAuthorityArnRef? CertificateAuthorityArnRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
    [JsonPropertyName("certificateAuthorityArnSelector")]
    public V1beta1CertificateSpecForProviderCertificateAuthorityArnSelector? CertificateAuthorityArnSelector { get; set; }

    /// <summary>Certificate's PEM-formatted public key</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate's PEM-formatted chain</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Domain name for which the certificate should be issued</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Amount of time to start automatic renewal process before expiration. Has no effect if less than 60 days. Represented by either a subset of RFC 3339 duration supporting years, months, and days (e.g., P90D), or a string such as 2160h.</summary>
    [JsonPropertyName("earlyRenewalDuration")]
    public string? EarlyRenewalDuration { get; set; }

    /// <summary>Specifies the algorithm of the public and private key pair that your Amazon issued certificate uses to encrypt data. See ACM Certificate characteristics for more details.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Configuration block used to set certificate options. Detailed below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1CertificateSpecForProviderOptions>? Options { get; set; }

    /// <summary>Certificate's PEM-formatted private key</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1CertificateSpecForProviderPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Set of domains that should be SANs in the issued certificate.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Which method to use for validation. DNS or EMAIL are valid.</summary>
    [JsonPropertyName("validationMethod")]
    public string? ValidationMethod { get; set; }

    /// <summary>Configuration block used to specify information about the initial validation of each domain name. Detailed below.</summary>
    [JsonPropertyName("validationOption")]
    public IList<V1beta1CertificateSpecForProviderValidationOption>? ValidationOption { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificateAuthorityArnRefPolicy
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
/// <summary>Reference to a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificateAuthorityArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderCertificateAuthorityArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificateAuthorityArnSelectorPolicy
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
/// <summary>Selector for a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderCertificateAuthorityArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderCertificateAuthorityArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderOptions
{
    /// <summary>Whether certificate details should be added to a certificate transparency log. Valid values are ENABLED or DISABLED. See https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency for more details.</summary>
    [JsonPropertyName("certificateTransparencyLoggingPreference")]
    public string? CertificateTransparencyLoggingPreference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Certificate's PEM-formatted private key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderPrivateKeySecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderValidationOption
{
    /// <summary>Fully qualified domain name (FQDN) in the certificate.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Domain name that you want ACM to use to send you validation emails. This domain name is the suffix of the email addresses that you want ACM to use. This must be the same as the domain_name value or a superdomain of the domain_name value. For example, if you request a certificate for "testing.example.com", you can specify "example.com" for this value.</summary>
    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProvider
{
    /// <summary>ARN of an ACM PCA</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Reference to a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
    [JsonPropertyName("certificateAuthorityArnRef")]
    public V1beta1CertificateSpecInitProviderCertificateAuthorityArnRef? CertificateAuthorityArnRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in acmpca to populate certificateAuthorityArn.</summary>
    [JsonPropertyName("certificateAuthorityArnSelector")]
    public V1beta1CertificateSpecInitProviderCertificateAuthorityArnSelector? CertificateAuthorityArnSelector { get; set; }

    /// <summary>Certificate's PEM-formatted public key</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate's PEM-formatted chain</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Domain name for which the certificate should be issued</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Amount of time to start automatic renewal process before expiration. Has no effect if less than 60 days. Represented by either a subset of RFC 3339 duration supporting years, months, and days (e.g., P90D), or a string such as 2160h.</summary>
    [JsonPropertyName("earlyRenewalDuration")]
    public string? EarlyRenewalDuration { get; set; }

    /// <summary>Specifies the algorithm of the public and private key pair that your Amazon issued certificate uses to encrypt data. See ACM Certificate characteristics for more details.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Configuration block used to set certificate options. Detailed below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1CertificateSpecInitProviderOptions>? Options { get; set; }

    /// <summary>Certificate's PEM-formatted private key</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1CertificateSpecInitProviderPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Set of domains that should be SANs in the issued certificate.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Which method to use for validation. DNS or EMAIL are valid.</summary>
    [JsonPropertyName("validationMethod")]
    public string? ValidationMethod { get; set; }

    /// <summary>Configuration block used to specify information about the initial validation of each domain name. Detailed below.</summary>
    [JsonPropertyName("validationOption")]
    public IList<V1beta1CertificateSpecInitProviderValidationOption>? ValidationOption { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecProviderConfigRefPolicy
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
public partial class V1beta1CertificateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecWriteConnectionSecretToRef
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
/// <summary>CertificateSpec defines the desired state of Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CertificateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CertificateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CertificateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CertificateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderDomainValidationOptions
{
    /// <summary>Fully qualified domain name (FQDN) in the certificate.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the DNS record to create to validate the certificate</summary>
    [JsonPropertyName("resourceRecordName")]
    public string? ResourceRecordName { get; set; }

    /// <summary>The type of DNS record to create</summary>
    [JsonPropertyName("resourceRecordType")]
    public string? ResourceRecordType { get; set; }

    /// <summary>The value the DNS record needs to have</summary>
    [JsonPropertyName("resourceRecordValue")]
    public string? ResourceRecordValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderOptions
{
    /// <summary>Whether certificate details should be added to a certificate transparency log. Valid values are ENABLED or DISABLED. See https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency for more details.</summary>
    [JsonPropertyName("certificateTransparencyLoggingPreference")]
    public string? CertificateTransparencyLoggingPreference { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderRenewalSummary
{
    /// <summary>The status of ACM's managed renewal of the certificate</summary>
    [JsonPropertyName("renewalStatus")]
    public string? RenewalStatus { get; set; }

    /// <summary>The reason that a renewal request was unsuccessful or is pending</summary>
    [JsonPropertyName("renewalStatusReason")]
    public string? RenewalStatusReason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderValidationOption
{
    /// <summary>Fully qualified domain name (FQDN) in the certificate.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Domain name that you want ACM to use to send you validation emails. This domain name is the suffix of the email addresses that you want ACM to use. This must be the same as the domain_name value or a superdomain of the domain_name value. For example, if you request a certificate for "testing.example.com", you can specify "example.com" for this value.</summary>
    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProvider
{
    /// <summary>ARN of the certificate</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of an ACM PCA</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Certificate's PEM-formatted public key</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate's PEM-formatted chain</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Domain name for which the certificate should be issued</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Set of domain validation objects which can be used to complete certificate validation. Can have more than one element, e.g., if SANs are defined. Only set if DNS-validation was used.</summary>
    [JsonPropertyName("domainValidationOptions")]
    public IList<V1beta1CertificateStatusAtProviderDomainValidationOptions>? DomainValidationOptions { get; set; }

    /// <summary>Amount of time to start automatic renewal process before expiration. Has no effect if less than 60 days. Represented by either a subset of RFC 3339 duration supporting years, months, and days (e.g., P90D), or a string such as 2160h.</summary>
    [JsonPropertyName("earlyRenewalDuration")]
    public string? EarlyRenewalDuration { get; set; }

    /// <summary>ARN of the certificate</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the algorithm of the public and private key pair that your Amazon issued certificate uses to encrypt data. See ACM Certificate characteristics for more details.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Expiration date and time of the certificate.</summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>Start of the validity period of the certificate.</summary>
    [JsonPropertyName("notBefore")]
    public string? NotBefore { get; set; }

    /// <summary>Configuration block used to set certificate options. Detailed below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1CertificateStatusAtProviderOptions>? Options { get; set; }

    /// <summary>true if a Private certificate eligible for managed renewal is within the early_renewal_duration period.</summary>
    [JsonPropertyName("pendingRenewal")]
    public bool? PendingRenewal { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether the certificate is eligible for managed renewal.</summary>
    [JsonPropertyName("renewalEligibility")]
    public string? RenewalEligibility { get; set; }

    /// <summary>Contains information about the status of ACM's managed renewal for the certificate.</summary>
    [JsonPropertyName("renewalSummary")]
    public IList<V1beta1CertificateStatusAtProviderRenewalSummary>? RenewalSummary { get; set; }

    /// <summary>Status of the certificate.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Set of domains that should be SANs in the issued certificate.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Source of the certificate.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>List of addresses that received a validation email. Only set if EMAIL validation was used.</summary>
    [JsonPropertyName("validationEmails")]
    public IList<string>? ValidationEmails { get; set; }

    /// <summary>Which method to use for validation. DNS or EMAIL are valid.</summary>
    [JsonPropertyName("validationMethod")]
    public string? ValidationMethod { get; set; }

    /// <summary>Configuration block used to specify information about the initial validation of each domain name. Detailed below.</summary>
    [JsonPropertyName("validationOption")]
    public IList<V1beta1CertificateStatusAtProviderValidationOption>? ValidationOption { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Certificate is the Schema for the Certificates API. Requests and manages a certificate from Amazon Certificate Manager (ACM).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateSpec>, IStatus<V1beta1CertificateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "acm.aws.upbound.io";
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
#nullable disable
