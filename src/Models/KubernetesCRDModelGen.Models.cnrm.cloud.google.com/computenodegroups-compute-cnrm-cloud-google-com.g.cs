using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupMetadata
{
}

/// <summary>Immutable. If you use sole-tenant nodes for your workloads, you can use the node group autoscaler to automatically manage the sizes of your node groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecAutoscalingPolicy
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

/// <summary>Immutable. contains properties for the timeframe of maintenance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecMaintenanceWindow
{
    /// <summary>Immutable. instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.</summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}

/// <summary>The node template to which this node group belongs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecNodeTemplateRef
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

/// <summary>The key of this project config in the parent map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecShareSettingsProjectMapIdRef
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

/// <summary>The project id/number should be the same as the key of this project config in the project map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecShareSettingsProjectMapProjectIdRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecShareSettingsProjectMap
{
    /// <summary>The key of this project config in the parent map.</summary>
    [JsonPropertyName("idRef")]
    public ComputeNodeGroupSpecShareSettingsProjectMapIdRef IdRef { get; set; }

    /// <summary>The project id/number should be the same as the key of this project config in the project map.</summary>
    [JsonPropertyName("projectIdRef")]
    public ComputeNodeGroupSpecShareSettingsProjectMapProjectIdRef ProjectIdRef { get; set; }
}

/// <summary>Immutable. Share settings for the node group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpecShareSettings
{
    /// <summary>Immutable. A map of project id and project config. This is only valid when shareType's value is SPECIFIC_PROJECTS.</summary>
    [JsonPropertyName("projectMap")]
    public IList<ComputeNodeGroupSpecShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>Immutable. Node group sharing type. Possible values: ["ORGANIZATION", "SPECIFIC_PROJECTS", "LOCAL"].</summary>
    [JsonPropertyName("shareType")]
    public string ShareType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupSpec
{
    /// <summary>Immutable. If you use sole-tenant nodes for your workloads, you can use the node group autoscaler to automatically manage the sizes of your node groups.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public ComputeNodeGroupSpecAutoscalingPolicy? AutoscalingPolicy { get; set; }

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
    public ComputeNodeGroupSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The node template to which this node group belongs.</summary>
    [JsonPropertyName("nodeTemplateRef")]
    public ComputeNodeGroupSpecNodeTemplateRef NodeTemplateRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Share settings for the node group.</summary>
    [JsonPropertyName("shareSettings")]
    public ComputeNodeGroupSpecShareSettings? ShareSettings { get; set; }

    /// <summary>Immutable. The total number of nodes in the node group. One of 'initial_size' or 'size' must be specified.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>Immutable. Zone where this node group is located.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<ComputeNodeGroupStatusConditions>? Conditions { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ComputeNodeGroup
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public ComputeNodeGroupMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public ComputeNodeGroupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public ComputeNodeGroupStatus? Status { get; set; }
}