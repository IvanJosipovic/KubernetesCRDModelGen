using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.aws.m.upbound.io;
/// <summary>DomainName is the Schema for the DomainNames API. Registers a custom domain name for use with AWS API Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainNameList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DomainName>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainNameList";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "domainnames";
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
    public IList<V1beta1DomainName> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CertificateValidation in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecForProviderCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CertificateValidation in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderCertificateArnSelector
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
    public V1beta1DomainNameSpecForProviderCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Private key associated with the domain certificate given in certificate_body. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderCertificatePrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Configuration block defining API endpoint information including type. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke a DomainName. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke a DomainName, or use dualstack to allow both IPv4 and IPv6 addresses to invoke a DomainName. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>A list of endpoint types of an API or its custom domain name. For an edge-optimized API and its custom domain name, the endpoint type is EDGE. For a regional API and its custom domain name, the endpoint type is REGIONAL. For a private API, the endpoint type is PRIVATE.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderRegionalCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CertificateValidation in acm to populate regionalCertificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderRegionalCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecForProviderRegionalCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderRegionalCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CertificateValidation in acm to populate regionalCertificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderRegionalCertificateArnSelector
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
    public V1beta1DomainNameSpecForProviderRegionalCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProvider
{
    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when an edge-optimized domain name is desired. Conflicts with certificate_name, certificate_body, certificate_chain, certificate_private_key, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a CertificateValidation in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1DomainNameSpecForProviderCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a CertificateValidation in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1DomainNameSpecForProviderCertificateArnSelector? CertificateArnSelector { get; set; }

    /// <summary>Certificate issued for the domain name being registered, in PEM format. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate for the CA that issued the certificate, along with any intermediate CA certificates required to create an unbroken chain to a certificate trusted by the intended API clients. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Unique name to use when registering this certificate as an IAM server certificate. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name. Required if certificate_arn is not set.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>Private key associated with the domain certificate given in certificate_body. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificatePrivateKeySecretRef")]
    public V1beta1DomainNameSpecForProviderCertificatePrivateKeySecretRef? CertificatePrivateKeySecretRef { get; set; }

    /// <summary>Fully-qualified domain name to register.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block defining API endpoint information including type. See below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1DomainNameSpecForProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameSpecForProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>A stringified JSON policy document that applies to the execute-api service for this DomainName regardless of the caller and Method configuration. Supported only for private custom domain names.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when a regional domain name is desired. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateArn")]
    public string? RegionalCertificateArn { get; set; }

    /// <summary>Reference to a CertificateValidation in acm to populate regionalCertificateArn.</summary>
    [JsonPropertyName("regionalCertificateArnRef")]
    public V1beta1DomainNameSpecForProviderRegionalCertificateArnRef? RegionalCertificateArnRef { get; set; }

    /// <summary>Selector for a CertificateValidation in acm to populate regionalCertificateArn.</summary>
    [JsonPropertyName("regionalCertificateArnSelector")]
    public V1beta1DomainNameSpecForProviderRegionalCertificateArnSelector? RegionalCertificateArnSelector { get; set; }

    /// <summary>User-friendly name of the certificate that will be used by regional endpoint for this domain name. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateName")]
    public string? RegionalCertificateName { get; set; }

    /// <summary>Transport Layer Security (TLS) version + cipher suite for this DomainName. Valid values are TLS_1_0 and TLS_1_2. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CertificateValidation in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecInitProviderCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CertificateValidation in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderCertificateArnSelector
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
    public V1beta1DomainNameSpecInitProviderCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Private key associated with the domain certificate given in certificate_body. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderCertificatePrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Configuration block defining API endpoint information including type. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke a DomainName. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke a DomainName, or use dualstack to allow both IPv4 and IPv6 addresses to invoke a DomainName. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>A list of endpoint types of an API or its custom domain name. For an edge-optimized API and its custom domain name, the endpoint type is EDGE. For a regional API and its custom domain name, the endpoint type is REGIONAL. For a private API, the endpoint type is PRIVATE.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderRegionalCertificateArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CertificateValidation in acm to populate regionalCertificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderRegionalCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecInitProviderRegionalCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderRegionalCertificateArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CertificateValidation in acm to populate regionalCertificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderRegionalCertificateArnSelector
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
    public V1beta1DomainNameSpecInitProviderRegionalCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProvider
{
    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when an edge-optimized domain name is desired. Conflicts with certificate_name, certificate_body, certificate_chain, certificate_private_key, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a CertificateValidation in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1DomainNameSpecInitProviderCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a CertificateValidation in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1DomainNameSpecInitProviderCertificateArnSelector? CertificateArnSelector { get; set; }

    /// <summary>Certificate issued for the domain name being registered, in PEM format. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate for the CA that issued the certificate, along with any intermediate CA certificates required to create an unbroken chain to a certificate trusted by the intended API clients. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Unique name to use when registering this certificate as an IAM server certificate. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name. Required if certificate_arn is not set.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>Private key associated with the domain certificate given in certificate_body. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificatePrivateKeySecretRef")]
    public V1beta1DomainNameSpecInitProviderCertificatePrivateKeySecretRef? CertificatePrivateKeySecretRef { get; set; }

    /// <summary>Fully-qualified domain name to register.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block defining API endpoint information including type. See below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1DomainNameSpecInitProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameSpecInitProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>A stringified JSON policy document that applies to the execute-api service for this DomainName regardless of the caller and Method configuration. Supported only for private custom domain names.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when a regional domain name is desired. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateArn")]
    public string? RegionalCertificateArn { get; set; }

    /// <summary>Reference to a CertificateValidation in acm to populate regionalCertificateArn.</summary>
    [JsonPropertyName("regionalCertificateArnRef")]
    public V1beta1DomainNameSpecInitProviderRegionalCertificateArnRef? RegionalCertificateArnRef { get; set; }

    /// <summary>Selector for a CertificateValidation in acm to populate regionalCertificateArn.</summary>
    [JsonPropertyName("regionalCertificateArnSelector")]
    public V1beta1DomainNameSpecInitProviderRegionalCertificateArnSelector? RegionalCertificateArnSelector { get; set; }

    /// <summary>User-friendly name of the certificate that will be used by regional endpoint for this domain name. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateName")]
    public string? RegionalCertificateName { get; set; }

    /// <summary>Transport Layer Security (TLS) version + cipher suite for this DomainName. Valid values are TLS_1_0 and TLS_1_2. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecProviderConfigRef
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
public partial class V1beta1DomainNameSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DomainNameSpec defines the desired state of DomainName</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainNameSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainNameSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainNameSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainNameSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block defining API endpoint information including type. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke a DomainName. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke a DomainName, or use dualstack to allow both IPv4 and IPv6 addresses to invoke a DomainName. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>A list of endpoint types of an API or its custom domain name. For an edge-optimized API and its custom domain name, the endpoint type is EDGE. For a regional API and its custom domain name, the endpoint type is REGIONAL. For a private API, the endpoint type is PRIVATE.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProvider
{
    /// <summary>ARN of domain name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when an edge-optimized domain name is desired. Conflicts with certificate_name, certificate_body, certificate_chain, certificate_private_key, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Certificate issued for the domain name being registered, in PEM format. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateBody")]
    public string? CertificateBody { get; set; }

    /// <summary>Certificate for the CA that issued the certificate, along with any intermediate CA certificates required to create an unbroken chain to a certificate trusted by the intended API clients. Only valid for EDGE endpoint configuration type. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Unique name to use when registering this certificate as an IAM server certificate. Conflicts with certificate_arn, regional_certificate_arn, and regional_certificate_name. Required if certificate_arn is not set.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>Upload date associated with the domain certificate.</summary>
    [JsonPropertyName("certificateUploadDate")]
    public string? CertificateUploadDate { get; set; }

    /// <summary>Hostname created by Cloudfront to represent the distribution that implements this domain name mapping.</summary>
    [JsonPropertyName("cloudfrontDomainName")]
    public string? CloudfrontDomainName { get; set; }

    /// <summary>For convenience, the hosted zone ID (Z2FDTNDATAQYW2) that can be used to create a Route53 alias record for the distribution.</summary>
    [JsonPropertyName("cloudfrontZoneId")]
    public string? CloudfrontZoneId { get; set; }

    /// <summary>Fully-qualified domain name to register.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The identifier for the domain name resource. Supported only for private custom domain names.</summary>
    [JsonPropertyName("domainNameId")]
    public string? DomainNameId { get; set; }

    /// <summary>Configuration block defining API endpoint information including type. See below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1DomainNameStatusAtProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Internal identifier assigned to this domain name by API Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name. See below.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameStatusAtProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>A stringified JSON policy document that applies to the execute-api service for this DomainName regardless of the caller and Method configuration. Supported only for private custom domain names.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN for an AWS-managed certificate. AWS Certificate Manager is the only supported source. Used when a regional domain name is desired. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateArn")]
    public string? RegionalCertificateArn { get; set; }

    /// <summary>User-friendly name of the certificate that will be used by regional endpoint for this domain name. Conflicts with certificate_arn, certificate_name, certificate_body, certificate_chain, and certificate_private_key.</summary>
    [JsonPropertyName("regionalCertificateName")]
    public string? RegionalCertificateName { get; set; }

    /// <summary>Hostname for the custom domain's regional endpoint.</summary>
    [JsonPropertyName("regionalDomainName")]
    public string? RegionalDomainName { get; set; }

    /// <summary>Hosted zone ID that can be used to create a Route53 alias record for the regional endpoint.</summary>
    [JsonPropertyName("regionalZoneId")]
    public string? RegionalZoneId { get; set; }

    /// <summary>Transport Layer Security (TLS) version + cipher suite for this DomainName. Valid values are TLS_1_0 and TLS_1_2. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusConditions
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

/// <summary>DomainNameStatus defines the observed state of DomainName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainNameStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainNameStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DomainName is the Schema for the DomainNames API. Registers a custom domain name for use with AWS API Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainName : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainNameSpec>, IStatus<V1beta1DomainNameStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainName";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "domainnames";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainNameSpec defines the desired state of DomainName</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainNameSpec Spec { get; set; }

    /// <summary>DomainNameStatus defines the observed state of DomainName.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainNameStatus? Status { get; set; }
}