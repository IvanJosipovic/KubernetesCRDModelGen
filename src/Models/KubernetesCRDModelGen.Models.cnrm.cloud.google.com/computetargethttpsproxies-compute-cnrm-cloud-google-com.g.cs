using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetHTTPSProxyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeTargetHTTPSProxy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetHTTPSProxyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargethttpsproxies";
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
    public IList<V1beta1ComputeTargetHTTPSProxy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. Currently, you may specify up to 15 certificates. Certificate manager certificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED. sslCertificates and certificateManagerCertificates fields cannot be defined together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecCertificateManagerCertificates
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/global/certificates/{{value}}`, where {{value}} is the `name` field of a `CertificateManagerCertificate` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A reference to the CertificateMap resource uri that identifies a certificate map associated with the given target proxy. This field can only be set for global target proxies. This field is only supported for EXTERNAL and EXTERNAL_MANAGED load balancing schemes. For INTERNAL_MANAGED, use certificateManagerCertificates instead. sslCertificates and certificateMap fields cannot be defined together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecCertificateMapRef
{
    /// <summary>Allowed value: string of the format `//certificatemanager.googleapis.com/projects/{{project}}/locations/global/certificateMaps/{{value}}`, where {{value}} is the `name` field of a `CertificateManagerCertificateMap` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecServerTlsPolicyRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/{{location}}/serverTlsPolicies/{{value}}`, where {{value}} is the `name` field of a `NetworkSecurityServerTLSPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A list of ComputeSSLCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecSslCertificates
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSSLCertificate` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A reference to the ComputeSSLPolicy resource that will be associated with the ComputeTargetHTTPSProxy resource. If not set, the ComputeTargetHTTPSProxy resource will not have any SSL policy configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecSslPolicyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSSLPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A reference to the ComputeURLMap resource that defines the mapping from URL to the BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpecUrlMapRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeURLMap` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxySpec
{
    /// <summary></summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<V1beta1ComputeTargetHTTPSProxySpecCertificateManagerCertificates>? CertificateManagerCertificates { get; set; }

    /// <summary>A reference to the CertificateMap resource uri that identifies a certificate map associated with the given target proxy. This field can only be set for global target proxies. This field is only supported for EXTERNAL and EXTERNAL_MANAGED load balancing schemes. For INTERNAL_MANAGED, use certificateManagerCertificates instead. sslCertificates and certificateMap fields cannot be defined together.</summary>
    [JsonPropertyName("certificateMapRef")]
    public V1beta1ComputeTargetHTTPSProxySpecCertificateMapRef? CertificateMapRef { get; set; }

    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Specifies how long to keep a connection open, after completing a response, while there is no matching traffic (in seconds). If an HTTP keepalive is not specified, a default value (610 seconds) will be used. For Global external HTTP(S) load balancer, the minimum allowed value is 5 seconds and the maximum allowed value is 1200 seconds. For Global external HTTP(S) load balancer (classic), this option is not available publicly.</summary>
    [JsonPropertyName("httpKeepAliveTimeoutSec")]
    public int? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>Location represents the geographical location of the ComputeTargetHTTPSProxy. Specify a region name or "global" for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. This field only applies when the forwarding rule that references this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("proxyBind")]
    public bool? ProxyBind { get; set; }

    /// <summary>Specifies the QUIC override policy for this resource. This determines whether the load balancer will attempt to negotiate QUIC with clients or not. Can specify one of NONE, ENABLE, or DISABLE. If NONE is specified, Google manages whether QUIC is used. Default value: "NONE" Possible values: ["NONE", "ENABLE", "DISABLE"].</summary>
    [JsonPropertyName("quicOverride")]
    public string? QuicOverride { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted.</summary>
    [JsonPropertyName("serverTlsPolicyRef")]
    public V1beta1ComputeTargetHTTPSProxySpecServerTlsPolicyRef? ServerTlsPolicyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslCertificates")]
    public IList<V1beta1ComputeTargetHTTPSProxySpecSslCertificates>? SslCertificates { get; set; }

    /// <summary>A reference to the ComputeSSLPolicy resource that will be associated with the ComputeTargetHTTPSProxy resource. If not set, the ComputeTargetHTTPSProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicyRef")]
    public V1beta1ComputeTargetHTTPSProxySpecSslPolicyRef? SslPolicyRef { get; set; }

    /// <summary>A reference to the ComputeURLMap resource that defines the mapping from URL to the BackendService.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1ComputeTargetHTTPSProxySpecUrlMapRef UrlMapRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxyStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPSProxyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeTargetHTTPSProxyStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("proxyId")]
    public int? ProxyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetHTTPSProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeTargetHTTPSProxySpec>, IStatus<V1beta1ComputeTargetHTTPSProxyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetHTTPSProxy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargethttpsproxies";
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
    public V1beta1ComputeTargetHTTPSProxySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeTargetHTTPSProxyStatus? Status { get; set; }
}
#nullable disable
