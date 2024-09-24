using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1PerInstanceConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateDisk
{
    /// <summary>A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The mode of the disk. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The URI of an existing persistent disk to attach under the specified device-name in the format projects/project-id/zones/zone/disks/disk-name.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1PerInstanceConfigSpecForProviderPreservedStateDiskSourceSelector? SourceSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedStateExternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedStateInternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

public enum V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderZoneRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate zone.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderZoneRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate zone.</summary>
public partial class V1beta1PerInstanceConfigSpecForProviderZoneSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecForProviderZoneSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecForProvider
{
    /// <summary>The instance group manager this instance config is part of.</summary>
    [JsonPropertyName("instanceGroupManager")]
    public string? InstanceGroupManager { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
    [JsonPropertyName("instanceGroupManagerRef")]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerRef? InstanceGroupManagerRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
    [JsonPropertyName("instanceGroupManagerSelector")]
    public V1beta1PerInstanceConfigSpecForProviderInstanceGroupManagerSelector? InstanceGroupManagerSelector { get; set; }

    /// <summary>The minimal action to perform on the instance during an update. Default is NONE. Possible values are:</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>The most disruptive action to perform on the instance during an update. Default is REPLACE. Possible values are:</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>The name for this per-instance config and its corresponding instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preserved state for this instance. Structure is documented below.</summary>
    [JsonPropertyName("preservedState")]
    public IList<V1beta1PerInstanceConfigSpecForProviderPreservedState>? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }

    /// <summary>Zone where the containing instance group manager is located</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate zone.</summary>
    [JsonPropertyName("zoneRef")]
    public V1beta1PerInstanceConfigSpecForProviderZoneRef? ZoneRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate zone.</summary>
    [JsonPropertyName("zoneSelector")]
    public V1beta1PerInstanceConfigSpecForProviderZoneSelector? ZoneSelector { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateDisk
{
    /// <summary>A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The mode of the disk. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The URI of an existing persistent disk to attach under the specified device-name in the format projects/project-id/zones/zone/disks/disk-name.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1PerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelector? SourceSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedStateExternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedStateInternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate zone.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderZoneRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate zone.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProviderZoneSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecInitProviderZoneSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PerInstanceConfigSpecInitProvider
{
    /// <summary>The instance group manager this instance config is part of.</summary>
    [JsonPropertyName("instanceGroupManager")]
    public string? InstanceGroupManager { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
    [JsonPropertyName("instanceGroupManagerRef")]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerRef? InstanceGroupManagerRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate instanceGroupManager.</summary>
    [JsonPropertyName("instanceGroupManagerSelector")]
    public V1beta1PerInstanceConfigSpecInitProviderInstanceGroupManagerSelector? InstanceGroupManagerSelector { get; set; }

    /// <summary>The minimal action to perform on the instance during an update. Default is NONE. Possible values are:</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>The most disruptive action to perform on the instance during an update. Default is REPLACE. Possible values are:</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>The name for this per-instance config and its corresponding instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preserved state for this instance. Structure is documented below.</summary>
    [JsonPropertyName("preservedState")]
    public IList<V1beta1PerInstanceConfigSpecInitProviderPreservedState>? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }

    /// <summary>Zone where the containing instance group manager is located</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate zone.</summary>
    [JsonPropertyName("zoneRef")]
    public V1beta1PerInstanceConfigSpecInitProviderZoneRef? ZoneRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate zone.</summary>
    [JsonPropertyName("zoneSelector")]
    public V1beta1PerInstanceConfigSpecInitProviderZoneSelector? ZoneSelector { get; set; }
}

public enum V1beta1PerInstanceConfigSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PerInstanceConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PerInstanceConfigSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PerInstanceConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PerInstanceConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PerInstanceConfigSpec defines the desired state of PerInstanceConfig</summary>
public partial class V1beta1PerInstanceConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PerInstanceConfigSpecDeletionPolicyEnum>))]
    public V1beta1PerInstanceConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PerInstanceConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PerInstanceConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PerInstanceConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PerInstanceConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PerInstanceConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PerInstanceConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedStateDisk
{
    /// <summary>A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The mode of the disk. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The URI of an existing persistent disk to attach under the specified device-name in the format projects/project-id/zones/zone/disks/disk-name.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedStateExternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedStateInternalIpIpAddress>? IpAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary></summary>
public partial class V1beta1PerInstanceConfigStatusAtProvider
{
    /// <summary>an identifier for the resource with format {{project}}/{{zone}}/{{instance_group_manager}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The instance group manager this instance config is part of.</summary>
    [JsonPropertyName("instanceGroupManager")]
    public string? InstanceGroupManager { get; set; }

    /// <summary>The minimal action to perform on the instance during an update. Default is NONE. Possible values are:</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>The most disruptive action to perform on the instance during an update. Default is REPLACE. Possible values are:</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>The name for this per-instance config and its corresponding instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preserved state for this instance. Structure is documented below.</summary>
    [JsonPropertyName("preservedState")]
    public IList<V1beta1PerInstanceConfigStatusAtProviderPreservedState>? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }

    /// <summary>Zone where the containing instance group manager is located</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PerInstanceConfigStatusConditions
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

/// <summary>PerInstanceConfigStatus defines the observed state of PerInstanceConfig.</summary>
public partial class V1beta1PerInstanceConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PerInstanceConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PerInstanceConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>PerInstanceConfig is the Schema for the PerInstanceConfigs API. A config defined for a single managed instance that belongs to an instance group manager.</summary>
public partial class V1beta1PerInstanceConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PerInstanceConfigSpec>, IStatus<V1beta1PerInstanceConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PerInstanceConfig";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "perinstanceconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PerInstanceConfigSpec defines the desired state of PerInstanceConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1PerInstanceConfigSpec Spec { get; set; }

    /// <summary>PerInstanceConfigStatus defines the observed state of PerInstanceConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1PerInstanceConfigStatus? Status { get; set; }
}