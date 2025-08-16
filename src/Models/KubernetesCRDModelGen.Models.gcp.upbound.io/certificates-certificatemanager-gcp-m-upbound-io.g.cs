using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.gcp.m.upbound.io;
/// <summary>Certificate is the Schema for the Certificates API. Certificate represents a HTTP-reachable backend for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Certificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "certificatemanager.gcp.m.upbound.io";
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDnsAuthorizationsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDnsAuthorizationsSelector
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
    public V1beta1CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDomainsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDomainsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderManagedDomainsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDomainsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManagedDomainsSelector
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
    public V1beta1CertificateSpecForProviderManagedDomainsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderManaged
{
    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1beta1CertificateSpecForProviderManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsSelector")]
    public V1beta1CertificateSpecForProviderManagedDnsAuthorizationsSelector? DnsAuthorizationsSelector { get; set; }

    /// <summary>The domains for which a managed SSL certificate will be generated. Wildcard domains are only supported with DNS challenge resolution</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsRefs")]
    public IList<V1beta1CertificateSpecForProviderManagedDomainsRefs>? DomainsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsSelector")]
    public V1beta1CertificateSpecForProviderManagedDomainsSelector? DomainsSelector { get; set; }

    /// <summary>The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*. If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }
}

/// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderSelfManagedCertificatePemSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderSelfManagedPemPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderSelfManagedPrivateKeyPemSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderSelfManaged
{
    /// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("certificatePemSecretRef")]
    public V1beta1CertificateSpecForProviderSelfManagedCertificatePemSecretRef? CertificatePemSecretRef { get; set; }

    /// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("pemPrivateKeySecretRef")]
    public V1beta1CertificateSpecForProviderSelfManagedPemPrivateKeySecretRef? PemPrivateKeySecretRef { get; set; }

    /// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("privateKeyPemSecretRef")]
    public V1beta1CertificateSpecForProviderSelfManagedPrivateKeyPemSecretRef? PrivateKeyPemSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProvider
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of label tags associated with the Certificate resource. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Certificate Manager location. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
    [JsonPropertyName("managed")]
    public V1beta1CertificateSpecForProviderManaged? Managed { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The scope of the certificate. DEFAULT: Certificates with default scope are served from core Google data centers. If unsure, choose this option. EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence. See https://cloud.google.com/vpc/docs/edge-locations. ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs). See https://cloud.google.com/compute/docs/regions-zones. CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured. See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
    [JsonPropertyName("selfManaged")]
    public V1beta1CertificateSpecForProviderSelfManaged? SelfManaged { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsSelector
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
    public V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDomainsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDomainsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderManagedDomainsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDomainsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManagedDomainsSelector
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
    public V1beta1CertificateSpecInitProviderManagedDomainsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderManaged
{
    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsSelector")]
    public V1beta1CertificateSpecInitProviderManagedDnsAuthorizationsSelector? DnsAuthorizationsSelector { get; set; }

    /// <summary>The domains for which a managed SSL certificate will be generated. Wildcard domains are only supported with DNS challenge resolution</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsRefs")]
    public IList<V1beta1CertificateSpecInitProviderManagedDomainsRefs>? DomainsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsSelector")]
    public V1beta1CertificateSpecInitProviderManagedDomainsSelector? DomainsSelector { get; set; }

    /// <summary>The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*. If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }
}

/// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderSelfManagedCertificatePemSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderSelfManagedPemPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderSelfManagedPrivateKeyPemSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderSelfManaged
{
    /// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("certificatePemSecretRef")]
    public V1beta1CertificateSpecInitProviderSelfManagedCertificatePemSecretRef? CertificatePemSecretRef { get; set; }

    /// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("pemPrivateKeySecretRef")]
    public V1beta1CertificateSpecInitProviderSelfManagedPemPrivateKeySecretRef? PemPrivateKeySecretRef { get; set; }

    /// <summary>The private key of the leaf certificate in PEM-encoded form. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("privateKeyPemSecretRef")]
    public V1beta1CertificateSpecInitProviderSelfManagedPrivateKeyPemSecretRef? PrivateKeyPemSecretRef { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProvider
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Set of label tags associated with the Certificate resource. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
    [JsonPropertyName("managed")]
    public V1beta1CertificateSpecInitProviderManaged? Managed { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The scope of the certificate. DEFAULT: Certificates with default scope are served from core Google data centers. If unsure, choose this option. EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence. See https://cloud.google.com/vpc/docs/edge-locations. ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs). See https://cloud.google.com/compute/docs/regions-zones. CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured. See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
    [JsonPropertyName("selfManaged")]
    public V1beta1CertificateSpecInitProviderSelfManaged? SelfManaged { get; set; }
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderManagedAuthorizationAttemptInfo
{
    /// <summary>(Output) Human readable explanation about the issue. Provided to help address the configuration issues. Not guaranteed to be stable. For programmatic access use reason field.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>(Output) Domain name of the authorization attempt.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>(Output) Reason for failure of the authorization attempt for the domain.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>(Output) A state of this Managed Certificate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderManagedProvisioningIssue
{
    /// <summary>(Output) Human readable explanation about the issue. Provided to help address the configuration issues. Not guaranteed to be stable. For programmatic access use reason field.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>(Output) Reason for provisioning failures.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderManaged
{
    /// <summary>(Output) Detailed state of the latest authorization attempt for each domain specified for this Managed Certificate. Structure is documented below.</summary>
    [JsonPropertyName("authorizationAttemptInfo")]
    public IList<V1beta1CertificateStatusAtProviderManagedAuthorizationAttemptInfo>? AuthorizationAttemptInfo { get; set; }

    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>The domains for which a managed SSL certificate will be generated. Wildcard domains are only supported with DNS challenge resolution</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*. If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }

    /// <summary>(Output) Information about issues with provisioning this Managed Certificate. Structure is documented below.</summary>
    [JsonPropertyName("provisioningIssue")]
    public IList<V1beta1CertificateStatusAtProviderManagedProvisioningIssue>? ProvisioningIssue { get; set; }

    /// <summary>(Output) A state of this Managed Certificate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProviderSelfManaged
{
    /// <summary>The certificate chain in PEM-encoded form. Leaf certificate comes first, followed by intermediate ones if any.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProvider
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/certificates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Set of label tags associated with the Certificate resource. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Certificate Manager location. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so. Structure is documented below.</summary>
    [JsonPropertyName("managed")]
    public V1beta1CertificateStatusAtProviderManaged? Managed { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)</summary>
    [JsonPropertyName("sanDnsnames")]
    public IList<string>? SanDnsnames { get; set; }

    /// <summary>The scope of the certificate. DEFAULT: Certificates with default scope are served from core Google data centers. If unsure, choose this option. EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence. See https://cloud.google.com/vpc/docs/edge-locations. ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs). See https://cloud.google.com/compute/docs/regions-zones. CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured. See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility. Structure is documented below.</summary>
    [JsonPropertyName("selfManaged")]
    public V1beta1CertificateStatusAtProviderSelfManaged? SelfManaged { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
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

/// <summary>Certificate is the Schema for the Certificates API. Certificate represents a HTTP-reachable backend for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateSpec>, IStatus<V1beta1CertificateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "certificatemanager.gcp.m.upbound.io";
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