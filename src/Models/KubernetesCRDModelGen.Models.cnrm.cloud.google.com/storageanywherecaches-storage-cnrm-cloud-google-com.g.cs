using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
/// <summary>Immutable. The reference to bucket where cache needs to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheSpecBucketRef
{
    /// <summary>The StorageBucket selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>StorageAnywhereCacheSpec defines the desired state of StorageAnywhereCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheSpec
{
    /// <summary>Cache admission policy. Valid values includes: `admit-on-first-miss` and `admit-on-second-miss`. Defaults to `admit-on-first-miss`.</summary>
    [JsonPropertyName("admissionPolicy")]
    public string? AdmissionPolicy { get; set; }

    /// <summary>Immutable. The reference to bucket where cache needs to be created.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageAnywhereCacheSpecBucketRef BucketRef { get; set; }

    /// <summary>The desired state of the cache. Possible values include "running", "disabled", and "paused". If not specified, the default value is "running". This field controls the runtime behavior of the cache. Please note that changes to the `desiredState` are prioritized over any other updates. For instance, if both the `desiredState` and `ttl` are updated simultaneously, the state would be updated first, followed by `ttl`.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>The AnywhereCacheID generated via backend, It can be used by users to manage an existing cache.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Cache entry TTL (ranges between 1h to 7d). This is a cache-level config that defines how long a cache entry can live. Defaults to "86400s" TTL must be in whole seconds.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Immutable. The zone in which the cache instance needs to be created. For example, us-central1-a.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatusObservedState
{
    /// <summary>Output only. Time when Anywhere cache instance is allocated.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. True if there is an active update operation against this cache instance. Subsequential update requests will be rejected if this field is true. Output only.</summary>
    [JsonPropertyName("pendingUpdate")]
    public bool? PendingUpdate { get; set; }

    /// <summary>Output only. Cache state including "running", "creating", "disabled" and "paused".</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Time when Anywhere cache instance is last updated, including creation.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>StorageAnywhereCacheStatus defines the config connector machine state of StorageAnywhereCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageAnywhereCacheStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the StorageAnywhereCache resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1StorageAnywhereCacheStatusObservedState? ObservedState { get; set; }
}

/// <summary>StorageAnywhereCache is the Schema for the StorageAnywhereCache API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageAnywhereCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageAnywhereCacheSpec>, IStatus<V1beta1StorageAnywhereCacheStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageAnywhereCache";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storageanywherecaches";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageAnywhereCacheSpec defines the desired state of StorageAnywhereCache</summary>
    [JsonPropertyName("spec")]
    public V1beta1StorageAnywhereCacheSpec Spec { get; set; }

    /// <summary>StorageAnywhereCacheStatus defines the config connector machine state of StorageAnywhereCache</summary>
    [JsonPropertyName("status")]
    public V1beta1StorageAnywhereCacheStatus? Status { get; set; }
}

/// <summary>StorageAnywhereCache is the Schema for the StorageAnywhereCache API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageAnywhereCacheList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageAnywhereCache>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageAnywhereCacheList";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storageanywherecaches";
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
    public IList<V1beta1StorageAnywhereCache> Items { get; set; }
}