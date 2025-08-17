using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
#nullable enable
/// <summary>APICatalogItem defines APIs that will be part of the API catalog on the portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APICatalogItemList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APICatalogItem>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APICatalogItemList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apicatalogitems";
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
    public IList<V1alpha1APICatalogItem> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIBundleReference references an APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiBundles
{
    /// <summary>Name of the APIBundle.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIPlan defines which APIPlan will be available. If multiple APICatalogItem specify the same API with different APIPlan, the API consumer will be able to pick a plan from this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiPlan
{
    /// <summary>Name of the APIPlan.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary>APISelector selects the APIs that will be visible to the configured audience. Multiple APICatalogItem can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1APICatalogItemSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIReference references an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OperationFilter specifies the visible operations on APIs and APIVersions. If not set, all operations are available. An empty OperationFilter prohibits all operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecOperationFilter
{
    /// <summary>Include defines the names of OperationSets that will be accessible.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The desired behavior of this APICatalogItem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpec
{
    /// <summary>APIBundles defines a set of APIBundle that will be visible to the configured audience. Multiple APICatalogItem can select the same APIBundles.</summary>
    [JsonPropertyName("apiBundles")]
    public IList<V1alpha1APICatalogItemSpecApiBundles>? ApiBundles { get; set; }

    /// <summary>APIPlan defines which APIPlan will be available. If multiple APICatalogItem specify the same API with different APIPlan, the API consumer will be able to pick a plan from this list.</summary>
    [JsonPropertyName("apiPlan")]
    public V1alpha1APICatalogItemSpecApiPlan? ApiPlan { get; set; }

    /// <summary>APISelector selects the APIs that will be visible to the configured audience. Multiple APICatalogItem can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1APICatalogItemSpecApiSelector? ApiSelector { get; set; }

    /// <summary>APIs defines a set of APIs that will be visible to the configured audience. Multiple APICatalogItem can select the same APIs. When combined with APISelector, this set of APIs is appended to the matching APIs.</summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1APICatalogItemSpecApis>? Apis { get; set; }

    /// <summary>Everyone indicates that all users will see these APIs.</summary>
    [JsonPropertyName("everyone")]
    public bool? Everyone { get; set; }

    /// <summary>Groups are the consumer groups that will see the APIs.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>OperationFilter specifies the visible operations on APIs and APIVersions. If not set, all operations are available. An empty OperationFilter prohibits all operations.</summary>
    [JsonPropertyName("operationFilter")]
    public V1alpha1APICatalogItemSpecOperationFilter? OperationFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The current status of this APICatalogItem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemStatus
{
    /// <summary>Hash is a hash representing the APICatalogItem.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APICatalogItem defines APIs that will be part of the API catalog on the portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APICatalogItem : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APICatalogItemSpec>, IStatus<V1alpha1APICatalogItemStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APICatalogItem";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apicatalogitems";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APICatalogItem.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APICatalogItemSpec? Spec { get; set; }

    /// <summary>The current status of this APICatalogItem.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APICatalogItemStatus? Status { get; set; }
}
#nullable disable
