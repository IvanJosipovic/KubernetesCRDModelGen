using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1DiskResourcePolicyAttachmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRefPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecForProvider
{
    /// <summary>The name of the disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a Disk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderDiskSelector? DiskSelector { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProviderNameSelector? NameSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the zone where the disk resides.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRefPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecInitProvider
{
    /// <summary>The name of the disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a Disk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderDiskSelector? DiskSelector { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a ResourcePolicy in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProviderNameSelector? NameSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the zone where the disk resides.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecManagementPoliciesEnum
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

public enum V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DiskResourcePolicyAttachmentSpecDeletionPolicyEnum>))]
    public V1beta1DiskResourcePolicyAttachmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DiskResourcePolicyAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DiskResourcePolicyAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DiskResourcePolicyAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DiskResourcePolicyAttachmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DiskResourcePolicyAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentStatusAtProvider
{
    /// <summary>The name of the disk in which the resource policies are attached to.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{zone}}/{{disk}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource policy to be attached to the disk for scheduling snapshot creation. Do not specify the self link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A reference to the zone where the disk resides.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1DiskResourcePolicyAttachmentStatusConditions
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

public partial class V1beta1DiskResourcePolicyAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DiskResourcePolicyAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DiskResourcePolicyAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DiskResourcePolicyAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DiskResourcePolicyAttachmentSpec>, IStatus<V1beta1DiskResourcePolicyAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DiskResourcePolicyAttachment";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "diskresourcepolicyattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiskResourcePolicyAttachmentSpec defines the desired state of DiskResourcePolicyAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1DiskResourcePolicyAttachmentSpec Spec { get; set; }

    /// <summary>DiskResourcePolicyAttachmentStatus defines the observed state of DiskResourcePolicyAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1DiskResourcePolicyAttachmentStatus? Status { get; set; }
}