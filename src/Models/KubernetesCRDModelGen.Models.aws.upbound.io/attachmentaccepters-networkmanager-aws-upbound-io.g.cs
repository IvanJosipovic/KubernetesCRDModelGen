using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkmanager.aws.upbound.io;
public enum V1beta1AttachmentAccepterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentId.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentId.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentType.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRefPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentType.</summary>
public partial class V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttachmentAccepterSpecForProvider
{
    /// <summary>The ID of the attachment.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    /// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentId.</summary>
    [JsonPropertyName("attachmentIdRef")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdRef? AttachmentIdRef { get; set; }

    /// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentId.</summary>
    [JsonPropertyName("attachmentIdSelector")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentIdSelector? AttachmentIdSelector { get; set; }

    /// <summary>The type of attachment. Valid values can be found in the AWS Documentation</summary>
    [JsonPropertyName("attachmentType")]
    public string? AttachmentType { get; set; }

    /// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentType.</summary>
    [JsonPropertyName("attachmentTypeRef")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeRef? AttachmentTypeRef { get; set; }

    /// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentType.</summary>
    [JsonPropertyName("attachmentTypeSelector")]
    public V1beta1AttachmentAccepterSpecForProviderAttachmentTypeSelector? AttachmentTypeSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentId.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentId.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentType.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRefPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentType.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AttachmentAccepterSpecInitProvider
{
    /// <summary>The ID of the attachment.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    /// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentId.</summary>
    [JsonPropertyName("attachmentIdRef")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdRef? AttachmentIdRef { get; set; }

    /// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentId.</summary>
    [JsonPropertyName("attachmentIdSelector")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentIdSelector? AttachmentIdSelector { get; set; }

    /// <summary>The type of attachment. Valid values can be found in the AWS Documentation</summary>
    [JsonPropertyName("attachmentType")]
    public string? AttachmentType { get; set; }

    /// <summary>Reference to a VPCAttachment in networkmanager to populate attachmentType.</summary>
    [JsonPropertyName("attachmentTypeRef")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeRef? AttachmentTypeRef { get; set; }

    /// <summary>Selector for a VPCAttachment in networkmanager to populate attachmentType.</summary>
    [JsonPropertyName("attachmentTypeSelector")]
    public V1beta1AttachmentAccepterSpecInitProviderAttachmentTypeSelector? AttachmentTypeSelector { get; set; }
}

public enum V1beta1AttachmentAccepterSpecManagementPoliciesEnum
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

public enum V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AttachmentAccepterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AttachmentAccepterSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AttachmentAccepterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AttachmentAccepterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AttachmentAccepterSpec defines the desired state of AttachmentAccepter</summary>
public partial class V1beta1AttachmentAccepterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AttachmentAccepterSpecDeletionPolicyEnum>))]
    public V1beta1AttachmentAccepterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AttachmentAccepterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AttachmentAccepterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AttachmentAccepterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AttachmentAccepterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AttachmentAccepterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AttachmentAccepterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AttachmentAccepterStatusAtProvider
{
    /// <summary>The ID of the attachment.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    /// <summary>The policy rule number associated with the attachment.</summary>
    [JsonPropertyName("attachmentPolicyRuleNumber")]
    public double? AttachmentPolicyRuleNumber { get; set; }

    /// <summary>The type of attachment. Valid values can be found in the AWS Documentation</summary>
    [JsonPropertyName("attachmentType")]
    public string? AttachmentType { get; set; }

    /// <summary>The ARN of a core network.</summary>
    [JsonPropertyName("coreNetworkArn")]
    public string? CoreNetworkArn { get; set; }

    /// <summary>The id of a core network.</summary>
    [JsonPropertyName("coreNetworkId")]
    public string? CoreNetworkId { get; set; }

    /// <summary>The Region where the edge is located.</summary>
    [JsonPropertyName("edgeLocation")]
    public string? EdgeLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the attachment account owner.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The attachment resource ARN.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The name of the segment attachment.</summary>
    [JsonPropertyName("segmentName")]
    public string? SegmentName { get; set; }

    /// <summary>The state of the attachment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AttachmentAccepterStatusConditions
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

/// <summary>AttachmentAccepterStatus defines the observed state of AttachmentAccepter.</summary>
public partial class V1beta1AttachmentAccepterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AttachmentAccepterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AttachmentAccepterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AttachmentAccepter is the Schema for the AttachmentAccepters API.</summary>
public partial class V1beta1AttachmentAccepter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AttachmentAccepterSpec>, IStatus<V1beta1AttachmentAccepterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AttachmentAccepter";
    public const string KubeGroup = "networkmanager.aws.upbound.io";
    public const string KubePluralName = "attachmentaccepters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AttachmentAccepterSpec defines the desired state of AttachmentAccepter</summary>
    [JsonPropertyName("spec")]
    public V1beta1AttachmentAccepterSpec Spec { get; set; }

    /// <summary>AttachmentAccepterStatus defines the observed state of AttachmentAccepter.</summary>
    [JsonPropertyName("status")]
    public V1beta1AttachmentAccepterStatus? Status { get; set; }
}