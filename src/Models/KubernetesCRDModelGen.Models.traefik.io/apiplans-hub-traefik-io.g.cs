using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>Quota defines the quota policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpecQuota
{
    /// <summary>Limit is the maximum number of token in the bucket.</summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    /// <summary>Period is the unit of time for the Limit.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>RateLimit defines the rate limit policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpecRateLimit
{
    /// <summary>Limit is the maximum number of token in the bucket.</summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    /// <summary>Period is the unit of time for the Limit.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>The desired behavior of this APIPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpec
{
    /// <summary>Description describes the plan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Quota defines the quota policy.</summary>
    [JsonPropertyName("quota")]
    public V1alpha1APIPlanSpecQuota? Quota { get; set; }

    /// <summary>RateLimit defines the rate limit policy.</summary>
    [JsonPropertyName("rateLimit")]
    public V1alpha1APIPlanSpecRateLimit? RateLimit { get; set; }

    /// <summary>Title is the human-readable name of the plan.</summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>The current status of this APIPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanStatus
{
    /// <summary>Hash is a hash representing the APIPlan.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIPlan defines API Plan policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPlanSpec>, IStatus<V1alpha1APIPlanStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPlan";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPlan.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPlanSpec? Spec { get; set; }

    /// <summary>The current status of this APIPlan.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPlanStatus? Status { get; set; }
}