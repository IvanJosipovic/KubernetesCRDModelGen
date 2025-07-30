using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>InFlightConn defines the InFlightConn middleware configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecInFlightConn
{
    /// <summary>Amount defines the maximum amount of allowed simultaneous connections. The middleware closes the connection if there are already amount connections opened.</summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; set; }
}

/// <summary>IPAllowList defines the IPAllowList middleware configuration. This middleware accepts/refuses connections based on the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/tcp/ipallowlist/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecIpAllowList
{
    /// <summary>SourceRange defines the allowed IPs (or ranges of allowed IPs by using CIDR notation).</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>IPWhiteList defines the IPWhiteList middleware configuration. This middleware accepts/refuses connections based on the client IP. Deprecated: please use IPAllowList instead. More info: https://doc.traefik.io/traefik/v3.5/middlewares/tcp/ipwhitelist/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecIpWhiteList
{
    /// <summary>SourceRange defines the allowed IPs (or ranges of allowed IPs by using CIDR notation).</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>MiddlewareTCPSpec defines the desired state of a MiddlewareTCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpec
{
    /// <summary>InFlightConn defines the InFlightConn middleware configuration.</summary>
    [JsonPropertyName("inFlightConn")]
    public V1alpha1MiddlewareTCPSpecInFlightConn? InFlightConn { get; set; }

    /// <summary>IPAllowList defines the IPAllowList middleware configuration. This middleware accepts/refuses connections based on the client IP. More info: https://doc.traefik.io/traefik/v3.5/middlewares/tcp/ipallowlist/</summary>
    [JsonPropertyName("ipAllowList")]
    public V1alpha1MiddlewareTCPSpecIpAllowList? IpAllowList { get; set; }

    /// <summary>IPWhiteList defines the IPWhiteList middleware configuration. This middleware accepts/refuses connections based on the client IP. Deprecated: please use IPAllowList instead. More info: https://doc.traefik.io/traefik/v3.5/middlewares/tcp/ipwhitelist/</summary>
    [JsonPropertyName("ipWhiteList")]
    public V1alpha1MiddlewareTCPSpecIpWhiteList? IpWhiteList { get; set; }
}

/// <summary>MiddlewareTCP is the CRD implementation of a Traefik TCP middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/overview/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MiddlewareTCP : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MiddlewareTCPSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MiddlewareTCP";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewaretcps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MiddlewareTCPSpec defines the desired state of a MiddlewareTCP.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MiddlewareTCPSpec Spec { get; set; }
}

/// <summary>MiddlewareTCP is the CRD implementation of a Traefik TCP middleware. More info: https://doc.traefik.io/traefik/v3.5/middlewares/overview/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MiddlewareTCPList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MiddlewareTCP>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MiddlewareTCPList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewaretcps";
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
    public IList<V1alpha1MiddlewareTCP> Items { get; set; }
}