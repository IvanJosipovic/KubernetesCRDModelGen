using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNodeGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeNodeGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNodeGroupList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenodegroups";
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
    public IList<V1beta1ComputeNodeGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. If you use sole-tenant nodes for your workloads, you can use the node group autoscaler to automatically manage the sizes of your node groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecAutoscalingPolicy
{
    /// <summary>Immutable. Maximum size of the node group. Set to a value less than or equal to 100 and greater than or equal to min-nodes.</summary>
    [JsonPropertyName("maxNodes")]
    public int? MaxNodes { get; set; }

    /// <summary>Immutable. Minimum size of the node group. Must be less than or equal to max-nodes. The default value is 0.</summary>
    [JsonPropertyName("minNodes")]
    public int? MinNodes { get; set; }

    /// <summary>Immutable. The autoscaling mode. Set to one of the following:   - OFF: Disables the autoscaler.   - ON: Enables scaling in and scaling out.   - ONLY_SCALE_OUT: Enables only scaling out.   You must use this mode if your node groups are configured to   restart their hosted VMs on minimal servers. Possible values: ["OFF", "ON", "ONLY_SCALE_OUT"].</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. contains properties for the timeframe of maintenance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecMaintenanceWindow
{
    /// <summary>Immutable. instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.</summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The node template to which this node group belongs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecNodeTemplateRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNodeTemplate` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The key of this project config in the parent map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecShareSettingsProjectMapIdRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project id/number should be the same as the key of this project config in the project map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecShareSettingsProjectMapProjectIdRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecShareSettingsProjectMap
{
    /// <summary>The key of this project config in the parent map.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1ComputeNodeGroupSpecShareSettingsProjectMapIdRef IdRef { get; set; }

    /// <summary>The project id/number should be the same as the key of this project config in the project map.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1ComputeNodeGroupSpecShareSettingsProjectMapProjectIdRef ProjectIdRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Share settings for the node group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpecShareSettings
{
    /// <summary>Immutable. A map of project id and project config. This is only valid when shareType's value is SPECIFIC_PROJECTS.</summary>
    [JsonPropertyName("projectMap")]
    public IList<V1beta1ComputeNodeGroupSpecShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>Immutable. Node group sharing type. Possible values: ["ORGANIZATION", "SPECIFIC_PROJECTS", "LOCAL"].</summary>
    [JsonPropertyName("shareType")]
    public string ShareType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupSpec
{
    /// <summary>Immutable. If you use sole-tenant nodes for your workloads, you can use the node group autoscaler to automatically manage the sizes of your node groups.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public V1beta1ComputeNodeGroupSpecAutoscalingPolicy? AutoscalingPolicy { get; set; }

    /// <summary>Immutable. An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The initial number of nodes in the node group. One of 'initial_size' or 'size' must be specified.</summary>
    [JsonPropertyName("initialSize")]
    public int? InitialSize { get; set; }

    /// <summary>Immutable. Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public string? MaintenancePolicy { get; set; }

    /// <summary>Immutable. contains properties for the timeframe of maintenance.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1ComputeNodeGroupSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The node template to which this node group belongs.</summary>
    [JsonPropertyName("nodeTemplateRef")]
    public V1beta1ComputeNodeGroupSpecNodeTemplateRef NodeTemplateRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Share settings for the node group.</summary>
    [JsonPropertyName("shareSettings")]
    public V1beta1ComputeNodeGroupSpecShareSettings? ShareSettings { get; set; }

    /// <summary>Immutable. The total number of nodes in the node group. One of 'initial_size' or 'size' must be specified.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>Immutable. Zone where this node group is located.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupStatusConditions
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
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeGroupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeNodeGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNodeGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeNodeGroupSpec>, IStatus<V1beta1ComputeNodeGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNodeGroup";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenodegroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeNodeGroupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeNodeGroupStatus? Status { get; set; }
}
#nullable disable
