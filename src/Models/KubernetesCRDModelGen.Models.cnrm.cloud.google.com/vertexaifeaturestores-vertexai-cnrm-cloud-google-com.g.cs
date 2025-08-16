using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>VertexAIFeaturestore is the Schema for the VertexAIFeaturestore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeaturestoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIFeaturestore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeaturestoreList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturestores";
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
    public IList<V1alpha1VertexAIFeaturestore> Items { get; set; }
}

/// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpecEncryptionSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Customer-managed encryption key spec for data storage. If set, both of the online and offline data storage will be secured by this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1VertexAIFeaturestoreSpecEncryptionSpecKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>Online serving scaling configuration. Only one of `fixed_node_count` and `scaling` can be set. Setting one will reset the other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpecOnlineServingConfigScaling
{
    /// <summary>Optional. The cpu utilization that the Autoscaler should be trying to achieve. This number is on a scale from 0 (no utilization) to 100 (total utilization), and is limited between 10 and 80. When a cluster's CPU utilization exceeds the target that you have set, Bigtable immediately adds nodes to the cluster. When CPU utilization is substantially lower than the target, Bigtable removes nodes. If not set or set to 0, default to 50.</summary>
    [JsonPropertyName("cpuUtilizationTarget")]
    public int? CpuUtilizationTarget { get; set; }

    /// <summary>The maximum number of nodes to scale up to. Must be greater than min_node_count, and less than or equal to 10 times of 'min_node_count'.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>Required. The minimum number of nodes to scale down to. Must be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Optional. Config for online storage resources. The field should not co-exist with the field of `OnlineStoreReplicationConfig`. If both of it and OnlineStoreReplicationConfig are unset, the feature store will not have an online store and cannot be used for online serving.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpecOnlineServingConfig
{
    /// <summary>The number of nodes for the online store. The number of nodes doesn't scale automatically, but you can manually update the number of nodes. If set to 0, the featurestore will not have an online store and cannot be used for online serving.</summary>
    [JsonPropertyName("fixedNodeCount")]
    public int? FixedNodeCount { get; set; }

    /// <summary>Online serving scaling configuration. Only one of `fixed_node_count` and `scaling` can be set. Setting one will reset the other.</summary>
    [JsonPropertyName("scaling")]
    public V1alpha1VertexAIFeaturestoreSpecOnlineServingConfigScaling? Scaling { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VertexAIFeaturestoreSpec defines the desired state of VertexAIFeaturestore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreSpec
{
    /// <summary>Optional. Customer-managed encryption key spec for data storage. If set, both of the online and offline data storage will be secured by this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIFeaturestoreSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Optional. Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. The labels with user-defined metadata to organize your  Featurestore.   Label keys and values can be no longer than 64 characters  (Unicode codepoints), can only contain lowercase letters, numeric  characters, underscores and dashes. International characters are allowed.   See https://goo.gl/xmQnxf for more information on and examples of labels.  No more than 64 user labels can be associated with one Featurestore(System  labels are excluded)."  System reserved label keys are prefixed with "aiplatform.googleapis.com/"  and are immutable.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Config for online storage resources. The field should not co-exist with the field of `OnlineStoreReplicationConfig`. If both of it and OnlineStoreReplicationConfig are unset, the feature store will not have an online store and cannot be used for online serving.</summary>
    [JsonPropertyName("onlineServingConfig")]
    public V1alpha1VertexAIFeaturestoreSpecOnlineServingConfig? OnlineServingConfig { get; set; }

    /// <summary>Optional. TTL in days for feature values that will be stored in online serving storage. The Feature Store online storage periodically removes obsolete feature values older than `online_storage_ttl_days` since the feature generation time. Note that `online_storage_ttl_days` should be less than or equal to `offline_storage_ttl_days` for each EntityType under a featurestore. If not set, default to 4000 days</summary>
    [JsonPropertyName("onlineStorageTTLDays")]
    public int? OnlineStorageTTLDays { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VertexAIFeaturestoreSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAIFeaturestore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreStatusConditions
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
public partial class V1alpha1VertexAIFeaturestoreStatusObservedState
{
    /// <summary>Output only. Timestamp when this Featurestore was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. State of the featurestore.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Timestamp when this Featurestore was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIFeaturestoreStatus defines the config connector machine state of VertexAIFeaturestore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIFeaturestoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIFeaturestore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIFeaturestoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIFeaturestore is the Schema for the VertexAIFeaturestore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeaturestore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIFeaturestoreSpec>, IStatus<V1alpha1VertexAIFeaturestoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeaturestore";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturestores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIFeaturestoreSpec defines the desired state of VertexAIFeaturestore</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VertexAIFeaturestoreSpec Spec { get; set; }

    /// <summary>VertexAIFeaturestoreStatus defines the config connector machine state of VertexAIFeaturestore</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIFeaturestoreStatus? Status { get; set; }
}