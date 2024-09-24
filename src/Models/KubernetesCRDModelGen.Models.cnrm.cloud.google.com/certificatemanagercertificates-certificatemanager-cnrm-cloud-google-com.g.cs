using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificateSpecManagedAuthorizationAttemptInfo
{
    /// <summary>Human readable explanation for reaching the state. Provided to help address the configuration issues. Not guaranteed to be stable. For programmatic access use 'failure_reason' field.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Domain name of the authorization attempt.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Reason for failure of the authorization attempt for the domain.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>State of the domain for managed certificate issuance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specified, but not both.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecManagedDnsAuthorizationsRefs
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/global/dnsAuthorizations/{{value}}`, where {{value}} is the `name` field of a `CertificateManagerDNSAuthorization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only the `external` field is supported to configure the reference.  Immutable. The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*. If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa. Either issuanceConfig or dnsAuthorizations should be specified, but not both.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecManagedIssuanceConfigRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/{{location}}/certificateIssuanceConfigs/{{name}}`, where {{value}} is the `name` field of a `CertificateManagerCertificateIssuanceConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificateSpecManagedProvisioningIssue
{
    /// <summary>Human readable explanation about the issue. Provided to help address the configuration issues. Not guaranteed to be stable. For programmatic access use 'reason' field.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Reason for provisioning failures.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Immutable. Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecManaged
{
    /// <summary>Detailed state of the latest authorization attempt for each domain specified for this Managed Certificate.</summary>
    [JsonPropertyName("authorizationAttemptInfo")]
    public IList<V1alpha1CertificateManagerCertificateSpecManagedAuthorizationAttemptInfo>? AuthorizationAttemptInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1alpha1CertificateManagerCertificateSpecManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>Immutable. The domains for which a managed SSL certificate will be generated. Wildcard domains are only supported with DNS challenge resolution.</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>Only the `external` field is supported to configure the reference.  Immutable. The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*. If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa. Either issuanceConfig or dnsAuthorizations should be specified, but not both.</summary>
    [JsonPropertyName("issuanceConfigRef")]
    public V1alpha1CertificateManagerCertificateSpecManagedIssuanceConfigRef? IssuanceConfigRef { get; set; }

    /// <summary>Information about issues with provisioning this Managed Certificate.</summary>
    [JsonPropertyName("provisioningIssue")]
    public IList<V1alpha1CertificateManagerCertificateSpecManagedProvisioningIssue>? ProvisioningIssue { get; set; }

    /// <summary>A state of this Managed Certificate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DEPRECATED. `certificate_pem` is deprecated. Use `pem_certificate` instead. Immutable. The certificate chain in PEM-encoded form.  Leaf certificate comes first, followed by intermediate ones if any.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePem
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DEPRECATED. `private_key_pem` is deprecated. Use `pem_private_key` instead. Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPem
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFrom? ValueFrom { get; set; }
}

/// <summary>Immutable. Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility.</summary>
public partial class V1alpha1CertificateManagerCertificateSpecSelfManaged
{
    /// <summary>DEPRECATED. `certificate_pem` is deprecated. Use `pem_certificate` instead. Immutable. The certificate chain in PEM-encoded form.  Leaf certificate comes first, followed by intermediate ones if any.</summary>
    [JsonPropertyName("certificatePem")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedCertificatePem? CertificatePem { get; set; }

    /// <summary>Immutable. The certificate chain in PEM-encoded form.  Leaf certificate comes first, followed by intermediate ones if any.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
    [JsonPropertyName("pemPrivateKey")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPemPrivateKey? PemPrivateKey { get; set; }

    /// <summary>DEPRECATED. `private_key_pem` is deprecated. Use `pem_private_key` instead. Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
    [JsonPropertyName("privateKeyPem")]
    public V1alpha1CertificateManagerCertificateSpecSelfManagedPrivateKeyPem? PrivateKeyPem { get; set; }
}

/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificateSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The Certificate Manager location. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Configuration and state of a Managed Certificate. Certificate Manager provisions and renews Managed Certificates automatically, for as long as it's authorized to do so.</summary>
    [JsonPropertyName("managed")]
    public V1alpha1CertificateManagerCertificateSpecManaged? Managed { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CertificateManagerCertificateSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The scope of the certificate.  DEFAULT: Certificates with default scope are served from core Google data centers. If unsure, choose this option.  EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from non-core Google data centers.  ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs). see https://cloud.google.com/compute/docs/regions-zones.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Immutable. Certificate data for a SelfManaged Certificate. SelfManaged Certificates are uploaded by the user. Updating such certificates before they expire remains the user's responsibility.</summary>
    [JsonPropertyName("selfManaged")]
    public V1alpha1CertificateManagerCertificateSpecSelfManaged? SelfManaged { get; set; }
}

/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificateStatusConditions
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

/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CertificateManagerCertificateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1CertificateManagerCertificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateManagerCertificateSpec>, IStatus<V1alpha1CertificateManagerCertificateStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateManagerCertificate";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificates";
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
    public V1alpha1CertificateManagerCertificateSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1CertificateManagerCertificateStatus? Status { get; set; }
}