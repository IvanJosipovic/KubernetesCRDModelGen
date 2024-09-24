using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1alpha1ComputePerInstanceConfigSpecInstanceGroupManagerRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeInstanceGroupManager` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedStateDisk
{
    /// <summary>A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are 'NEVER' and 'ON_PERMANENT_INSTANCE_DELETION'. 'NEVER' - detach the disk when the VM is deleted, but do not delete the disk. 'ON_PERMANENT_INSTANCE_DELETION' will delete the stateful disk when the VM is permanently deleted from the instance group. Default value: "NEVER" Possible values: ["NEVER", "ON_PERMANENT_INSTANCE_DELETION"].</summary>
    [JsonPropertyName("deleteRule")]
    public string? DeleteRule { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string DeviceName { get; set; }

    /// <summary>The mode of the disk. Default value: "READ_WRITE" Possible values: ["READ_ONLY", "READ_WRITE"].</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The URI of an existing persistent disk to attach under the specified device-name in the format 'projects/project-id/zones/zone/disks/disk-name'.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value: "NEVER" Possible values: ["NEVER", "ON_PERMANENT_INSTANCE_DELETION"].</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interfaceName")]
    public string InterfaceName { get; set; }

    /// <summary>Ip address representation.</summary>
    [JsonPropertyName("ipAddress")]
    public V1alpha1ComputePerInstanceConfigSpecPreservedStateExternalIpIpAddress? IpAddress { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value: "NEVER" Possible values: ["NEVER", "ON_PERMANENT_INSTANCE_DELETION"].</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interfaceName")]
    public string InterfaceName { get; set; }

    /// <summary>Ip address representation.</summary>
    [JsonPropertyName("ipAddress")]
    public V1alpha1ComputePerInstanceConfigSpecPreservedStateInternalIpIpAddress? IpAddress { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecPreservedState
{
    /// <summary>Stateful disks for the instance.</summary>
    [JsonPropertyName("disk")]
    public IList<V1alpha1ComputePerInstanceConfigSpecPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1alpha1ComputePerInstanceConfigSpecPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1alpha1ComputePerInstanceConfigSpecPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigSpecProjectRef
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

public partial class V1alpha1ComputePerInstanceConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("instanceGroupManagerRef")]
    public V1alpha1ComputePerInstanceConfigSpecInstanceGroupManagerRef InstanceGroupManagerRef { get; set; }

    /// <summary>The minimal action to perform on the instance during an update. Default is 'NONE'. Possible values are: * REPLACE * RESTART * REFRESH * NONE.</summary>
    [JsonPropertyName("minimalAction")]
    public string? MinimalAction { get; set; }

    /// <summary>The most disruptive action to perform on the instance during an update. Default is 'REPLACE'. Possible values are: * REPLACE * RESTART * REFRESH * NONE.</summary>
    [JsonPropertyName("mostDisruptiveAllowedAction")]
    public string? MostDisruptiveAllowedAction { get; set; }

    /// <summary>The preserved state for this instance.</summary>
    [JsonPropertyName("preservedState")]
    public V1alpha1ComputePerInstanceConfigSpecPreservedState? PreservedState { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputePerInstanceConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will *not* immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Zone where the containing instance group manager is located.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

public partial class V1alpha1ComputePerInstanceConfigStatusConditions
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

public partial class V1alpha1ComputePerInstanceConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputePerInstanceConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputePerInstanceConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputePerInstanceConfigSpec>, IStatus<V1alpha1ComputePerInstanceConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputePerInstanceConfig";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeperinstanceconfigs";
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
    public V1alpha1ComputePerInstanceConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputePerInstanceConfigStatus? Status { get; set; }
}