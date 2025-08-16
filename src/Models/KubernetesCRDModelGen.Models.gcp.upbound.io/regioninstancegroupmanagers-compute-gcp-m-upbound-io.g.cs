using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>RegionInstanceGroupManager is the Schema for the RegionInstanceGroupManagers API. Manages an Regional Instance Group within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionInstanceGroupManagerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionInstanceGroupManager>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionInstanceGroupManagerList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regioninstancegroupmanagers";
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
    public IList<V1beta1RegionInstanceGroupManager> Items { get; set; }
}

/// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector
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
    public V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderInstanceFlexibilityPolicyInstanceSelections
{
    /// <summary>, A list of full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>, Name of the instance selection, e.g. instance_selection_with_n1_machines_types. Instance selection names must be unique within the flexibility policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>, Preference of this instance selection. Lower number means higher preference. Managed instance group will first try to create a VM based on the machine-type with lowest rank and fallback to next rank based on availability. Machine types and instance selections with the same rank have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

/// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderInstanceFlexibilityPolicy
{
    /// <summary>, Named instance selections configuring properties that the group will use when creating new VMs. One can specify multiple instance selection to allow managed instance group to create VMs from multiple types of machines, based on preference and availability. Structure is documented below.</summary>
    [JsonPropertyName("instanceSelections")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderInstanceFlexibilityPolicyInstanceSelections>? InstanceSelections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsSelector
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
    public V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderUpdatePolicy
{
    /// <summary>- The instance redistribution policy for regional managed instance groups. Valid values are: "PROACTIVE", "NONE". If PROACTIVE (default), the group attempts to maintain an even distribution of VM instances across zones in the region. If NONE, proactive redistribution is disabled.</summary>
    [JsonPropertyName("instanceRedistributionType")]
    public string? InstanceRedistributionType { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: "RECREATE", "SUBSTITUTE". If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector
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
    public V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>, The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed. Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions, one of which has a target_size.percent of 60 will create 2 instances of that version.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created.</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderVersionTargetSize? TargetSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecForProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The shape to which the group converges either proactively or on resize events (depending on the value set in update_policy.0.instance_redistribution_type). For more information see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyTargetShape")]
    public string? DistributionPolicyTargetShape { get; set; }

    /// <summary>The distribution policy for this managed instance group. You can specify one or more values. For more information, see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyZones")]
    public IList<string>? DistributionPolicyZones { get; set; }

    /// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderNamedPort>? NamedPort { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region where the managed instance group resides. If not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation. Proactive cross zone instance redistribution must be disabled before you can update stateful disks on existing instance group managers. This can be controlled via the update_policy.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1RegionInstanceGroupManagerSpecForProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1RegionInstanceGroupManagerSpecForProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }
}

/// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector
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
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceFlexibilityPolicyInstanceSelections
{
    /// <summary>, A list of full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>, Name of the instance selection, e.g. instance_selection_with_n1_machines_types. Instance selection names must be unique within the flexibility policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>, Preference of this instance selection. Lower number means higher preference. Managed instance group will first try to create a VM based on the machine-type with lowest rank and fallback to next rank based on availability. Machine types and instance selections with the same rank have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

/// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceFlexibilityPolicy
{
    /// <summary>, Named instance selections configuring properties that the group will use when creating new VMs. One can specify multiple instance selection to allow managed instance group to create VMs from multiple types of machines, based on preference and availability. Structure is documented below.</summary>
    [JsonPropertyName("instanceSelections")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceFlexibilityPolicyInstanceSelections>? InstanceSelections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsSelector
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
    public V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderUpdatePolicy
{
    /// <summary>- The instance redistribution policy for regional managed instance groups. Valid values are: "PROACTIVE", "NONE". If PROACTIVE (default), the group attempts to maintain an even distribution of VM instances across zones in the region. If NONE, proactive redistribution is disabled.</summary>
    [JsonPropertyName("instanceRedistributionType")]
    public string? InstanceRedistributionType { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: "RECREATE", "SUBSTITUTE". If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector
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
    public V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>, The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed. Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions, one of which has a target_size.percent of 60 will create 2 instances of that version.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created.</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderVersionTargetSize? TargetSize { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecInitProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The shape to which the group converges either proactively or on resize events (depending on the value set in update_policy.0.instance_redistribution_type). For more information see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyTargetShape")]
    public string? DistributionPolicyTargetShape { get; set; }

    /// <summary>The distribution policy for this managed instance group. You can specify one or more values. For more information, see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyZones")]
    public IList<string>? DistributionPolicyZones { get; set; }

    /// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderNamedPort>? NamedPort { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region where the managed instance group resides. If not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation. Proactive cross zone instance redistribution must be disabled before you can update stateful disks on existing instance group managers. This can be controlled via the update_policy.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1RegionInstanceGroupManagerSpecInitProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1RegionInstanceGroupManagerSpecInitProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpecProviderConfigRef
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
public partial class V1beta1RegionInstanceGroupManagerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RegionInstanceGroupManagerSpec defines the desired state of RegionInstanceGroupManager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionInstanceGroupManagerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionInstanceGroupManagerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionInstanceGroupManagerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionInstanceGroupManagerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceFlexibilityPolicyInstanceSelections
{
    /// <summary>, A list of full machine-type names, e.g. "n1-standard-16".</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>, Name of the instance selection, e.g. instance_selection_with_n1_machines_types. Instance selection names must be unique within the flexibility policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>, Preference of this instance selection. Lower number means higher preference. Managed instance group will first try to create a VM based on the machine-type with lowest rank and fallback to next rank based on availability. Machine types and instance selections with the same rank have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

/// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceFlexibilityPolicy
{
    /// <summary>, Named instance selections configuring properties that the group will use when creating new VMs. One can specify multiple instance selection to allow managed instance group to create VMs from multiple types of machines, based on preference and availability. Structure is documented below.</summary>
    [JsonPropertyName("instanceSelections")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceFlexibilityPolicyInstanceSelections>? InstanceSelections { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy
{
    /// <summary>, Specifies the action that a MIG performs on a failed VM. If the value of the on_failed_health_check field is DEFAULT_ACTION, then the same action also applies to the VMs on which your application fails a health check. Valid options are: DO_NOTHING, REPAIR. If DO_NOTHING, then MIG does not repair a failed VM. If REPAIR (default), then MIG automatically repairs a failed VM by recreating it. For more information, see about repairing VMs in a MIG.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>, Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStandbyPolicy
{
    /// <summary>- Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }

    /// <summary>- Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. Valid options are: MANUAL, SCALE_OUT_POOL. If MANUAL(default), you have full control over which VMs are stopped and suspended in the MIG. If SCALE_OUT_POOL, the MIG uses the VMs from the standby pools to accelerate the scale out by resuming or starting them and then automatically replenishes the standby pool with new VMs to maintain the target sizes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulDisk
{
    /// <summary>, A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The device name of the disk to be attached.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatusAllInstancesConfig
{
    /// <summary>Current all-instances configuration revision. This value is in RFC3339 text format.</summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }

    /// <summary>A bit indicating whether this configuration has been applied to all managed instances in the group.</summary>
    [JsonPropertyName("effective")]
    public bool? Effective { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs
{
    /// <summary>A bit indicating if all of the group's per-instance configs (listed in the output of a listPerInstanceConfigs API call) have status EFFECTIVE or there are no per-instance-configs.</summary>
    [JsonPropertyName("allEffective")]
    public bool? AllEffective { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatusStateful
{
    /// <summary>A bit indicating whether the managed instance group has stateful configuration, that is, if you have configured any items in a stateful policy or in per-instance configs. The group might report that it has no stateful config even when there is still some preserved state on a managed instance, for example, if you have deleted all PICs but not yet applied those deletions.</summary>
    [JsonPropertyName("hasStatefulConfig")]
    public bool? HasStatefulConfig { get; set; }

    /// <summary>Status of per-instance configs on the instances.</summary>
    [JsonPropertyName("perInstanceConfigs")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs>? PerInstanceConfigs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatusVersionTarget
{
    /// <summary></summary>
    [JsonPropertyName("isReached")]
    public bool? IsReached { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderStatus
{
    /// <summary>Status of all-instances configuration on the group.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatusAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>A bit indicating whether the managed instance group is in a stable state. A stable state means that: none of the instances in the managed instance group is currently undergoing any type of change (for example, creation, restart, or deletion); no future changes are scheduled for instances in the managed instance group; and the managed instance group itself is not being modified.</summary>
    [JsonPropertyName("isStable")]
    public bool? IsStable { get; set; }

    /// <summary>Stateful status of the given Instance Group Manager.</summary>
    [JsonPropertyName("stateful")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatusStateful>? Stateful { get; set; }

    /// <summary>A status of consistency of Instances' versions with their target version specified by version field on Instance Group Manager.</summary>
    [JsonPropertyName("versionTarget")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatusVersionTarget>? VersionTarget { get; set; }
}

/// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderUpdatePolicy
{
    /// <summary>- The instance redistribution policy for regional managed instance groups. Valid values are: "PROACTIVE", "NONE". If PROACTIVE (default), the group attempts to maintain an even distribution of VM instances across zones in the region. If NONE, proactive redistribution is disabled.</summary>
    [JsonPropertyName("instanceRedistributionType")]
    public string? InstanceRedistributionType { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0.</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%..</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>- Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>, The instance replacement method for managed instance groups. Valid values are: "RECREATE", "SUBSTITUTE". If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.</summary>
    [JsonPropertyName("replacementMethod")]
    public string? ReplacementMethod { get; set; }

    /// <summary>- The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderVersionTargetSize
{
    /// <summary>, The number of instances which are managed for this version. Conflicts with percent.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>, The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed. Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions, one of which has a target_size.percent of 60 will create 2 instances of that version.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created.</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderVersionTargetSize? TargetSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusAtProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderAllInstancesConfig? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderAutoHealingPolicies? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The shape to which the group converges either proactively or on resize events (depending on the value set in update_policy.0.instance_redistribution_type). For more information see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyTargetShape")]
    public string? DistributionPolicyTargetShape { get; set; }

    /// <summary>The distribution policy for this managed instance group. You can specify one or more values. For more information, see the official documentation.</summary>
    [JsonPropertyName("distributionPolicyZones")]
    public IList<string>? DistributionPolicyZones { get; set; }

    /// <summary>The fingerprint of the instance group manager.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/instanceGroupManagers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The flexibility policy for managed instance group. Instance flexibility allows managed instance group to create VMs from multiple types of machines. Instance flexibility configuration on managed instance group overrides instance template configuration. Structure is documented below.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>The full URL of the instance group created by the manager.</summary>
    [JsonPropertyName("instanceGroup")]
    public string? InstanceGroup { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/instanceGroupManagers/{{name}}</summary>
    [JsonPropertyName("instanceGroupManagerId")]
    public double? InstanceGroupManagerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderNamedPort>? NamedPort { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region where the managed instance group resides. If not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URL of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The standby policy for stopped and suspended instances. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("standbyPolicy")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderStandbyPolicy? StandbyPolicy { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation. Proactive cross zone instance redistribution must be disabled before you can update stateful disks on existing instance group managers. This can be controlled via the update_policy.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderStatus>? Status { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The target number of stopped instances for this managed instance group.</summary>
    [JsonPropertyName("targetStoppedSize")]
    public double? TargetStoppedSize { get; set; }

    /// <summary>The target number of suspended instances for this managed instance group.</summary>
    [JsonPropertyName("targetSuspendedSize")]
    public double? TargetSuspendedSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1RegionInstanceGroupManagerStatusAtProviderUpdatePolicy? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1RegionInstanceGroupManagerStatusAtProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatusConditions
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

/// <summary>RegionInstanceGroupManagerStatus defines the observed state of RegionInstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionInstanceGroupManagerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionInstanceGroupManagerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionInstanceGroupManagerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionInstanceGroupManager is the Schema for the RegionInstanceGroupManagers API. Manages an Regional Instance Group within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionInstanceGroupManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionInstanceGroupManagerSpec>, IStatus<V1beta1RegionInstanceGroupManagerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionInstanceGroupManager";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regioninstancegroupmanagers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionInstanceGroupManagerSpec defines the desired state of RegionInstanceGroupManager</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionInstanceGroupManagerSpec Spec { get; set; }

    /// <summary>RegionInstanceGroupManagerStatus defines the observed state of RegionInstanceGroupManager.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionInstanceGroupManagerStatus? Status { get; set; }
}