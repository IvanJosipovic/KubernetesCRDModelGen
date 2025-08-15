using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serving.knative.dev;
/// <summary>TrafficTarget holds a single entry of the routing table for a Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteSpecTraffic
{
    /// <summary>ConfigurationName of a configuration to whose latest revision we will send this portion of traffic. When the "status.latestReadyRevisionName" of the referenced configuration changes, we will automatically migrate traffic from the prior "latest ready" revision to the new one.  This field is never set in Route's status, only its spec.  This is mutually exclusive with RevisionName.</summary>
    [JsonPropertyName("configurationName")]
    public string? ConfigurationName { get; set; }

    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target.  When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent indicates that percentage based routing should be used and the value indicates the percent of traffic that is be routed to this Revision or Configuration. `0` (zero) mean no traffic, `100` means all traffic. When percentage based routing is being used the follow rules apply: - the sum of all percent values must equal 100 - when not specified, the implied value for `percent` is zero for   that particular Revision or Configuration</summary>
    [JsonPropertyName("percent")]
    public long? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.  This is mutually exclusive with ConfigurationName.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL displays the URL for accessing named traffic targets. URL is displayed in status, and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname, but may not contain anything else (e.g. basic auth, url path, etc.)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Spec holds the desired state of the Route (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteSpec
{
    /// <summary>Traffic specifies how to distribute traffic over a collection of revisions and configurations.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1RouteSpecTraffic>? Traffic { get; set; }
}

/// <summary>Address holds the information needed for a Route to be the target of an event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteStatusAddress
{
    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience for this address.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Name is the name of the address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Condition defines a readiness condition for a Knative resource. See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>TrafficTarget holds a single entry of the routing table for a Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteStatusTraffic
{
    /// <summary>ConfigurationName of a configuration to whose latest revision we will send this portion of traffic. When the "status.latestReadyRevisionName" of the referenced configuration changes, we will automatically migrate traffic from the prior "latest ready" revision to the new one.  This field is never set in Route's status, only its spec.  This is mutually exclusive with RevisionName.</summary>
    [JsonPropertyName("configurationName")]
    public string? ConfigurationName { get; set; }

    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target.  When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent indicates that percentage based routing should be used and the value indicates the percent of traffic that is be routed to this Revision or Configuration. `0` (zero) mean no traffic, `100` means all traffic. When percentage based routing is being used the follow rules apply: - the sum of all percent values must equal 100 - when not specified, the implied value for `percent` is zero for   that particular Revision or Configuration</summary>
    [JsonPropertyName("percent")]
    public long? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.  This is mutually exclusive with ConfigurationName.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL displays the URL for accessing named traffic targets. URL is displayed in status, and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname, but may not contain anything else (e.g. basic auth, url path, etc.)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Status communicates the observed state of the Route (from the controller).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1RouteStatus
{
    /// <summary>Address holds the information needed for a Route to be the target of an event.</summary>
    [JsonPropertyName("address")]
    public V1RouteStatusAddress? Address { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1RouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Traffic holds the configured traffic distribution. These entries will always contain RevisionName references. When ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that we last observed.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1RouteStatusTraffic>? Traffic { get; set; }

    /// <summary>URL holds the url that will distribute traffic over the provided traffic targets. It generally has the form http[s]://{route-name}.{route-namespace}.{cluster-level-suffix}</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Route is responsible for configuring ingress over a collection of Revisions. Some of the Revisions a Route distributes traffic over may be specified by referencing the Configuration responsible for creating them; in these cases the Route is additionally responsible for monitoring the Configuration for "latest ready revision" changes, and smoothly rolling out latest revisions. See also: https://github.com/knative/serving/blob/main/docs/spec/overview.md#route</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Route : IKubernetesObject<V1ObjectMeta>, ISpec<V1RouteSpec>, IStatus<V1RouteStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Route";
    public const string KubeGroup = "serving.knative.dev";
    public const string KubePluralName = "routes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec holds the desired state of the Route (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1RouteSpec? Spec { get; set; }

    /// <summary>Status communicates the observed state of the Route (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1RouteStatus? Status { get; set; }
}

/// <summary>Route is responsible for configuring ingress over a collection of Revisions. Some of the Revisions a Route distributes traffic over may be specified by referencing the Configuration responsible for creating them; in these cases the Route is additionally responsible for monitoring the Configuration for "latest ready revision" changes, and smoothly rolling out latest revisions. See also: https://github.com/knative/serving/blob/main/docs/spec/overview.md#route</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1RouteList : IKubernetesObject<V1ListMeta>, IItems<V1Route>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "RouteList";
    public const string KubeGroup = "serving.knative.dev";
    public const string KubePluralName = "routes";
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
    public IList<V1Route> Items { get; set; }
}