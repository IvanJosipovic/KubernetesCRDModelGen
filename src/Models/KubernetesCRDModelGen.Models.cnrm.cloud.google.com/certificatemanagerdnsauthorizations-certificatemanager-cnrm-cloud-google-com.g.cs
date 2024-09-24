using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerDNSAuthorizationSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>CertificateManagerDNSAuthorizationSpec defines the desired state of CertificateManagerDNSAuthorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerDNSAuthorizationSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. A domain which is being authorized. A DnsAuthorization resource covers a single domain and its wildcard, e.g. authorization for "example.com" can be used to issue certificates for "example.com" and "*.example.com".</summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1CertificateManagerDNSAuthorizationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerDNSAuthorizationStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerDNSAuthorizationStatusDnsResourceRecord
{
    /// <summary>Data of the DNS Resource Record.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Fully qualified name of the DNS Resource Record. E.g. '_acme-challenge.example.com'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the DNS Resource Record.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>CertificateManagerDNSAuthorizationStatus defines the config connector machine state of CertificateManagerDNSAuthorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerDNSAuthorizationStatus
{
    /// <summary>Conditions represent the latest available observations of the CertificateManagerDNSAuthorization's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateManagerDNSAuthorizationStatusConditions>? Conditions { get; set; }

    /// <summary>The structure describing the DNS Resource Record that needs to be added to DNS configuration for the authorization to be usable by certificate.</summary>
    [JsonPropertyName("dnsResourceRecord")]
    public IList<V1beta1CertificateManagerDNSAuthorizationStatusDnsResourceRecord>? DnsResourceRecord { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CertificateManagerDNSAuthorization is the Schema for the CertificateManagerDNSAuthorization API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateManagerDNSAuthorization : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateManagerDNSAuthorizationSpec>, IStatus<V1beta1CertificateManagerDNSAuthorizationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateManagerDNSAuthorization";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagerdnsauthorizations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateManagerDNSAuthorizationSpec defines the desired state of CertificateManagerDNSAuthorization</summary>
    [JsonPropertyName("spec")]
    public V1beta1CertificateManagerDNSAuthorizationSpec Spec { get; set; }

    /// <summary>CertificateManagerDNSAuthorizationStatus defines the config connector machine state of CertificateManagerDNSAuthorization</summary>
    [JsonPropertyName("status")]
    public V1beta1CertificateManagerDNSAuthorizationStatus? Status { get; set; }
}