using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
/// <summary>Gateway represents an instance of a service-traffic handling infrastructure by binding Listeners to a set of IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GatewayList : IKubernetesObject<V1ListMeta>, IItems<V1Gateway>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GatewayList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gateways";
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
    public IList<V1Gateway> Items { get; set; }
}

/// <summary>GatewaySpecAddress describes an address that can be bound to a Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAddresses
{
    /// <summary>Type of the address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>When a value is unspecified, an implementation SHOULD automatically assign an address matching the requested type if possible.  If an implementation does not support an empty value, they MUST set the "Programmed" condition in status to False with a reason of "AddressNotAssigned".  Examples: `1.2.3.4`, `128::1`, `my-ip-address`.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ParametersRef is a reference to a resource that contains the configuration parameters corresponding to the Gateway. This is optional if the controller does not require any additional configuration.  This follows the same semantics as GatewayClass's `parametersRef`, but on a per-Gateway basis  The Gateway's GatewayClass may provide its own `parametersRef`. When both are specified, the merging behavior is implementation specific. It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.  If the referent cannot be found, refers to an unsupported kind, or when the data within that resource is malformed, the Gateway SHOULD be rejected with the "Accepted" status condition set to "False" and an "InvalidParameters" reason.  Support: Implementation-specific</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecInfrastructureParametersRef
{
    /// <summary>Group is the group of the referent.</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>Kind is kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Infrastructure defines infrastructure level attributes about this Gateway instance.  Support: Extended</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecInfrastructure
{
    /// <summary>Annotations that SHOULD be applied to any resources created in response to this Gateway.  For implementations creating other Kubernetes objects, this should be the `metadata.annotations` field on resources. For other implementations, this refers to any relevant (implementation specific) "annotations" concepts.  An implementation may chose to add additional implementation-specific annotations as they see fit.  Support: Extended</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels that SHOULD be applied to any resources created in response to this Gateway.  For implementations creating other Kubernetes objects, this should be the `metadata.labels` field on resources. For other implementations, this refers to any relevant (implementation specific) "labels" concepts.  An implementation may chose to add additional implementation-specific labels as they see fit.  If an implementation maps these labels to Pods, or any other resource that would need to be recreated when labels change, it SHOULD clearly warn about this behavior in documentation.  Support: Extended</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>ParametersRef is a reference to a resource that contains the configuration parameters corresponding to the Gateway. This is optional if the controller does not require any additional configuration.  This follows the same semantics as GatewayClass's `parametersRef`, but on a per-Gateway basis  The Gateway's GatewayClass may provide its own `parametersRef`. When both are specified, the merging behavior is implementation specific. It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.  If the referent cannot be found, refers to an unsupported kind, or when the data within that resource is malformed, the Gateway SHOULD be rejected with the "Accepted" status condition set to "False" and an "InvalidParameters" reason.  Support: Implementation-specific</summary>
    [JsonPropertyName("parametersRef")]
    public V1GatewaySpecInfrastructureParametersRef? ParametersRef { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutesKinds
{
    /// <summary>Group is the group of the Route.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the kind of the Route.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutesNamespacesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Selector must be specified when From is set to "Selector". In that case, only Routes in Namespaces matching this Selector will be selected by this Gateway. This field is ignored for other values of "From".  Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutesNamespacesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewaySpecListenersAllowedRoutesNamespacesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Namespaces indicates namespaces from which Routes may be attached to this Listener. This is restricted to the namespace of this Gateway by default.  Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutesNamespaces
{
    /// <summary>From indicates where Routes will be selected for this Gateway. Possible values are:  * All: Routes in all namespaces may be used by this Gateway. * Selector: Routes in namespaces selected by the selector may be used by   this Gateway. * Same: Only Routes in the same namespace may be used by this Gateway.  Support: Core</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Selector must be specified when From is set to "Selector". In that case, only Routes in Namespaces matching this Selector will be selected by this Gateway. This field is ignored for other values of "From".  Support: Core</summary>
    [JsonPropertyName("selector")]
    public V1GatewaySpecListenersAllowedRoutesNamespacesSelector? Selector { get; set; }
}

/// <summary>AllowedRoutes defines the types of routes that MAY be attached to a Listener and the trusted namespaces where those Route resources MAY be present.  Although a client request may match multiple route rules, only one rule may ultimately receive the request. Matching precedence MUST be determined in order of the following criteria:  * The most specific match as defined by the Route type. * The oldest Route based on creation timestamp. For example, a Route with   a creation timestamp of "2020-09-08 01:02:03" is given precedence over   a Route with a creation timestamp of "2020-09-08 01:02:04". * If everything else is equivalent, the Route appearing first in   alphabetical order (namespace/name) should be given precedence. For   example, foo/bar is given precedence over foo/baz.  All valid rules within a Route attached to this Listener should be implemented. Invalid Route rules can be ignored (sometimes that will mean the full Route). If a Route rule transitions from valid to invalid, support for that Route rule should be dropped to ensure consistency. For example, even if a filter specified by a Route rule is invalid, the rest of the rules within that Route should still be supported.  Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutes
{
    /// <summary>Kinds specifies the groups and kinds of Routes that are allowed to bind to this Gateway Listener. When unspecified or empty, the kinds of Routes selected are determined using the Listener protocol.  A RouteGroupKind MUST correspond to kinds of Routes that are compatible with the application protocol specified in the Listener's Protocol field. If an implementation does not support or recognize this resource type, it MUST set the "ResolvedRefs" condition to False for this Listener with the "InvalidRouteKinds" reason.  Support: Core</summary>
    [JsonPropertyName("kinds")]
    public IList<V1GatewaySpecListenersAllowedRoutesKinds>? Kinds { get; set; }

    /// <summary>Namespaces indicates namespaces from which Routes may be attached to this Listener. This is restricted to the namespace of this Gateway by default.  Support: Core</summary>
    [JsonPropertyName("namespaces")]
    public V1GatewaySpecListenersAllowedRoutesNamespaces? Namespaces { get; set; }
}

/// <summary>SecretObjectReference identifies an API object including its namespace, defaulting to Secret.  The API object must be valid in the cluster; the Group and Kind must be registered in the cluster for this reference to be valid.  References to objects with invalid Group and Kind are not valid, and must be rejected by the implementation, with appropriate Conditions set on the containing object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersTlsCertificateRefs
{
    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent. For example "Secret".</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the referenced object. When unspecified, the local namespace is inferred.  Note that when a namespace different than the local namespace is specified, a ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details.  Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>TLS is the TLS configuration for the Listener. This field is required if the Protocol field is "HTTPS" or "TLS". It is invalid to set this field if the Protocol field is "HTTP", "TCP", or "UDP".  The association of SNIs to Certificate defined in GatewayTLSConfig is defined based on the Hostname field for this listener.  The GatewayClass MUST use the longest matching SNI out of all available certificates for any TLS handshake.  Support: Core</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersTls
{
    /// <summary>CertificateRefs contains a series of references to Kubernetes objects that contains TLS certificates and private keys. These certificates are used to establish a TLS handshake for requests that match the hostname of the associated listener.  A single CertificateRef to a Kubernetes Secret has "Core" support. Implementations MAY choose to support attaching multiple certificates to a Listener, but this behavior is implementation-specific.  References to a resource in different namespace are invalid UNLESS there is a ReferenceGrant in the target namespace that allows the certificate to be attached. If a ReferenceGrant does not allow this reference, the "ResolvedRefs" condition MUST be set to False for this listener with the "RefNotPermitted" reason.  This field is required to have at least one element when the mode is set to "Terminate" (default) and is optional otherwise.  CertificateRefs can reference to standard Kubernetes resources, i.e. Secret, or implementation-specific custom resources.  Support: Core - A single reference to a Kubernetes Secret of type kubernetes.io/tls  Support: Implementation-specific (More than one reference or other resource types)</summary>
    [JsonPropertyName("certificateRefs")]
    public IList<V1GatewaySpecListenersTlsCertificateRefs>? CertificateRefs { get; set; }

    /// <summary>Mode defines the TLS behavior for the TLS session initiated by the client. There are two possible modes:  - Terminate: The TLS session between the downstream client and the   Gateway is terminated at the Gateway. This mode requires certificates   to be specified in some way, such as populating the certificateRefs   field. - Passthrough: The TLS session is NOT terminated by the Gateway. This   implies that the Gateway can't decipher the TLS stream except for   the ClientHello message of the TLS protocol. The certificateRefs field   is ignored in this mode.  Support: Core</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Options are a list of key/value pairs to enable extended TLS configuration for each implementation. For example, configuring the minimum TLS version or supported cipher suites.  A set of common keys MAY be defined by the API in the future. To avoid any ambiguity, implementation-specific definitions MUST use domain-prefixed names, such as `example.com/my-custom-option`. Un-prefixed names are reserved for key names defined by Gateway API.  Support: Implementation-specific</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }
}

/// <summary>Listener embodies the concept of a logical endpoint where a Gateway accepts network connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListeners
{
    /// <summary>AllowedRoutes defines the types of routes that MAY be attached to a Listener and the trusted namespaces where those Route resources MAY be present.  Although a client request may match multiple route rules, only one rule may ultimately receive the request. Matching precedence MUST be determined in order of the following criteria:  * The most specific match as defined by the Route type. * The oldest Route based on creation timestamp. For example, a Route with   a creation timestamp of "2020-09-08 01:02:03" is given precedence over   a Route with a creation timestamp of "2020-09-08 01:02:04". * If everything else is equivalent, the Route appearing first in   alphabetical order (namespace/name) should be given precedence. For   example, foo/bar is given precedence over foo/baz.  All valid rules within a Route attached to this Listener should be implemented. Invalid Route rules can be ignored (sometimes that will mean the full Route). If a Route rule transitions from valid to invalid, support for that Route rule should be dropped to ensure consistency. For example, even if a filter specified by a Route rule is invalid, the rest of the rules within that Route should still be supported.  Support: Core</summary>
    [JsonPropertyName("allowedRoutes")]
    public V1GatewaySpecListenersAllowedRoutes? AllowedRoutes { get; set; }

    /// <summary>Hostname specifies the virtual hostname to match for protocol types that define this concept. When unspecified, all hostnames are matched. This field is ignored for protocols that don't require hostname based matching.  Implementations MUST apply Hostname matching appropriately for each of the following protocols:  * TLS: The Listener Hostname MUST match the SNI. * HTTP: The Listener Hostname MUST match the Host header of the request. * HTTPS: The Listener Hostname SHOULD match both the SNI and Host header.   Note that this does not require the SNI and Host header to be the same.   The semantics of this are described in more detail below.  To ensure security, Section 11.1 of RFC-6066 emphasizes that server implementations that rely on SNI hostname matching MUST also verify hostnames within the application protocol.  Section 9.1.2 of RFC-7540 provides a mechanism for servers to reject the reuse of a connection by responding with the HTTP 421 Misdirected Request status code. This indicates that the origin server has rejected the request because it appears to have been misdirected.  To detect misdirected requests, Gateways SHOULD match the authority of the requests with all the SNI hostname(s) configured across all the Gateway Listeners on the same port and protocol:  * If another Listener has an exact match or more specific wildcard entry,   the Gateway SHOULD return a 421. * If the current Listener (selected by SNI matching during ClientHello)   does not match the Host:     * If another Listener does match the Host the Gateway SHOULD return a       421.     * If no other Listener matches the Host, the Gateway MUST return a       404.  For HTTPRoute and TLSRoute resources, there is an interaction with the `spec.hostnames` array. When both listener and route specify hostnames, there MUST be an intersection between the values for a Route to be accepted. For more information, refer to the Route specific Hostnames documentation.  Hostnames that are prefixed with a wildcard label (`*.`) are interpreted as a suffix match. That means that a match for `*.example.com` would match both `test.example.com`, and `foo.test.example.com`, but not `example.com`.  Support: Core</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Name is the name of the Listener. This name MUST be unique within a Gateway.  Support: Core</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Port is the network port. Multiple listeners may use the same port, subject to the Listener compatibility rules.  Support: Core</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Protocol specifies the network protocol this listener expects to receive.  Support: Core</summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }

    /// <summary>TLS is the TLS configuration for the Listener. This field is required if the Protocol field is "HTTPS" or "TLS". It is invalid to set this field if the Protocol field is "HTTP", "TCP", or "UDP".  The association of SNIs to Certificate defined in GatewayTLSConfig is defined based on the Hostname field for this listener.  The GatewayClass MUST use the longest matching SNI out of all available certificates for any TLS handshake.  Support: Core</summary>
    [JsonPropertyName("tls")]
    public V1GatewaySpecListenersTls? Tls { get; set; }
}

/// <summary>Spec defines the desired state of Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpec
{
    /// <summary>Addresses requested for this Gateway. This is optional and behavior can depend on the implementation. If a value is set in the spec and the requested address is invalid or unavailable, the implementation MUST indicate this in the associated entry in GatewayStatus.Addresses.  The Addresses field represents a request for the address(es) on the "outside of the Gateway", that traffic bound for this Gateway will use. This could be the IP address or hostname of an external load balancer or other networking infrastructure, or some other address that traffic will be sent to.  If no Addresses are specified, the implementation MAY schedule the Gateway in an implementation-specific manner, assigning an appropriate set of Addresses.  The implementation MUST bind all Listeners to every GatewayAddress that it assigns to the Gateway and add a corresponding entry in GatewayStatus.Addresses.  Support: Extended</summary>
    [JsonPropertyName("addresses")]
    public IList<V1GatewaySpecAddresses>? Addresses { get; set; }

    /// <summary>GatewayClassName used for this Gateway. This is the name of a GatewayClass resource.</summary>
    [JsonPropertyName("gatewayClassName")]
    public string GatewayClassName { get; set; }

    /// <summary>Infrastructure defines infrastructure level attributes about this Gateway instance.  Support: Extended</summary>
    [JsonPropertyName("infrastructure")]
    public V1GatewaySpecInfrastructure? Infrastructure { get; set; }

    /// <summary>Listeners associated with this Gateway. Listeners define logical endpoints that are bound on this Gateway's addresses. At least one Listener MUST be specified.  ## Distinct Listeners  Each Listener in a set of Listeners (for example, in a single Gateway) MUST be _distinct_, in that a traffic flow MUST be able to be assigned to exactly one listener. (This section uses "set of Listeners" rather than "Listeners in a single Gateway" because implementations MAY merge configuration from multiple Gateways onto a single data plane, and these rules _also_ apply in that case).  Practically, this means that each listener in a set MUST have a unique combination of Port, Protocol, and, if supported by the protocol, Hostname.  Some combinations of port, protocol, and TLS settings are considered Core support and MUST be supported by implementations based on the objects they support:  HTTPRoute  1. HTTPRoute, Port: 80, Protocol: HTTP 2. HTTPRoute, Port: 443, Protocol: HTTPS, TLS Mode: Terminate, TLS keypair provided  TLSRoute  1. TLSRoute, Port: 443, Protocol: TLS, TLS Mode: Passthrough  "Distinct" Listeners have the following property:  **The implementation can match inbound requests to a single distinct Listener**.  When multiple Listeners share values for fields (for example, two Listeners with the same Port value), the implementation can match requests to only one of the Listeners using other Listener fields.  When multiple listeners have the same value for the Protocol field, then each of the Listeners with matching Protocol values MUST have different values for other fields.  The set of fields that MUST be different for a Listener differs per protocol. The following rules define the rules for what fields MUST be considered for Listeners to be distinct with each protocol currently defined in the Gateway API spec.  The set of listeners that all share a protocol value MUST have _different_ values for _at least one_ of these fields to be distinct:  * **HTTP, HTTPS, TLS**: Port, Hostname * **TCP, UDP**: Port  One **very** important rule to call out involves what happens when an implementation:  * Supports TCP protocol Listeners, as well as HTTP, HTTPS, or TLS protocol   Listeners, and * sees HTTP, HTTPS, or TLS protocols with the same `port` as one with TCP   Protocol.  In this case all the Listeners that share a port with the TCP Listener are not distinct and so MUST NOT be accepted.  If an implementation does not support TCP Protocol Listeners, then the previous rule does not apply, and the TCP Listeners SHOULD NOT be accepted.  Note that the `tls` field is not used for determining if a listener is distinct, because Listeners that _only_ differ on TLS config will still conflict in all cases.  ### Listeners that are distinct only by Hostname  When the Listeners are distinct based only on Hostname, inbound request hostnames MUST match from the most specific to least specific Hostname values to choose the correct Listener and its associated set of Routes.  Exact matches MUST be processed before wildcard matches, and wildcard matches MUST be processed before fallback (empty Hostname value) matches. For example, `"foo.example.com"` takes precedence over `"*.example.com"`, and `"*.example.com"` takes precedence over `""`.  Additionally, if there are multiple wildcard entries, more specific wildcard entries must be processed before less specific wildcard entries. For example, `"*.foo.example.com"` takes precedence over `"*.example.com"`.  The precise definition here is that the higher the number of dots in the hostname to the right of the wildcard character, the higher the precedence.  The wildcard character will match any number of characters _and dots_ to the left, however, so `"*.example.com"` will match both `"foo.bar.example.com"` _and_ `"bar.example.com"`.  ## Handling indistinct Listeners  If a set of Listeners contains Listeners that are not distinct, then those Listeners are _Conflicted_, and the implementation MUST set the "Conflicted" condition in the Listener Status to "True".  The words "indistinct" and "conflicted" are considered equivalent for the purpose of this documentation.  Implementations MAY choose to accept a Gateway with some Conflicted Listeners only if they only accept the partial Listener set that contains no Conflicted Listeners.  Specifically, an implementation MAY accept a partial Listener set subject to the following rules:  * The implementation MUST NOT pick one conflicting Listener as the winner.   ALL indistinct Listeners must not be accepted for processing. * At least one distinct Listener MUST be present, or else the Gateway effectively   contains _no_ Listeners, and must be rejected from processing as a whole.  The implementation MUST set a "ListenersNotValid" condition on the Gateway Status when the Gateway contains Conflicted Listeners whether or not they accept the Gateway. That Condition SHOULD clearly indicate in the Message which Listeners are conflicted, and which are Accepted. Additionally, the Listener status for those listeners SHOULD indicate which Listeners are conflicted and not Accepted.  ## General Listener behavior  Note that, for all distinct Listeners, requests SHOULD match at most one Listener. For example, if Listeners are defined for "foo.example.com" and "*.example.com", a request to "foo.example.com" SHOULD only be routed using routes attached to the "foo.example.com" Listener (and not the "*.example.com" Listener).  This concept is known as "Listener Isolation", and it is an Extended feature of Gateway API. Implementations that do not support Listener Isolation MUST clearly document this, and MUST NOT claim support for the `GatewayHTTPListenerIsolation` feature.  Implementations that _do_ support Listener Isolation SHOULD claim support for the Extended `GatewayHTTPListenerIsolation` feature and pass the associated conformance tests.  ## Compatible Listeners  A Gateway's Listeners are considered _compatible_ if:  1. They are distinct. 2. The implementation can serve them in compliance with the Addresses    requirement that all Listeners are available on all assigned    addresses.  Compatible combinations in Extended support are expected to vary across implementations. A combination that is compatible for one implementation may not be compatible for another.  For example, an implementation that cannot serve both TCP and UDP listeners on the same address, or cannot mix HTTPS and generic TLS listens on the same port would not consider those cases compatible, even though they are distinct.  Implementations MAY merge separate Gateways onto a single set of Addresses if all Listeners across all Gateways are compatible.  In a future release the MinItems=1 requirement MAY be dropped.  Support: Core</summary>
    [JsonPropertyName("listeners")]
    public IList<V1GatewaySpecListeners> Listeners { get; set; }
}

/// <summary>GatewayStatusAddress describes a network address that is bound to a Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusAddresses
{
    /// <summary>Type of the address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value of the address. The validity of the values will depend on the type and support by the controller.  Examples: `1.2.3.4`, `128::1`, `my-ip-address`.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusListenersConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusListenersSupportedKinds
{
    /// <summary>Group is the group of the Route.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the kind of the Route.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>ListenerStatus is the status associated with a Listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusListeners
{
    /// <summary>AttachedRoutes represents the total number of Routes that have been successfully attached to this Listener.  Successful attachment of a Route to a Listener is based solely on the combination of the AllowedRoutes field on the corresponding Listener and the Route's ParentRefs field. A Route is successfully attached to a Listener when it is selected by the Listener's AllowedRoutes field AND the Route has a valid ParentRef selecting the whole Gateway resource or a specific Listener as a parent resource (more detail on attachment semantics can be found in the documentation on the various Route kinds ParentRefs fields). Listener or Route status does not impact successful attachment, i.e. the AttachedRoutes field count MUST be set for Listeners with condition Accepted: false and MUST count successfully attached Routes that may themselves have Accepted: false conditions.  Uses for this field include troubleshooting Route attachment and measuring blast radius/impact of changes to a Listener.</summary>
    [JsonPropertyName("attachedRoutes")]
    public int AttachedRoutes { get; set; }

    /// <summary>Conditions describe the current condition of this listener.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GatewayStatusListenersConditions> Conditions { get; set; }

    /// <summary>Name is the name of the Listener that this status corresponds to.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>SupportedKinds is the list indicating the Kinds supported by this listener. This MUST represent the kinds an implementation supports for that Listener configuration.  If kinds are specified in Spec that are not supported, they MUST NOT appear in this list and an implementation MUST set the "ResolvedRefs" condition to "False" with the "InvalidRouteKinds" reason. If both valid and invalid Route kinds are specified, the implementation MUST reference the valid Route kinds that have been specified.</summary>
    [JsonPropertyName("supportedKinds")]
    public IList<V1GatewayStatusListenersSupportedKinds> SupportedKinds { get; set; }
}

/// <summary>Status defines the current state of Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatus
{
    /// <summary>Addresses lists the network addresses that have been bound to the Gateway.  This list may differ from the addresses provided in the spec under some conditions:    * no addresses are specified, all addresses are dynamically assigned   * a combination of specified and dynamic addresses are assigned   * a specified address was unusable (e.g. already in use)</summary>
    [JsonPropertyName("addresses")]
    public IList<V1GatewayStatusAddresses>? Addresses { get; set; }

    /// <summary>Conditions describe the current conditions of the Gateway.  Implementations should prefer to express Gateway conditions using the `GatewayConditionType` and `GatewayConditionReason` constants so that operators and tools can converge on a common vocabulary to describe Gateway state.  Known condition types are:  * "Accepted" * "Programmed" * "Ready"</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GatewayStatusConditions>? Conditions { get; set; }

    /// <summary>Listeners provide status for each unique listener port defined in the Spec.</summary>
    [JsonPropertyName("listeners")]
    public IList<V1GatewayStatusListeners>? Listeners { get; set; }
}

/// <summary>Gateway represents an instance of a service-traffic handling infrastructure by binding Listeners to a set of IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Gateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1GatewaySpec>, IStatus<V1GatewayStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Gateway";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of Gateway.</summary>
    [JsonPropertyName("spec")]
    public V1GatewaySpec Spec { get; set; }

    /// <summary>Status defines the current state of Gateway.</summary>
    [JsonPropertyName("status")]
    public V1GatewayStatus? Status { get; set; }
}