using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1RegionDiskResourcePolicyAttachmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecForProvider
{
    /// <summary>The name of the regional disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderDiskSelector? DiskSelector { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProviderNameSelector? NameSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecInitProvider
{
    /// <summary>The name of the regional disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderDiskSelector? DiskSelector { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProviderNameSelector? NameSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecManagementPoliciesEnum
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

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegionDiskResourcePolicyAttachmentSpec defines the desired state of RegionDiskResourcePolicyAttachment</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionDiskResourcePolicyAttachmentSpecDeletionPolicyEnum>))]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegionDiskResourcePolicyAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentStatusAtProvider
{
    /// <summary>The name of the regional disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{region}}/{{disk}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentStatusConditions
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

/// <summary>RegionDiskResourcePolicyAttachmentStatus defines the observed state of RegionDiskResourcePolicyAttachment.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionDiskResourcePolicyAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionDiskResourcePolicyAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RegionDiskResourcePolicyAttachment is the Schema for the RegionDiskResourcePolicyAttachments API. Adds existing resource policies to a disk.</summary>
public partial class V1beta1RegionDiskResourcePolicyAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionDiskResourcePolicyAttachmentSpec>, IStatus<V1beta1RegionDiskResourcePolicyAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionDiskResourcePolicyAttachment";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiondiskresourcepolicyattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionDiskResourcePolicyAttachmentSpec defines the desired state of RegionDiskResourcePolicyAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionDiskResourcePolicyAttachmentSpec Spec { get; set; }

    /// <summary>RegionDiskResourcePolicyAttachmentStatus defines the observed state of RegionDiskResourcePolicyAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionDiskResourcePolicyAttachmentStatus? Status { get; set; }
}