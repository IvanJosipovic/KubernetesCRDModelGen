using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>CertSecretRef specifies the Secret containing a PEM-encoded CA certificate (in the `ca.crt` key).   Note: Support for the `caFile` key has been deprecated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretRef specifies the Secret containing the authentication credentials for this Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ProviderSpec defines the desired state of the Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpec
{
    /// <summary>Address specifies the endpoint, in a generic sense, to where alerts are sent. What kind of endpoint depends on the specific Provider type being used. For the generic Provider, for example, this is an HTTP/S address. For other Provider types this could be a project ID or a namespace.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>CertSecretRef specifies the Secret containing a PEM-encoded CA certificate (in the `ca.crt` key).   Note: Support for the `caFile` key has been deprecated.</summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta3ProviderSpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Channel specifies the destination channel where events should be posted.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Interval at which to reconcile the Provider with its Secret references. Deprecated and not used in v1beta3.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Proxy the HTTP/S address of the proxy server.</summary>
    [JsonPropertyName("proxy")]
    public string? Proxy { get; set; }

    /// <summary>SecretRef specifies the Secret containing the authentication credentials for this Provider.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta3ProviderSpecSecretRef? SecretRef { get; set; }

    /// <summary>Suspend tells the controller to suspend subsequent events handling for this Provider.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for sending alerts to the Provider.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Type specifies which Provider implementation to use.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>Username specifies the name under which events are posted.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Provider is the Schema for the providers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3Provider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta3ProviderSpec>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "Provider";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderSpec defines the desired state of the Provider.</summary>
    [JsonPropertyName("spec")]
    public V1beta3ProviderSpec? Spec { get; set; }
}