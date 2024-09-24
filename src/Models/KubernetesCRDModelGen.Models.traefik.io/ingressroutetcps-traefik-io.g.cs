using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>ObjectReference is a generic reference to a Traefik resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecRoutesMiddlewares
{
    /// <summary>Name defines the name of the referenced Traefik resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Traefik resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ProxyProtocol defines the PROXY protocol configuration. More info: https://doc.traefik.io/traefik/v3.1/routing/services/#proxy-protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecRoutesServicesProxyProtocol
{
    /// <summary>Version defines the PROXY Protocol version to use.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>ServiceTCP defines an upstream TCP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecRoutesServices
{
    /// <summary>Name defines the name of the referenced Kubernetes Service.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>NativeLB controls, when creating the load-balancer, whether the LB's children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP. The Kubernetes Service itself does load-balance to the pods. By default, NativeLB is false.</summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>NodePortLB controls, when creating the load-balancer, whether the LB's children are directly the nodes internal IPs using the nodePort when the service type is NodePort. It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes. By default, NodePortLB is false.</summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>Port defines the port of a Kubernetes Service. This can be a reference to a named port.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>ProxyProtocol defines the PROXY protocol configuration. More info: https://doc.traefik.io/traefik/v3.1/routing/services/#proxy-protocol</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1alpha1IngressRouteTCPSpecRoutesServicesProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>ServersTransport defines the name of ServersTransportTCP resource to use. It allows to configure the transport between Traefik and your servers. Can only be used on a Kubernetes Service.</summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>TerminationDelay defines the deadline that the proxy sets, after one of its connected peers indicates it has closed the writing capability of its connection, to close the reading capability as well, hence fully terminating the connection. It is a duration in milliseconds, defaulting to 100. A negative value means an infinite deadline (i.e. the reading capability is never closed). Deprecated: TerminationDelay will not be supported in future APIVersions, please use ServersTransport to configure the TerminationDelay instead.</summary>
    [JsonPropertyName("terminationDelay")]
    public int? TerminationDelay { get; set; }

    /// <summary>TLS determines whether to use TLS when dialing with the backend.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>Weight defines the weight used when balancing requests between multiple Kubernetes Service.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>RouteTCP holds the TCP route configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecRoutes
{
    /// <summary>Match defines the router's rule. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#rule_1</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }

    /// <summary>Middlewares defines the list of references to MiddlewareTCP resources.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1IngressRouteTCPSpecRoutesMiddlewares>? Middlewares { get; set; }

    /// <summary>Priority defines the router's priority. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#priority_1</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Services defines the list of TCP services.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1IngressRouteTCPSpecRoutesServices>? Services { get; set; }

    /// <summary>Syntax defines the router's rule syntax. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#rulesyntax_1</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }
}

/// <summary>Domain holds a domain name with SANs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecTlsDomains
{
    /// <summary>Main defines the main domain name.</summary>
    [JsonPropertyName("main")]
    public string? Main { get; set; }

    /// <summary>SANs defines the subject alternative domain names.</summary>
    [JsonPropertyName("sans")]
    public IList<string>? Sans { get; set; }
}

/// <summary>Options defines the reference to a TLSOption, that specifies the parameters of the TLS connection. If not defined, the `default` TLSOption is used. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#tls-options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecTlsOptions
{
    /// <summary>Name defines the name of the referenced Traefik resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Traefik resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Store defines the reference to the TLSStore, that will be used to store certificates. Please note that only `default` TLSStore can be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecTlsStore
{
    /// <summary>Name defines the name of the referenced Traefik resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Traefik resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>TLS defines the TLS configuration on a layer 4 / TCP Route. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#tls_1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpecTls
{
    /// <summary>CertResolver defines the name of the certificate resolver to use. Cert resolvers have to be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.1/https/acme/#certificate-resolvers</summary>
    [JsonPropertyName("certResolver")]
    public string? CertResolver { get; set; }

    /// <summary>Domains defines the list of domains that will be used to issue certificates. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#domains</summary>
    [JsonPropertyName("domains")]
    public IList<V1alpha1IngressRouteTCPSpecTlsDomains>? Domains { get; set; }

    /// <summary>Options defines the reference to a TLSOption, that specifies the parameters of the TLS connection. If not defined, the `default` TLSOption is used. More info: https://doc.traefik.io/traefik/v3.1/https/tls/#tls-options</summary>
    [JsonPropertyName("options")]
    public V1alpha1IngressRouteTCPSpecTlsOptions? Options { get; set; }

    /// <summary>Passthrough defines whether a TLS router will terminate the TLS connection.</summary>
    [JsonPropertyName("passthrough")]
    public bool? Passthrough { get; set; }

    /// <summary>SecretName is the name of the referenced Kubernetes Secret to specify the certificate details.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Store defines the reference to the TLSStore, that will be used to store certificates. Please note that only `default` TLSStore can be used.</summary>
    [JsonPropertyName("store")]
    public V1alpha1IngressRouteTCPSpecTlsStore? Store { get; set; }
}

/// <summary>IngressRouteTCPSpec defines the desired state of IngressRouteTCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteTCPSpec
{
    /// <summary>EntryPoints defines the list of entry point names to bind to. Entry points have to be configured in the static configuration. More info: https://doc.traefik.io/traefik/v3.1/routing/entrypoints/ Default: all.</summary>
    [JsonPropertyName("entryPoints")]
    public IList<string>? EntryPoints { get; set; }

    /// <summary>Routes defines the list of routes.</summary>
    [JsonPropertyName("routes")]
    public IList<V1alpha1IngressRouteTCPSpecRoutes> Routes { get; set; }

    /// <summary>TLS defines the TLS configuration on a layer 4 / TCP Route. More info: https://doc.traefik.io/traefik/v3.1/routing/routers/#tls_1</summary>
    [JsonPropertyName("tls")]
    public V1alpha1IngressRouteTCPSpecTls? Tls { get; set; }
}

/// <summary>IngressRouteTCP is the CRD implementation of a Traefik TCP Router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IngressRouteTCP : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IngressRouteTCPSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IngressRouteTCP";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "ingressroutetcps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IngressRouteTCPSpec defines the desired state of IngressRouteTCP.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1IngressRouteTCPSpec Spec { get; set; }
}