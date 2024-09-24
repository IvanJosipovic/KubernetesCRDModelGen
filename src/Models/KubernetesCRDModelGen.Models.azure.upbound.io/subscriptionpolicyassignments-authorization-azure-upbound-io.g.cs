using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
public enum V1beta1SubscriptionPolicyAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecForProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1SubscriptionPolicyAssignmentSpecForProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecForProviderResourceSelectors>? ResourceSelectors { get; set; }

    /// <summary>The ID of the Subscription where this Policy Assignment should be created. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecInitProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecInitProviderResourceSelectors>? ResourceSelectors { get; set; }

    /// <summary>The ID of the Subscription where this Policy Assignment should be created. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecManagementPoliciesEnum
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

public enum V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionPolicyAssignmentSpecDeletionPolicyEnum>))]
    public V1beta1SubscriptionPolicyAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubscriptionPolicyAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubscriptionPolicyAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SubscriptionPolicyAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubscriptionPolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SubscriptionPolicyAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubscriptionPolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID of the Policy Assignment for this Subscription.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID of the Policy Assignment for this Subscription.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusAtProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>The ID of the Subscription Policy Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusAtProviderResourceSelectors>? ResourceSelectors { get; set; }

    /// <summary>The ID of the Subscription where this Policy Assignment should be created. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

public partial class V1beta1SubscriptionPolicyAssignmentStatusConditions
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

public partial class V1beta1SubscriptionPolicyAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubscriptionPolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubscriptionPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubscriptionPolicyAssignmentSpec>, IStatus<V1beta1SubscriptionPolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionPolicyAssignment";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "subscriptionpolicyassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionPolicyAssignmentSpec defines the desired state of SubscriptionPolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubscriptionPolicyAssignmentSpec Spec { get; set; }

    /// <summary>SubscriptionPolicyAssignmentStatus defines the observed state of SubscriptionPolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubscriptionPolicyAssignmentStatus? Status { get; set; }
}