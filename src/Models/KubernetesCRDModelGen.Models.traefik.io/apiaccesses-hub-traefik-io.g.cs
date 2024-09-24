using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
public partial class V1alpha1APIAccessSpecApiSelectorMatchExpressions
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

public partial class V1alpha1APIAccessSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1APIAccessSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

public partial class V1alpha1APIAccessSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1APIAccessSpecOperationFilter
{
    /// <summary>Include defines the names of OperationSets that will be accessible.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

public partial class V1alpha1APIAccessSpec
{
    /// <summary>APISelector selects the APIs that will be accessible to the configured audience. Multiple APIAccesses can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1APIAccessSpecApiSelector? ApiSelector { get; set; }

    /// <summary>APIs defines a set of APIs that will be accessible to the configured audience. Multiple APIAccesses can select the same APIs. When combined with APISelector, this set of APIs is appended to the matching APIs.</summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1APIAccessSpecApis>? Apis { get; set; }

    /// <summary>Everyone indicates that all users will have access to the selected APIs.</summary>
    [JsonPropertyName("everyone")]
    public bool? Everyone { get; set; }

    /// <summary>Groups are the consumer groups that will gain access to the selected APIs.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>OperationFilter specifies the allowed operations on APIs and APIVersions. If not set, all operations are available. An empty OperationFilter prohibits all operations.</summary>
    [JsonPropertyName("operationFilter")]
    public V1alpha1APIAccessSpecOperationFilter? OperationFilter { get; set; }
}

public partial class V1alpha1APIAccessStatus
{
    /// <summary>Hash is a hash representing the APIAccess.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIAccess : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIAccessSpec>, IStatus<V1alpha1APIAccessStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIAccess";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiaccesses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIAccess.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIAccessSpec? Spec { get; set; }

    /// <summary>The current status of this APIAccess.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIAccessStatus? Status { get; set; }
}