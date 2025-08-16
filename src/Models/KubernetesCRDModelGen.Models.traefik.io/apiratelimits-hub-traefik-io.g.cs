using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>APIRateLimit defines how group of consumers are rate limited on a set of APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIRateLimitList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIRateLimit>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIRateLimitList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiratelimits";
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
    public IList<V1alpha1APIRateLimit> Items { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIRateLimitSpecApiSelectorMatchExpressions
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

/// <summary>APISelector selects the APIs that will be rate limited. Multiple APIRateLimits can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIRateLimitSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1APIRateLimitSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>APIReference references an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIRateLimitSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The desired behavior of this APIRateLimit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIRateLimitSpec
{
    /// <summary>APISelector selects the APIs that will be rate limited. Multiple APIRateLimits can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1APIRateLimitSpecApiSelector? ApiSelector { get; set; }

    /// <summary>APIs defines a set of APIs that will be rate limited. Multiple APIRateLimits can select the same APIs. When combined with APISelector, this set of APIs is appended to the matching APIs.</summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1APIRateLimitSpecApis>? Apis { get; set; }

    /// <summary>Everyone indicates that all users will, by default, be rate limited with this configuration. If an APIRateLimit explicitly target a group, the default rate limit will be ignored.</summary>
    [JsonPropertyName("everyone")]
    public bool? Everyone { get; set; }

    /// <summary>Groups are the consumer groups that will be rate limited. Multiple APIRateLimits can target the same set of consumer groups, the most restrictive one applies. When a consumer belongs to multiple groups, the least restrictive APIRateLimit applies.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Limit is the maximum number of token in the bucket.</summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    /// <summary>Period is the unit of time for the Limit.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>Strategy defines how the bucket state will be synchronized between the different Traefik Hub instances. It can be, either "local" or "distributed".</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>The current status of this APIRateLimit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIRateLimitStatus
{
    /// <summary>Hash is a hash representing the APIRateLimit.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIRateLimit defines how group of consumers are rate limited on a set of APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIRateLimit : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIRateLimitSpec>, IStatus<V1alpha1APIRateLimitStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIRateLimit";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiratelimits";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIRateLimit.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIRateLimitSpec? Spec { get; set; }

    /// <summary>The current status of this APIRateLimit.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIRateLimitStatus? Status { get; set; }
}