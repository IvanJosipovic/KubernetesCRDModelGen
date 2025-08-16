using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devtestlab.azure.m.upbound.io;
/// <summary>GlobalVMShutdownSchedule is the Schema for the GlobalVMShutdownSchedules API. Manages automated shutdown schedules for Azure Resource Manager VMs outside of Dev Test Labs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GlobalVMShutdownScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GlobalVMShutdownSchedule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GlobalVMShutdownScheduleList";
    public const string KubeGroup = "devtestlab.azure.m.upbound.io";
    public const string KubePluralName = "globalvmshutdownschedules";
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
    public IList<V1beta1GlobalVMShutdownSchedule> Items { get; set; }
}

/// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProviderNotificationSettings
{
    /// <summary>E-mail address to which the notification will be sent.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Whether to enable pre-shutdown notifications. Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Time in minutes between 15 and 120 before a shutdown event at which a notification will be sent. Defaults to 30.</summary>
    [JsonPropertyName("timeInMinutes")]
    public double? TimeInMinutes { get; set; }

    /// <summary>The webhook URL to which the notification will be sent.</summary>
    [JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecForProvider
{
    /// <summary>The time each day when the schedule takes effect. Must match the format HHmm where HH is 00-23 and mm is 00-59 (e.g. 0930, 2300, etc.)</summary>
    [JsonPropertyName("dailyRecurrenceTime")]
    public string? DailyRecurrenceTime { get; set; }

    /// <summary>Whether to enable the schedule. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The location where the schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1GlobalVMShutdownScheduleSpecForProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The time zone ID (e.g. Pacific Standard time). Refer to this guide for a full list of accepted time zone names.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The resource ID of the target ARM-based Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1GlobalVMShutdownScheduleSpecForProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }
}

/// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProviderNotificationSettings
{
    /// <summary>E-mail address to which the notification will be sent.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Whether to enable pre-shutdown notifications. Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Time in minutes between 15 and 120 before a shutdown event at which a notification will be sent. Defaults to 30.</summary>
    [JsonPropertyName("timeInMinutes")]
    public double? TimeInMinutes { get; set; }

    /// <summary>The webhook URL to which the notification will be sent.</summary>
    [JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecInitProvider
{
    /// <summary>The time each day when the schedule takes effect. Must match the format HHmm where HH is 00-23 and mm is 00-59 (e.g. 0930, 2300, etc.)</summary>
    [JsonPropertyName("dailyRecurrenceTime")]
    public string? DailyRecurrenceTime { get; set; }

    /// <summary>Whether to enable the schedule. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The location where the schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The time zone ID (e.g. Pacific Standard time). Refer to this guide for a full list of accepted time zone names.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The resource ID of the target ARM-based Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpecProviderConfigRef
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
public partial class V1beta1GlobalVMShutdownScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GlobalVMShutdownScheduleSpec defines the desired state of GlobalVMShutdownSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GlobalVMShutdownScheduleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GlobalVMShutdownScheduleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GlobalVMShutdownScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GlobalVMShutdownScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleStatusAtProviderNotificationSettings
{
    /// <summary>E-mail address to which the notification will be sent.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Whether to enable pre-shutdown notifications. Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Time in minutes between 15 and 120 before a shutdown event at which a notification will be sent. Defaults to 30.</summary>
    [JsonPropertyName("timeInMinutes")]
    public double? TimeInMinutes { get; set; }

    /// <summary>The webhook URL to which the notification will be sent.</summary>
    [JsonPropertyName("webhookUrl")]
    public string? WebhookUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleStatusAtProvider
{
    /// <summary>The time each day when the schedule takes effect. Must match the format HHmm where HH is 00-23 and mm is 00-59 (e.g. 0930, 2300, etc.)</summary>
    [JsonPropertyName("dailyRecurrenceTime")]
    public string? DailyRecurrenceTime { get; set; }

    /// <summary>Whether to enable the schedule. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Dev Test Global Schedule ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location where the schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The notification setting of a schedule. A notification_settings block as defined below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1GlobalVMShutdownScheduleStatusAtProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The time zone ID (e.g. Pacific Standard time). Refer to this guide for a full list of accepted time zone names.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The resource ID of the target ARM-based Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleStatusConditions
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

/// <summary>GlobalVMShutdownScheduleStatus defines the observed state of GlobalVMShutdownSchedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GlobalVMShutdownScheduleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GlobalVMShutdownScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GlobalVMShutdownScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GlobalVMShutdownSchedule is the Schema for the GlobalVMShutdownSchedules API. Manages automated shutdown schedules for Azure Resource Manager VMs outside of Dev Test Labs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GlobalVMShutdownSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GlobalVMShutdownScheduleSpec>, IStatus<V1beta1GlobalVMShutdownScheduleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GlobalVMShutdownSchedule";
    public const string KubeGroup = "devtestlab.azure.m.upbound.io";
    public const string KubePluralName = "globalvmshutdownschedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GlobalVMShutdownScheduleSpec defines the desired state of GlobalVMShutdownSchedule</summary>
    [JsonPropertyName("spec")]
    public V1beta1GlobalVMShutdownScheduleSpec Spec { get; set; }

    /// <summary>GlobalVMShutdownScheduleStatus defines the observed state of GlobalVMShutdownSchedule.</summary>
    [JsonPropertyName("status")]
    public V1beta1GlobalVMShutdownScheduleStatus? Status { get; set; }
}