using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderAllInstancesConfig
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
public partial class V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy
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
public partial class V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1InstanceGroupManagerSpecForProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderInstanceLifecyclePolicy
{
    /// <summary>, Default behavior for all instance or health check failures. Valid options are: REPAIR, DO_NOTHING. If DO_NOTHING then instances will not be repaired. If REPAIR (default), then failed instances will be repaired.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>), Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderStatefulDisk
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
public partial class V1beta1InstanceGroupManagerSpecForProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecForProviderTargetPoolsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderUpdatePolicy
{
    /// <summary>, The maximum number of instances that can be created above the specified targetSize during the update process. Conflicts with max_surge_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be created above the specified targetSize during the update process. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, The maximum number of instances that can be unavailable during the update process. Conflicts with max_unavailable_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be unavailable during the update process. Conflicts with max_unavailable_fixed.</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
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
public partial class V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy
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
public partial class V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProviderVersionTargetSize
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
public partial class V1beta1InstanceGroupManagerSpecForProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta1InstanceGroupManagerSpecForProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderVersionTargetSize>? TargetSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecForProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderAutoHealingPolicies>? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderInstanceLifecyclePolicy>? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderNamedPort>? NamedPort { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta1InstanceGroupManagerSpecForProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderUpdatePolicy>? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1InstanceGroupManagerSpecForProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }

    /// <summary>The zone that instances in this group should be created in.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderAllInstancesConfig
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPolicies
{
    /// <summary>The health check resource that signals autohealing.</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPoliciesHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.</summary>
    [JsonPropertyName("initialDelaySec")]
    public double? InitialDelaySec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy
{
    /// <summary>, Default behavior for all instance or health check failures. Valid options are: REPAIR, DO_NOTHING. If DO_NOTHING then instances will not be repaired. If REPAIR (default), then failed instances will be repaired.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>), Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderStatefulDisk
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderUpdatePolicy
{
    /// <summary>, The maximum number of instances that can be created above the specified targetSize during the update process. Conflicts with max_surge_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be created above the specified targetSize during the update process. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, The maximum number of instances that can be unavailable during the update process. Conflicts with max_unavailable_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be unavailable during the update process. Conflicts with max_unavailable_fixed.</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersionTargetSize
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
public partial class V1beta1InstanceGroupManagerSpecInitProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateRef")]
    public V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateRef? InstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate instanceTemplate.</summary>
    [JsonPropertyName("instanceTemplateSelector")]
    public V1beta1InstanceGroupManagerSpecInitProviderVersionInstanceTemplateSelector? InstanceTemplateSelector { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderVersionTargetSize>? TargetSize { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecInitProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderAutoHealingPolicies>? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderInstanceLifecyclePolicy>? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderNamedPort>? NamedPort { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>References to TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsRefs")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsRefs>? TargetPoolsRefs { get; set; }

    /// <summary>Selector for a list of TargetPool in compute to populate targetPools.</summary>
    [JsonPropertyName("targetPoolsSelector")]
    public V1beta1InstanceGroupManagerSpecInitProviderTargetPoolsSelector? TargetPoolsSelector { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderUpdatePolicy>? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1InstanceGroupManagerSpecInitProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InstanceGroupManagerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InstanceGroupManagerSpec defines the desired state of InstanceGroupManager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceGroupManagerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceGroupManagerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceGroupManagerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InstanceGroupManagerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceGroupManagerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderAllInstancesConfig
{
    /// <summary>, The label key-value pairs that you want to patch onto the instance.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>, The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderAutoHealingPolicies
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
public partial class V1beta1InstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy
{
    /// <summary>, Default behavior for all instance or health check failures. Valid options are: REPAIR, DO_NOTHING. If DO_NOTHING then instances will not be repaired. If REPAIR (default), then failed instances will be repaired.</summary>
    [JsonPropertyName("defaultActionOnFailure")]
    public string? DefaultActionOnFailure { get; set; }

    /// <summary>), Specifies whether to apply the group's latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group's instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group's update policy type.</summary>
    [JsonPropertyName("forceUpdateOnRepair")]
    public string? ForceUpdateOnRepair { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderNamedPort
{
    /// <summary>The name of the port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port number.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatefulDisk
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
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatefulExternalIp
{
    /// <summary>, A value that prescribes what should happen to the external ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the external ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the external Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatefulInternalIp
{
    /// <summary>, A value that prescribes what should happen to the internal ip when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the ip when the VM is deleted, but do not delete the ip. ON_PERMANENT_INSTANCE_DELETION will delete the internal ip when the VM is permanently deleted from the instance group.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>, The network interface name of the internal Ip. Possible value: nic0</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatusAllInstancesConfig
{
    /// <summary>Current all-instances configuration revision. This value is in RFC3339 text format.</summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effective")]
    public bool? Effective { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs
{
    /// <summary>A bit indicating if all of the group's per-instance configs (listed in the output of a listPerInstanceConfigs API call) have status EFFECTIVE or there are no per-instance-configs.</summary>
    [JsonPropertyName("allEffective")]
    public bool? AllEffective { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatusStateful
{
    /// <summary>A bit indicating whether the managed instance group has stateful configuration, that is, if you have configured any items in a stateful policy or in per-instance configs. The group might report that it has no stateful config even when there is still some preserved state on a managed instance, for example, if you have deleted all PICs but not yet applied those deletions.</summary>
    [JsonPropertyName("hasStatefulConfig")]
    public bool? HasStatefulConfig { get; set; }

    /// <summary>Status of per-instance configs on the instance.</summary>
    [JsonPropertyName("perInstanceConfigs")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatusStatefulPerInstanceConfigs>? PerInstanceConfigs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatusVersionTarget
{
    /// <summary></summary>
    [JsonPropertyName("isReached")]
    public bool? IsReached { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderStatus
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatusAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>A bit indicating whether the managed instance group is in a stable state. A stable state means that: none of the instances in the managed instance group is currently undergoing any type of change (for example, creation, restart, or deletion); no future changes are scheduled for instances in the managed instance group; and the managed instance group itself is not being modified.</summary>
    [JsonPropertyName("isStable")]
    public bool? IsStable { get; set; }

    /// <summary>Stateful status of the given Instance Group Manager.</summary>
    [JsonPropertyName("stateful")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatusStateful>? Stateful { get; set; }

    /// <summary>A status of consistency of Instances' versions with their target version specified by version field on Instance Group Manager.</summary>
    [JsonPropertyName("versionTarget")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatusVersionTarget>? VersionTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderUpdatePolicy
{
    /// <summary>, The maximum number of instances that can be created above the specified targetSize during the update process. Conflicts with max_surge_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxSurgeFixed")]
    public double? MaxSurgeFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be created above the specified targetSize during the update process. Conflicts with max_surge_fixed.</summary>
    [JsonPropertyName("maxSurgePercent")]
    public double? MaxSurgePercent { get; set; }

    /// <summary>, The maximum number of instances that can be unavailable during the update process. Conflicts with max_unavailable_percent. If neither is set, defaults to 1</summary>
    [JsonPropertyName("maxUnavailableFixed")]
    public double? MaxUnavailableFixed { get; set; }

    /// <summary>, The maximum number of instances(calculated as percentage) that can be unavailable during the update process. Conflicts with max_unavailable_fixed.</summary>
    [JsonPropertyName("maxUnavailablePercent")]
    public double? MaxUnavailablePercent { get; set; }

    /// <summary>- Minimal action to be taken on an instance. You can specify either REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.</summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProviderVersionTargetSize
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
public partial class V1beta1InstanceGroupManagerStatusAtProviderVersion
{
    /// <summary>- The full URL to an instance template from which all new instances of this version will be created. It is recommended to reference instance templates through their unique id (self_link_unique attribute).</summary>
    [JsonPropertyName("instanceTemplate")]
    public string? InstanceTemplate { get; set; }

    /// <summary>- Version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>- The number of instances calculated as a fixed number or a percentage depending on the settings. Structure is documented below.</summary>
    [JsonPropertyName("targetSize")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderVersionTargetSize>? TargetSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusAtProvider
{
    /// <summary>Properties to set on all instances in the group. After setting allInstancesConfig on the group, you must update the group's instances to apply the configuration.</summary>
    [JsonPropertyName("allInstancesConfig")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderAllInstancesConfig>? AllInstancesConfig { get; set; }

    /// <summary>The autohealing policies for this managed instance group. You can specify only one value. Structure is documented below. For more information, see the official documentation.</summary>
    [JsonPropertyName("autoHealingPolicies")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderAutoHealingPolicies>? AutoHealingPolicies { get; set; }

    /// <summary>The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.</summary>
    [JsonPropertyName("baseInstanceName")]
    public string? BaseInstanceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional textual description of the instance group manager.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The fingerprint of the instance group manager.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/instanceGroupManagers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The full URL of the instance group created by the manager.</summary>
    [JsonPropertyName("instanceGroup")]
    public string? InstanceGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceLifecyclePolicy")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderInstanceLifecyclePolicy>? InstanceLifecyclePolicy { get; set; }

    /// <summary>Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: PAGELESS, PAGINATED. If PAGELESS (default), Pagination is disabled for the group's listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.</summary>
    [JsonPropertyName("listManagedInstancesResults")]
    public string? ListManagedInstancesResults { get; set; }

    /// <summary>The named port configuration. See the section below for details on configuration.</summary>
    [JsonPropertyName("namedPort")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderNamedPort>? NamedPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URL of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation.</summary>
    [JsonPropertyName("statefulDisk")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatefulDisk>? StatefulDisk { get; set; }

    /// <summary>External network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulExternalIp")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatefulExternalIp>? StatefulExternalIp { get; set; }

    /// <summary>Internal network IPs assigned to the instances that will be preserved on instance delete, update, etc. This map is keyed with the network interface name. Structure is documented below.</summary>
    [JsonPropertyName("statefulInternalIp")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatefulInternalIp>? StatefulInternalIp { get; set; }

    /// <summary>The status of this managed instance group.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderStatus>? Status { get; set; }

    /// <summary>The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.</summary>
    [JsonPropertyName("targetPools")]
    public IList<string>? TargetPools { get; set; }

    /// <summary>The target number of running instances for this managed instance group. This value will fight with autoscaler settings when set, and generally shouldn't be set when using one. If a value is required, such as to specify a creation-time target size for the MIG, lifecycle. Defaults to 0.</summary>
    [JsonPropertyName("targetSize")]
    public double? TargetSize { get; set; }

    /// <summary>The update policy for this managed instance group. Structure is documented below. For more information, see the official documentation and API</summary>
    [JsonPropertyName("updatePolicy")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderUpdatePolicy>? UpdatePolicy { get; set; }

    /// <summary>Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios. Structure is documented below.</summary>
    [JsonPropertyName("version")]
    public IList<V1beta1InstanceGroupManagerStatusAtProviderVersion>? Version { get; set; }

    /// <summary>Whether to wait for all instances to be created/updated before returning.</summary>
    [JsonPropertyName("waitForInstances")]
    public bool? WaitForInstances { get; set; }

    /// <summary>When used with wait_for_instances it specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective as well as all instances to be stable before returning. The possible values are STABLE and UPDATED</summary>
    [JsonPropertyName("waitForInstancesStatus")]
    public string? WaitForInstancesStatus { get; set; }

    /// <summary>The zone that instances in this group should be created in.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatusConditions
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

/// <summary>InstanceGroupManagerStatus defines the observed state of InstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceGroupManagerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceGroupManagerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceGroupManagerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceGroupManager is the Schema for the InstanceGroupManagers API. Manages an Instance Group within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceGroupManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceGroupManagerSpec>, IStatus<V1beta1InstanceGroupManagerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceGroupManager";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "instancegroupmanagers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceGroupManagerSpec defines the desired state of InstanceGroupManager</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceGroupManagerSpec Spec { get; set; }

    /// <summary>InstanceGroupManagerStatus defines the observed state of InstanceGroupManager.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceGroupManagerStatus? Status { get; set; }
}