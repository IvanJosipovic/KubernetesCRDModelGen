using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
#nullable enable
/// <summary>LoggingLink is the Schema for the LoggingLink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LoggingLinkList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LoggingLink>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LoggingLinkList";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglinks";
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
    public IList<V1alpha1LoggingLink> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The LoggingLogBucket that this Link is associated with</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkSpecLoggingLogBucketRef
{
    /// <summary>A reference to an externally managed LoggingLogBucket resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/buckets/{{bucketID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LoggingLinkSpec defines the desired state of LoggingLink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkSpec
{
    /// <summary>Describes this link. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The LoggingLogBucket that this Link is associated with</summary>
    [JsonPropertyName("loggingLogBucketRef")]
    public V1alpha1LoggingLinkSpecLoggingLogBucketRef? LoggingLogBucketRef { get; set; }

    /// <summary>Immutable. The LoggingLink name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkStatusConditions
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
#nullable disable

#nullable enable
/// <summary>The information of a BigQuery Dataset. When a link is created, a BigQuery dataset is created along with it, in the same project as the LogBucket it's linked to. This dataset will also have BigQuery Views corresponding to the LogViews in the bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkStatusObservedStateBigQueryDataset
{
    /// <summary>Output only. The full resource name of the BigQuery dataset. The DATASET_ID  will match the ID of the link, so the link must match the naming  restrictions of BigQuery datasets (alphanumeric characters and underscores  only).   The dataset will have a resource path of    "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET_ID]"</summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkStatusObservedState
{
    /// <summary>The information of a BigQuery Dataset. When a link is created, a BigQuery dataset is created along with it, in the same project as the LogBucket it's linked to. This dataset will also have BigQuery Views corresponding to the LogViews in the bucket.</summary>
    [JsonPropertyName("bigQueryDataset")]
    public V1alpha1LoggingLinkStatusObservedStateBigQueryDataset? BigQueryDataset { get; set; }

    /// <summary>Output only. The creation timestamp of the link.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The resource lifecycle state.</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LoggingLinkStatus defines the config connector machine state of LoggingLink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoggingLinkStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LoggingLinkStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the LoggingLink resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1LoggingLinkStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LoggingLink is the Schema for the LoggingLink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LoggingLink : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LoggingLinkSpec>, IStatus<V1alpha1LoggingLinkStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LoggingLink";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglinks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoggingLinkSpec defines the desired state of LoggingLink</summary>
    [JsonPropertyName("spec")]
    public V1alpha1LoggingLinkSpec Spec { get; set; }

    /// <summary>LoggingLinkStatus defines the config connector machine state of LoggingLink</summary>
    [JsonPropertyName("status")]
    public V1alpha1LoggingLinkStatus? Status { get; set; }
}
#nullable disable
