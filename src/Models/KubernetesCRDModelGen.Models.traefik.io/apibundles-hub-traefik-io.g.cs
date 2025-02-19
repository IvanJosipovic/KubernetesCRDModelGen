using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIBundleSpecApiSelectorMatchExpressions
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

/// <summary>APISelector selects the APIs that will be accessible to the configured audience. Multiple APIBundles can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIBundleSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1APIBundleSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>APIReference references an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIBundleSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The desired behavior of this APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIBundleSpec
{
    /// <summary>APISelector selects the APIs that will be accessible to the configured audience. Multiple APIBundles can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1APIBundleSpecApiSelector? ApiSelector { get; set; }

    /// <summary>APIs defines a set of APIs that will be accessible to the configured audience. Multiple APIBundles can select the same APIs. When combined with APISelector, this set of APIs is appended to the matching APIs.</summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1APIBundleSpecApis>? Apis { get; set; }

    /// <summary>Title is the human-readable name of the APIBundle that will be used on the portal.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>The current status of this APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIBundleStatus
{
    /// <summary>Hash is a hash representing the APIBundle.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIBundle defines a set of APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIBundle : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIBundleSpec>, IStatus<V1alpha1APIBundleStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIBundle";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apibundles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIBundle.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIBundleSpec? Spec { get; set; }

    /// <summary>The current status of this APIBundle.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIBundleStatus? Status { get; set; }
}