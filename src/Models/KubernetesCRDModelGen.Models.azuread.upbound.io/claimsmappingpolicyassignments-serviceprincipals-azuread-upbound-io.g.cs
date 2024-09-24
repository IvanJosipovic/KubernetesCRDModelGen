using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serviceprincipals.azuread.upbound.io;
public enum V1beta1ClaimsMappingPolicyAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecForProvider
{
    /// <summary>The ID of the claims mapping policy to assign. ID of the claims mapping policy to assign</summary>
    [JsonPropertyName("claimsMappingPolicyId")]
    public string? ClaimsMappingPolicyId { get; set; }

    /// <summary>Reference to a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
    [JsonPropertyName("claimsMappingPolicyIdRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdRef? ClaimsMappingPolicyIdRef { get; set; }

    /// <summary>Selector for a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
    [JsonPropertyName("claimsMappingPolicyIdSelector")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderClaimsMappingPolicyIdSelector? ClaimsMappingPolicyIdSelector { get; set; }

    /// <summary>The object ID of the service principal for the policy assignment. Object ID of the service principal for which to assign the policy</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdRef? ServicePrincipalIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdSelector")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProviderServicePrincipalIdSelector? ServicePrincipalIdSelector { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecInitProvider
{
    /// <summary>The ID of the claims mapping policy to assign. ID of the claims mapping policy to assign</summary>
    [JsonPropertyName("claimsMappingPolicyId")]
    public string? ClaimsMappingPolicyId { get; set; }

    /// <summary>Reference to a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
    [JsonPropertyName("claimsMappingPolicyIdRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdRef? ClaimsMappingPolicyIdRef { get; set; }

    /// <summary>Selector for a ClaimsMappingPolicy in policies to populate claimsMappingPolicyId.</summary>
    [JsonPropertyName("claimsMappingPolicyIdSelector")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderClaimsMappingPolicyIdSelector? ClaimsMappingPolicyIdSelector { get; set; }

    /// <summary>The object ID of the service principal for the policy assignment. Object ID of the service principal for which to assign the policy</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdRef? ServicePrincipalIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdSelector")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProviderServicePrincipalIdSelector? ServicePrincipalIdSelector { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecManagementPoliciesEnum
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

public enum V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClaimsMappingPolicyAssignmentSpec defines the desired state of ClaimsMappingPolicyAssignment</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClaimsMappingPolicyAssignmentSpecDeletionPolicyEnum>))]
    public V1beta1ClaimsMappingPolicyAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClaimsMappingPolicyAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClaimsMappingPolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentStatusAtProvider
{
    /// <summary>The ID of the claims mapping policy to assign. ID of the claims mapping policy to assign</summary>
    [JsonPropertyName("claimsMappingPolicyId")]
    public string? ClaimsMappingPolicyId { get; set; }

    /// <summary>The ID of the Claims Mapping Policy Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The object ID of the service principal for the policy assignment. Object ID of the service principal for which to assign the policy</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentStatusConditions
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

/// <summary>ClaimsMappingPolicyAssignmentStatus defines the observed state of ClaimsMappingPolicyAssignment.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClaimsMappingPolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClaimsMappingPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ClaimsMappingPolicyAssignment is the Schema for the ClaimsMappingPolicyAssignments API.</summary>
public partial class V1beta1ClaimsMappingPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClaimsMappingPolicyAssignmentSpec>, IStatus<V1beta1ClaimsMappingPolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClaimsMappingPolicyAssignment";
    public const string KubeGroup = "serviceprincipals.azuread.upbound.io";
    public const string KubePluralName = "claimsmappingpolicyassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClaimsMappingPolicyAssignmentSpec defines the desired state of ClaimsMappingPolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClaimsMappingPolicyAssignmentSpec Spec { get; set; }

    /// <summary>ClaimsMappingPolicyAssignmentStatus defines the observed state of ClaimsMappingPolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClaimsMappingPolicyAssignmentStatus? Status { get; set; }
}