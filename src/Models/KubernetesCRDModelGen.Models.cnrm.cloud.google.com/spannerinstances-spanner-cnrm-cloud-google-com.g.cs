using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.cnrm.cloud.google.com;
#nullable enable
/// <summary>SpannerInstance is the Schema for the SpannerInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpannerInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpannerInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpannerInstanceList";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerinstances";
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
    public IList<V1beta1SpannerInstance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Autoscaling limits for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceSpecAutoscalingConfigAutoscalingLimits
{
    /// <summary>Maximum number of nodes allocated to the instance. If set, this number should be greater than or equal to min_nodes.</summary>
    [JsonPropertyName("maxNodes")]
    public int? MaxNodes { get; set; }

    /// <summary>Maximum number of processing units allocated to the instance. If set, this number should be multiples of 1000 and be greater than or equal to min_processing_units.</summary>
    [JsonPropertyName("maxProcessingUnits")]
    public int? MaxProcessingUnits { get; set; }

    /// <summary>Minimum number of nodes allocated to the instance. If set, this number should be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodes")]
    public int? MinNodes { get; set; }

    /// <summary>Minimum number of processing units allocated to the instance. If set, this number should be multiples of 1000.</summary>
    [JsonPropertyName("minProcessingUnits")]
    public int? MinProcessingUnits { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The autoscaling targets for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceSpecAutoscalingConfigAutoscalingTargets
{
    /// <summary>Required. The target high priority cpu utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization). The valid range is [10, 90] inclusive.</summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public int? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>Required. The target storage utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization). The valid range is [10, 100] inclusive.</summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public int? StorageUtilizationPercent { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is enabled, node_count and processing_units are treated as OUTPUT_ONLY fields and reflect the current compute capacity allocated to the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceSpecAutoscalingConfig
{
    /// <summary>Required. Autoscaling limits for an instance.</summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta1SpannerInstanceSpecAutoscalingConfigAutoscalingLimits? AutoscalingLimits { get; set; }

    /// <summary>Required. The autoscaling targets for an instance.</summary>
    [JsonPropertyName("autoscalingTargets")]
    public V1beta1SpannerInstanceSpecAutoscalingConfigAutoscalingTargets? AutoscalingTargets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpannerInstanceSpec defines the desired state of SpannerInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceSpec
{
    /// <summary>Optional. The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is enabled, node_count and processing_units are treated as OUTPUT_ONLY fields and reflect the current compute capacity allocated to the instance.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta1SpannerInstanceSpecAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>Immutable. The name of the instance's configuration (similar but not quite the same as a region) which defines the geographic placement and replication of your databases in this instance. It determines where your data is stored. Values are typically of the form 'regional-europe-west1' , 'us-central' etc. In order to obtain a valid list please consult the [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).</summary>
    [JsonPropertyName("config")]
    public string Config { get; set; }

    /// <summary>Optional. Controls the default backup schedule behavior for new databases within the instance. By default, a backup schedule is created automatically when a new database is created in a new instance.  Note that the `AUTOMATIC` value isn't permitted for free instances, as backups and backup schedules aren't supported for free instances.  In the `GetInstance` or `ListInstances` response, if the value of `default_backup_schedule_type` isn't set, or set to `NONE`, Spanner doesn't create a default backup schedule for new databases in the instance.</summary>
    [JsonPropertyName("defaultBackupScheduleType")]
    public string? DefaultBackupScheduleType { get; set; }

    /// <summary>The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters in length.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Optional. The `Edition` of the current instance. Currently accepted values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS. If edition is unspecified, it has automatically upgraded to the lowest edition that matches your usage pattern.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Cloud Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that reflect a customer's organizational needs and deployment strategies. Cloud Labels can be used to filter collections of resources. They can be used to control how resource metrics are aggregated. And they can be used as arguments to policy management rules (e.g. route, firewall, load balancing, etc.).    - Label keys must be between 1 and 63 characters long and must conform to     the following regular expression: `[a-z][a-z0-9_-]{0,62}`.   - Label values must be between 0 and 63 characters long and must conform     to the regular expression `[a-z0-9_-]{0,63}`.   - No more than 64 labels can be associated with a given resource.  See https://goo.gl/xmQnxf for more information on and examples of labels.  If you plan to use labels in your own code, please note that additional characters may be allowed in the future. And so you are advised to use an internal label representation, such as JSON, which doesn't rely upon specific characters being disallowed.  For example, representing labels as the string:  name + "_" + value  would prove problematic if we were to allow "_" in a future release.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numNodes")]
    public int? NumNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("processingUnits")]
    public int? ProcessingUnits { get; set; }

    /// <summary>The SpannerInstance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceStatusObservedState
{
    /// <summary>NumNodes and ProcessUnits is output fields with AutoScaler is set.</summary>
    [JsonPropertyName("numNodes")]
    public int? NumNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("processingUnits")]
    public int? ProcessingUnits { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpannerInstanceStatus defines the config connector machine state of SpannerInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the SpannerInstance's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpannerInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpannerInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SpannerInstanceStatusObservedState? ObservedState { get; set; }

    /// <summary>Instance status: 'CREATING' or 'READY'.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpannerInstance is the Schema for the SpannerInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpannerInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpannerInstanceSpec>, IStatus<V1beta1SpannerInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpannerInstance";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpannerInstanceSpec defines the desired state of SpannerInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpannerInstanceSpec Spec { get; set; }

    /// <summary>SpannerInstanceStatus defines the config connector machine state of SpannerInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1SpannerInstanceStatus? Status { get; set; }
}
#nullable disable
