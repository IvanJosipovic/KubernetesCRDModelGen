using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>RegionPerInstanceConfig is the Schema for the RegionPerInstanceConfigs API. A config defined for a single managed instance that belongs to an instance group manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionPerInstanceConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionPerInstanceConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionPerInstanceConfigList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regionperinstanceconfigs";
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
    public IList<V1beta1RegionPerInstanceConfig> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceSelector
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
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDisk
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
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDiskSourceSelector? SourceSelector { get; set; }
}

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateExternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateInternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>The preserved state for this instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1RegionPerInstanceConfigSpecForProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerSelector
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
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProviderRegionSelector
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
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecForProvider
{
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
    public V1beta1RegionPerInstanceConfigSpecForProviderPreservedState? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the containing instance group manager is located</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The region instance group manager this instance config is part of.</summary>
    [JsonPropertyName("regionInstanceGroupManager")]
    public string? RegionInstanceGroupManager { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
    [JsonPropertyName("regionInstanceGroupManagerRef")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerRef? RegionInstanceGroupManagerRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
    [JsonPropertyName("regionInstanceGroupManagerSelector")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionInstanceGroupManagerSelector? RegionInstanceGroupManagerSelector { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RegionPerInstanceConfigSpecForProviderRegionSelector? RegionSelector { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelector
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
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDisk
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
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDiskSourceSelector? SourceSelector { get; set; }
}

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateExternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateInternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>The preserved state for this instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1RegionPerInstanceConfigSpecInitProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerSelector
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
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProviderRegionSelector
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
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecInitProvider
{
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
    public V1beta1RegionPerInstanceConfigSpecInitProviderPreservedState? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the containing instance group manager is located</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The region instance group manager this instance config is part of.</summary>
    [JsonPropertyName("regionInstanceGroupManager")]
    public string? RegionInstanceGroupManager { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
    [JsonPropertyName("regionInstanceGroupManagerRef")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerRef? RegionInstanceGroupManagerRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate regionInstanceGroupManager.</summary>
    [JsonPropertyName("regionInstanceGroupManagerSelector")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionInstanceGroupManagerSelector? RegionInstanceGroupManagerSelector { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RegionPerInstanceConfigSpecInitProviderRegionSelector? RegionSelector { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpecProviderConfigRef
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
public partial class V1beta1RegionPerInstanceConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RegionPerInstanceConfigSpec defines the desired state of RegionPerInstanceConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionPerInstanceConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionPerInstanceConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionPerInstanceConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionPerInstanceConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateDisk
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

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateExternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateExternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateExternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>Ip address representation Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateInternalIpIpAddress
{
    /// <summary>The URL of the reservation for this IP address.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateInternalIp
{
    /// <summary>These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value is NEVER. Possible values are: NEVER, ON_PERMANENT_INSTANCE_DELETION.</summary>
    [JsonPropertyName("autoDelete")]
    public string? AutoDelete { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>Ip address representation Structure is documented below.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateInternalIpIpAddress? IpAddress { get; set; }
}

/// <summary>The preserved state for this instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProviderPreservedState
{
    /// <summary>Stateful disks for the instance. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateDisk>? Disk { get; set; }

    /// <summary>Preserved external IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("externalIp")]
    public IList<V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateExternalIp>? ExternalIp { get; set; }

    /// <summary>Preserved internal IPs defined for this instance. This map is keyed with the name of the network interface. Structure is documented below.</summary>
    [JsonPropertyName("internalIp")]
    public IList<V1beta1RegionPerInstanceConfigStatusAtProviderPreservedStateInternalIp>? InternalIp { get; set; }

    /// <summary>Preserved metadata defined for this instance. This is a list of key-&gt;value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusAtProvider
{
    /// <summary>an identifier for the resource with format {{project}}/{{region}}/{{region_instance_group_manager}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
    public V1beta1RegionPerInstanceConfigStatusAtProviderPreservedState? PreservedState { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the containing instance group manager is located</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The region instance group manager this instance config is part of.</summary>
    [JsonPropertyName("regionInstanceGroupManager")]
    public string? RegionInstanceGroupManager { get; set; }

    /// <summary>When true, deleting this config will immediately remove the underlying instance. When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.</summary>
    [JsonPropertyName("removeInstanceOnDestroy")]
    public bool? RemoveInstanceOnDestroy { get; set; }

    /// <summary>When true, deleting this config will immediately remove any specified state from the underlying instance. When false, deleting this config will not immediately remove any state from the underlying instance. State will be removed on the next instance recreation or update.</summary>
    [JsonPropertyName("removeInstanceStateOnDestroy")]
    public bool? RemoveInstanceStateOnDestroy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatusConditions
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

/// <summary>RegionPerInstanceConfigStatus defines the observed state of RegionPerInstanceConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionPerInstanceConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionPerInstanceConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionPerInstanceConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionPerInstanceConfig is the Schema for the RegionPerInstanceConfigs API. A config defined for a single managed instance that belongs to an instance group manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionPerInstanceConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionPerInstanceConfigSpec>, IStatus<V1beta1RegionPerInstanceConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionPerInstanceConfig";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regionperinstanceconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionPerInstanceConfigSpec defines the desired state of RegionPerInstanceConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionPerInstanceConfigSpec Spec { get; set; }

    /// <summary>RegionPerInstanceConfigStatus defines the observed state of RegionPerInstanceConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionPerInstanceConfigStatus? Status { get; set; }
}