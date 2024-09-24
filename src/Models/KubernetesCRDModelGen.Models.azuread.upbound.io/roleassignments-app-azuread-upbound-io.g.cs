using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azuread.upbound.io;
public enum V1beta1RoleAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecForProviderResourceObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RoleAssignmentSpecForProvider
{
    /// <summary>The ID of the app role to be assigned, or the default role ID 00000000-0000-0000-0000-000000000000. Changing this forces a new resource to be created. The ID of the app role to be assigned</summary>
    [JsonPropertyName("appRoleId")]
    public string? AppRoleId { get; set; }

    /// <summary>The object ID of the user, group or service principal to be assigned this app role. Supported object types are Users, Groups or Service Principals. Changing this forces a new resource to be created. The object ID of the user, group or service principal to be assigned this app role</summary>
    [JsonPropertyName("principalObjectId")]
    public string? PrincipalObjectId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate principalObjectId.</summary>
    [JsonPropertyName("principalObjectIdRef")]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdRef? PrincipalObjectIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate principalObjectId.</summary>
    [JsonPropertyName("principalObjectIdSelector")]
    public V1beta1RoleAssignmentSpecForProviderPrincipalObjectIdSelector? PrincipalObjectIdSelector { get; set; }

    /// <summary>The object ID of the service principal representing the resource. Changing this forces a new resource to be created. The object ID of the service principal representing the resource</summary>
    [JsonPropertyName("resourceObjectId")]
    public string? ResourceObjectId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate resourceObjectId.</summary>
    [JsonPropertyName("resourceObjectIdRef")]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdRef? ResourceObjectIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate resourceObjectId.</summary>
    [JsonPropertyName("resourceObjectIdSelector")]
    public V1beta1RoleAssignmentSpecForProviderResourceObjectIdSelector? ResourceObjectIdSelector { get; set; }
}

public enum V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RoleAssignmentSpecInitProvider
{
    /// <summary>The ID of the app role to be assigned, or the default role ID 00000000-0000-0000-0000-000000000000. Changing this forces a new resource to be created. The ID of the app role to be assigned</summary>
    [JsonPropertyName("appRoleId")]
    public string? AppRoleId { get; set; }

    /// <summary>The object ID of the user, group or service principal to be assigned this app role. Supported object types are Users, Groups or Service Principals. Changing this forces a new resource to be created. The object ID of the user, group or service principal to be assigned this app role</summary>
    [JsonPropertyName("principalObjectId")]
    public string? PrincipalObjectId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate principalObjectId.</summary>
    [JsonPropertyName("principalObjectIdRef")]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdRef? PrincipalObjectIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate principalObjectId.</summary>
    [JsonPropertyName("principalObjectIdSelector")]
    public V1beta1RoleAssignmentSpecInitProviderPrincipalObjectIdSelector? PrincipalObjectIdSelector { get; set; }

    /// <summary>The object ID of the service principal representing the resource. Changing this forces a new resource to be created. The object ID of the service principal representing the resource</summary>
    [JsonPropertyName("resourceObjectId")]
    public string? ResourceObjectId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate resourceObjectId.</summary>
    [JsonPropertyName("resourceObjectIdRef")]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdRef? ResourceObjectIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate resourceObjectId.</summary>
    [JsonPropertyName("resourceObjectIdSelector")]
    public V1beta1RoleAssignmentSpecInitProviderResourceObjectIdSelector? ResourceObjectIdSelector { get; set; }
}

public enum V1beta1RoleAssignmentSpecManagementPoliciesEnum
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

public enum V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1RoleAssignmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1RoleAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1RoleAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1RoleAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleAssignmentSpecDeletionPolicyEnum>))]
    public V1beta1RoleAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RoleAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RoleAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RoleAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RoleAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RoleAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RoleAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1RoleAssignmentStatusAtProvider
{
    /// <summary>The ID of the app role to be assigned, or the default role ID 00000000-0000-0000-0000-000000000000. Changing this forces a new resource to be created. The ID of the app role to be assigned</summary>
    [JsonPropertyName("appRoleId")]
    public string? AppRoleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The display name of the principal to which the app role is assigned. The display name of the principal to which the app role is assigned</summary>
    [JsonPropertyName("principalDisplayName")]
    public string? PrincipalDisplayName { get; set; }

    /// <summary>The object ID of the user, group or service principal to be assigned this app role. Supported object types are Users, Groups or Service Principals. Changing this forces a new resource to be created. The object ID of the user, group or service principal to be assigned this app role</summary>
    [JsonPropertyName("principalObjectId")]
    public string? PrincipalObjectId { get; set; }

    /// <summary>The object type of the principal to which the app role is assigned. The object type of the principal to which the app role is assigned</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The display name of the application representing the resource. The display name of the application representing the resource</summary>
    [JsonPropertyName("resourceDisplayName")]
    public string? ResourceDisplayName { get; set; }

    /// <summary>The object ID of the service principal representing the resource. Changing this forces a new resource to be created. The object ID of the service principal representing the resource</summary>
    [JsonPropertyName("resourceObjectId")]
    public string? ResourceObjectId { get; set; }
}

public partial class V1beta1RoleAssignmentStatusConditions
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

public partial class V1beta1RoleAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RoleAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RoleAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RoleAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RoleAssignmentSpec>, IStatus<V1beta1RoleAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RoleAssignment";
    public const string KubeGroup = "app.azuread.upbound.io";
    public const string KubePluralName = "roleassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RoleAssignmentSpec defines the desired state of RoleAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1RoleAssignmentSpec Spec { get; set; }

    /// <summary>RoleAssignmentStatus defines the observed state of RoleAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1RoleAssignmentStatus? Status { get; set; }
}