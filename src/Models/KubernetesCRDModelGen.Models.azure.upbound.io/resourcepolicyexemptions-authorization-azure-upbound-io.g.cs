using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
public enum V1beta1ResourcePolicyExemptionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecForProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name of the Policy Exemption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>Reference to a ResourcePolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdRef")]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdRef? PolicyAssignmentIdRef { get; set; }

    /// <summary>Selector for a ResourcePolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdSelector")]
    public V1beta1ResourcePolicyExemptionSpecForProviderPolicyAssignmentIdSelector? PolicyAssignmentIdSelector { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }

    /// <summary>The Resource ID where the Policy Exemption should be applied. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Reference to a ResourcePolicyAssignment in authorization to populate resourceId.</summary>
    [JsonPropertyName("resourceIdRef")]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a ResourcePolicyAssignment in authorization to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta1ResourcePolicyExemptionSpecForProviderResourceIdSelector? ResourceIdSelector { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecInitProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name of the Policy Exemption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>Reference to a ResourcePolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdRef")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdRef? PolicyAssignmentIdRef { get; set; }

    /// <summary>Selector for a ResourcePolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdSelector")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderPolicyAssignmentIdSelector? PolicyAssignmentIdSelector { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }

    /// <summary>The Resource ID where the Policy Exemption should be applied. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Reference to a ResourcePolicyAssignment in authorization to populate resourceId.</summary>
    [JsonPropertyName("resourceIdRef")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a ResourcePolicyAssignment in authorization to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta1ResourcePolicyExemptionSpecInitProviderResourceIdSelector? ResourceIdSelector { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecManagementPoliciesEnum
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

public enum V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourcePolicyExemptionSpecDeletionPolicyEnum>))]
    public V1beta1ResourcePolicyExemptionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResourcePolicyExemptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResourcePolicyExemptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ResourcePolicyExemptionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourcePolicyExemptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ResourcePolicyExemptionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourcePolicyExemptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionStatusAtProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The Policy Exemption id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name of the Policy Exemption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }

    /// <summary>The Resource ID where the Policy Exemption should be applied. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

public partial class V1beta1ResourcePolicyExemptionStatusConditions
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

public partial class V1beta1ResourcePolicyExemptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResourcePolicyExemptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourcePolicyExemptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourcePolicyExemption : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourcePolicyExemptionSpec>, IStatus<V1beta1ResourcePolicyExemptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourcePolicyExemption";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcepolicyexemptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourcePolicyExemptionSpec defines the desired state of ResourcePolicyExemption</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourcePolicyExemptionSpec Spec { get; set; }

    /// <summary>ResourcePolicyExemptionStatus defines the observed state of ResourcePolicyExemption.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourcePolicyExemptionStatus? Status { get; set; }
}