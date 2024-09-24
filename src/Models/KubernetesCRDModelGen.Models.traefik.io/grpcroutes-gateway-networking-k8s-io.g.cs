using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
public partial class V1GRPCRouteSpecParentRefs
{
    /// <summary>Group is the group of the referent. When unspecified, "gateway.networking.k8s.io" is inferred. To set the core API group (such as for a "Service" kind referent), Group must be explicitly set to "" (empty string).   Support: Core</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent.   There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   Support for other resources is Implementation-Specific.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.   Support: Core</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the referent. When unspecified, this refers to the local namespace of the Route.   Note that there are specific rules for ParentRefs which cross namespace boundaries. Cross-namespace references are only valid if they are explicitly allowed by something in the namespace they are referring to. For example: Gateway has the AllowedRoutes field, and ReferenceGrant provides a generic way to enable any other kind of cross-namespace reference.      Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port is the network port this Route targets. It can be interpreted differently based on the type of parent resource.   When the parent resource is a Gateway, this targets all listeners listening on the specified port that also support this kind of Route(and select this Route). It's not recommended to set `Port` unless the networking behaviors specified in a Route must apply to a specific port as opposed to a listener(s) whose port(s) may be changed. When both Port and SectionName are specified, the name and port of the selected listener must match both specified values.      Implementations MAY choose to support other parent resources. Implementations supporting other types of parent resources MUST clearly document how/if Port is interpreted.   For the purpose of status, an attachment is considered successful as long as the parent resource accepts it partially. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Extended</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SectionName is the name of a section within the target resource. In the following resources, SectionName is interpreted as the following:   * Gateway: Listener name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values. * Service: Port name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values.   Implementations MAY choose to support attaching Routes to other resources. If that is the case, they MUST clearly document how SectionName is interpreted.   When unspecified (empty string), this will reference the entire resource. For the purpose of status, an attachment is considered successful if at least one section in the parent resource accepts it. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Core</summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersExtensionRef
{
    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example "HTTPRoute" or "Service".</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifier
{
    /// <summary>Add adds the given header(s) (name, value) to the request before the action. It appends to any existing values associated with the header name.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   add:   - name: "my-header"     value: "bar,baz"   Output:   GET /foo HTTP/1.1   my-header: foo,bar,baz</summary>
    [JsonPropertyName("add")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd>? Add { get; set; }

    /// <summary>Remove the given header(s) from the HTTP request before the action. The value of Remove is a list of HTTP header names. Note that the header names are case-insensitive (see https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).   Input:   GET /foo HTTP/1.1   my-header1: foo   my-header2: bar   my-header3: baz   Config:   remove: ["my-header1", "my-header3"]   Output:   GET /foo HTTP/1.1   my-header2: bar</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Set overwrites the request with the given header (name, value) before the action.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   set:   - name: "my-header"     value: "bar"   Output:   GET /foo HTTP/1.1   my-header: bar</summary>
    [JsonPropertyName("set")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet>? Set { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef
{
    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes resource kind of the referent. For example "Service".   Defaults to "Service" when not specified.   ExternalName services can refer to CNAME DNS records that may live outside of the cluster and as such are difficult to reason about in terms of conformance. They also may not be safe to forward to (see CVE-2021-25740 for more information). Implementations SHOULD NOT support ExternalName Services.   Support: Core (Services with a type other than ExternalName)   Support: Implementation-specific (Services with type ExternalName)</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the backend. When unspecified, the local namespace is inferred.   Note that when a namespace different than the local namespace is specified, a ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details.   Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port specifies the destination port number to use for this resource. Port is required when the referent is a Kubernetes Service. In this case, the port number is the service port number, not the target port. For other resources, destination port might be derived from the referent resource or this field.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirror
{
    /// <summary>BackendRef references a resource where mirrored requests are sent.   Mirrored requests must be sent only to a single destination endpoint within this BackendRef, irrespective of how many endpoints are present within this BackendRef.   If the referent cannot be found, this BackendRef is invalid and must be dropped from the Gateway. The controller must ensure the "ResolvedRefs" condition on the Route status is set to `status: False` and not configure this backend in the underlying implementation.   If there is a cross-namespace reference to an *existing* object that is not allowed by a ReferenceGrant, the controller must ensure the "ResolvedRefs"  condition on the Route is set to `status: False`, with the "RefNotPermitted" reason and not configure this backend in the underlying implementation.   In either error case, the Message of the `ResolvedRefs` Condition should be used to provide more detail about the problem.   Support: Extended for Kubernetes Service   Support: Implementation-specific for any other resource</summary>
    [JsonPropertyName("backendRef")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef BackendRef { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifier
{
    /// <summary>Add adds the given header(s) (name, value) to the request before the action. It appends to any existing values associated with the header name.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   add:   - name: "my-header"     value: "bar,baz"   Output:   GET /foo HTTP/1.1   my-header: foo,bar,baz</summary>
    [JsonPropertyName("add")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd>? Add { get; set; }

    /// <summary>Remove the given header(s) from the HTTP request before the action. The value of Remove is a list of HTTP header names. Note that the header names are case-insensitive (see https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).   Input:   GET /foo HTTP/1.1   my-header1: foo   my-header2: bar   my-header3: baz   Config:   remove: ["my-header1", "my-header3"]   Output:   GET /foo HTTP/1.1   my-header2: bar</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Set overwrites the request with the given header (name, value) before the action.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   set:   - name: "my-header"     value: "bar"   Output:   GET /foo HTTP/1.1   my-header: bar</summary>
    [JsonPropertyName("set")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet>? Set { get; set; }
}

public enum V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum
{
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    /// <summary>ResponseHeaderModifier</summary>
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    /// <summary>RequestHeaderModifier</summary>
    RequestHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    /// <summary>RequestMirror</summary>
    RequestMirror,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    /// <summary>ExtensionRef</summary>
    ExtensionRef
}

public partial class V1GRPCRouteSpecRulesBackendRefsFilters
{
    /// <summary>ExtensionRef is an optional, implementation-specific extension to the "filter" behavior.  For example, resource "myroutefilter" in group "networking.example.net"). ExtensionRef MUST NOT be used for core and extended filters.   Support: Implementation-specific   This filter can be used multiple times within the same rule.</summary>
    [JsonPropertyName("extensionRef")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>RequestHeaderModifier defines a schema for a filter that modifies request headers.   Support: Core</summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

    /// <summary>RequestMirror defines a schema for a filter that mirrors requests. Requests are sent to the specified destination, but responses from that destination are ignored.   This filter can be used multiple times within the same rule. Note that not all implementations will be able to support mirroring to multiple backends.   Support: Extended</summary>
    [JsonPropertyName("requestMirror")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>ResponseHeaderModifier defines a schema for a filter that modifies response headers.   Support: Extended</summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>Type identifies the type of filter to apply. As with other API fields, types are classified into three conformance levels:   - Core: Filter types and their corresponding configuration defined by   "Support: Core" in this package, e.g. "RequestHeaderModifier". All   implementations supporting GRPCRoute MUST support core filters.   - Extended: Filter types and their corresponding configuration defined by   "Support: Extended" in this package, e.g. "RequestMirror". Implementers   are encouraged to support extended filters.   - Implementation-specific: Filters that are defined and supported by specific vendors.   In the future, filters showing convergence in behavior across multiple   implementations will be considered for inclusion in extended or core   conformance levels. Filter-specific configuration for such filters   is specified using the ExtensionRef field. `Type` MUST be set to   "ExtensionRef" for custom filters.   Implementers are encouraged to define custom implementation types to extend the core API with implementation-specific behavior.   If a reference to a custom filter type cannot be resolved, the filter MUST NOT be skipped. Instead, requests that would have been processed by that filter MUST receive a HTTP error response.   </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum>))]
    public V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum Type { get; set; }
}

public partial class V1GRPCRouteSpecRulesBackendRefs
{
    /// <summary>Filters defined at this level MUST be executed if and only if the request is being forwarded to the backend defined here.   Support: Implementation-specific (For broader support of filters, use the Filters field in GRPCRouteRule.)</summary>
    [JsonPropertyName("filters")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFilters>? Filters { get; set; }

    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes resource kind of the referent. For example "Service".   Defaults to "Service" when not specified.   ExternalName services can refer to CNAME DNS records that may live outside of the cluster and as such are difficult to reason about in terms of conformance. They also may not be safe to forward to (see CVE-2021-25740 for more information). Implementations SHOULD NOT support ExternalName Services.   Support: Core (Services with a type other than ExternalName)   Support: Implementation-specific (Services with type ExternalName)</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the backend. When unspecified, the local namespace is inferred.   Note that when a namespace different than the local namespace is specified, a ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details.   Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port specifies the destination port number to use for this resource. Port is required when the referent is a Kubernetes Service. In this case, the port number is the service port number, not the target port. For other resources, destination port might be derived from the referent resource or this field.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Weight specifies the proportion of requests forwarded to the referenced backend. This is computed as weight/(sum of all weights in this BackendRefs list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports. Weight is not a percentage and the sum of weights does not need to equal 100.   If only one backend is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend. If weight is set to 0, no traffic should be forwarded for this entry. If unspecified, weight defaults to 1.   Support for this field varies based on the context where used.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersExtensionRef
{
    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example "HTTPRoute" or "Service".</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifierAdd
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifierSet
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifier
{
    /// <summary>Add adds the given header(s) (name, value) to the request before the action. It appends to any existing values associated with the header name.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   add:   - name: "my-header"     value: "bar,baz"   Output:   GET /foo HTTP/1.1   my-header: foo,bar,baz</summary>
    [JsonPropertyName("add")]
    public IList<V1GRPCRouteSpecRulesFiltersRequestHeaderModifierAdd>? Add { get; set; }

    /// <summary>Remove the given header(s) from the HTTP request before the action. The value of Remove is a list of HTTP header names. Note that the header names are case-insensitive (see https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).   Input:   GET /foo HTTP/1.1   my-header1: foo   my-header2: bar   my-header3: baz   Config:   remove: ["my-header1", "my-header3"]   Output:   GET /foo HTTP/1.1   my-header2: bar</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Set overwrites the request with the given header (name, value) before the action.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   set:   - name: "my-header"     value: "bar"   Output:   GET /foo HTTP/1.1   my-header: bar</summary>
    [JsonPropertyName("set")]
    public IList<V1GRPCRouteSpecRulesFiltersRequestHeaderModifierSet>? Set { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersRequestMirrorBackendRef
{
    /// <summary>Group is the group of the referent. For example, "gateway.networking.k8s.io". When unspecified or empty string, core API group is inferred.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes resource kind of the referent. For example "Service".   Defaults to "Service" when not specified.   ExternalName services can refer to CNAME DNS records that may live outside of the cluster and as such are difficult to reason about in terms of conformance. They also may not be safe to forward to (see CVE-2021-25740 for more information). Implementations SHOULD NOT support ExternalName Services.   Support: Core (Services with a type other than ExternalName)   Support: Implementation-specific (Services with type ExternalName)</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the backend. When unspecified, the local namespace is inferred.   Note that when a namespace different than the local namespace is specified, a ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details.   Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port specifies the destination port number to use for this resource. Port is required when the referent is a Kubernetes Service. In this case, the port number is the service port number, not the target port. For other resources, destination port might be derived from the referent resource or this field.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersRequestMirror
{
    /// <summary>BackendRef references a resource where mirrored requests are sent.   Mirrored requests must be sent only to a single destination endpoint within this BackendRef, irrespective of how many endpoints are present within this BackendRef.   If the referent cannot be found, this BackendRef is invalid and must be dropped from the Gateway. The controller must ensure the "ResolvedRefs" condition on the Route status is set to `status: False` and not configure this backend in the underlying implementation.   If there is a cross-namespace reference to an *existing* object that is not allowed by a ReferenceGrant, the controller must ensure the "ResolvedRefs"  condition on the Route is set to `status: False`, with the "RefNotPermitted" reason and not configure this backend in the underlying implementation.   In either error case, the Message of the `ResolvedRefs` Condition should be used to provide more detail about the problem.   Support: Extended for Kubernetes Service   Support: Implementation-specific for any other resource</summary>
    [JsonPropertyName("backendRef")]
    public V1GRPCRouteSpecRulesFiltersRequestMirrorBackendRef BackendRef { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifierAdd
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifierSet
{
    /// <summary>Name is the name of the HTTP Header to be matched. Name matching MUST be case insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).   If multiple entries specify equivalent header names, the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifier
{
    /// <summary>Add adds the given header(s) (name, value) to the request before the action. It appends to any existing values associated with the header name.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   add:   - name: "my-header"     value: "bar,baz"   Output:   GET /foo HTTP/1.1   my-header: foo,bar,baz</summary>
    [JsonPropertyName("add")]
    public IList<V1GRPCRouteSpecRulesFiltersResponseHeaderModifierAdd>? Add { get; set; }

    /// <summary>Remove the given header(s) from the HTTP request before the action. The value of Remove is a list of HTTP header names. Note that the header names are case-insensitive (see https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).   Input:   GET /foo HTTP/1.1   my-header1: foo   my-header2: bar   my-header3: baz   Config:   remove: ["my-header1", "my-header3"]   Output:   GET /foo HTTP/1.1   my-header2: bar</summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>Set overwrites the request with the given header (name, value) before the action.   Input:   GET /foo HTTP/1.1   my-header: foo   Config:   set:   - name: "my-header"     value: "bar"   Output:   GET /foo HTTP/1.1   my-header: bar</summary>
    [JsonPropertyName("set")]
    public IList<V1GRPCRouteSpecRulesFiltersResponseHeaderModifierSet>? Set { get; set; }
}

public enum V1GRPCRouteSpecRulesFiltersTypeEnum
{
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    /// <summary>ResponseHeaderModifier</summary>
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    /// <summary>RequestHeaderModifier</summary>
    RequestHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    /// <summary>RequestMirror</summary>
    RequestMirror,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    /// <summary>ExtensionRef</summary>
    ExtensionRef
}

public partial class V1GRPCRouteSpecRulesFilters
{
    /// <summary>ExtensionRef is an optional, implementation-specific extension to the "filter" behavior.  For example, resource "myroutefilter" in group "networking.example.net"). ExtensionRef MUST NOT be used for core and extended filters.   Support: Implementation-specific   This filter can be used multiple times within the same rule.</summary>
    [JsonPropertyName("extensionRef")]
    public V1GRPCRouteSpecRulesFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>RequestHeaderModifier defines a schema for a filter that modifies request headers.   Support: Core</summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1GRPCRouteSpecRulesFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

    /// <summary>RequestMirror defines a schema for a filter that mirrors requests. Requests are sent to the specified destination, but responses from that destination are ignored.   This filter can be used multiple times within the same rule. Note that not all implementations will be able to support mirroring to multiple backends.   Support: Extended</summary>
    [JsonPropertyName("requestMirror")]
    public V1GRPCRouteSpecRulesFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>ResponseHeaderModifier defines a schema for a filter that modifies response headers.   Support: Extended</summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1GRPCRouteSpecRulesFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>Type identifies the type of filter to apply. As with other API fields, types are classified into three conformance levels:   - Core: Filter types and their corresponding configuration defined by   "Support: Core" in this package, e.g. "RequestHeaderModifier". All   implementations supporting GRPCRoute MUST support core filters.   - Extended: Filter types and their corresponding configuration defined by   "Support: Extended" in this package, e.g. "RequestMirror". Implementers   are encouraged to support extended filters.   - Implementation-specific: Filters that are defined and supported by specific vendors.   In the future, filters showing convergence in behavior across multiple   implementations will be considered for inclusion in extended or core   conformance levels. Filter-specific configuration for such filters   is specified using the ExtensionRef field. `Type` MUST be set to   "ExtensionRef" for custom filters.   Implementers are encouraged to define custom implementation types to extend the core API with implementation-specific behavior.   If a reference to a custom filter type cannot be resolved, the filter MUST NOT be skipped. Instead, requests that would have been processed by that filter MUST receive a HTTP error response.   </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesFiltersTypeEnum>))]
    public V1GRPCRouteSpecRulesFiltersTypeEnum Type { get; set; }
}

public enum V1GRPCRouteSpecRulesMatchesHeadersTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    /// <summary>Exact</summary>
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    /// <summary>RegularExpression</summary>
    RegularExpression
}

public partial class V1GRPCRouteSpecRulesMatchesHeaders
{
    /// <summary>Name is the name of the gRPC Header to be matched.   If multiple entries specify equivalent header names, only the first entry with an equivalent name MUST be considered for a match. Subsequent entries with an equivalent header name MUST be ignored. Due to the case-insensitivity of header names, "foo" and "Foo" are considered equivalent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Type specifies how to match against the value of the header.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesMatchesHeadersTypeEnum>))]
    public V1GRPCRouteSpecRulesMatchesHeadersTypeEnum? Type { get; set; }

    /// <summary>Value is the value of the gRPC Header to be matched.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public enum V1GRPCRouteSpecRulesMatchesMethodTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    /// <summary>Exact</summary>
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    /// <summary>RegularExpression</summary>
    RegularExpression
}

public partial class V1GRPCRouteSpecRulesMatchesMethod
{
    /// <summary>Value of the method to match against. If left empty or omitted, will match all services.   At least one of Service and Method MUST be a non-empty string.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value of the service to match against. If left empty or omitted, will match any service.   At least one of Service and Method MUST be a non-empty string.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Type specifies how to match against the service and/or method. Support: Core (Exact with service and method specified)   Support: Implementation-specific (Exact with method specified but no service specified)   Support: Implementation-specific (RegularExpression)</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesMatchesMethodTypeEnum>))]
    public V1GRPCRouteSpecRulesMatchesMethodTypeEnum? Type { get; set; }
}

public partial class V1GRPCRouteSpecRulesMatches
{
    /// <summary>Headers specifies gRPC request header matchers. Multiple match values are ANDed together, meaning, a request MUST match all the specified headers to select the route.</summary>
    [JsonPropertyName("headers")]
    public IList<V1GRPCRouteSpecRulesMatchesHeaders>? Headers { get; set; }

    /// <summary>Method specifies a gRPC request service/method matcher. If this field is not specified, all services and methods will match.</summary>
    [JsonPropertyName("method")]
    public V1GRPCRouteSpecRulesMatchesMethod? Method { get; set; }
}

public partial class V1GRPCRouteSpecRules
{
    /// <summary>BackendRefs defines the backend(s) where matching requests should be sent.   Failure behavior here depends on how many BackendRefs are specified and how many are invalid.   If *all* entries in BackendRefs are invalid, and there are also no filters specified in this route rule, *all* traffic which matches this rule MUST receive an `UNAVAILABLE` status.   See the GRPCBackendRef definition for the rules about what makes a single GRPCBackendRef invalid.   When a GRPCBackendRef is invalid, `UNAVAILABLE` statuses MUST be returned for requests that would have otherwise been routed to an invalid backend. If multiple backends are specified, and some are invalid, the proportion of requests that would otherwise have been routed to an invalid backend MUST receive an `UNAVAILABLE` status.   For example, if two backends are specified with equal weights, and one is invalid, 50 percent of traffic MUST receive an `UNAVAILABLE` status. Implementations may choose how that 50 percent is determined.   Support: Core for Kubernetes Service   Support: Implementation-specific for any other resource   Support for weight: Core</summary>
    [JsonPropertyName("backendRefs")]
    public IList<V1GRPCRouteSpecRulesBackendRefs>? BackendRefs { get; set; }

    /// <summary>Filters define the filters that are applied to requests that match this rule.   The effects of ordering of multiple behaviors are currently unspecified. This can change in the future based on feedback during the alpha stage.   Conformance-levels at this level are defined based on the type of filter:   - ALL core filters MUST be supported by all implementations that support   GRPCRoute. - Implementers are encouraged to support extended filters. - Implementation-specific custom filters have no API guarantees across   implementations.   Specifying the same filter multiple times is not supported unless explicitly indicated in the filter.   If an implementation can not support a combination of filters, it must clearly document that limitation. In cases where incompatible or unsupported filters are specified and cause the `Accepted` condition to be set to status `False`, implementations may use the `IncompatibleFilters` reason to specify this configuration error.   Support: Core</summary>
    [JsonPropertyName("filters")]
    public IList<V1GRPCRouteSpecRulesFilters>? Filters { get; set; }

    /// <summary>Matches define conditions used for matching the rule against incoming gRPC requests. Each match is independent, i.e. this rule will be matched if **any** one of the matches is satisfied.   For example, take the following matches configuration:   ``` matches: - method:     service: foo.bar   headers:     values:       version: 2 - method:     service: foo.bar.v2 ```   For a request to match against this rule, it MUST satisfy EITHER of the two conditions:   - service of foo.bar AND contains the header `version: 2` - service of foo.bar.v2   See the documentation for GRPCRouteMatch on how to specify multiple match conditions to be ANDed together.   If no matches are specified, the implementation MUST match every gRPC request.   Proxy or Load Balancer routing configuration generated from GRPCRoutes MUST prioritize rules based on the following criteria, continuing on ties. Merging MUST not be done between GRPCRoutes and HTTPRoutes. Precedence MUST be given to the rule with the largest number of:   * Characters in a matching non-wildcard hostname. * Characters in a matching hostname. * Characters in a matching service. * Characters in a matching method. * Header matches.   If ties still exist across multiple Routes, matching precedence MUST be determined in order of the following criteria, continuing on ties:   * The oldest Route based on creation timestamp. * The Route appearing first in alphabetical order by   "{namespace}/{name}".   If ties still exist within the Route that has been given precedence, matching precedence MUST be granted to the first matching rule meeting the above criteria.</summary>
    [JsonPropertyName("matches")]
    public IList<V1GRPCRouteSpecRulesMatches>? Matches { get; set; }
}

public partial class V1GRPCRouteSpec
{
    /// <summary>Hostnames defines a set of hostnames to match against the GRPC Host header to select a GRPCRoute to process the request. This matches the RFC 1123 definition of a hostname with 2 notable exceptions:   1. IPs are not allowed. 2. A hostname may be prefixed with a wildcard label (`*.`). The wildcard    label MUST appear by itself as the first label.   If a hostname is specified by both the Listener and GRPCRoute, there MUST be at least one intersecting hostname for the GRPCRoute to be attached to the Listener. For example:   * A Listener with `test.example.com` as the hostname matches GRPCRoutes   that have either not specified any hostnames, or have specified at   least one of `test.example.com` or `*.example.com`. * A Listener with `*.example.com` as the hostname matches GRPCRoutes   that have either not specified any hostnames or have specified at least   one hostname that matches the Listener hostname. For example,   `test.example.com` and `*.example.com` would both match. On the other   hand, `example.com` and `test.example.net` would not match.   Hostnames that are prefixed with a wildcard label (`*.`) are interpreted as a suffix match. That means that a match for `*.example.com` would match both `test.example.com`, and `foo.test.example.com`, but not `example.com`.   If both the Listener and GRPCRoute have specified hostnames, any GRPCRoute hostnames that do not match the Listener hostname MUST be ignored. For example, if a Listener specified `*.example.com`, and the GRPCRoute specified `test.example.com` and `test.example.net`, `test.example.net` MUST NOT be considered for a match.   If both the Listener and GRPCRoute have specified hostnames, and none match with the criteria above, then the GRPCRoute MUST NOT be accepted by the implementation. The implementation MUST raise an 'Accepted' Condition with a status of `False` in the corresponding RouteParentStatus.   If a Route (A) of type HTTPRoute or GRPCRoute is attached to a Listener and that listener already has another Route (B) of the other type attached and the intersection of the hostnames of A and B is non-empty, then the implementation MUST accept exactly one of these two routes, determined by the following criteria, in order:   * The oldest Route based on creation timestamp. * The Route appearing first in alphabetical order by   "{namespace}/{name}".   The rejected Route MUST raise an 'Accepted' condition with a status of 'False' in the corresponding RouteParentStatus.   Support: Core</summary>
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    /// <summary>ParentRefs references the resources (usually Gateways) that a Route wants to be attached to. Note that the referenced parent resource needs to allow this for the attachment to be complete. For Gateways, that means the Gateway needs to allow attachment from Routes of this kind and namespace. For Services, that means the Service must either be in the same namespace for a "producer" route, or the mesh implementation must support and allow "consumer" routes for the referenced Service. ReferenceGrant is not applicable for governing ParentRefs to Services - it is not possible to create a "producer" route for a Service in a different namespace from the Route.   There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   This API may be extended in the future to support additional kinds of parent resources.   ParentRefs must be _distinct_. This means either that:   * They select different objects.  If this is the case, then parentRef   entries are distinct. In terms of fields, this means that the   multi-part key defined by `group`, `kind`, `namespace`, and `name` must   be unique across all parentRef entries in the Route. * They do not select different objects, but for each optional field used,   each ParentRef that selects the same object must set the same set of   optional fields to different values. If one ParentRef sets a   combination of optional fields, all must set the same combination.   Some examples:   * If one ParentRef sets `sectionName`, all ParentRefs referencing the   same object must also set `sectionName`. * If one ParentRef sets `port`, all ParentRefs referencing the same   object must also set `port`. * If one ParentRef sets `sectionName` and `port`, all ParentRefs   referencing the same object must also set `sectionName` and `port`.   It is possible to separately reference multiple distinct objects that may be collapsed by an implementation. For example, some implementations may choose to merge compatible Gateway Listeners together. If that is the case, the list of routes attached to those resources should also be merged.   Note that for ParentRefs that cross namespace boundaries, there are specific rules. Cross-namespace references are only valid if they are explicitly allowed by something in the namespace they are referring to. For example, Gateway has the AllowedRoutes field, and ReferenceGrant provides a generic way to enable other kinds of cross-namespace reference.         </summary>
    [JsonPropertyName("parentRefs")]
    public IList<V1GRPCRouteSpecParentRefs>? ParentRefs { get; set; }

    /// <summary>Rules are a list of GRPC matchers, filters and actions.</summary>
    [JsonPropertyName("rules")]
    public IList<V1GRPCRouteSpecRules>? Rules { get; set; }
}

public enum V1GRPCRouteStatusParentsConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

public partial class V1GRPCRouteStatusParentsConditions
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteStatusParentsConditionsStatusEnum>))]
    public V1GRPCRouteStatusParentsConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1GRPCRouteStatusParentsParentRef
{
    /// <summary>Group is the group of the referent. When unspecified, "gateway.networking.k8s.io" is inferred. To set the core API group (such as for a "Service" kind referent), Group must be explicitly set to "" (empty string).   Support: Core</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent.   There are two kinds of parent resources with "Core" support:   * Gateway (Gateway conformance profile) * Service (Mesh conformance profile, ClusterIP Services only)   Support for other resources is Implementation-Specific.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.   Support: Core</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of the referent. When unspecified, this refers to the local namespace of the Route.   Note that there are specific rules for ParentRefs which cross namespace boundaries. Cross-namespace references are only valid if they are explicitly allowed by something in the namespace they are referring to. For example: Gateway has the AllowedRoutes field, and ReferenceGrant provides a generic way to enable any other kind of cross-namespace reference.      Support: Core</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Port is the network port this Route targets. It can be interpreted differently based on the type of parent resource.   When the parent resource is a Gateway, this targets all listeners listening on the specified port that also support this kind of Route(and select this Route). It's not recommended to set `Port` unless the networking behaviors specified in a Route must apply to a specific port as opposed to a listener(s) whose port(s) may be changed. When both Port and SectionName are specified, the name and port of the selected listener must match both specified values.      Implementations MAY choose to support other parent resources. Implementations supporting other types of parent resources MUST clearly document how/if Port is interpreted.   For the purpose of status, an attachment is considered successful as long as the parent resource accepts it partially. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Extended</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SectionName is the name of a section within the target resource. In the following resources, SectionName is interpreted as the following:   * Gateway: Listener name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values. * Service: Port name. When both Port (experimental) and SectionName are specified, the name and port of the selected listener must match both specified values.   Implementations MAY choose to support attaching Routes to other resources. If that is the case, they MUST clearly document how SectionName is interpreted.   When unspecified (empty string), this will reference the entire resource. For the purpose of status, an attachment is considered successful if at least one section in the parent resource accepts it. For example, Gateway listeners can restrict which Routes can attach to them by Route kind, namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from the referencing Route, the Route MUST be considered successfully attached. If no Gateway listeners accept attachment from this Route, the Route MUST be considered detached from the Gateway.   Support: Core</summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

public partial class V1GRPCRouteStatusParents
{
    /// <summary>Conditions describes the status of the route with respect to the Gateway. Note that the route's availability is also subject to the Gateway's own status conditions and listener status.   If the Route's ParentRef specifies an existing Gateway that supports Routes of this kind AND that Gateway's controller has sufficient access, then that Gateway's controller MUST set the "Accepted" condition on the Route, to indicate whether the route has been accepted or rejected by the Gateway, and why.   A Route MUST be considered "Accepted" if at least one of the Route's rules is implemented by the Gateway.   There are a number of cases where the "Accepted" condition may not be set due to lack of controller visibility, that includes when:   * The Route refers to a non-existent parent. * The Route is of a type that the controller does not support. * The Route is in a namespace the controller does not have access to.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GRPCRouteStatusParentsConditions>? Conditions { get; set; }

    /// <summary>ControllerName is a domain/path string that indicates the name of the controller that wrote this status. This corresponds with the controllerName field on GatewayClass.   Example: "example.net/gateway-controller".   The format of this field is DOMAIN "/" PATH, where DOMAIN and PATH are valid Kubernetes names (https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).   Controllers MUST populate this field when writing status. Controllers should ensure that entries to status populated with their ControllerName are cleaned up when they are no longer necessary.</summary>
    [JsonPropertyName("controllerName")]
    public string ControllerName { get; set; }

    /// <summary>ParentRef corresponds with a ParentRef in the spec that this RouteParentStatus struct describes the status of.</summary>
    [JsonPropertyName("parentRef")]
    public V1GRPCRouteStatusParentsParentRef ParentRef { get; set; }
}

public partial class V1GRPCRouteStatus
{
    /// <summary>Parents is a list of parent resources (usually Gateways) that are associated with the route, and the status of the route with respect to each parent. When this route attaches to a parent, the controller that manages the parent must add an entry to this list when the controller first sees the route and should update the entry as appropriate when the route or gateway is modified.   Note that parent references that cannot be resolved by an implementation of this API will not be added to this list. Implementations of this API can only populate Route status for the Gateways/parent resources they are responsible for.   A maximum of 32 Gateways will be represented in this list. An empty list means the route has not been attached to any Gateway.</summary>
    [JsonPropertyName("parents")]
    public IList<V1GRPCRouteStatusParents> Parents { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GRPCRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1GRPCRouteSpec>, IStatus<V1GRPCRouteStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GRPCRoute";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "grpcroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of GRPCRoute.</summary>
    [JsonPropertyName("spec")]
    public V1GRPCRouteSpec? Spec { get; set; }

    /// <summary>Status defines the current state of GRPCRoute.</summary>
    [JsonPropertyName("status")]
    public V1GRPCRouteStatus? Status { get; set; }
}