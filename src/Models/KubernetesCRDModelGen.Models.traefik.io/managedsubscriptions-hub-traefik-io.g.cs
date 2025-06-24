using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>APIBundleReference references an APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiBundles
{
    /// <summary>Name of the APIBundle.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>APIPlan defines which APIPlan will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiPlan
{
    /// <summary>Name of the APIPlan.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiSelectorMatchExpressions
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

/// <summary>APISelector selects the APIs that will be accessible. Multiple ManagedSubscriptions can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ManagedSubscriptionSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>APIReference references an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ApplicationReference references an Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApplications
{
    /// <summary>AppID is the public identifier of the application. In the case of OIDC, it corresponds to the clientId.</summary>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }
}

/// <summary>ManagedApplicationReference references a ManagedApplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecManagedApplications
{
    /// <summary>Name is the name of the ManagedApplication.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OperationFilter specifies the allowed operations on APIs and APIVersions. If not set, all operations are available. An empty OperationFilter prohibits all operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecOperationFilter
{
    /// <summary>Include defines the names of OperationSets that will be accessible.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The desired behavior of this ManagedSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpec
{
    /// <summary>APIBundles defines a set of APIBundle that will be accessible. Multiple ManagedSubscriptions can select the same APIBundles.</summary>
    [JsonPropertyName("apiBundles")]
    public IList<V1alpha1ManagedSubscriptionSpecApiBundles>? ApiBundles { get; set; }

    /// <summary>APIPlan defines which APIPlan will be used.</summary>
    [JsonPropertyName("apiPlan")]
    public V1alpha1ManagedSubscriptionSpecApiPlan ApiPlan { get; set; }

    /// <summary>APISelector selects the APIs that will be accessible. Multiple ManagedSubscriptions can select the same set of APIs. This field is optional and follows standard label selector semantics. An empty APISelector matches any API.</summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1ManagedSubscriptionSpecApiSelector? ApiSelector { get; set; }

    /// <summary>APIs defines a set of APIs that will be accessible. Multiple ManagedSubscriptions can select the same APIs. When combined with APISelector, this set of APIs is appended to the matching APIs.</summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1ManagedSubscriptionSpecApis>? Apis { get; set; }

    /// <summary>Applications references the Applications that will gain access to the specified APIs. Multiple ManagedSubscriptions can select the same AppID. Deprecated: Use ManagedApplications instead.</summary>
    [JsonPropertyName("applications")]
    public IList<V1alpha1ManagedSubscriptionSpecApplications>? Applications { get; set; }

    /// <summary>Claims specifies an expression that validate claims in order to authorize the request.</summary>
    [JsonPropertyName("claims")]
    public string? Claims { get; set; }

    /// <summary>ManagedApplications references the ManagedApplications that will gain access to the specified APIs. Multiple ManagedSubscriptions can select the same ManagedApplication.</summary>
    [JsonPropertyName("managedApplications")]
    public IList<V1alpha1ManagedSubscriptionSpecManagedApplications>? ManagedApplications { get; set; }

    /// <summary>OperationFilter specifies the allowed operations on APIs and APIVersions. If not set, all operations are available. An empty OperationFilter prohibits all operations.</summary>
    [JsonPropertyName("operationFilter")]
    public V1alpha1ManagedSubscriptionSpecOperationFilter? OperationFilter { get; set; }

    /// <summary>Weight specifies the evaluation order of the APIPlan. When multiple ManagedSubscriptions targets the same API and Application with different APIPlan, the APIPlan with the highest weight will be enforced. If weights are equal, alphabetical order is used.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>The current status of this ManagedSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionStatus
{
    /// <summary>Hash is a hash representing the ManagedSubscription.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ManagedSubscription defines a Subscription managed by the API manager as the result of a pre-negotiation with its API consumers. This subscription grant consuming access to a set of APIs to a set of Applications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedSubscriptionSpec>, IStatus<V1alpha1ManagedSubscriptionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedSubscription";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedsubscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this ManagedSubscription.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ManagedSubscriptionSpec? Spec { get; set; }

    /// <summary>The current status of this ManagedSubscription.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedSubscriptionStatus? Status { get; set; }
}

/// <summary>ManagedSubscription defines a Subscription managed by the API manager as the result of a pre-negotiation with its API consumers. This subscription grant consuming access to a set of APIs to a set of Applications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedSubscription>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedSubscriptionList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedsubscriptions";
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
    public IList<V1alpha1ManagedSubscription> Items { get; set; }
}