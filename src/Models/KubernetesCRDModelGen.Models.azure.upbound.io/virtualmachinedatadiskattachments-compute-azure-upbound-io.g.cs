using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
public enum V1beta1VirtualMachineDataDiskAttachmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecForProvider
{
    /// <summary>Specifies the caching requirements for this Data Disk. Possible values include None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The Create Option of the Data Disk, such as Empty or Attach. Defaults to Attach. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdRef? ManagedDiskIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdSelector")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderManagedDiskIdSelector? ManagedDiskIdSelector { get; set; }

    /// <summary>The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the disk. This can only be enabled on Premium_LRS managed disks with no caching and M-Series VMs. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecInitProvider
{
    /// <summary>Specifies the caching requirements for this Data Disk. Possible values include None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The Create Option of the Data Disk, such as Empty or Attach. Defaults to Attach. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdRef? ManagedDiskIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate managedDiskId.</summary>
    [JsonPropertyName("managedDiskIdSelector")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderManagedDiskIdSelector? ManagedDiskIdSelector { get; set; }

    /// <summary>The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the disk. This can only be enabled on Premium_LRS managed disks with no caching and M-Series VMs. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecManagementPoliciesEnum
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

public enum V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualMachineDataDiskAttachmentSpec defines the desired state of VirtualMachineDataDiskAttachment</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualMachineDataDiskAttachmentSpecDeletionPolicyEnum>))]
    public V1beta1VirtualMachineDataDiskAttachmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualMachineDataDiskAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualMachineDataDiskAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentStatusAtProvider
{
    /// <summary>Specifies the caching requirements for this Data Disk. Possible values include None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The Create Option of the Data Disk, such as Empty or Attach. Defaults to Attach. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Virtual Machine Data Disk attachment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the disk. This can only be enabled on Premium_LRS managed disks with no caching and M-Series VMs. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentStatusConditions
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

/// <summary>VirtualMachineDataDiskAttachmentStatus defines the observed state of VirtualMachineDataDiskAttachment.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualMachineDataDiskAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualMachineDataDiskAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VirtualMachineDataDiskAttachment is the Schema for the VirtualMachineDataDiskAttachments API. Manages attaching a Disk to a Virtual Machine.</summary>
public partial class V1beta1VirtualMachineDataDiskAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualMachineDataDiskAttachmentSpec>, IStatus<V1beta1VirtualMachineDataDiskAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualMachineDataDiskAttachment";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "virtualmachinedatadiskattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualMachineDataDiskAttachmentSpec defines the desired state of VirtualMachineDataDiskAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualMachineDataDiskAttachmentSpec Spec { get; set; }

    /// <summary>VirtualMachineDataDiskAttachmentStatus defines the observed state of VirtualMachineDataDiskAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualMachineDataDiskAttachmentStatus? Status { get; set; }
}