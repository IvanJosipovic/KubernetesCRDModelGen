using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.m.upbound.io;
/// <summary>FrontdoorCustomDomain is the Schema for the FrontdoorCustomDomains API. Manages a Front Door (standard/premium) Custom Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorCustomDomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorCustomDomain>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorCustomDomainList";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
    public const string KubePluralName = "frontdoorcustomdomains";
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
    public IList<V1beta1FrontdoorCustomDomain> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdSelector
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
    public V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DNSZone in network to populate dnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DNSZone in network to populate dnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdSelector
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
    public V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A tls block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProviderTls
{
    /// <summary>Resource ID of the Front Door Secret.</summary>
    [JsonPropertyName("cdnFrontdoorSecretId")]
    public string? CdnFrontdoorSecretId { get; set; }

    /// <summary>Defines the source of the SSL certificate. Possible values include CustomerCertificate and ManagedCertificate. Defaults to ManagedCertificate.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }

    /// <summary>TLS protocol version that will be used for Https. Possible values are TLS12. Defaults to TLS12.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecForProvider
{
    /// <summary>The ID of the Front Door Profile. Changing this forces a new Front Door Custom Domain to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdRef")]
    public V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdRef? CdnFrontdoorProfileIdRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdSelector")]
    public V1beta1FrontdoorCustomDomainSpecForProviderCdnFrontdoorProfileIdSelector? CdnFrontdoorProfileIdSelector { get; set; }

    /// <summary>The ID of the Azure DNS Zone which should be used for this Front Door Custom Domain. If you are using Azure to host your DNS domains, you must delegate the domain provider's domain name system (DNS) to an Azure DNS Zone. For more information, see Delegate a domain to Azure DNS. Otherwise, if you're using your own domain provider to handle your DNS, you must validate the Front Door Custom Domain by creating the DNS TXT records manually.</summary>
    [JsonPropertyName("dnsZoneId")]
    public string? DnsZoneId { get; set; }

    /// <summary>Reference to a DNSZone in network to populate dnsZoneId.</summary>
    [JsonPropertyName("dnsZoneIdRef")]
    public V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdRef? DnsZoneIdRef { get; set; }

    /// <summary>Selector for a DNSZone in network to populate dnsZoneId.</summary>
    [JsonPropertyName("dnsZoneIdSelector")]
    public V1beta1FrontdoorCustomDomainSpecForProviderDnsZoneIdSelector? DnsZoneIdSelector { get; set; }

    /// <summary>The host name of the domain. The host_name field must be the FQDN of your domain(e.g. contoso.fabrikam.com). Changing this forces a new Front Door Custom Domain to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A tls block as defined below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1FrontdoorCustomDomainSpecForProviderTls? Tls { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DNSZone in network to populate dnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DNSZone in network to populate dnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdSelector
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
    public V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A tls block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProviderTls
{
    /// <summary>Resource ID of the Front Door Secret.</summary>
    [JsonPropertyName("cdnFrontdoorSecretId")]
    public string? CdnFrontdoorSecretId { get; set; }

    /// <summary>Defines the source of the SSL certificate. Possible values include CustomerCertificate and ManagedCertificate. Defaults to ManagedCertificate.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }

    /// <summary>TLS protocol version that will be used for Https. Possible values are TLS12. Defaults to TLS12.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecInitProvider
{
    /// <summary>The ID of the Azure DNS Zone which should be used for this Front Door Custom Domain. If you are using Azure to host your DNS domains, you must delegate the domain provider's domain name system (DNS) to an Azure DNS Zone. For more information, see Delegate a domain to Azure DNS. Otherwise, if you're using your own domain provider to handle your DNS, you must validate the Front Door Custom Domain by creating the DNS TXT records manually.</summary>
    [JsonPropertyName("dnsZoneId")]
    public string? DnsZoneId { get; set; }

    /// <summary>Reference to a DNSZone in network to populate dnsZoneId.</summary>
    [JsonPropertyName("dnsZoneIdRef")]
    public V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdRef? DnsZoneIdRef { get; set; }

    /// <summary>Selector for a DNSZone in network to populate dnsZoneId.</summary>
    [JsonPropertyName("dnsZoneIdSelector")]
    public V1beta1FrontdoorCustomDomainSpecInitProviderDnsZoneIdSelector? DnsZoneIdSelector { get; set; }

    /// <summary>The host name of the domain. The host_name field must be the FQDN of your domain(e.g. contoso.fabrikam.com). Changing this forces a new Front Door Custom Domain to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A tls block as defined below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1FrontdoorCustomDomainSpecInitProviderTls? Tls { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpecProviderConfigRef
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
public partial class V1beta1FrontdoorCustomDomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FrontdoorCustomDomainSpec defines the desired state of FrontdoorCustomDomain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorCustomDomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorCustomDomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorCustomDomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorCustomDomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A tls block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainStatusAtProviderTls
{
    /// <summary>Resource ID of the Front Door Secret.</summary>
    [JsonPropertyName("cdnFrontdoorSecretId")]
    public string? CdnFrontdoorSecretId { get; set; }

    /// <summary>Defines the source of the SSL certificate. Possible values include CustomerCertificate and ManagedCertificate. Defaults to ManagedCertificate.</summary>
    [JsonPropertyName("certificateType")]
    public string? CertificateType { get; set; }

    /// <summary>TLS protocol version that will be used for Https. Possible values are TLS12. Defaults to TLS12.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainStatusAtProvider
{
    /// <summary>The ID of the Front Door Profile. Changing this forces a new Front Door Custom Domain to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>The ID of the Azure DNS Zone which should be used for this Front Door Custom Domain. If you are using Azure to host your DNS domains, you must delegate the domain provider's domain name system (DNS) to an Azure DNS Zone. For more information, see Delegate a domain to Azure DNS. Otherwise, if you're using your own domain provider to handle your DNS, you must validate the Front Door Custom Domain by creating the DNS TXT records manually.</summary>
    [JsonPropertyName("dnsZoneId")]
    public string? DnsZoneId { get; set; }

    /// <summary>The date time that the token expires.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The host name of the domain. The host_name field must be the FQDN of your domain(e.g. contoso.fabrikam.com). Changing this forces a new Front Door Custom Domain to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Front Door Custom Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A tls block as defined below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1FrontdoorCustomDomainStatusAtProviderTls? Tls { get; set; }

    /// <summary>Challenge used for DNS TXT record or file based validation.</summary>
    [JsonPropertyName("validationToken")]
    public string? ValidationToken { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainStatusConditions
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

/// <summary>FrontdoorCustomDomainStatus defines the observed state of FrontdoorCustomDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorCustomDomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorCustomDomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorCustomDomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorCustomDomain is the Schema for the FrontdoorCustomDomains API. Manages a Front Door (standard/premium) Custom Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorCustomDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorCustomDomainSpec>, IStatus<V1beta1FrontdoorCustomDomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorCustomDomain";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
    public const string KubePluralName = "frontdoorcustomdomains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorCustomDomainSpec defines the desired state of FrontdoorCustomDomain</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorCustomDomainSpec Spec { get; set; }

    /// <summary>FrontdoorCustomDomainStatus defines the observed state of FrontdoorCustomDomain.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorCustomDomainStatus? Status { get; set; }
}