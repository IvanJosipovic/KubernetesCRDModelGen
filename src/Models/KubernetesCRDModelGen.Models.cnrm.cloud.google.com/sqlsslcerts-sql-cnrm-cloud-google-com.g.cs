using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.cnrm.cloud.google.com;
/// <summary>The Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLSSLCertSpecInstanceRef
{
    /// <summary>Allowed value: The `name` field of a `SQLInstance` resource.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLSSLCertSpec
{
    /// <summary>Immutable. The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("commonName")]
    public string CommonName { get; set; }

    /// <summary>The Cloud SQL instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1SQLSSLCertSpecInstanceRef InstanceRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated sha1Fingerprint of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLSSLCertStatusConditions
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
public partial class V1beta1SQLSSLCertStatus
{
    /// <summary>The actual certificate data for this client certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>The serial number extracted from the certificate data.</summary>
    [JsonPropertyName("certSerialNumber")]
    public string? CertSerialNumber { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLSSLCertStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The private key associated with the client certificate.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The CA cert of the server this client cert was generated from.</summary>
    [JsonPropertyName("serverCaCert")]
    public string? ServerCaCert { get; set; }

    /// <summary>The SHA1 Fingerprint of the certificate.</summary>
    [JsonPropertyName("sha1Fingerprint")]
    public string? Sha1Fingerprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLSSLCert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLSSLCertSpec>, IStatus<V1beta1SQLSSLCertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLSSLCert";
    public const string KubeGroup = "sql.cnrm.cloud.google.com";
    public const string KubePluralName = "sqlsslcerts";
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
    public V1beta1SQLSSLCertSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1SQLSSLCertStatus? Status { get; set; }
}