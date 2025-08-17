using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
#nullable enable
/// <summary>RegionTargetHTTPSProxy is the Schema for the RegionTargetHTTPSProxys API. Represents a RegionTargetHttpsProxy resource, which is used by one or more forwarding rules to route incoming HTTPS requests to a URL map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionTargetHTTPSProxyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionTargetHTTPSProxy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionTargetHTTPSProxyList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiontargethttpsproxies";
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
    public IList<V1beta1RegionTargetHTTPSProxy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecForProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies how long to keep a connection open, after completing a response, while there is no matching traffic (in seconds). If an HTTP keepalive is not specified, a default value (600 seconds) will be used. For Regioanl HTTP(S) load balancer, the minimum allowed value is 5 seconds and the maximum allowed value is 600 seconds.</summary>
    [JsonPropertyName("httpKeepAliveTimeoutSec")]
    public double? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created target https proxy should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted. If you remove this field from your configuration at the same time as deleting or recreating a referenced ServerTlsPolicy resource, you will receive a resourceInUseByAnotherResource error. Use lifecycle.create_before_destroy within the ServerTlsPolicy resource to avoid this.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>References to RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesRefs")]
    public IList<V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesRefs>? SslCertificatesRefs { get; set; }

    /// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesSelector")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderSslCertificatesSelector? SslCertificatesSelector { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }

    /// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapRef? UrlMapRef { get; set; }

    /// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapSelector")]
    public V1beta1RegionTargetHTTPSProxySpecForProviderUrlMapSelector? UrlMapSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecInitProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies how long to keep a connection open, after completing a response, while there is no matching traffic (in seconds). If an HTTP keepalive is not specified, a default value (600 seconds) will be used. For Regioanl HTTP(S) load balancer, the minimum allowed value is 5 seconds and the maximum allowed value is 600 seconds.</summary>
    [JsonPropertyName("httpKeepAliveTimeoutSec")]
    public double? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted. If you remove this field from your configuration at the same time as deleting or recreating a referenced ServerTlsPolicy resource, you will receive a resourceInUseByAnotherResource error. Use lifecycle.create_before_destroy within the ServerTlsPolicy resource to avoid this.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>References to RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesRefs")]
    public IList<V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesRefs>? SslCertificatesRefs { get; set; }

    /// <summary>Selector for a list of RegionSSLCertificate in compute to populate sslCertificates.</summary>
    [JsonPropertyName("sslCertificatesSelector")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderSslCertificatesSelector? SslCertificatesSelector { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }

    /// <summary>Reference to a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapRef")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapRef? UrlMapRef { get; set; }

    /// <summary>Selector for a RegionURLMap in compute to populate urlMap.</summary>
    [JsonPropertyName("urlMapSelector")]
    public V1beta1RegionTargetHTTPSProxySpecInitProviderUrlMapSelector? UrlMapSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RegionTargetHTTPSProxySpec defines the desired state of RegionTargetHTTPSProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionTargetHTTPSProxySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionTargetHTTPSProxySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionTargetHTTPSProxySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionTargetHTTPSProxySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxyStatusAtProvider
{
    /// <summary>URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer. sslCertificates and certificateManagerCertificates can't be defined together. Accepted format is //certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName} or just the self_link projects/{project}/locations/{location}/certificates/{resourceName}</summary>
    [JsonPropertyName("certificateManagerCertificates")]
    public IList<string>? CertificateManagerCertificates { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies how long to keep a connection open, after completing a response, while there is no matching traffic (in seconds). If an HTTP keepalive is not specified, a default value (600 seconds) will be used. For Regioanl HTTP(S) load balancer, the minimum allowed value is 5 seconds and the maximum allowed value is 600 seconds.</summary>
    [JsonPropertyName("httpKeepAliveTimeoutSec")]
    public double? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/targetHttpsProxies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("proxyId")]
    public double? ProxyId { get; set; }

    /// <summary>The Region in which the created target https proxy should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic. serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED. For details which ServerTlsPolicy resources are accepted with INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED loadBalancingScheme consult ServerTlsPolicy documentation. If left blank, communications are not encrypted. If you remove this field from your configuration at the same time as deleting or recreating a referenced ServerTlsPolicy resource, you will receive a resourceInUseByAnotherResource error. Use lifecycle.create_before_destroy within the ServerTlsPolicy resource to avoid this.</summary>
    [JsonPropertyName("serverTlsPolicy")]
    public string? ServerTlsPolicy { get; set; }

    /// <summary>URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("sslCertificates")]
    public IList<string>? SslCertificates { get; set; }

    /// <summary>A reference to the Region SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource will not have any SSL policy configured.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>A reference to the RegionUrlMap resource that defines the mapping from URL to the RegionBackendService.</summary>
    [JsonPropertyName("urlMap")]
    public string? UrlMap { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxyStatusConditions
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
#nullable disable

#nullable enable
/// <summary>RegionTargetHTTPSProxyStatus defines the observed state of RegionTargetHTTPSProxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionTargetHTTPSProxyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionTargetHTTPSProxyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionTargetHTTPSProxyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RegionTargetHTTPSProxy is the Schema for the RegionTargetHTTPSProxys API. Represents a RegionTargetHttpsProxy resource, which is used by one or more forwarding rules to route incoming HTTPS requests to a URL map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionTargetHTTPSProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionTargetHTTPSProxySpec>, IStatus<V1beta1RegionTargetHTTPSProxyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionTargetHTTPSProxy";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiontargethttpsproxies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionTargetHTTPSProxySpec defines the desired state of RegionTargetHTTPSProxy</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionTargetHTTPSProxySpec Spec { get; set; }

    /// <summary>RegionTargetHTTPSProxyStatus defines the observed state of RegionTargetHTTPSProxy.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionTargetHTTPSProxyStatus? Status { get; set; }
}
#nullable disable
