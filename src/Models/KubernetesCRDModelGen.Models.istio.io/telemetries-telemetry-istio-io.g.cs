using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.telemetry.istio.io;
/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingFilter
{
    /// <summary>CEL expression for selecting when requests/connections should be logged.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>Allows tailoring of logging behavior to specific conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingMatch
{
    /// <summary>This determines whether or not to apply the access logging configuration based on the direction of traffic relative to the proxied workload.  Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLogging
{
    /// <summary>Controls logging.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1TelemetrySpecAccessLoggingFilter? Filter { get; set; }

    /// <summary>Allows tailoring of logging behavior to specific conditions.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecAccessLoggingMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecAccessLoggingProviders>? Providers { get; set; }
}

/// <summary>Match allows providing the scope of the override.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverridesMatch
{
    /// <summary>Allows free-form specification of a metric.</summary>
    [JsonPropertyName("customMetric")]
    public string? CustomMetric { get; set; }

    /// <summary>One of the well-known [Istio Standard Metrics](https://istio.io/latest/docs/reference/config/metrics/).  Valid Options: ALL_METRICS, REQUEST_COUNT, REQUEST_DURATION, REQUEST_SIZE, RESPONSE_SIZE, TCP_OPENED_CONNECTIONS, TCP_CLOSED_CONNECTIONS, TCP_SENT_BYTES, TCP_RECEIVED_BYTES, GRPC_REQUEST_MESSAGES, GRPC_RESPONSE_MESSAGES</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>Controls which mode of metrics generation is selected: `CLIENT`, `SERVER`, or `CLIENT_AND_SERVER`.  Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverridesTagOverrides
{
    /// <summary>Operation controls whether or not to update/add a tag, or to remove it.  Valid Options: UPSERT, REMOVE</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Value is only considered if the operation is `UPSERT`.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverrides
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Match allows providing the scope of the override.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecMetricsOverridesMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("tagOverrides")]
    public IDictionary<string, V1alpha1TelemetrySpecMetricsOverridesTagOverrides>? TagOverrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetrics
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1alpha1TelemetrySpecMetricsOverrides>? Overrides { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecMetricsProviders>? Providers { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("reportingInterval")]
    public string? ReportingInterval { get; set; }
}

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTargetRef
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTargetRefs
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Environment adds the value of an environment variable to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsEnvironment
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>Name of the environment variable from which to extract the tag value.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RequestHeader adds the value of an header from the request to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsHeader
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>Name of the header from which to extract the tag value.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Literal adds the same, hard-coded value to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsLiteral
{
    /// <summary>The tag value to use.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTags
{
    /// <summary>Environment adds the value of an environment variable to each span.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1TelemetrySpecTracingCustomTagsEnvironment? Environment { get; set; }

    /// <summary>RequestHeader adds the value of an header from the request to each span.</summary>
    [JsonPropertyName("header")]
    public V1alpha1TelemetrySpecTracingCustomTagsHeader? Header { get; set; }

    /// <summary>Literal adds the same, hard-coded value to each span.</summary>
    [JsonPropertyName("literal")]
    public V1alpha1TelemetrySpecTracingCustomTagsLiteral? Literal { get; set; }
}

/// <summary>Allows tailoring of behavior to specific conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingMatch
{
    /// <summary>This determines whether or not to apply the tracing configuration based on the direction of traffic relative to the proxied workload.  Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracing
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, V1alpha1TelemetrySpecTracingCustomTags>? CustomTags { get; set; }

    /// <summary>Controls span reporting.</summary>
    [JsonPropertyName("disableSpanReporting")]
    public bool? DisableSpanReporting { get; set; }

    /// <summary>Determines whether or not trace spans generated by Envoy will include Istio specific tags.</summary>
    [JsonPropertyName("enableIstioTags")]
    public bool? EnableIstioTags { get; set; }

    /// <summary>Allows tailoring of behavior to specific conditions.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecTracingMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecTracingProviders>? Providers { get; set; }

    /// <summary>Controls the rate at which traffic will be selected for tracing if no prior sampling decision has been made.</summary>
    [JsonPropertyName("randomSamplingPercentage")]
    public double? RandomSamplingPercentage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useRequestIdForTraceSampling")]
    public bool? UseRequestIdForTraceSampling { get; set; }
}

/// <summary>Telemetry configuration for workloads. See more details at: https://istio.io/docs/reference/config/telemetry.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpec
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("accessLogging")]
    public IList<V1alpha1TelemetrySpecAccessLogging>? AccessLogging { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1TelemetrySpecMetrics>? Metrics { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1TelemetrySpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRef")]
    public V1alpha1TelemetrySpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1TelemetrySpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("tracing")]
    public IList<V1alpha1TelemetrySpecTracing>? Tracing { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Telemetry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TelemetrySpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Telemetry";
    public const string KubeGroup = "telemetry.istio.io";
    public const string KubePluralName = "telemetries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Telemetry configuration for workloads. See more details at: https://istio.io/docs/reference/config/telemetry.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TelemetrySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}