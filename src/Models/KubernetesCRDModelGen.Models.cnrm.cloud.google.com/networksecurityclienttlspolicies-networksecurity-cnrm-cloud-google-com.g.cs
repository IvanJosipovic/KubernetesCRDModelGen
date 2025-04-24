using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicyMetadata
{
}

/// <summary>The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecClientCertificateCertificateProviderInstance
{
    /// <summary>Required. Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to "google_cloud_private_spiffe" to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string PluginInstance { get; set; }
}

/// <summary>gRPC specific configuration to access the gRPC server to obtain the cert and private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecClientCertificateGrpcEndpoint
{
    /// <summary>Required. The target URI of the gRPC endpoint. Only UDS path is supported, and should start with “unix:”.</summary>
    [JsonPropertyName("targetUri")]
    public string TargetUri { get; set; }
}

/// <summary>Optional. Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecClientCertificate
{
    /// <summary>The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
    [JsonPropertyName("certificateProviderInstance")]
    public NetworkSecurityClientTLSPolicySpecClientCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>gRPC specific configuration to access the gRPC server to obtain the cert and private key.</summary>
    [JsonPropertyName("grpcEndpoint")]
    public NetworkSecurityClientTLSPolicySpecClientCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecServerValidationCaCertificateProviderInstance
{
    /// <summary>Required. Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to "google_cloud_private_spiffe" to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string PluginInstance { get; set; }
}

/// <summary>gRPC specific configuration to access the gRPC server to obtain the CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecServerValidationCaGrpcEndpoint
{
    /// <summary>Required. The target URI of the gRPC endpoint. Only UDS path is supported, and should start with “unix:”.</summary>
    [JsonPropertyName("targetUri")]
    public string TargetUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpecServerValidationCa
{
    /// <summary>The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
    [JsonPropertyName("certificateProviderInstance")]
    public NetworkSecurityClientTLSPolicySpecServerValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>gRPC specific configuration to access the gRPC server to obtain the CA certificate.</summary>
    [JsonPropertyName("grpcEndpoint")]
    public NetworkSecurityClientTLSPolicySpecServerValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicySpec
{
    /// <summary>Optional. Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.</summary>
    [JsonPropertyName("clientCertificate")]
    public NetworkSecurityClientTLSPolicySpecClientCertificate? ClientCertificate { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public NetworkSecurityClientTLSPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Defines the mechanism to obtain the Certificate Authority certificate to validate the server certificate.</summary>
    [JsonPropertyName("serverValidationCa")]
    public IList<NetworkSecurityClientTLSPolicySpecServerValidationCa>? ServerValidationCa { get; set; }

    /// <summary>Optional. Server Name Indication string to present to the server during TLS handshake. E.g: "secure.example.com".</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicyStatusConditions
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
public partial class NetworkSecurityClientTLSPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<NetworkSecurityClientTLSPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkSecurityClientTLSPolicy
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public NetworkSecurityClientTLSPolicyMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public NetworkSecurityClientTLSPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public NetworkSecurityClientTLSPolicyStatus? Status { get; set; }
}