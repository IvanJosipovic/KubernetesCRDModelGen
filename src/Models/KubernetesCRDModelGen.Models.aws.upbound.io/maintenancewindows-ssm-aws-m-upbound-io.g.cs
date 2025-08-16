using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.m.upbound.io;
/// <summary>MaintenanceWindow is the Schema for the MaintenanceWindows API. Provides an SSM Maintenance Window resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MaintenanceWindowList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MaintenanceWindow>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MaintenanceWindowList";
    public const string KubeGroup = "ssm.aws.m.upbound.io";
    public const string KubePluralName = "maintenancewindows";
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
    public IList<V1beta1MaintenanceWindow> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowSpecForProvider
{
    /// <summary>Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.</summary>
    [JsonPropertyName("allowUnassociatedTargets")]
    public bool? AllowUnassociatedTargets { get; set; }

    /// <summary>The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.</summary>
    [JsonPropertyName("cutoff")]
    public double? Cutoff { get; set; }

    /// <summary>A description for the maintenance window.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The duration of the Maintenance Window in hours.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether the maintenance window is enabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to no longer run the maintenance window.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The name of the maintenance window.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The schedule of the Maintenance Window in the form of a cron or rate expression.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The number of days to wait after the date and time specified by a CRON expression before running the maintenance window. Valid range is 1 to 6.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Timezone for schedule in Internet Assigned Numbers Authority (IANA) Time Zone Database format. For example: America/Los_Angeles, etc/UTC, or Asia/Seoul.</summary>
    [JsonPropertyName("scheduleTimezone")]
    public string? ScheduleTimezone { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to begin the maintenance window.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowSpecInitProvider
{
    /// <summary>Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.</summary>
    [JsonPropertyName("allowUnassociatedTargets")]
    public bool? AllowUnassociatedTargets { get; set; }

    /// <summary>The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.</summary>
    [JsonPropertyName("cutoff")]
    public double? Cutoff { get; set; }

    /// <summary>A description for the maintenance window.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The duration of the Maintenance Window in hours.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether the maintenance window is enabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to no longer run the maintenance window.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The name of the maintenance window.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The schedule of the Maintenance Window in the form of a cron or rate expression.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The number of days to wait after the date and time specified by a CRON expression before running the maintenance window. Valid range is 1 to 6.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Timezone for schedule in Internet Assigned Numbers Authority (IANA) Time Zone Database format. For example: America/Los_Angeles, etc/UTC, or Asia/Seoul.</summary>
    [JsonPropertyName("scheduleTimezone")]
    public string? ScheduleTimezone { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to begin the maintenance window.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MaintenanceWindowSpec defines the desired state of MaintenanceWindow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MaintenanceWindowSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MaintenanceWindowSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MaintenanceWindowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MaintenanceWindowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowStatusAtProvider
{
    /// <summary>Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.</summary>
    [JsonPropertyName("allowUnassociatedTargets")]
    public bool? AllowUnassociatedTargets { get; set; }

    /// <summary>The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.</summary>
    [JsonPropertyName("cutoff")]
    public double? Cutoff { get; set; }

    /// <summary>A description for the maintenance window.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The duration of the Maintenance Window in hours.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether the maintenance window is enabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to no longer run the maintenance window.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The ID of the maintenance window.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the maintenance window.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The schedule of the Maintenance Window in the form of a cron or rate expression.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The number of days to wait after the date and time specified by a CRON expression before running the maintenance window. Valid range is 1 to 6.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Timezone for schedule in Internet Assigned Numbers Authority (IANA) Time Zone Database format. For example: America/Los_Angeles, etc/UTC, or Asia/Seoul.</summary>
    [JsonPropertyName("scheduleTimezone")]
    public string? ScheduleTimezone { get; set; }

    /// <summary>Timestamp in ISO-8601 extended format when to begin the maintenance window.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>MaintenanceWindowStatus defines the observed state of MaintenanceWindow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MaintenanceWindowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MaintenanceWindowStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MaintenanceWindow is the Schema for the MaintenanceWindows API. Provides an SSM Maintenance Window resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MaintenanceWindow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MaintenanceWindowSpec>, IStatus<V1beta1MaintenanceWindowStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MaintenanceWindow";
    public const string KubeGroup = "ssm.aws.m.upbound.io";
    public const string KubePluralName = "maintenancewindows";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MaintenanceWindowSpec defines the desired state of MaintenanceWindow</summary>
    [JsonPropertyName("spec")]
    public V1beta1MaintenanceWindowSpec Spec { get; set; }

    /// <summary>MaintenanceWindowStatus defines the observed state of MaintenanceWindow.</summary>
    [JsonPropertyName("status")]
    public V1beta1MaintenanceWindowStatus? Status { get; set; }
}