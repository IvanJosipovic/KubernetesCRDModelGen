using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
public enum V1beta1PimEligibleRoleAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Eligible Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicy? Policy { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecForProvider
{
    /// <summary>The justification of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The justification of the eligible role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Eligible Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Eligible Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. The schedule details of this eligible role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Eligible Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. Ticket details relating to the assignment.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderTicket? Ticket { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Eligible Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecInitProvider
{
    /// <summary>The justification of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The justification of the eligible role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Eligible Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Eligible Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. The schedule details of this eligible role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Eligible Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. Ticket details relating to the assignment.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderTicket? Ticket { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecManagementPoliciesEnum
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

public enum V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimEligibleRoleAssignmentSpecDeletionPolicyEnum>))]
    public V1beta1PimEligibleRoleAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PimEligibleRoleAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PimEligibleRoleAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PimEligibleRoleAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PimEligibleRoleAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Eligible Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Eligible Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentStatusAtProvider
{
    /// <summary>The ID of the Pim Eligible Role Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The justification of the role assignment. Changing this forces a new Pim Eligible Role Assignment to be created. The justification of the eligible role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Eligible Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The type of principal. The type of principal.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Eligible Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. The schedule details of this eligible role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Eligible Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Eligible Role Assignment to be created. Ticket details relating to the assignment.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderTicket? Ticket { get; set; }
}

public partial class V1beta1PimEligibleRoleAssignmentStatusConditions
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

public partial class V1beta1PimEligibleRoleAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PimEligibleRoleAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PimEligibleRoleAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PimEligibleRoleAssignmentSpec>, IStatus<V1beta1PimEligibleRoleAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PimEligibleRoleAssignment";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "pimeligibleroleassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PimEligibleRoleAssignmentSpec defines the desired state of PimEligibleRoleAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1PimEligibleRoleAssignmentSpec Spec { get; set; }

    /// <summary>PimEligibleRoleAssignmentStatus defines the observed state of PimEligibleRoleAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1PimEligibleRoleAssignmentStatus? Status { get; set; }
}